namespace VehicleServicesV2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblWorkPerformed = new System.Windows.Forms.Label();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.clbWorkPerformed = new System.Windows.Forms.CheckedListBox();
            this.btnEmployeeSave = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainMenuEmployeeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordEmployeeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.typeWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTypeTypeWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeTypeWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(620, 12);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(168, 36);
            this.txtFullName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 226);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(563, 26);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(51, 20);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "ФИО:";
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Location = new System.Drawing.Point(515, 57);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(99, 20);
            this.lblProfession.TabIndex = 5;
            this.lblProfession.Text = "Должность:";
            // 
            // lblWorkPerformed
            // 
            this.lblWorkPerformed.AutoSize = true;
            this.lblWorkPerformed.Location = new System.Drawing.Point(38, 118);
            this.lblWorkPerformed.Name = "lblWorkPerformed";
            this.lblWorkPerformed.Size = new System.Drawing.Size(181, 20);
            this.lblWorkPerformed.TabIndex = 6;
            this.lblWorkPerformed.Text = "Выполняемые работы:";
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(620, 54);
            this.txtProfession.Multiline = true;
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(168, 36);
            this.txtProfession.TabIndex = 7;
            // 
            // clbWorkPerformed
            // 
            this.clbWorkPerformed.FormattingEnabled = true;
            this.clbWorkPerformed.HorizontalScrollbar = true;
            this.clbWorkPerformed.Location = new System.Drawing.Point(271, 13);
            this.clbWorkPerformed.Name = "clbWorkPerformed";
            this.clbWorkPerformed.Size = new System.Drawing.Size(242, 188);
            this.clbWorkPerformed.TabIndex = 8;
            // 
            // btnEmployeeSave
            // 
            this.btnEmployeeSave.Location = new System.Drawing.Point(519, 175);
            this.btnEmployeeSave.Name = "btnEmployeeSave";
            this.btnEmployeeSave.Size = new System.Drawing.Size(105, 31);
            this.btnEmployeeSave.TabIndex = 9;
            this.btnEmployeeSave.Text = "Сохранить";
            this.btnEmployeeSave.UseVisualStyleBackColor = true;
            this.btnEmployeeSave.Click += new System.EventHandler(this.btnEmployeeSave_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.Location = new System.Drawing.Point(641, 175);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(105, 31);
            this.btnEmployeeDelete.TabIndex = 10;
            this.btnEmployeeDelete.Text = "Удалить";
            this.btnEmployeeDelete.UseVisualStyleBackColor = true;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainMenuEmployeeForm,
            this.tsmiRecordEmployeeForm});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(73, 30);
            this.tsmMenu.Text = "Menu";
            // 
            // tsmiMainMenuEmployeeForm
            // 
            this.tsmiMainMenuEmployeeForm.Name = "tsmiMainMenuEmployeeForm";
            this.tsmiMainMenuEmployeeForm.Size = new System.Drawing.Size(232, 34);
            this.tsmiMainMenuEmployeeForm.Text = "Главное меню";
            this.tsmiMainMenuEmployeeForm.Click += new System.EventHandler(this.tsmiMainMenuEmployeeForm_Click);
            // 
            // tsmiRecordEmployeeForm
            // 
            this.tsmiRecordEmployeeForm.Name = "tsmiRecordEmployeeForm";
            this.tsmiRecordEmployeeForm.Size = new System.Drawing.Size(232, 34);
            this.tsmiRecordEmployeeForm.Text = "Записи";
            this.tsmiRecordEmployeeForm.Click += new System.EventHandler(this.tsmiRecordEmployeeForm_Click);
            // 
            // typeWorkBindingSource
            // 
            this.typeWorkBindingSource.DataSource = typeof(VehicleServicesV2.TypeWork);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(VehicleServicesV2.Employee);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(VehicleServicesV2.Employee);
            // 
            // vehicleTypeTypeWorkBindingSource
            // 
            this.vehicleTypeTypeWorkBindingSource.DataSource = typeof(VehicleServicesV2.VehicleType_TypeWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmployeeDelete);
            this.Controls.Add(this.btnEmployeeSave);
            this.Controls.Add(this.clbWorkPerformed);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.lblWorkPerformed);
            this.Controls.Add(this.lblProfession);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeTypeWorkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblWorkPerformed;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.CheckedListBox clbWorkPerformed;
        private System.Windows.Forms.Button btnEmployeeSave;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainMenuEmployeeForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordEmployeeForm;
        private System.Windows.Forms.BindingSource vehicleTypeTypeWorkBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource typeWorkBindingSource;
    }
}

