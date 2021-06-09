
namespace LookingGlass
{
    partial class AssignVacancySkillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignVacancySkillForm));
            this.dsLookingGlass = new LookingGlass.dsLookingGlass();
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.lstAssignedSkills = new System.Windows.Forms.ListBox();
            this.lblSkillID = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.cboSkillID = new System.Windows.Forms.ComboBox();
            this.cboSkillName = new System.Windows.Forms.ComboBox();
            this.btnAssignVS = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblRemoveSkills = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // dsLookingGlass
            // 
            this.dsLookingGlass.DataSetName = "dsLookingGlass";
            this.dsLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstVacancy
            // 
            this.lstVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.ItemHeight = 15;
            this.lstVacancy.Location = new System.Drawing.Point(29, 62);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(832, 139);
            this.lstVacancy.TabIndex = 0;
            this.lstVacancy.SelectedIndexChanged += new System.EventHandler(this.lstVacancy_SelectedIndexChanged);
            // 
            // lstAssignedSkills
            // 
            this.lstAssignedSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssignedSkills.FormattingEnabled = true;
            this.lstAssignedSkills.ItemHeight = 15;
            this.lstAssignedSkills.Location = new System.Drawing.Point(29, 236);
            this.lstAssignedSkills.Name = "lstAssignedSkills";
            this.lstAssignedSkills.Size = new System.Drawing.Size(481, 109);
            this.lstAssignedSkills.TabIndex = 1;
            // 
            // lblSkillID
            // 
            this.lblSkillID.AutoSize = true;
            this.lblSkillID.BackColor = System.Drawing.Color.Transparent;
            this.lblSkillID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSkillID.Location = new System.Drawing.Point(552, 255);
            this.lblSkillID.Name = "lblSkillID";
            this.lblSkillID.Size = new System.Drawing.Size(57, 15);
            this.lblSkillID.TabIndex = 2;
            this.lblSkillID.Text = "Skill ID:";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.BackColor = System.Drawing.Color.Transparent;
            this.lblSkill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSkill.Location = new System.Drawing.Point(569, 285);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(39, 15);
            this.lblSkill.TabIndex = 3;
            this.lblSkill.Text = "Skill:";
            // 
            // cboSkillID
            // 
            this.cboSkillID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSkillID.FormattingEnabled = true;
            this.cboSkillID.Location = new System.Drawing.Point(612, 252);
            this.cboSkillID.Name = "cboSkillID";
            this.cboSkillID.Size = new System.Drawing.Size(67, 21);
            this.cboSkillID.TabIndex = 4;
            // 
            // cboSkillName
            // 
            this.cboSkillName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSkillName.FormattingEnabled = true;
            this.cboSkillName.Location = new System.Drawing.Point(612, 282);
            this.cboSkillName.Name = "cboSkillName";
            this.cboSkillName.Size = new System.Drawing.Size(249, 21);
            this.cboSkillName.TabIndex = 5;
            // 
            // btnAssignVS
            // 
            this.btnAssignVS.Location = new System.Drawing.Point(537, 333);
            this.btnAssignVS.Name = "btnAssignVS";
            this.btnAssignVS.Size = new System.Drawing.Size(145, 27);
            this.btnAssignVS.TabIndex = 7;
            this.btnAssignVS.Text = "Assign Skill";
            this.btnAssignVS.UseVisualStyleBackColor = true;
            this.btnAssignVS.Click += new System.EventHandler(this.btnAssignVS_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(716, 333);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(145, 27);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblRemoveSkills
            // 
            this.lblRemoveSkills.AutoSize = true;
            this.lblRemoveSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveSkills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRemoveSkills.Location = new System.Drawing.Point(613, 3);
            this.lblRemoveSkills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveSkills.Name = "lblRemoveSkills";
            this.lblRemoveSkills.Size = new System.Drawing.Size(265, 29);
            this.lblRemoveSkills.TabIndex = 48;
            this.lblRemoveSkills.Text = "Assign Vacancy Skills";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Current Vacancy Skills:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Vacancy Details:";
            // 
            // AssignVacancySkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRemoveSkills);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignVS);
            this.Controls.Add(this.cboSkillName);
            this.Controls.Add(this.cboSkillID);
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.lblSkillID);
            this.Controls.Add(this.lstAssignedSkills);
            this.Controls.Add(this.lstVacancy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AssignVacancySkillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Vacancy Skill";
            this.Load += new System.EventHandler(this.AssignVacancySkillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dsLookingGlass dsLookingGlass;
        private System.Windows.Forms.ListBox lstVacancy;
        private System.Windows.Forms.ListBox lstAssignedSkills;
        private System.Windows.Forms.Label lblSkillID;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.ComboBox cboSkillID;
        private System.Windows.Forms.ComboBox cboSkillName;
        private System.Windows.Forms.Button btnAssignVS;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblRemoveSkills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}