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
    public partial class ApplicationReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        
        public ApplicationReportForm(DataController dc, MainForm mnu)
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
            string vacancyText = "";
            txtAppReport.Text = "";


            foreach (DataRow drCandidate in DC.dtCadidates.Rows)
            {

                int candidateID = Convert.ToInt32(drCandidate["CandidateID"]);
                DataRow[] drApplications = drCandidate.GetChildRows(DC.dtCadidates.ChildRelations["APP_CAND"]);
                if (drApplications.Length == 0)
                {
                }
                else
                {
                    foreach (DataRow drApplication in drApplications)
                    {
                        DC.CandidatesView.Sort = "FirstName ASC";
                        vacancyText += drCandidate["FirstName"] + ", " +  drCandidate["LastName"] + "\r\n";
                        vacancyText += "Application Date: " + Convert.ToDateTime(drApplication["ApplicationDate"]).ToShortDateString() + "\r\n";
                        vacancyText += "Application Date: " + drApplication["ApplicationStatus"] + "\r\n";
                        vacancyText += "Candidate ID: " + drApplication["CandidateID"] + "\r\n";
                        vacancyText += "Vacancy ID: " + drApplication["VacancyID"] + "\r\n";

                        int aVacaID = Convert.ToInt32(drApplication["VacancyID"]);
                        DataRow drVacancy = DC.dtVacancies.Rows[aVacaID - 1];
                        vacancyText += "Vacancy Description: " + drVacancy["VacancyDescription"] + "\r\n";

                        
                        string empID = drVacancy["EmployerID"].ToString();
                        DataRow drEmployer = DC.dtEmployers.Rows.Find(empID);

                        vacancyText += "Company Name: " + drEmployer["CompanyName"] + "\r\n";

                        vacancyText += "--------------------------------------------------------------------------------------------------------------------------" + "\r\n\r\n\r\n";
                        txtAppReport.Text += vacancyText;

                        vacancyText = "";
                    }
                }

            }
        }
    }
}
