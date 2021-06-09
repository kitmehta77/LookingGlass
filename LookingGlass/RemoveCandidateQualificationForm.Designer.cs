
namespace LookingGlass
{
    partial class RemoveCandidateQualificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveCandidateQualificationForm));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.candidatesTableAdapter = new LookingGlass.dsLookingGlassTableAdapters.candidatesTableAdapter();
            this.dsLookingGlass = new LookingGlass.dsLookingGlass();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRemoveCQ = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.btnRemoveQualification = new System.Windows.Forms.Button();
            this.lblCurrentQualification = new System.Windows.Forms.Label();
            this.lstCurrentQualification = new System.Windows.Forms.ListBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dgvCandidatesQualification = new System.Windows.Forms.DataGridView();
            this.candidateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualificationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatesQualification)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(438, 167);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 15);
            this.lblFirstName.TabIndex = 55;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidateID.Location = new System.Drawing.Point(424, 102);
            this.lblCandidateID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(94, 15);
            this.lblCandidateID.TabIndex = 53;
            this.lblCandidateID.Text = "Candidate ID:";
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // dsLookingGlass
            // 
            this.dsLookingGlass.DataSetName = "dsLookingGlass";
            this.dsLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "candidates";
            this.candidatesBindingSource.DataSource = this.dsLookingGlass;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(438, 135);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 15);
            this.lblLastName.TabIndex = 54;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblRemoveCQ
            // 
            this.lblRemoveCQ.AutoSize = true;
            this.lblRemoveCQ.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveCQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRemoveCQ.Location = new System.Drawing.Point(505, 3);
            this.lblRemoveCQ.Name = "lblRemoveCQ";
            this.lblRemoveCQ.Size = new System.Drawing.Size(401, 29);
            this.lblRemoveCQ.TabIndex = 67;
            this.lblRemoveCQ.Text = "Remove Candidate Qualifications";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(661, 434);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(167, 30);
            this.Return.TabIndex = 66;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnRemoveQualification
            // 
            this.btnRemoveQualification.Location = new System.Drawing.Point(460, 434);
            this.btnRemoveQualification.Name = "btnRemoveQualification";
            this.btnRemoveQualification.Size = new System.Drawing.Size(167, 30);
            this.btnRemoveQualification.TabIndex = 65;
            this.btnRemoveQualification.Text = "Remove Qualification";
            this.btnRemoveQualification.UseVisualStyleBackColor = true;
            this.btnRemoveQualification.Click += new System.EventHandler(this.btnRemoveQualification_Click);
            // 
            // lblCurrentQualification
            // 
            this.lblCurrentQualification.AutoSize = true;
            this.lblCurrentQualification.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentQualification.Location = new System.Drawing.Point(387, 269);
            this.lblCurrentQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentQualification.Name = "lblCurrentQualification";
            this.lblCurrentQualification.Size = new System.Drawing.Size(150, 15);
            this.lblCurrentQualification.TabIndex = 64;
            this.lblCurrentQualification.Text = "Current Qualifications:";
            // 
            // lstCurrentQualification
            // 
            this.lstCurrentQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrentQualification.FormattingEnabled = true;
            this.lstCurrentQualification.ItemHeight = 15;
            this.lstCurrentQualification.Location = new System.Drawing.Point(391, 289);
            this.lstCurrentQualification.Name = "lstCurrentQualification";
            this.lstCurrentQualification.Size = new System.Drawing.Size(480, 94);
            this.lstCurrentQualification.TabIndex = 58;
            this.lstCurrentQualification.SelectedIndexChanged += new System.EventHandler(this.lstCurrentQualification_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cboStatus.Location = new System.Drawing.Point(521, 198);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(150, 21);
            this.cboStatus.TabIndex = 57;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(469, 202);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 56;
            this.lblStatus.Text = "Status:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(521, 164);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(183, 20);
            this.txtFirstName.TabIndex = 52;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateID.Location = new System.Drawing.Point(521, 99);
            this.txtCandidateID.MaxLength = 8;
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(65, 20);
            this.txtCandidateID.TabIndex = 50;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(521, 132);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(183, 20);
            this.txtLastName.TabIndex = 51;
            // 
            // dgvCandidatesQualification
            // 
            this.dgvCandidatesQualification.AllowUserToAddRows = false;
            this.dgvCandidatesQualification.AllowUserToDeleteRows = false;
            this.dgvCandidatesQualification.AllowUserToResizeColumns = false;
            this.dgvCandidatesQualification.AllowUserToResizeRows = false;
            this.dgvCandidatesQualification.AutoGenerateColumns = false;
            this.dgvCandidatesQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatesQualification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateIDDataGridViewTextBoxColumn,
            this.LastName,
            this.FirstName,
            this.CandidateID,
            this.QualificationID});
            this.dgvCandidatesQualification.DataSource = this.candidatesBindingSource;
            this.dgvCandidatesQualification.Location = new System.Drawing.Point(32, 55);
            this.dgvCandidatesQualification.Name = "dgvCandidatesQualification";
            this.dgvCandidatesQualification.ReadOnly = true;
            this.dgvCandidatesQualification.RowHeadersVisible = false;
            this.dgvCandidatesQualification.RowHeadersWidth = 51;
            this.dgvCandidatesQualification.RowTemplate.Height = 24;
            this.dgvCandidatesQualification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatesQualification.Size = new System.Drawing.Size(313, 409);
            this.dgvCandidatesQualification.TabIndex = 49;
            this.dgvCandidatesQualification.Click += new System.EventHandler(this.dgvCandidatesQualification_Click);
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
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // CandidateID
            // 
            this.CandidateID.DataPropertyName = "CandidateID";
            this.CandidateID.HeaderText = "CandidateID";
            this.CandidateID.MinimumWidth = 6;
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            this.CandidateID.Visible = false;
            this.CandidateID.Width = 125;
            // 
            // QualificationID
            // 
            this.QualificationID.DataPropertyName = "QualificationID";
            this.QualificationID.HeaderText = "QualificationID";
            this.QualificationID.MinimumWidth = 6;
            this.QualificationID.Name = "QualificationID";
            this.QualificationID.ReadOnly = true;
            this.QualificationID.Visible = false;
            this.QualificationID.Width = 125;
            // 
            // RemoveCandidateQualificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 480);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblRemoveCQ);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnRemoveQualification);
            this.Controls.Add(this.lblCurrentQualification);
            this.Controls.Add(this.lstCurrentQualification);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dgvCandidatesQualification);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RemoveCandidateQualificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Candidate Qualification";
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatesQualification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCandidateID;
        private dsLookingGlassTableAdapters.candidatesTableAdapter candidatesTableAdapter;
        private dsLookingGlass dsLookingGlass;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblRemoveCQ;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button btnRemoveQualification;
        private System.Windows.Forms.Label lblCurrentQualification;
        private System.Windows.Forms.ListBox lstCurrentQualification;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView dgvCandidatesQualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualificationID;
    }
}