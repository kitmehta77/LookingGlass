
namespace LookingGlass
{
    partial class AssignVacancyQualificationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignVacancyQualificationForm));
            this.btnAssignVQ = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dsLookingGlass = new LookingGlass.dsLookingGlass();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAssignVQ = new System.Windows.Forms.Label();
            this.cboQName = new System.Windows.Forms.ComboBox();
            this.cboQualificationID = new System.Windows.Forms.ComboBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblQualificationID = new System.Windows.Forms.Label();
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.vacancyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacanciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lstAssignedQualification = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssignVQ
            // 
            this.btnAssignVQ.Location = new System.Drawing.Point(653, 451);
            this.btnAssignVQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAssignVQ.Name = "btnAssignVQ";
            this.btnAssignVQ.Size = new System.Drawing.Size(156, 31);
            this.btnAssignVQ.TabIndex = 0;
            this.btnAssignVQ.Text = "Assign Qualification";
            this.btnAssignVQ.UseVisualStyleBackColor = true;
            this.btnAssignVQ.Click += new System.EventHandler(this.btnAssignVQ_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(836, 451);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 31);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dsLookingGlass
            // 
            this.dsLookingGlass.DataSetName = "dsLookingGlass";
            this.dsLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(467, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Vacancy Details:";
            // 
            // lblAssignVQ
            // 
            this.lblAssignVQ.AutoSize = true;
            this.lblAssignVQ.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignVQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignVQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssignVQ.Location = new System.Drawing.Point(669, 3);
            this.lblAssignVQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignVQ.Name = "lblAssignVQ";
            this.lblAssignVQ.Size = new System.Drawing.Size(347, 29);
            this.lblAssignVQ.TabIndex = 59;
            this.lblAssignVQ.Text = "Assign Vacancy Qualification";
            // 
            // cboQName
            // 
            this.cboQName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQName.FormattingEnabled = true;
            this.cboQName.Location = new System.Drawing.Point(653, 384);
            this.cboQName.Name = "cboQName";
            this.cboQName.Size = new System.Drawing.Size(249, 21);
            this.cboQName.TabIndex = 56;
            // 
            // cboQualificationID
            // 
            this.cboQualificationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualificationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQualificationID.FormattingEnabled = true;
            this.cboQualificationID.Location = new System.Drawing.Point(653, 354);
            this.cboQualificationID.Name = "cboQualificationID";
            this.cboQualificationID.Size = new System.Drawing.Size(67, 21);
            this.cboQualificationID.TabIndex = 55;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.BackColor = System.Drawing.Color.Transparent;
            this.lblQualification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQualification.Location = new System.Drawing.Point(559, 388);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(92, 15);
            this.lblQualification.TabIndex = 54;
            this.lblQualification.Text = "Qualification:";
            // 
            // lblQualificationID
            // 
            this.lblQualificationID.AutoSize = true;
            this.lblQualificationID.BackColor = System.Drawing.Color.Transparent;
            this.lblQualificationID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQualificationID.Location = new System.Drawing.Point(541, 357);
            this.lblQualificationID.Name = "lblQualificationID";
            this.lblQualificationID.Size = new System.Drawing.Size(110, 15);
            this.lblQualificationID.TabIndex = 53;
            this.lblQualificationID.Text = "Qualification ID:";
            // 
            // lstVacancy
            // 
            this.lstVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.ItemHeight = 15;
            this.lstVacancy.Location = new System.Drawing.Point(471, 96);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(521, 79);
            this.lstVacancy.TabIndex = 51;
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.AllowUserToAddRows = false;
            this.dgvVacancy.AllowUserToDeleteRows = false;
            this.dgvVacancy.AllowUserToResizeColumns = false;
            this.dgvVacancy.AllowUserToResizeRows = false;
            this.dgvVacancy.AutoGenerateColumns = false;
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vacancyIDDataGridViewTextBoxColumn,
            this.vacancyDescriptionDataGridViewTextBoxColumn});
            this.dgvVacancy.DataSource = this.vacanciesBindingSource;
            this.dgvVacancy.Location = new System.Drawing.Point(33, 42);
            this.dgvVacancy.MultiSelect = false;
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.ReadOnly = true;
            this.dgvVacancy.RowHeadersVisible = false;
            this.dgvVacancy.RowHeadersWidth = 51;
            this.dgvVacancy.RowTemplate.Height = 24;
            this.dgvVacancy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacancy.Size = new System.Drawing.Size(385, 441);
            this.dgvVacancy.TabIndex = 62;
            this.dgvVacancy.Click += new System.EventHandler(this.dgvVacancy_Click);
            // 
            // vacancyIDDataGridViewTextBoxColumn
            // 
            this.vacancyIDDataGridViewTextBoxColumn.DataPropertyName = "VacancyID";
            this.vacancyIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.vacancyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vacancyIDDataGridViewTextBoxColumn.Name = "vacancyIDDataGridViewTextBoxColumn";
            this.vacancyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacancyIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // vacancyDescriptionDataGridViewTextBoxColumn
            // 
            this.vacancyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "VacancyDescription";
            this.vacancyDescriptionDataGridViewTextBoxColumn.HeaderText = "Vacancy Description";
            this.vacancyDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vacancyDescriptionDataGridViewTextBoxColumn.Name = "vacancyDescriptionDataGridViewTextBoxColumn";
            this.vacancyDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacancyDescriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // vacanciesBindingSource
            // 
            this.vacanciesBindingSource.DataMember = "vacancies";
            this.vacanciesBindingSource.DataSource = this.dsLookingGlass;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(467, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "Current Vacancy Qualifications:";
            // 
            // lstAssignedQualification
            // 
            this.lstAssignedQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssignedQualification.FormattingEnabled = true;
            this.lstAssignedQualification.ItemHeight = 15;
            this.lstAssignedQualification.Location = new System.Drawing.Point(471, 222);
            this.lstAssignedQualification.Name = "lstAssignedQualification";
            this.lstAssignedQualification.Size = new System.Drawing.Size(521, 94);
            this.lstAssignedQualification.TabIndex = 63;
            // 
            // AssignVacancyQualificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAssignedQualification);
            this.Controls.Add(this.dgvVacancy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAssignVQ);
            this.Controls.Add(this.cboQName);
            this.Controls.Add(this.cboQualificationID);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.lblQualificationID);
            this.Controls.Add(this.lstVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignVQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AssignVacancyQualificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Vacancy Qualification";
            this.Load += new System.EventHandler(this.AssignVacancyQualificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssignVQ;
        private System.Windows.Forms.Button btnReturn;
        private dsLookingGlass dsLookingGlass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAssignVQ;
        private System.Windows.Forms.ComboBox cboQName;
        private System.Windows.Forms.ComboBox cboQualificationID;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblQualificationID;
        private System.Windows.Forms.ListBox lstVacancy;
        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.BindingSource vacanciesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAssignedQualification;
    }
}