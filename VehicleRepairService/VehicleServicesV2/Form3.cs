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
    public partial class Form3 : Form
    {
        string query = null;
        string constr = @"Data Source=DESKTOP-179JTUH;Database=VehicleRepairServiceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Data();
            FillVehicleType();
            cbVehicleType.SelectedItem = null;
        }

        void FillVehicleType()
        {
            query = "SELECT Type, Id FROM VehicleType";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cbVehicleType.DataSource = dt;
                    cbVehicleType.DisplayMember = "Type";
                    cbVehicleType.ValueMember = "Id";
                }
            }
        }

        private void cbVehicleType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            GetCorrectPerformedWork((int)cbVehicleType.SelectedValue);
            cbPerformedWork.SelectedItem = null;
            cbPerformedWork.Enabled = true;
        }

        void GetCorrectEmployees(int typeWorkId)
        {
            query = $"select p.id, p.FullName from Employee as p where p.id in (select pt.employeeId from Employee_TypeWork as pt where pt.TypeWorkId = {typeWorkId})";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, constr))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cbEmployee.DataSource = dt;
                    cbEmployee.DisplayMember = "FullName";
                    cbEmployee.ValueMember = "Id";
                }
            }
        }

        void GetCorrectPerformedWork(int vehicleTypeId)
        {
            query = $"select p.id, p.name from TypeWork as p where p.id in (select pt.typeworkid from VehicleType_TypeWork as pt where pt.VehicleTypeId = {vehicleTypeId})";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, constr))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cbPerformedWork.DataSource = dt;
                    cbPerformedWork.DisplayMember = "Name";
                    cbPerformedWork.ValueMember = "Id";
                }
            }
        }

        void Data()
        {
            query = @"select pt.Id, pt.date as 'Дата', p.fullname as 'Работник', t.Name as 'Выполняемая работа', v.brand as 'Марка', v.model as 'Модель', v.fullname as 'Владелец', vt.type as 'Тип ТС' FROM Employee as p INNER JOIN maintanceservice as pt ON p.id = pt.employeeid INNER JOIN TypeWork as t ON t.id = pt.worktypeid INNER JOIN Vehicle as v ON v.id = pt.vehicleid INNER JOIN VehicleType as vt ON vt.id = v.vehicletypeid;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvRecord.DataSource = ds.Tables[0];
        }

        private void cbPerformedWork_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCorrectEmployees((int)cbPerformedWork.SelectedValue);
            cbEmployee.SelectedItem = null;
            cbEmployee.Enabled = true;
        }

        private void btnRecordSave_Click(object sender, EventArgs e)
        {
            using (var ctx = new VehicleService())
            {
                var vehicle = new Vehicle()
                {
                    Brand = txtBrand.Text,
                    Model = txtModel.Text,
                    FullName = txtOwner.Text,
                    VehicleTypeId = (int)cbVehicleType.SelectedValue
                };
                ctx.Vehicle.Add(vehicle);
                ctx.SaveChanges();
                int vehicleId = vehicle.Id;
                var maintanceService = new MaintanceService()
                {
                    Date = dtpRecordDate.Value,
                    VehicleId = vehicleId,
                    EmployeeId = (int)cbEmployee.SelectedValue,
                    WorkTypeId = (int)cbPerformedWork.SelectedValue
                };
                    ctx.MaintanceService.Add(maintanceService);
                    ctx.SaveChanges();
            }
            MessageBox.Show("Запись создана");
            Data();
        }

        private void tsmiMainMenuRecord_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void tsmiEmployeeRecord_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btnRecordDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку? ", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int currentId = Convert.ToInt32(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                foreach (DataGridViewCell oneCell in dgvRecord.SelectedCells)
                {
                    if (oneCell.Selected) dgvRecord.Rows.RemoveAt(oneCell.RowIndex);

                }

                query = $"DELETE FROM MaintanceService WHERE Id ={currentId}";

                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand com = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        com.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                Data();
            }
        }
    }
}
