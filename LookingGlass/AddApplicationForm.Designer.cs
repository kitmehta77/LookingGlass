
namespace LookingGlass
{
    partial class AddApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApplicationForm));
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstCandidates = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.lblCandID = new System.Windows.Forms.Label();
            this.lblCLastName = new System.Windows.Forms.Label();
            this.lblCFirstName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.cboVacID = new System.Windows.Forms.ComboBox();
            this.cboVacDescription = new System.Windows.Forms.ComboBox();
            this.lblVacID = new System.Windows.Forms.Label();
            this.lblVacDescrip = new System.Windows.Forms.Label();
            this.lblFillVacancy = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(381, 334);
            this.btnAddApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(125, 29);
            this.btnAddApp.TabIndex = 63;
            this.btnAddApp.Text = "Add Application";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(556, 334);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 29);
            this.btnReturn.TabIndex = 64;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstCandidates
            // 
            this.lstCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCandidates.FormattingEnabled = true;
            this.lstCandidates.ItemHeight = 15;
            this.lstCandidates.Location = new System.Drawing.Point(26, 44);
            this.lstCandidates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCandidates.Name = "lstCandidates";
            this.lstCandidates.Size = new System.Drawing.Size(296, 319);
            this.lstCandidates.TabIndex = 65;
            this.lstCandidates.SelectedIndexChanged += new System.EventHandler(this.lstCandidates_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(501, 109);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(107, 20);
            this.txtFirstName.TabIndex = 80;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(501, 82);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(107, 20);
            this.txtLastName.TabIndex = 79;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateID.Location = new System.Drawing.Point(501, 57);
            this.txtCandidateID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.ReadOnly = true;
            this.txtCandidateID.Size = new System.Drawing.Size(47, 20);
            this.txtCandidateID.TabIndex = 78;
            // 
            // lblCandID
            // 
            this.lblCandID.AutoSize = true;
            this.lblCandID.BackColor = System.Drawing.Color.Transparent;
            this.lblCandID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandID.ForeColor = System.Drawing.Color.White;
            this.lblCandID.Location = new System.Drawing.Point(394, 59);
            this.lblCandID.Name = "lblCandID";
            this.lblCandID.Size = new System.Drawing.Size(106, 17);
            this.lblCandID.TabIndex = 83;
            this.lblCandID.Text = "Candidate ID:";
            // 
            // lblCLastName
            // 
            this.lblCLastName.AutoSize = true;
            this.lblCLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblCLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCLastName.ForeColor = System.Drawing.Color.White;
            this.lblCLastName.Location = new System.Drawing.Point(408, 84);
            this.lblCLastName.Name = "lblCLastName";
            this.lblCLastName.Size = new System.Drawing.Size(90, 17);
            this.lblCLastName.TabIndex = 82;
            this.lblCLastName.Text = "Last Name:";
            // 
            // lblCFirstName
            // 
            this.lblCFirstName.AutoSize = true;
            this.lblCFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblCFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCFirstName.ForeColor = System.Drawing.Color.White;
            this.lblCFirstName.Location = new System.Drawing.Point(408, 111);
            this.lblCFirstName.Name = "lblCFirstName";
            this.lblCFirstName.Size = new System.Drawing.Size(91, 17);
            this.lblCFirstName.TabIndex = 81;
            this.lblCFirstName.Text = "First Name:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(501, 163);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(107, 20);
            this.txtPhoneNumber.TabIndex = 85;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(501, 136);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailAddress.MaxLength = 50;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(180, 20);
            this.txtEmailAddress.TabIndex = 84;
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEmail.ForeColor = System.Drawing.Color.White;
            this.lblCEmail.Location = new System.Drawing.Point(382, 139);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(116, 17);
            this.lblCEmail.TabIndex = 87;
            this.lblCEmail.Text = "Email Address:";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblCPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPhone.ForeColor = System.Drawing.Color.White;
            this.lblCPhone.Location = new System.Drawing.Point(378, 165);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(120, 17);
            this.lblCPhone.TabIndex = 86;
            this.lblCPhone.Text = "Phone Number:";
            // 
            // cboVacID
            // 
            this.cboVacID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVacID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVacID.FormattingEnabled = true;
            this.cboVacID.Location = new System.Drawing.Point(501, 219);
            this.cboVacID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboVacID.Name = "cboVacID";
            this.cboVacID.Size = new System.Drawing.Size(113, 21);
            this.cboVacID.TabIndex = 88;
            // 
            // cboVacDescription
            // 
            this.cboVacDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVacDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVacDescription.FormattingEnabled = true;
            this.cboVacDescription.Location = new System.Drawing.Point(501, 248);
            this.cboVacDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboVacDescription.Name = "cboVacDescription";
            this.cboVacDescription.Size = new System.Drawing.Size(180, 21);
            this.cboVacDescription.TabIndex = 89;
            // 
            // lblVacID
            // 
            this.lblVacID.AutoSize = true;
            this.lblVacID.BackColor = System.Drawing.Color.Transparent;
            this.lblVacID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacID.ForeColor = System.Drawing.Color.White;
            this.lblVacID.Location = new System.Drawing.Point(404, 222);
            this.lblVacID.Name = "lblVacID";
            this.lblVacID.Size = new System.Drawing.Size(94, 17);
            this.lblVacID.TabIndex = 90;
            this.lblVacID.Text = "Vacancy ID:";
            // 
            // lblVacDescrip
            // 
            this.lblVacDescrip.AutoSize = true;
            this.lblVacDescrip.BackColor = System.Drawing.Color.Transparent;
            this.lblVacDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacDescrip.ForeColor = System.Drawing.Color.White;
            this.lblVacDescrip.Location = new System.Drawing.Point(403, 250);
            this.lblVacDescrip.Name = "lblVacDescrip";
            this.lblVacDescrip.Size = new System.Drawing.Size(95, 17);
            this.lblVacDescrip.TabIndex = 91;
            this.lblVacDescrip.Text = "Description:";
            // 
            // lblFillVacancy
            // 
            this.lblFillVacancy.AutoSize = true;
            this.lblFillVacancy.BackColor = System.Drawing.Color.Transparent;
            this.lblFillVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillVacancy.ForeColor = System.Drawing.Color.White;
            this.lblFillVacancy.Location = new System.Drawing.Point(512, 5);
            this.lblFillVacancy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFillVacancy.Name = "lblFillVacancy";
            this.lblFillVacancy.Size = new System.Drawing.Size(196, 29);
            this.lblFillVacancy.TabIndex = 92;
            this.lblFillVacancy.Text = "Add Application";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 430);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(107, 21);
            this.textBox1.TabIndex = 93;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(493, 430);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(107, 21);
            this.textBox2.TabIndex = 94;
            // 
            // AddApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 391);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFillVacancy);
            this.Controls.Add(this.lblVacDescrip);
            this.Controls.Add(this.lblVacID);
            this.Controls.Add(this.cboVacDescription);
            this.Controls.Add(this.cboVacID);
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
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstCandidates;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.Label lblCandID;
        private System.Windows.Forms.Label lblCLastName;
        private System.Windows.Forms.Label lblCFirstName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.ComboBox cboVacID;
        private System.Windows.Forms.ComboBox cboVacDescription;
        private System.Windows.Forms.Label lblVacID;
        private System.Windows.Forms.Label lblVacDescrip;
        private System.Windows.Forms.Label lblFillVacancy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}