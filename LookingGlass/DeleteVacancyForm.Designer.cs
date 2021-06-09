
namespace LookingGlass
{
    partial class DeleteVacancyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteVacancyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblVac = new System.Windows.Forms.Label();
            this.lblDeleteVac = new System.Windows.Forms.Label();
            this.lstVacDetails = new System.Windows.Forms.ListBox();
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.btnDeleteVacancy = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.txtVacDes = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Vacancy Details:";
            // 
            // lblVac
            // 
            this.lblVac.AutoSize = true;
            this.lblVac.BackColor = System.Drawing.Color.Transparent;
            this.lblVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVac.Location = new System.Drawing.Point(32, 46);
            this.lblVac.Name = "lblVac";
            this.lblVac.Size = new System.Drawing.Size(87, 17);
            this.lblVac.TabIndex = 64;
            this.lblVac.Text = "Vacancies:";
            // 
            // lblDeleteVac
            // 
            this.lblDeleteVac.AutoSize = true;
            this.lblDeleteVac.BackColor = System.Drawing.Color.Transparent;
            this.lblDeleteVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteVac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeleteVac.Location = new System.Drawing.Point(619, 0);
            this.lblDeleteVac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteVac.Name = "lblDeleteVac";
            this.lblDeleteVac.Size = new System.Drawing.Size(214, 29);
            this.lblDeleteVac.TabIndex = 63;
            this.lblDeleteVac.Text = "Delete a Vacancy";
            this.lblDeleteVac.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstVacDetails
            // 
            this.lstVacDetails.FormattingEnabled = true;
            this.lstVacDetails.ItemHeight = 15;
            this.lstVacDetails.Location = new System.Drawing.Point(73, 563);
            this.lstVacDetails.Name = "lstVacDetails";
            this.lstVacDetails.Size = new System.Drawing.Size(826, 79);
            this.lstVacDetails.TabIndex = 62;
            // 
            // lstVacancy
            // 
            this.lstVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.Location = new System.Drawing.Point(32, 66);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(355, 186);
            this.lstVacancy.TabIndex = 61;
            this.lstVacancy.SelectedIndexChanged += new System.EventHandler(this.lstVacancy_SelectedIndexChanged);
            // 
            // btnDeleteVacancy
            // 
            this.btnDeleteVacancy.Location = new System.Drawing.Point(532, 225);
            this.btnDeleteVacancy.Name = "btnDeleteVacancy";
            this.btnDeleteVacancy.Size = new System.Drawing.Size(139, 27);
            this.btnDeleteVacancy.TabIndex = 59;
            this.btnDeleteVacancy.Text = "Delete Vacancy";
            this.btnDeleteVacancy.UseVisualStyleBackColor = true;
            this.btnDeleteVacancy.Click += new System.EventHandler(this.btnDeleteVacancy_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(677, 225);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(139, 27);
            this.btnReturn.TabIndex = 60;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacancyID.Location = new System.Drawing.Point(601, 88);
            this.txtVacancyID.MaxLength = 5;
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.ReadOnly = true;
            this.txtVacancyID.Size = new System.Drawing.Size(51, 20);
            this.txtVacancyID.TabIndex = 66;
            // 
            // txtVacDes
            // 
            this.txtVacDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacDes.Location = new System.Drawing.Point(601, 117);
            this.txtVacDes.MaxLength = 50;
            this.txtVacDes.Name = "txtVacDes";
            this.txtVacDes.ReadOnly = true;
            this.txtVacDes.Size = new System.Drawing.Size(215, 20);
            this.txtVacDes.TabIndex = 67;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(601, 147);
            this.txtCompanyName.MaxLength = 30;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(163, 20);
            this.txtCompanyName.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(470, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Company Name:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(436, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "Vacancy Description:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(503, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "Vacancy ID:";
            // 
            // DeleteVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 293);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtVacDes);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVac);
            this.Controls.Add(this.lstVacDetails);
            this.Controls.Add(this.lstVacancy);
            this.Controls.Add(this.btnDeleteVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDeleteVac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DeleteVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Vacancy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVac;
        private System.Windows.Forms.Label lblDeleteVac;
        private System.Windows.Forms.ListBox lstVacDetails;
        private System.Windows.Forms.ListBox lstVacancy;
        private System.Windows.Forms.Button btnDeleteVacancy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.TextBox txtVacDes;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}