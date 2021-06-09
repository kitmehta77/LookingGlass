
namespace LookingGlass
{
    partial class RemoveVacancySkillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveVacancySkillForm));
            this.btnRemoveVS = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAssignedSkills = new System.Windows.Forms.ListBox();
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.lblRemoveVSkills = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveVS
            // 
            this.btnRemoveVS.Location = new System.Drawing.Point(775, 319);
            this.btnRemoveVS.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveVS.Name = "btnRemoveVS";
            this.btnRemoveVS.Size = new System.Drawing.Size(155, 32);
            this.btnRemoveVS.TabIndex = 0;
            this.btnRemoveVS.Text = "Remove Skill";
            this.btnRemoveVS.UseVisualStyleBackColor = true;
            this.btnRemoveVS.Click += new System.EventHandler(this.btnRemoveVS_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(775, 374);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 32);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Vacancies:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Current Vacancy Skills:";
            // 
            // lstAssignedSkills
            // 
            this.lstAssignedSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssignedSkills.FormattingEnabled = true;
            this.lstAssignedSkills.ItemHeight = 15;
            this.lstAssignedSkills.Location = new System.Drawing.Point(17, 266);
            this.lstAssignedSkills.Margin = new System.Windows.Forms.Padding(4);
            this.lstAssignedSkills.Name = "lstAssignedSkills";
            this.lstAssignedSkills.Size = new System.Drawing.Size(675, 139);
            this.lstAssignedSkills.TabIndex = 52;
            // 
            // lstVacancy
            // 
            this.lstVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.ItemHeight = 15;
            this.lstVacancy.Location = new System.Drawing.Point(13, 67);
            this.lstVacancy.Margin = new System.Windows.Forms.Padding(4);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(917, 154);
            this.lstVacancy.TabIndex = 51;
            this.lstVacancy.SelectedIndexChanged += new System.EventHandler(this.lstVacancy_SelectedIndexChanged);
            // 
            // lblRemoveVSkills
            // 
            this.lblRemoveVSkills.AutoSize = true;
            this.lblRemoveVSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveVSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveVSkills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRemoveVSkills.Location = new System.Drawing.Point(669, 3);
            this.lblRemoveVSkills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveVSkills.Name = "lblRemoveVSkills";
            this.lblRemoveVSkills.Size = new System.Drawing.Size(283, 29);
            this.lblRemoveVSkills.TabIndex = 55;
            this.lblRemoveVSkills.Text = "Remove Vacancy Skills";
            // 
            // RemoveVacancySkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 429);
            this.Controls.Add(this.lblRemoveVSkills);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAssignedSkills);
            this.Controls.Add(this.lstVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveVS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RemoveVacancySkillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Vacancy Skill";
            this.Load += new System.EventHandler(this.RemoveVacancySkillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveVS;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAssignedSkills;
        private System.Windows.Forms.ListBox lstVacancy;
        private System.Windows.Forms.Label lblRemoveVSkills;
    }
}