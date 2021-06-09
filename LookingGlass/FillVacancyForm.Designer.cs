
namespace LookingGlass
{
    partial class FillVacancyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillVacancyForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnFillVac = new System.Windows.Forms.Button();
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.lstVacDetails = new System.Windows.Forms.ListBox();
            this.lstApplicants = new System.Windows.Forms.ListBox();
            this.lblFillVacancy = new System.Windows.Forms.Label();
            this.lblVac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtVacDes = new System.Windows.Forms.TextBox();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(726, 310);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(129, 27);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnFillVac
            // 
            this.btnFillVac.Location = new System.Drawing.Point(568, 310);
            this.btnFillVac.Name = "btnFillVac";
            this.btnFillVac.Size = new System.Drawing.Size(129, 27);
            this.btnFillVac.TabIndex = 0;
            this.btnFillVac.Text = "Fill Vacancy";
            this.btnFillVac.UseVisualStyleBackColor = true;
            this.btnFillVac.Click += new System.EventHandler(this.btnFillVac_Click);
            // 
            // lstVacancy
            // 
            this.lstVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.ItemHeight = 15;
            this.lstVacancy.Location = new System.Drawing.Point(12, 64);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(279, 274);
            this.lstVacancy.TabIndex = 1;
            this.lstVacancy.SelectedIndexChanged += new System.EventHandler(this.lstVacancy_SelectedIndexChanged);
            // 
            // lstVacDetails
            // 
            this.lstVacDetails.FormattingEnabled = true;
            this.lstVacDetails.ItemHeight = 15;
            this.lstVacDetails.Location = new System.Drawing.Point(80, 612);
            this.lstVacDetails.Name = "lstVacDetails";
            this.lstVacDetails.Size = new System.Drawing.Size(672, 79);
            this.lstVacDetails.TabIndex = 2;
            // 
            // lstApplicants
            // 
            this.lstApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstApplicants.FormattingEnabled = true;
            this.lstApplicants.ItemHeight = 15;
            this.lstApplicants.Location = new System.Drawing.Point(312, 186);
            this.lstApplicants.Name = "lstApplicants";
            this.lstApplicants.Size = new System.Drawing.Size(543, 109);
            this.lstApplicants.TabIndex = 3;
            this.lstApplicants.SelectedIndexChanged += new System.EventHandler(this.lstApplicants_SelectedIndexChanged);
            // 
            // lblFillVacancy
            // 
            this.lblFillVacancy.AutoSize = true;
            this.lblFillVacancy.BackColor = System.Drawing.Color.Transparent;
            this.lblFillVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillVacancy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFillVacancy.Location = new System.Drawing.Point(702, 2);
            this.lblFillVacancy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFillVacancy.Name = "lblFillVacancy";
            this.lblFillVacancy.Size = new System.Drawing.Size(174, 29);
            this.lblFillVacancy.TabIndex = 56;
            this.lblFillVacancy.Text = "Fill a Vacancy";
            // 
            // lblVac
            // 
            this.lblVac.AutoSize = true;
            this.lblVac.BackColor = System.Drawing.Color.Transparent;
            this.lblVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVac.Location = new System.Drawing.Point(12, 43);
            this.lblVac.Name = "lblVac";
            this.lblVac.Size = new System.Drawing.Size(87, 17);
            this.lblVac.TabIndex = 57;
            this.lblVac.Text = "Vacancies:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Vacancy Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Applications:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(492, 129);
            this.txtCompanyName.MaxLength = 30;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(160, 20);
            this.txtCompanyName.TabIndex = 74;
            // 
            // txtVacDes
            // 
            this.txtVacDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacDes.Location = new System.Drawing.Point(492, 100);
            this.txtVacDes.MaxLength = 50;
            this.txtVacDes.Name = "txtVacDes";
            this.txtVacDes.ReadOnly = true;
            this.txtVacDes.Size = new System.Drawing.Size(205, 20);
            this.txtVacDes.TabIndex = 73;
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacancyID.Location = new System.Drawing.Point(492, 71);
            this.txtVacancyID.MaxLength = 5;
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.ReadOnly = true;
            this.txtVacancyID.Size = new System.Drawing.Size(58, 20);
            this.txtVacancyID.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 77;
            this.label4.Text = "Vacancy ID:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 76;
            this.label3.Text = "Description:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 75;
            this.label5.Text = "Company Name:";
            // 
            // FillVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 353);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtVacDes);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVac);
            this.Controls.Add(this.lblFillVacancy);
            this.Controls.Add(this.lstApplicants);
            this.Controls.Add(this.lstVacDetails);
            this.Controls.Add(this.lstVacancy);
            this.Controls.Add(this.btnFillVac);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FillVacancyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill Vacancy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnFillVac;
        private System.Windows.Forms.ListBox lstVacancy;
        private System.Windows.Forms.ListBox lstVacDetails;
        private System.Windows.Forms.ListBox lstApplicants;
        private System.Windows.Forms.Label lblFillVacancy;
        private System.Windows.Forms.Label lblVac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtVacDes;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}