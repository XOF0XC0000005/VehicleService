using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleServicesV2
{

    public partial class Form1 : Form
    {
        string query = String.Empty;
        string constr = @"Data Source=DESKTOP-179JTUH;Database=VehicleRepairServiceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
            
        }

        void Data()
        {
            query = @"select e.id, e.FullName, (select STRING_AGG(t.Name, '; ') from TypeWork as t where t.id IN 
(select pt.TypeWorkId from Employee_TypeWork as pt where pt.EmployeeId = e.id)) as WorkType from Employee as e";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void PopulateCheckBoxes()
        {
            query = "SELECT Name, Id FROM TypeWork";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    ((ListBox)clbWorkPerformed).DataSource = dt;
                    ((ListBox)clbWorkPerformed).DisplayMember = "Name";
                    ((ListBox)clbWorkPerformed).ValueMember = "Id";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data();
            PopulateCheckBoxes();
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            using (var ctx = new VehicleService())
            {
                var employee = new Employee() 
                { 
                    FullName = txtFullName.Text ,
                    Profession = txtProfession.Text
                };
                ctx.Employee.Add(employee);
                ctx.SaveChanges();
                int employeeId = employee.Id;
                foreach (object itemChecked in clbWorkPerformed.CheckedItems)
                {
                    DataRowView dv = (DataRowView)itemChecked;
                    

                    var employeeTypeWork = new Employee_TypeWork()
                    {
                        EmployeeId = employeeId,
                        TypeWorkId = (int)dv.Row[1]
                    };
                    ctx.Employee_TypeWork.Add(employeeTypeWork);
                    ctx.SaveChanges();
                }
                MessageBox.Show("Пользователь создан");
                Data();
            }
        }

        private void tsmiMainMenuEmployeeForm_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void tsmiRecordEmployeeForm_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку? ", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int currentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected) dataGridView1.Rows.RemoveAt(oneCell.RowIndex);

                }
                string query = $"DELETE FROM Employee WHERE Id ={currentId}";
                using (SqlConnection con = new SqlConnection(constr))
                {   
                    SqlCommand com = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        com.ExecuteNonQuery();

                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                Data();
            }

        }
    }
}
