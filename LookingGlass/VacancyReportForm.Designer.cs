
namespace LookingGlass
{
    partial class VacancyReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacancyReportForm));
            this.btnGenReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtVacReport = new System.Windows.Forms.TextBox();
            this.lblEmpReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenReport
            // 
            this.btnGenReport.Location = new System.Drawing.Point(328, 426);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(144, 27);
            this.btnGenReport.TabIndex = 61;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(500, 426);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(144, 27);
            this.btnReturn.TabIndex = 62;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtVacReport
            // 
            this.txtVacReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacReport.Location = new System.Drawing.Point(12, 41);
            this.txtVacReport.Multiline = true;
            this.txtVacReport.Name = "txtVacReport";
            this.txtVacReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVacReport.Size = new System.Drawing.Size(632, 368);
            this.txtVacReport.TabIndex = 63;
            // 
            // lblEmpReport
            // 
            this.lblEmpReport.AutoSize = true;
            this.lblEmpReport.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpReport.Location = new System.Drawing.Point(12, 9);
            this.lblEmpReport.Name = "lblEmpReport";
            this.lblEmpReport.Size = new System.Drawing.Size(195, 29);
            this.lblEmpReport.TabIndex = 64;
            this.lblEmpReport.Text = "Vacancy Report";
            // 
            // VacancyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 462);
            this.Controls.Add(this.lblEmpReport);
            this.Controls.Add(this.txtVacReport);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VacancyReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacancy Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtVacReport;
        private System.Windows.Forms.Label lblEmpReport;
    }
}