
namespace LookingGlass
{
    partial class AddVacancyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVacancyForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddVacancy = new System.Windows.Forms.Button();
            this.lblAddVacancy = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtVacDes = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cboVacType = new System.Windows.Forms.ComboBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblComName = new System.Windows.Forms.Label();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.cboCompName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(341, 327);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(139, 32);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddVacancy
            // 
            this.btnAddVacancy.Location = new System.Drawing.Point(189, 327);
            this.btnAddVacancy.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVacancy.Name = "btnAddVacancy";
            this.btnAddVacancy.Size = new System.Drawing.Size(139, 32);
            this.btnAddVacancy.TabIndex = 29;
            this.btnAddVacancy.Text = "Add Vacancy";
            this.btnAddVacancy.UseVisualStyleBackColor = true;
            this.btnAddVacancy.Click += new System.EventHandler(this.btnAddVacancy_Click);
            // 
            // lblAddVacancy
            // 
            this.lblAddVacancy.AutoSize = true;
            this.lblAddVacancy.BackColor = System.Drawing.Color.Transparent;
            this.lblAddVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVacancy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddVacancy.Location = new System.Drawing.Point(380, 5);
            this.lblAddVacancy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddVacancy.Name = "lblAddVacancy";
            this.lblAddVacancy.Size = new System.Drawing.Size(162, 29);
            this.lblAddVacancy.TabIndex = 31;
            this.lblAddVacancy.Text = "Add Vacancy";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Filled",
            "Unfilled",
            "Cancelled"});
            this.cboStatus.Location = new System.Drawing.Point(190, 110);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(138, 21);
            this.cboStatus.TabIndex = 28;
            // 
            // txtVacDes
            // 
            this.txtVacDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacDes.Location = new System.Drawing.Point(189, 75);
            this.txtVacDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtVacDes.MaxLength = 50;
            this.txtVacDes.Name = "txtVacDes";
            this.txtVacDes.Size = new System.Drawing.Size(242, 20);
            this.txtVacDes.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(135, 114);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(136, 169);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 15);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Salary:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(85, 141);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(97, 15);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "Vacancy Type:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStreet.Location = new System.Drawing.Point(45, 78);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(140, 15);
            this.lblStreet.TabIndex = 17;
            this.lblStreet.Text = "Vacancy Description:";
            // 
            // cboVacType
            // 
            this.cboVacType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVacType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVacType.FormattingEnabled = true;
            this.cboVacType.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.cboVacType.Location = new System.Drawing.Point(190, 139);
            this.cboVacType.Margin = new System.Windows.Forms.Padding(2);
            this.cboVacType.Name = "cboVacType";
            this.cboVacType.Size = new System.Drawing.Size(138, 21);
            this.cboVacType.TabIndex = 32;
            // 
            // nudSalary
            // 
            this.nudSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(192, 168);
            this.nudSalary.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.nudSalary.Minimum = new decimal(new int[] {
            2000000,
            0,
            0,
            131072});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.ReadOnly = true;
            this.nudSalary.Size = new System.Drawing.Size(136, 20);
            this.nudSalary.TabIndex = 33;
            this.nudSalary.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            131072});
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpID.Location = new System.Drawing.Point(99, 241);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(89, 15);
            this.lblEmpID.TabIndex = 34;
            this.lblEmpID.Text = "Employer ID:";
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.BackColor = System.Drawing.Color.Transparent;
            this.lblComName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComName.Location = new System.Drawing.Point(74, 275);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(112, 15);
            this.lblComName.TabIndex = 35;
            this.lblComName.Text = "Company Name:";
            // 
            // cboEmpID
            // 
            this.cboEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.cboEmpID.Location = new System.Drawing.Point(190, 238);
            this.cboEmpID.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(75, 21);
            this.cboEmpID.TabIndex = 36;
            // 
            // cboCompName
            // 
            this.cboCompName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompName.FormattingEnabled = true;
            this.cboCompName.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.cboCompName.Location = new System.Drawing.Point(189, 273);
            this.cboCompName.Margin = new System.Windows.Forms.Padding(2);
            this.cboCompName.Name = "cboCompName";
            this.cboCompName.Size = new System.Drawing.Size(195, 21);
            this.cboCompName.TabIndex = 37;
            // 
            // AddVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 385);
            this.Controls.Add(this.cboCompName);
            this.Controls.Add(this.cboEmpID);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.cboVacType);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddVacancy);
            this.Controls.Add(this.lblAddVacancy);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtVacDes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddVacancy;
        private System.Windows.Forms.Label lblAddVacancy;
        private System.Windows.Forms.TextBox txtVacDes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cboVacType;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.ComboBox cboCompName;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}