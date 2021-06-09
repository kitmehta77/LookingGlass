
namespace LookingGlass
{
    partial class AssignCandidateSkills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignCandidateSkills));
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lstCurrentSkills = new System.Windows.Forms.ListBox();
            this.cboSkillDescription = new System.Windows.Forms.ComboBox();
            this.cboSkillID = new System.Windows.Forms.ComboBox();
            this.nudYears = new System.Windows.Forms.NumericUpDown();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblSkillDescription = new System.Windows.Forms.Label();
            this.lblSkillID = new System.Windows.Forms.Label();
            this.lblCurrentSkills = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.lblAssignSkills = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
            this.SuspendLayout();
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
            this.dgvCandidates.Location = new System.Drawing.Point(33, 27);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowHeadersVisible = false;
            this.dgvCandidates.RowHeadersWidth = 51;
            this.dgvCandidates.RowTemplate.Height = 24;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(313, 440);
            this.dgvCandidates.TabIndex = 0;
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
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(631, 138);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateID.Location = new System.Drawing.Point(631, 74);
            this.txtCandidateID.MaxLength = 8;
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(65, 20);
            this.txtCandidateID.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(631, 107);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(151, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstName.Location = new System.Drawing.Point(548, 141);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 15);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidateID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCandidateID.Location = new System.Drawing.Point(533, 77);
            this.lblCandidateID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(94, 15);
            this.lblCandidateID.TabIndex = 12;
            this.lblCandidateID.Text = "Candidate ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Location = new System.Drawing.Point(548, 108);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 15);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(579, 175);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cboStatus.Location = new System.Drawing.Point(631, 172);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(151, 21);
            this.cboStatus.TabIndex = 16;
            // 
            // lstCurrentSkills
            // 
            this.lstCurrentSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrentSkills.FormattingEnabled = true;
            this.lstCurrentSkills.ItemHeight = 15;
            this.lstCurrentSkills.Location = new System.Drawing.Point(397, 222);
            this.lstCurrentSkills.Name = "lstCurrentSkills";
            this.lstCurrentSkills.Size = new System.Drawing.Size(489, 64);
            this.lstCurrentSkills.TabIndex = 17;
            // 
            // cboSkillDescription
            // 
            this.cboSkillDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkillDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSkillDescription.FormattingEnabled = true;
            this.cboSkillDescription.Location = new System.Drawing.Point(552, 348);
            this.cboSkillDescription.MaxLength = 50;
            this.cboSkillDescription.Name = "cboSkillDescription";
            this.cboSkillDescription.Size = new System.Drawing.Size(229, 21);
            this.cboSkillDescription.TabIndex = 19;
            // 
            // cboSkillID
            // 
            this.cboSkillID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSkillID.FormattingEnabled = true;
            this.cboSkillID.Location = new System.Drawing.Point(552, 315);
            this.cboSkillID.MaxLength = 7;
            this.cboSkillID.Name = "cboSkillID";
            this.cboSkillID.Size = new System.Drawing.Size(65, 21);
            this.cboSkillID.TabIndex = 18;
            // 
            // nudYears
            // 
            this.nudYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYears.Location = new System.Drawing.Point(552, 381);
            this.nudYears.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYears.Name = "nudYears";
            this.nudYears.ReadOnly = true;
            this.nudYears.Size = new System.Drawing.Size(87, 20);
            this.nudYears.TabIndex = 20;
            this.nudYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.BackColor = System.Drawing.Color.Transparent;
            this.lblYears.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYears.Location = new System.Drawing.Point(411, 383);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(139, 15);
            this.lblYears.TabIndex = 23;
            this.lblYears.Text = "Experience in Years:";
            // 
            // lblSkillDescription
            // 
            this.lblSkillDescription.AutoSize = true;
            this.lblSkillDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSkillDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSkillDescription.Location = new System.Drawing.Point(433, 351);
            this.lblSkillDescription.Name = "lblSkillDescription";
            this.lblSkillDescription.Size = new System.Drawing.Size(116, 15);
            this.lblSkillDescription.TabIndex = 22;
            this.lblSkillDescription.Text = "Skill Description:";
            // 
            // lblSkillID
            // 
            this.lblSkillID.AutoSize = true;
            this.lblSkillID.BackColor = System.Drawing.Color.Transparent;
            this.lblSkillID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSkillID.Location = new System.Drawing.Point(492, 318);
            this.lblSkillID.Name = "lblSkillID";
            this.lblSkillID.Size = new System.Drawing.Size(57, 15);
            this.lblSkillID.TabIndex = 21;
            this.lblSkillID.Text = "Skill ID:";
            // 
            // lblCurrentSkills
            // 
            this.lblCurrentSkills.AutoSize = true;
            this.lblCurrentSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSkills.Location = new System.Drawing.Point(393, 198);
            this.lblCurrentSkills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentSkills.Name = "lblCurrentSkills";
            this.lblCurrentSkills.Size = new System.Drawing.Size(110, 17);
            this.lblCurrentSkills.TabIndex = 24;
            this.lblCurrentSkills.Text = "Current Skills:";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(753, 437);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(133, 30);
            this.Return.TabIndex = 26;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(599, 437);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(133, 30);
            this.btnAssignSkill.TabIndex = 25;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            this.btnAssignSkill.Click += new System.EventHandler(this.btnAssignSkill_Click);
            // 
            // lblAssignSkills
            // 
            this.lblAssignSkills.AutoSize = true;
            this.lblAssignSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignSkills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssignSkills.Location = new System.Drawing.Point(612, 3);
            this.lblAssignSkills.Name = "lblAssignSkills";
            this.lblAssignSkills.Size = new System.Drawing.Size(288, 29);
            this.lblAssignSkills.TabIndex = 27;
            this.lblAssignSkills.Text = "Assign Candidate Skills";
            // 
            // AssignCandidateSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 490);
            this.Controls.Add(this.lblAssignSkills);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.lblCurrentSkills);
            this.Controls.Add(this.cboSkillDescription);
            this.Controls.Add(this.cboSkillID);
            this.Controls.Add(this.nudYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblSkillDescription);
            this.Controls.Add(this.lblSkillID);
            this.Controls.Add(this.lstCurrentSkills);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dgvCandidates);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AssignCandidateSkills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Candidate Skills";
            this.Load += new System.EventHandler(this.AssignCandidateSkills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidates;
        private dsLookingGlass dsLookingGlass;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private dsLookingGlassTableAdapters.candidatesTableAdapter candidatesTableAdapter;
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
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ListBox lstCurrentSkills;
        private System.Windows.Forms.ComboBox cboSkillDescription;
        private System.Windows.Forms.ComboBox cboSkillID;
        private System.Windows.Forms.NumericUpDown nudYears;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblSkillDescription;
        private System.Windows.Forms.Label lblSkillID;
        private System.Windows.Forms.Label lblCurrentSkills;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.Label lblAssignSkills;
    }
}