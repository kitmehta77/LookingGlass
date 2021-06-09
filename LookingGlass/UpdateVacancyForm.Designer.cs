
namespace LookingGlass
{
    partial class UpdateVacancyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVacancyForm));
            this.cboCompName = new System.Windows.Forms.ComboBox();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.cboVacType = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateVac = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtVacDes = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblVacID = new System.Windows.Forms.Label();
            this.txtVacID = new System.Windows.Forms.TextBox();
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.vacancyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacanciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLookingGlass = new LookingGlass.dsLookingGlass();
            this.vacanciesTableAdapter = new LookingGlass.dsLookingGlassTableAdapters.vacanciesTableAdapter();
            this.lblAssignSkills = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCompName
            // 
            this.cboCompName.Enabled = false;
            this.cboCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompName.FormattingEnabled = true;
            this.cboCompName.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.cboCompName.Location = new System.Drawing.Point(579, 230);
            this.cboCompName.Margin = new System.Windows.Forms.Padding(2);
            this.cboCompName.Name = "cboCompName";
            this.cboCompName.Size = new System.Drawing.Size(259, 21);
            this.cboCompName.TabIndex = 51;
            // 
            // cboEmpID
            // 
            this.cboEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.cboEmpID.Location = new System.Drawing.Point(447, 383);
            this.cboEmpID.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(75, 23);
            this.cboEmpID.TabIndex = 50;
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.BackColor = System.Drawing.Color.Transparent;
            this.lblComName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComName.Location = new System.Drawing.Point(464, 234);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(112, 15);
            this.lblComName.TabIndex = 49;
            this.lblComName.Text = "Company Name:";
            // 
            // nudSalary
            // 
            this.nudSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(581, 185);
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
            this.nudSalary.TabIndex = 47;
            this.nudSalary.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            131072});
            // 
            // cboVacType
            // 
            this.cboVacType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVacType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVacType.FormattingEnabled = true;
            this.cboVacType.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.cboVacType.Location = new System.Drawing.Point(580, 155);
            this.cboVacType.Margin = new System.Windows.Forms.Padding(2);
            this.cboVacType.Name = "cboVacType";
            this.cboVacType.Size = new System.Drawing.Size(138, 21);
            this.cboVacType.TabIndex = 46;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(731, 281);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(139, 29);
            this.btnReturn.TabIndex = 45;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateVac
            // 
            this.btnUpdateVac.Location = new System.Drawing.Point(581, 281);
            this.btnUpdateVac.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateVac.Name = "btnUpdateVac";
            this.btnUpdateVac.Size = new System.Drawing.Size(139, 29);
            this.btnUpdateVac.TabIndex = 44;
            this.btnUpdateVac.Text = "Update Vacancy";
            this.btnUpdateVac.UseVisualStyleBackColor = true;
            this.btnUpdateVac.Click += new System.EventHandler(this.btnUpdateVac_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Unfilled",
            "Cancelled"});
            this.cboStatus.Location = new System.Drawing.Point(580, 126);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(138, 21);
            this.cboStatus.TabIndex = 43;
            // 
            // txtVacDes
            // 
            this.txtVacDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacDes.Location = new System.Drawing.Point(579, 84);
            this.txtVacDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtVacDes.MaxLength = 50;
            this.txtVacDes.Name = "txtVacDes";
            this.txtVacDes.Size = new System.Drawing.Size(291, 20);
            this.txtVacDes.TabIndex = 39;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(525, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(526, 187);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 15);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Salary:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(480, 158);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(97, 15);
            this.lblCity.TabIndex = 40;
            this.lblCity.Text = "Vacancy Type:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStreet.Location = new System.Drawing.Point(436, 87);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(140, 15);
            this.lblStreet.TabIndex = 38;
            this.lblStreet.Text = "Vacancy Description:";
            // 
            // lblVacID
            // 
            this.lblVacID.AutoSize = true;
            this.lblVacID.BackColor = System.Drawing.Color.Transparent;
            this.lblVacID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVacID.Location = new System.Drawing.Point(495, 60);
            this.lblVacID.Name = "lblVacID";
            this.lblVacID.Size = new System.Drawing.Size(81, 15);
            this.lblVacID.TabIndex = 52;
            this.lblVacID.Text = "Vacancy ID:";
            // 
            // txtVacID
            // 
            this.txtVacID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacID.Location = new System.Drawing.Point(579, 57);
            this.txtVacID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVacID.MaxLength = 8;
            this.txtVacID.Name = "txtVacID";
            this.txtVacID.ReadOnly = true;
            this.txtVacID.Size = new System.Drawing.Size(63, 20);
            this.txtVacID.TabIndex = 53;
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.AllowUserToAddRows = false;
            this.dgvVacancy.AllowUserToDeleteRows = false;
            this.dgvVacancy.AllowUserToResizeColumns = false;
            this.dgvVacancy.AllowUserToResizeRows = false;
            this.dgvVacancy.AutoGenerateColumns = false;
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vacancyIDDataGridViewTextBoxColumn,
            this.vacancyDescriptionDataGridViewTextBoxColumn});
            this.dgvVacancy.DataSource = this.vacanciesBindingSource;
            this.dgvVacancy.Location = new System.Drawing.Point(25, 50);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.ReadOnly = true;
            this.dgvVacancy.RowHeadersVisible = false;
            this.dgvVacancy.RowHeadersWidth = 51;
            this.dgvVacancy.RowTemplate.Height = 24;
            this.dgvVacancy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacancy.Size = new System.Drawing.Size(364, 260);
            this.dgvVacancy.TabIndex = 54;
            // 
            // vacancyIDDataGridViewTextBoxColumn
            // 
            this.vacancyIDDataGridViewTextBoxColumn.DataPropertyName = "VacancyID";
            this.vacancyIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.vacancyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vacancyIDDataGridViewTextBoxColumn.Name = "vacancyIDDataGridViewTextBoxColumn";
            this.vacancyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacancyIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // vacancyDescriptionDataGridViewTextBoxColumn
            // 
            this.vacancyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VacancyDescription";
            this.vacancyDescriptionDataGridViewTextBoxColumn.HeaderText = "Vacancy Description";
            this.vacancyDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vacancyDescriptionDataGridViewTextBoxColumn.Name = "vacancyDescriptionDataGridViewTextBoxColumn";
            this.vacancyDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacancyDescriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // vacanciesBindingSource
            // 
            this.vacanciesBindingSource.DataMember = "vacancies";
            this.vacanciesBindingSource.DataSource = this.dsLookingGlass;
            // 
            // dsLookingGlass
            // 
            this.dsLookingGlass.DataSetName = "dsLookingGlass";
            this.dsLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacanciesTableAdapter
            // 
            this.vacanciesTableAdapter.ClearBeforeFill = true;
            // 
            // lblAssignSkills
            // 
            this.lblAssignSkills.AutoSize = true;
            this.lblAssignSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignSkills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssignSkills.Location = new System.Drawing.Point(691, 4);
            this.lblAssignSkills.Name = "lblAssignSkills";
            this.lblAssignSkills.Size = new System.Drawing.Size(200, 29);
            this.lblAssignSkills.TabIndex = 55;
            this.lblAssignSkills.Text = "Update Vacancy";
            // 
            // UpdateVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 338);
            this.Controls.Add(this.lblAssignSkills);
            this.Controls.Add(this.dgvVacancy);
            this.Controls.Add(this.txtVacID);
            this.Controls.Add(this.lblVacID);
            this.Controls.Add(this.cboCompName);
            this.Controls.Add(this.cboEmpID);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.cboVacType);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateVac);
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
            this.Name = "UpdateVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Vacancy";
            this.Load += new System.EventHandler(this.UpdateVacancyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCompName;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.ComboBox cboVacType;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateVac;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtVacDes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblVacID;
        private System.Windows.Forms.TextBox txtVacID;
        private System.Windows.Forms.DataGridView dgvVacancy;
        private dsLookingGlass dsLookingGlass;
        private System.Windows.Forms.BindingSource vacanciesBindingSource;
        private dsLookingGlassTableAdapters.vacanciesTableAdapter vacanciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAssignSkills;
    }
}