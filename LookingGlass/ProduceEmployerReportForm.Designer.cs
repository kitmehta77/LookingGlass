
namespace LookingGlass
{
    partial class ProduceEmployerReportForm
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtEmployerReport = new System.Windows.Forms.TextBox();
            this.lblEmpReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(113, 593);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(192, 42);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(370, 593);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(192, 42);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtEmployerReport
            // 
            this.txtEmployerReport.Location = new System.Drawing.Point(12, 48);
            this.txtEmployerReport.Multiline = true;
            this.txtEmployerReport.Name = "txtEmployerReport";
            this.txtEmployerReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmployerReport.Size = new System.Drawing.Size(685, 530);
            this.txtEmployerReport.TabIndex = 1;
            // 
            // lblEmpReport
            // 
            this.lblEmpReport.AutoSize = true;
            this.lblEmpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpReport.Location = new System.Drawing.Point(437, 9);
            this.lblEmpReport.Name = "lblEmpReport";
            this.lblEmpReport.Size = new System.Drawing.Size(269, 36);
            this.lblEmpReport.TabIndex = 2;
            this.lblEmpReport.Text = "Employers Report";
            // 
            // ProduceEmployerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 654);
            this.Controls.Add(this.lblEmpReport);
            this.Controls.Add(this.txtEmployerReport);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGenerateReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProduceEmployerReportForm";
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