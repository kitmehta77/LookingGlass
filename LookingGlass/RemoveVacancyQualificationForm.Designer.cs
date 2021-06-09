
namespace LookingGlass
{
    partial class RemoveVacancyQualificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveVacancyQualificationForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveVQ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAssignedQualification = new System.Windows.Forms.ListBox();
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.vacancyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacanciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLookingGlass = new LookingGlass.dsLookingGlass();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAssignVQ = new System.Windows.Forms.Label();
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.vacanciesTableAdapter = new LookingGlass.dsLookingGlassTableAdapters.vacanciesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(807, 375);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 27);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveVQ
            // 
            this.btnRemoveVQ.Location = new System.Drawing.Point(579, 375);
            this.btnRemoveVQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveVQ.Name = "btnRemoveVQ";
            this.btnRemoveVQ.Size = new System.Drawing.Size(164, 27);
            this.btnRemoveVQ.TabIndex = 2;
            this.btnRemoveVQ.Text = "Remove Qualification";
            this.btnRemoveVQ.UseVisualStyleBackColor = true;
            this.btnRemoveVQ.Click += new System.EventHandler(this.btnRemoveVQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(446, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Current Vacancy Qualifications:";
            // 
            // lstAssignedQualification
            // 
            this.lstAssignedQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssignedQualification.FormattingEnabled = true;
            this.lstAssignedQualification.ItemHeight = 15;
            this.lstAssignedQualification.Location = new System.Drawing.Point(450, 237);
            this.lstAssignedQualification.Name = "lstAssignedQualification";
            this.lstAssignedQualification.Size = new System.Drawing.Size(521, 94);
            this.lstAssignedQualification.TabIndex = 69;
            this.lstAssignedQualification.SelectedIndexChanged += new System.EventHandler(this.lstAssignedQualification_SelectedIndexChanged);
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
            this.dgvVacancy.Location = new System.Drawing.Point(35, 36);
            this.dgvVacancy.MultiSelect = false;
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.ReadOnly = true;
            this.dgvVacancy.RowHeadersVisible = false;
            this.dgvVacancy.RowHeadersWidth = 51;
            this.dgvVacancy.RowTemplate.Height = 24;
            this.dgvVacancy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacancy.Size = new System.Drawing.Size(363, 365);
            this.dgvVacancy.TabIndex = 68;
            this.dgvVacancy.Click += new System.EventHandler(this.dgvVacancy_Click);
            // 
            // vacancyIDDataGridViewTextBoxColumn
            // 
            this.vacancyIDDataGridViewTextBoxColumn.DataPropertyName = "VacancyID";
            this.vacancyIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.vacancyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vacancyIDDataGridViewTextBoxColumn.Name = "vacancyIDDataGridViewTextBoxColumn";
            this.vacancyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacancyIDDataGridViewTextBoxColumn.Width = 60;
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
            // dsLookingGlass
            // 
            this.dsLookingGlass.DataSetName = "dsLookingGlass";
            this.dsLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(446, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "Vacancy Details:";
            // 
            // lblAssignVQ
            // 
            this.lblAssignVQ.AutoSize = true;
            this.lblAssignVQ.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignVQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignVQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssignVQ.Location = new System.Drawing.Point(632, 3);
            this.lblAssignVQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignVQ.Name = "lblAssignVQ";
            this.lblAssignVQ.Size = new System.Drawing.Size(365, 29);
            this.lblAssignVQ.TabIndex = 66;
            this.lblAssignVQ.Text = "Remove Vacancy Qualification";
            // 
            // lstVacancy
            // 
            this.lstVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.ItemHeight = 15;
            this.lstVacancy.Location = new System.Drawing.Point(450, 90);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(521, 79);
            this.lstVacancy.TabIndex = 65;
            // 
            // vacanciesTableAdapter
            // 
            this.vacanciesTableAdapter.ClearBeforeFill = true;
            // 
            // RemoveVacancyQualificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAssignedQualification);
            this.Controls.Add(this.dgvVacancy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAssignVQ);
            this.Controls.Add(this.lstVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveVQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RemoveVacancyQualificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Vacancy Qualification";
            this.Load += new System.EventHandler(this.RemoveVacancyQualificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLookingGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveVQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAssignedQualification;
        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAssignVQ;
        private System.Windows.Forms.ListBox lstVacancy;
        private dsLookingGlass dsLookingGlass;
        private System.Windows.Forms.BindingSource vacanciesBindingSource;
        private dsLookingGlassTableAdapters.vacanciesTableAdapter vacanciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyDescriptionDataGridViewTextBoxColumn;
    }
}