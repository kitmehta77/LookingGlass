using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LookingGlass
{
    public partial class ProduceEmployerReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        int numberOfRecords = 0;

        public ProduceEmployerReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string employerText = "";
            txtEmployerReport.Text = "";


            foreach (DataRow drEmployer in DC.dtEmployers.Rows)
            {
                employerText += drEmployer["CompanyName"] + "  " + "\r\n";
                employerText += "Employer ID: " + drEmployer["EmployerID"] + "  " + "\r\n";
                employerText += "Address: " + drEmployer["StreetAddress"] + ",  ";
                employerText += drEmployer["Suburb"] + ",  ";
                employerText += drEmployer["City"] + "  " + "\r\n";
                employerText += "Phone Number: " + drEmployer["PhoneNumber"] + "  " + "\r\n";
                employerText += "Status: " + drEmployer["Status"] + "  " + "\r\n";

                
                DataRow drEmployerCount = DC.dtEmployers.Rows[DC.cmEmployer.Position];
                DC.cmEmployer.Position++;

                DataRow[] drVacs = drEmployerCount.GetChildRows(DC.dtEmployers.ChildRelations["EMP_VAC"]);

                numberOfRecords = drVacs.Length;

               
                employerText += "Total Vacancies: " + numberOfRecords + "  " + "\r\n";
                employerText += "--------------------------------------------------------------------------------------------------------------------------" + "\r\n\r\n\r\n";
                txtEmployerReport.Text += employerText;
               
                employerText = "";
            }

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
