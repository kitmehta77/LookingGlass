
namespace LookingGlass
{
    partial class AssignCandidateQualification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignCandidateQualification));
            this.lblAssignSkills = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.btnAssignQualification = new System.Windows.Forms.Button();
            this.lblCurrentQualification = new System.Windows.Forms.Label();
            this.cboQualificationDescription = new System.Windows.Forms.ComboBox();
            this.cboQualificationID = new System.Windows.Forms.ComboBox();
            this.lblDateObtained = new System.Windows.Forms.Label();
            this.lblQualDescription = new System.Windows.Forms.Label();
            this.lblQualificationID = new System.Windows.Forms.Label();
            this.lstCurrentQualification = new System.Windows.Forms.ListBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.candidateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suburbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLookingGlass = new LookingGlass.dsLookingGlass();
            this.candidatesTableAdapter = new LookingGlass.dsLookingGlassTableAdapters.candidatesTableAdapter();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAssignSkills
            // 
            this.lblAssignSkills.AutoSize = true;
            this.lblAssignSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignSkills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssignSkills.Location = new System.Drawing.Point(548, 9);
            this.lblAssignSkills.Name = "lblAssignSkills";
            this.lblAssignSkills.Size = new System.Drawing.Size(383, 29);
            this.lblAssignSkills.TabIndex = 47;
            this.lblAssignSkills.Text = "Assign Candidate Qualifications";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(758, 456);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(146, 31);
            this.Return.TabIndex = 46;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnAssignQualification
            // 
            this.btnAssignQualification.Location = new System.Drawing.Point(592, 456);
            this.btnAssignQualification.Name = "btnAssignQualification";
            this.btnAssignQualification.Size = new System.Drawing.Size(146, 31);
            this.btnAssignQualification.TabIndex = 45;
            this.btnAssignQualification.Text = "Assign Qualification";
            this.btnAssignQualification.UseVisualStyleBackColor = true;
            this.btnAssignQualification.Click += new System.EventHandler(this.btnAssignQualification_Click);
            // 
            // lblCurrentQualification
            // 
            this.lblCurrentQualification.AutoSize = true;
            this.lblCurrentQualification.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQualification.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentQualification.Location = new System.Drawing.Point(390, 197);
            this.lblCurrentQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentQualification.Name = "lblCurrentQualification";
            this.lblCurrentQualification.Size = new System.Drawing.Size(171, 17);
            this.lblCurrentQualification.TabIndex = 44;
            this.lblCurrentQualification.Text = "Current Qualifications:";
            // 
            // cboQualificationDescription
            // 
            this.cboQualificationDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualificationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQualificationDescription.FormattingEnabled = true;
            this.cboQualificationDescription.Location = new System.Drawing.Point(515, 375);
            this.cboQualificationDescription.MaxLength = 50;
            this.cboQualificationDescription.Name = "cboQualificationDescription";
            this.cboQualificationDescription.Size = new System.Drawing.Size(250, 21);
            this.cboQualificationDescription.TabIndex = 39;
            // 
            // cboQualificationID
            // 
            this.cboQualificationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualificationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQualificationID.FormattingEnabled = true;
            this.cboQualificationID.Location = new System.Drawing.Point(515, 341);
            this.cboQualificationID.MaxLength = 7;
            this.cboQualificationID.Name = "cboQualificationID";
            this.cboQualificationID.Size = new System.Drawing.Size(65, 21);
            this.cboQualificationID.TabIndex = 38;
            // 
            // lblDateObtained
            // 
            this.lblDateObtained.AutoSize = true;
            this.lblDateObtained.BackColor = System.Drawing.Color.Transparent;
            this.lblDateObtained.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateObtained.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDateObtained.Location = new System.Drawing.Point(408, 413);
            this.lblDateObtained.Name = "lblDateObtained";
            this.lblDateObtained.Size = new System.Drawing.Size(103, 15);
            this.lblDateObtained.TabIndex = 43;
            this.lblDateObtained.Text = "Date Obtained:";
            // 
            // lblQualDescription
            // 
            this.lblQualDescription.AutoSize = true;
            this.lblQualDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblQualDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQualDescription.Location = new System.Drawing.Point(414, 378);
            this.lblQualDescription.Name = "lblQualDescription";
            this.lblQualDescription.Size = new System.Drawing.Size(99, 15);
            this.lblQualDescription.TabIndex = 42;
            this.lblQualDescription.Text = "Qualifications:";
            // 
            // lblQualificationID
            // 
            this.lblQualificationID.AutoSize = true;
            this.lblQualificationID.BackColor = System.Drawing.Color.Transparent;
            this.lblQualificationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualificationID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQualificationID.Location = new System.Drawing.Point(405, 343);
            this.lblQualificationID.Name = "lblQualificationID";
            this.lblQualificationID.Size = new System.Drawing.Size(110, 15);
            this.lblQualificationID.TabIndex = 41;
            this.lblQualificationID.Text = "Qualification ID:";
            // 
            // lstCurrentQualification
            // 
            this.lstCurrentQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrentQualification.FormattingEnabled = true;
            this.lstCurrentQualification.ItemHeight = 15;
            this.lstCurrentQualification.Location = new System.Drawing.Point(393, 214);
            this.lstCurrentQualification.Name = "lstCurrentQualification";
            this.lstCurrentQualification.Size = new System.Drawing.Size(511, 79);
            this.lstCurrentQualification.TabIndex = 37;
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cboStatus.Location = new System.Drawing.Point(621, 152);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(150, 21);
            this.cboStatus.TabIndex = 36;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(568, 155);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "Status:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(621, 122);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 31;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateID.Location = new System.Drawing.Point(621, 62);
            this.txtCandidateID.MaxLength = 8;
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(65, 20);
            this.txtCandidateID.TabIndex = 29;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(621, 92);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 30;
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AllowUserToAddRows = false;
            this.dgvCandidates.AllowUserToDeleteRows = false;
            this.dgvCandidates.AllowUserToResizeColumns = false;
            this.dgvCandidates.AllowUserToResizeRows = false;
            this.dgvCandidates.AutoGenerateColumns = false;
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.suburbDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.workTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvCandidates.DataSource = this.candidatesBindingSource;
            this.dgvCandidates.Location = new System.Drawing.Point(40, 47);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowHeadersVisible = false;
            this.dgvCandidates.RowHeadersWidth = 51;
            this.dgvCandidates.RowTemplate.Height = 24;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(313, 440);
            this.dgvCandidates.TabIndex = 28;
            this.dgvCandidates.Click += new System.EventHandler(this.dgvCandidates_Click);
            // 
            // candidateIDDataGridViewTextBoxColumn
            // 
            this.candidateIDDataGridViewTextBoxColumn.DataPropertyName = "CandidateID";
            this.candidateIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.candidateIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.candidateIDDataGridViewTextBoxColumn.Name = "candidateIDDataGridViewTextBoxColumn";
            this.candidateIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.candidateIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetAddressDataGridViewTextBoxColumn.Visible = false;
            this.streetAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            this.suburbDataGridViewTextBoxColumn.DataPropertyName = "Suburb";
            this.suburbDataGridViewTextBoxColumn.HeaderText = "Suburb";
            this.suburbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            this.suburbDataGridViewTextBoxColumn.ReadOnly = true;
            this.suburbDataGridViewTextBoxColumn.Visible = false;
            this.suburbDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Visible = false;
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Visible = false;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // workTypeDataGridViewTextBoxColumn
            // 
            this.workTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.HeaderText = "WorkType";
            this.workTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workTypeDataGridViewTextBoxColumn.Name = "workTypeDataGridViewTextBoxColumn";
            this.workTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.workTypeDataGridViewTextBoxColumn.Visible = false;
            this.workTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "candidates";
            this.candidatesBindingSource.DataSource = this.dsLookingGlass;
            // 
            // dsLookingGlass
            // 
            this.dsLookingGlass.DataSetName = "dsLookingGlass";
            this.dsLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstName.Location = new System.Drawing.Point(538, 124);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 15);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCandidateID.Location = new System.Drawing.Point(525, 63);
            this.lblCandidateID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(94, 15);
            this.lblCandidateID.TabIndex = 32;
            this.lblCandidateID.Text = "Candidate ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Location = new System.Drawing.Point(538, 95);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 15);
            this.lblLastName.TabIndex = 33;
            this.lblLastName.Text = "Last Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 410);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // AssignCandidateQualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.lblCurrentQualification);
            this.Controls.Add(this.lblDateObtained);
            this.Controls.Add(this.lblQualDescription);
            this.Controls.Add(this.lblQualificationID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAssignSkills);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnAssignQualification);
            this.Controls.Add(this.cboQualificationDescription);
            this.Controls.Add(this.cboQualificationID);
            this.Controls.Add(this.lstCurrentQualification);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dgvCandidates);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignCandidateQualification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Candidate Qualification";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssignSkills;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button btnAssignQualification;
        private System.Windows.Forms.Label lblCurrentQualification;
        private System.Windows.Forms.ComboBox cboQualificationDescription;
        private System.Windows.Forms.ComboBox cboQualificationID;
        private System.Windows.Forms.Label lblDateObtained;
        private System.Windows.Forms.Label lblQualDescription;
        private System.Windows.Forms.Label lblQualificationID;
        private System.Windows.Forms.ListBox lstCurrentQualification;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suburbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private dsLookingGlass dsLookingGlass;
        private dsLookingGlassTableAdapters.candidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}