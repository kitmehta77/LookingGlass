
namespace LookingGlass
{
    partial class DeleteCandidateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCandidateForm));
            this.lstCandidate = new System.Windows.Forms.ListBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSubrub = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddCandidate = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteCandidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCandidate
            // 
            this.lstCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCandidate.FormattingEnabled = true;
            this.lstCandidate.Location = new System.Drawing.Point(30, 47);
            this.lstCandidate.Margin = new System.Windows.Forms.Padding(4);
            this.lstCandidate.Name = "lstCandidate";
            this.lstCandidate.ScrollAlwaysVisible = true;
            this.lstCandidate.Size = new System.Drawing.Size(284, 277);
            this.lstCandidate.TabIndex = 1;
            this.lstCandidate.SelectedIndexChanged += new System.EventHandler(this.lstCandidate_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cboStatus.Location = new System.Drawing.Point(481, 240);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(150, 21);
            this.cboStatus.TabIndex = 22;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(481, 205);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 19;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.Location = new System.Drawing.Point(481, 179);
            this.txtSuburb.MaxLength = 25;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(150, 20);
            this.txtSuburb.TabIndex = 18;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.Location = new System.Drawing.Point(481, 154);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(217, 20);
            this.txtStreetAddress.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(481, 116);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateID.Location = new System.Drawing.Point(481, 57);
            this.txtCandidateID.MaxLength = 8;
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(57, 20);
            this.txtCandidateID.TabIndex = 14;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(481, 91);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 15;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStreetAddress.Location = new System.Drawing.Point(374, 158);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(104, 15);
            this.lblStreetAddress.TabIndex = 26;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(426, 243);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(443, 209);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 15);
            this.lblCity.TabIndex = 25;
            this.lblCity.Text = "City:";
            // 
            // lblSubrub
            // 
            this.lblSubrub.AutoSize = true;
            this.lblSubrub.BackColor = System.Drawing.Color.Transparent;
            this.lblSubrub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubrub.Location = new System.Drawing.Point(420, 183);
            this.lblSubrub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubrub.Name = "lblSubrub";
            this.lblSubrub.Size = new System.Drawing.Size(57, 15);
            this.lblSubrub.TabIndex = 24;
            this.lblSubrub.Text = "Suburb:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstName.Location = new System.Drawing.Point(398, 119);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 15);
            this.lblFirstName.TabIndex = 23;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidateID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCandidateID.Location = new System.Drawing.Point(384, 60);
            this.lblCandidateID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(94, 15);
            this.lblCandidateID.TabIndex = 20;
            this.lblCandidateID.Text = "Candidate ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Location = new System.Drawing.Point(398, 94);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 15);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAddCandidate
            // 
            this.lblAddCandidate.AutoSize = true;
            this.lblAddCandidate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCandidate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddCandidate.Location = new System.Drawing.Point(513, -1);
            this.lblAddCandidate.Name = "lblAddCandidate";
            this.lblAddCandidate.Size = new System.Drawing.Size(216, 29);
            this.lblAddCandidate.TabIndex = 28;
            this.lblAddCandidate.Text = "Delete Candidate";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(569, 299);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(129, 26);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteCandidate
            // 
            this.btnDeleteCandidate.Location = new System.Drawing.Point(391, 299);
            this.btnDeleteCandidate.Name = "btnDeleteCandidate";
            this.btnDeleteCandidate.Size = new System.Drawing.Size(129, 26);
            this.btnDeleteCandidate.TabIndex = 29;
            this.btnDeleteCandidate.Text = "Delete Candidate";
            this.btnDeleteCandidate.UseVisualStyleBackColor = true;
            this.btnDeleteCandidate.Click += new System.EventHandler(this.btnDeleteCandidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID        Candidates";
            // 
            // DeleteCandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCandidate);
            this.Controls.Add(this.lblAddCandidate);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSubrub);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lstCandidate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DeleteCandidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Candidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCandidate;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSubrub;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddCandidate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteCandidate;
        private System.Windows.Forms.Label label1;
    }
}