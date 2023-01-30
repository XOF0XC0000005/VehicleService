namespace VehicleServicesV2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainMenuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.dtpRecordDate = new System.Windows.Forms.DateTimePicker();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.btnRecordSave = new System.Windows.Forms.Button();
            this.btnRecordDelete = new System.Windows.Forms.Button();
            this.lblPerformedWork = new System.Windows.Forms.Label();
            this.cbPerformedWork = new System.Windows.Forms.ComboBox();
            this.vehicleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainMenuRecord,
            this.tsmiEmployeeRecord});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 30);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmiMainMenuRecord
            // 
            this.tsmiMainMenuRecord.Name = "tsmiMainMenuRecord";
            this.tsmiMainMenuRecord.Size = new System.Drawing.Size(232, 34);
            this.tsmiMainMenuRecord.Text = "Главное меню";
            this.tsmiMainMenuRecord.Click += new System.EventHandler(this.tsmiMainMenuRecord_Click);
            // 
            // tsmiEmployeeRecord
            // 
            this.tsmiEmployeeRecord.Name = "tsmiEmployeeRecord";
            this.tsmiEmployeeRecord.Size = new System.Drawing.Size(232, 34);
            this.tsmiEmployeeRecord.Text = "Сотрудники";
            this.tsmiEmployeeRecord.Click += new System.EventHandler(this.tsmiEmployeeRecord_Click);
            // 
            // lblRecordDate
            // 
            this.lblRecordDate.AutoSize = true;
            this.lblRecordDate.Location = new System.Drawing.Point(3, 63);
            this.lblRecordDate.Name = "lblRecordDate";
            this.lblRecordDate.Size = new System.Drawing.Size(129, 20);
            this.lblRecordDate.TabIndex = 1;
            this.lblRecordDate.Text = "Выберите дату:";
            // 
            // dtpRecordDate
            // 
            this.dtpRecordDate.Location = new System.Drawing.Point(138, 59);
            this.dtpRecordDate.Name = "dtpRecordDate";
            this.dtpRecordDate.Size = new System.Drawing.Size(179, 26);
            this.dtpRecordDate.TabIndex = 2;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(353, 65);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 20);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Марка";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(353, 102);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(70, 20);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Модель";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(12, 105);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(87, 20);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Владелец";
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(138, 152);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(179, 28);
            this.cbVehicleType.TabIndex = 6;
            this.cbVehicleType.SelectionChangeCommitted += new System.EventHandler(this.cbVehicleType_SelectionChangeCommitted);
            // 
            // cbEmployee
            // 
            this.cbEmployee.Enabled = false;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(138, 195);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(179, 28);
            this.cbEmployee.TabIndex = 7;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(12, 152);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(60, 20);
            this.lblVehicleType.TabIndex = 8;
            this.lblVehicleType.Text = "Тип ТС";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 198);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(70, 20);
            this.lblEmployee.TabIndex = 9;
            this.lblEmployee.Text = "Мастер:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(429, 57);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(179, 26);
            this.txtBrand.TabIndex = 10;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(138, 102);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(179, 26);
            this.txtOwner.TabIndex = 11;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(429, 99);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(179, 26);
            this.txtModel.TabIndex = 12;
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Location = new System.Drawing.Point(7, 229);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowHeadersWidth = 62;
            this.dgvRecord.RowTemplate.Height = 28;
            this.dgvRecord.Size = new System.Drawing.Size(772, 203);
            this.dgvRecord.TabIndex = 15;
            // 
            // btnRecordSave
            // 
            this.btnRecordSave.Location = new System.Drawing.Point(643, 65);
            this.btnRecordSave.Name = "btnRecordSave";
            this.btnRecordSave.Size = new System.Drawing.Size(106, 39);
            this.btnRecordSave.TabIndex = 16;
            this.btnRecordSave.Text = "Сохранить";
            this.btnRecordSave.UseVisualStyleBackColor = true;
            this.btnRecordSave.Click += new System.EventHandler(this.btnRecordSave_Click);
            // 
            // btnRecordDelete
            // 
            this.btnRecordDelete.Location = new System.Drawing.Point(643, 134);
            this.btnRecordDelete.Name = "btnRecordDelete";
            this.btnRecordDelete.Size = new System.Drawing.Size(106, 37);
            this.btnRecordDelete.TabIndex = 17;
            this.btnRecordDelete.Text = "Удалить";
            this.btnRecordDelete.UseVisualStyleBackColor = true;
            this.btnRecordDelete.Click += new System.EventHandler(this.btnRecordDelete_Click);
            // 
            // lblPerformedWork
            // 
            this.lblPerformedWork.AutoSize = true;
            this.lblPerformedWork.Location = new System.Drawing.Point(357, 151);
            this.lblPerformedWork.Name = "lblPerformedWork";
            this.lblPerformedWork.Size = new System.Drawing.Size(66, 20);
            this.lblPerformedWork.TabIndex = 18;
            this.lblPerformedWork.Text = "Работы";
            // 
            // cbPerformedWork
            // 
            this.cbPerformedWork.Enabled = false;
            this.cbPerformedWork.FormattingEnabled = true;
            this.cbPerformedWork.Location = new System.Drawing.Point(429, 148);
            this.cbPerformedWork.Name = "cbPerformedWork";
            this.cbPerformedWork.Size = new System.Drawing.Size(179, 28);
            this.cbPerformedWork.TabIndex = 19;
            this.cbPerformedWork.SelectionChangeCommitted += new System.EventHandler(this.cbPerformedWork_SelectionChangeCommitted);
            // 
            // vehicleTypeBindingSource
            // 
            this.vehicleTypeBindingSource.DataSource = typeof(VehicleServicesV2.VehicleType);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPerformedWork);
            this.Controls.Add(this.lblPerformedWork);
            this.Controls.Add(this.btnRecordDelete);
            this.Controls.Add(this.btnRecordSave);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbVehicleType);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.dtpRecordDate);
            this.Controls.Add(this.lblRecordDate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Записи";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainMenuRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeRecord;
        private System.Windows.Forms.Label lblRecordDate;
        private System.Windows.Forms.DateTimePicker dtpRecordDate;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cbVehicleType;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnRecordSave;
        private System.Windows.Forms.Button btnRecordDelete;
        private System.Windows.Forms.BindingSource vehicleTypeBindingSource;
        private System.Windows.Forms.Label lblPerformedWork;
        private System.Windows.Forms.ComboBox cbPerformedWork;
    }
}