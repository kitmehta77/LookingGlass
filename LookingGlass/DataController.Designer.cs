
namespace LookingGlass
{
    partial class DataController
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
            this.ctcLookingGlass = new MySql.Data.MySqlClient.MySqlConnection();
            this.dsLGdataCon = new LookingGlass.dsLookingGlass();
            ((System.ComponentModel.ISupportInitialize)(this.dsLGdataCon)).BeginInit();
            this.SuspendLayout();
            // 
            // ctcLookingGlass
            // 
            this.ctcLookingGlass.ConnectionString = "server=bmlx3df4ma7r1yh4.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;user id=u5bjygxz" +
    "fk20gi56;password=owc8txf5hia2tx4b;database=rtrd52qkf6p24ebs";
            // 
            // dsLGdataCon
            // 
            this.dsLGdataCon.DataSetName = "dsLookingGlass";
            this.dsLGdataCon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 428);
            this.Name = "DataController";
            this.Text = "DataController";
            ((System.ComponentModel.ISupportInitialize)(this.dsLGdataCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MySql.Data.MySqlClient.MySqlConnection ctcLookingGlass;
        public dsLookingGlass dsLGdataCon;
    }
}