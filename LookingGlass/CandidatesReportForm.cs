using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class CandidatesReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        int numberOfRecords = 0;

        public CandidatesReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string candidateText = "";
            txtCandidatesReport.Text = "";


            foreach (DataRow drCandidate in DC.dtCadidates.Rows)
            {
                candidateText += drCandidate["LastName"] + ",  " + drCandidate["FirstName"] + "\r\n";
                candidateText += "Candidate ID: " + drCandidate["CandidateID"] + "  " + "\r\n";
                candidateText += "Address: " + drCandidate["StreetAddress"] + ",  ";
                candidateText += drCandidate["Suburb"] + ",  ";
                candidateText += drCandidate["City"] + "  " + "\r\n";
                candidateText += "Email Address: " + drCandidate["Email"] + "  " + "\r\n";
                candidateText += "Phone Number: " + drCandidate["PhoneNumber"] + "  " + "\r\n";
                candidateText += "Work Type: " + drCandidate["WorkType"] + "  " + "\r\n";
                candidateText += "Status: " + drCandidate["Status"] + "  " + "\r\n";


                DataRow drCandidateCount = DC.dtCadidates.Rows[DC.cmCandidates.Position];
                DC.cmCandidates.Position++;

                DataRow[] drApps = drCandidate.GetChildRows(DC.dtCadidates.ChildRelations["APP_CAND"]);

                numberOfRecords = drApps.Length;


                candidateText += "Total Vacancies applied for: " + numberOfRecords + "  " + "\r\n";
                candidateText += "--------------------------------------------------------------------------------------------------------------------------" + "\r\n\r\n\r\n";
                txtCandidatesReport.Text += candidateText;

                candidateText = "";
            }
        }
    }
}
