
namespace LookingGlass
{
    partial class DeleteEmployerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmployerForm));
            this.lstEmployers = new System.Windows.Forms.ListBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblCoName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtEmployerID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDeleteEmployer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDeleteEmp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEmployers
            // 
            this.lstEmployers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployers.FormattingEnabled = true;
            this.lstEmployers.Location = new System.Drawing.Point(21, 50);
            this.lstEmployers.Name = "lstEmployers";
            this.lstEmployers.ScrollAlwaysVisible = true;
            this.lstEmployers.Size = new System.Drawing.Size(283, 264);
            this.lstEmployers.TabIndex = 0;
            this.lstEmployers.SelectedIndexChanged += new System.EventHandler(this.lstCompanyName_SelectedIndexChanged);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpID.Location = new System.Drawing.Point(411, 95);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(89, 15);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "Employer ID:";
            // 
            // lblCoName
            // 
            this.lblCoName.AutoSize = true;
            this.lblCoName.BackColor = System.Drawing.Color.Transparent;
            this.lblCoName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCoName.Location = new System.Drawing.Point(388, 130);
            this.lblCoName.Name = "lblCoName";
            this.lblCoName.Size = new System.Drawing.Size(112, 15);
            this.lblCoName.TabIndex = 1;
            this.lblCoName.Text = "Company Name:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmailAddress.Location = new System.Drawing.Point(397, 166);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(103, 15);
            this.lblEmailAddress.TabIndex = 1;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(450, 202);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // txtEmployerID
            // 
            this.txtEmployerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployerID.Location = new System.Drawing.Point(503, 93);
            this.txtEmployerID.MaxLength = 8;
            this.txtEmployerID.Name = "txtEmployerID";
            this.txtEmployerID.ReadOnly = true;
            this.txtEmployerID.Size = new System.Drawing.Size(54, 20);
            this.txtEmployerID.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(503, 127);
            this.txtCompanyName.MaxLength = 30;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(165, 20);
            this.txtCompanyName.TabIndex = 2;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(503, 163);
            this.txtEmailAddress.MaxLength = 50;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(212, 20);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(503, 199);
            this.txtStatus.MaxLength = 25;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(81, 20);
            this.txtStatus.TabIndex = 4;
            // 
            // btnDeleteEmployer
            // 
            this.btnDeleteEmployer.Location = new System.Drawing.Point(393, 284);
            this.btnDeleteEmployer.Name = "btnDeleteEmployer";
            this.btnDeleteEmployer.Size = new System.Drawing.Size(141, 30);
            this.btnDeleteEmployer.TabIndex = 5;
            this.btnDeleteEmployer.Text = "Delete Employer";
            this.btnDeleteEmployer.UseVisualStyleBackColor = true;
            this.btnDeleteEmployer.Click += new System.EventHandler(this.btnDeleteEmployer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(574, 284);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 30);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDeleteEmp
            // 
            this.lblDeleteEmp.AutoSize = true;
            this.lblDeleteEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeleteEmp.Location = new System.Drawing.Point(553, 6);
            this.lblDeleteEmp.Name = "lblDeleteEmp";
            this.lblDeleteEmp.Size = new System.Drawing.Size(208, 29);
            this.lblDeleteEmp.TabIndex = 7;
            this.lblDeleteEmp.Text = "Delete Employer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID        Employers";
            // 
            // DeleteEmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeleteEmp);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEmployer);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtEmployerID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblCoName);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lstEmployers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DeleteEmployerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Employer";
            this.Load += new System.EventHandler(this.DeleteEmployerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployers;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblCoName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtEmployerID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnDeleteEmployer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDeleteEmp;
        private System.Windows.Forms.Label label1;
    }
}