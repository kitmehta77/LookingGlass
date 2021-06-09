
namespace LookingGlass
{
    partial class RemoveApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveApplicationForm));
            this.lblRemoveVacancy = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblCandID = new System.Windows.Forms.Label();
            this.lblCLastName = new System.Windows.Forms.Label();
            this.lblCFirstName = new System.Windows.Forms.Label();
            this.lstCandidates = new System.Windows.Forms.ListBox();
            this.btnRemoveApp = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstApplications = new System.Windows.Forms.ListBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRemoveVacancy
            // 
            this.lblRemoveVacancy.AutoSize = true;
            this.lblRemoveVacancy.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveVacancy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRemoveVacancy.Location = new System.Drawing.Point(569, 2);
            this.lblRemoveVacancy.Name = "lblRemoveVacancy";
            this.lblRemoveVacancy.Size = new System.Drawing.Size(246, 29);
            this.lblRemoveVacancy.TabIndex = 112;
            this.lblRemoveVacancy.Text = "Remove Application";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(474, 149);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(142, 20);
            this.txtPhoneNumber.TabIndex = 105;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(474, 125);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAddress.MaxLength = 50;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(215, 20);
            this.txtEmailAddress.TabIndex = 104;
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCEmail.Location = new System.Drawing.Point(356, 126);
            this.lblCEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(116, 17);
            this.lblCEmail.TabIndex = 107;
            this.lblCEmail.Text = "Email Address:";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPhone.Location = new System.Drawing.Point(353, 148);
            this.lblCPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(120, 17);
            this.lblCPhone.TabIndex = 106;
            this.lblCPhone.Text = "Phone Number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(474, 100);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 100;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(474, 76);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(156, 20);
            this.txtLastName.TabIndex = 99;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateID.Location = new System.Drawing.Point(474, 51);
            this.txtCandidateID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCandidateID.MaxLength = 8;
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(53, 20);
            this.txtCandidateID.TabIndex = 98;
            // 
            // lblCandID
            // 
            this.lblCandID.AutoSize = true;
            this.lblCandID.BackColor = System.Drawing.Color.Transparent;
            this.lblCandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCandID.Location = new System.Drawing.Point(369, 53);
            this.lblCandID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandID.Name = "lblCandID";
            this.lblCandID.Size = new System.Drawing.Size(106, 17);
            this.lblCandID.TabIndex = 103;
            this.lblCandID.Text = "Candidate ID:";
            // 
            // lblCLastName
            // 
            this.lblCLastName.AutoSize = true;
            this.lblCLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblCLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCLastName.Location = new System.Drawing.Point(384, 76);
            this.lblCLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCLastName.Name = "lblCLastName";
            this.lblCLastName.Size = new System.Drawing.Size(90, 17);
            this.lblCLastName.TabIndex = 102;
            this.lblCLastName.Text = "Last Name:";
            // 
            // lblCFirstName
            // 
            this.lblCFirstName.AutoSize = true;
            this.lblCFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblCFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCFirstName.Location = new System.Drawing.Point(384, 102);
            this.lblCFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCFirstName.Name = "lblCFirstName";
            this.lblCFirstName.Size = new System.Drawing.Size(91, 17);
            this.lblCFirstName.TabIndex = 101;
            this.lblCFirstName.Text = "First Name:";
            // 
            // lstCandidates
            // 
            this.lstCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCandidates.FormattingEnabled = true;
            this.lstCandidates.ItemHeight = 15;
            this.lstCandidates.Location = new System.Drawing.Point(17, 51);
            this.lstCandidates.Margin = new System.Windows.Forms.Padding(2);
            this.lstCandidates.Name = "lstCandidates";
            this.lstCandidates.Size = new System.Drawing.Size(272, 289);
            this.lstCandidates.TabIndex = 97;
            this.lstCandidates.SelectedIndexChanged += new System.EventHandler(this.lstCandidates_SelectedIndexChanged);
            // 
            // btnRemoveApp
            // 
            this.btnRemoveApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveApp.Location = new System.Drawing.Point(474, 317);
            this.btnRemoveApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveApp.Name = "btnRemoveApp";
            this.btnRemoveApp.Size = new System.Drawing.Size(152, 23);
            this.btnRemoveApp.TabIndex = 95;
            this.btnRemoveApp.Text = "Remove Application";
            this.btnRemoveApp.UseVisualStyleBackColor = true;
            this.btnRemoveApp.Click += new System.EventHandler(this.btnRemoveApp_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(652, 317);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(152, 23);
            this.btnReturn.TabIndex = 96;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstApplications
            // 
            this.lstApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstApplications.FormattingEnabled = true;
            this.lstApplications.ItemHeight = 15;
            this.lstApplications.Location = new System.Drawing.Point(308, 219);
            this.lstApplications.Name = "lstApplications";
            this.lstApplications.Size = new System.Drawing.Size(496, 79);
            this.lstApplications.TabIndex = 113;
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApplication.Location = new System.Drawing.Point(307, 197);
            this.lblApplication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(101, 17);
            this.lblApplication.TabIndex = 114;
            this.lblApplication.Text = "Applications:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 115;
            this.label1.Text = "Candidates:";
            // 
            // RemoveApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.lstApplications);
            this.Controls.Add(this.lblRemoveVacancy);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblCEmail);
            this.Controls.Add(this.lblCPhone);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.lblCandID);
            this.Controls.Add(this.lblCLastName);
            this.Controls.Add(this.lblCFirstName);
            this.Controls.Add(this.lstCandidates);
            this.Controls.Add(this.btnRemoveApp);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RemoveApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoveVacancy;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.Label lblCandID;
        private System.Windows.Forms.Label lblCLastName;
        private System.Windows.Forms.Label lblCFirstName;
        private System.Windows.Forms.ListBox lstCandidates;
        private System.Windows.Forms.Button btnRemoveApp;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstApplications;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label label1;
    }
}