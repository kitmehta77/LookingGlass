
namespace LookingGlass
{
    partial class EmployerReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerReportForm));
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtEmployerReport = new System.Windows.Forms.TextBox();
            this.lblEmpReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(420, 501);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(142, 28);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(579, 501);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 28);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtEmployerReport
            // 
            this.txtEmployerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployerReport.Location = new System.Drawing.Point(12, 42);
            this.txtEmployerReport.Multiline = true;
            this.txtEmployerReport.Name = "txtEmployerReport";
            this.txtEmployerReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmployerReport.Size = new System.Drawing.Size(709, 440);
            this.txtEmployerReport.TabIndex = 1;
            // 
            // lblEmpReport
            // 
            this.lblEmpReport.AutoSize = true;
            this.lblEmpReport.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpReport.Location = new System.Drawing.Point(7, 10);
            this.lblEmpReport.Name = "lblEmpReport";
            this.lblEmpReport.Size = new System.Drawing.Size(223, 29);
            this.lblEmpReport.TabIndex = 2;
            this.lblEmpReport.Text = "Employers Report";
            // 
            // EmployerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 547);
            this.Controls.Add(this.lblEmpReport);
            this.Controls.Add(this.txtEmployerReport);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGenerateReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployerReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employers Report ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtEmployerReport;
        private System.Windows.Forms.Label lblEmpReport;
    }
}