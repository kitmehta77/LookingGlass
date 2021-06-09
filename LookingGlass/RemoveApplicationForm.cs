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
    public partial class RemoveApplicationForm : Form
    {

        private DataController DC;
        private MainForm frmMenu;
        public CurrencyManager cmVacancy;
        public CurrencyManager cmEmployer;
        public CurrencyManager cmApplication;
        public CurrencyManager cmCandidate;
        public string aVacID;
        public string aCandidateID;
        public string anAppID;
        public string aCandID;

        public int aCandSkillID;
        public int aCandQualID;
        public int aVacSkillID;
        public int aVacQualID;


        public RemoveApplicationForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControl();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
        private void bindControl()
        {
            cmApplication = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "application"];
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "employers"];
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancies"];
            cmCandidate = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "candidates"];


            foreach (DataRow drCandidate in DC.dtCadidates.Rows)
            {
                DataRow[] drCandidateApplications = drCandidate.GetChildRows(DC.dtCadidates.ChildRelations["APP_CAND"]);

                foreach (DataRow drCA in drCandidateApplications)
                {
                    if (drCA["ApplicationStatus"].ToString() != "Successful")
                    {
                        lstCandidates.Items.Add("Candidate ID: " + drCandidate["CandidateID"] + "\t" + drCandidate["LastName"] + ", " + drCandidate["FirstName"]);
                        aCandID = drCandidate["CandidateID"].ToString();
                        break;
                    }
                }
            }
        }

        private void lstCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCandidates.SelectedItem != null)
            {
                int startIndex = 13;
                int length = 3;
                string aCandidate;
                aCandidate = lstCandidates.SelectedItem.ToString();
                aCandID = aCandidate.Substring(startIndex, length);

            }

            DC.CandidatesView.Sort = "CandidateID ASC";
            int candidateID = Convert.ToInt32(aCandID);
            cmCandidate.Position = DC.CandidatesView.Find(candidateID);
            DataRow drCand = DC.dtCadidates.Rows[cmCandidate.Position];

            txtCandidateID.Text = drCand["CandidateID"].ToString();
            txtLastName.Text = drCand["LastName"].ToString();
            txtFirstName.Text = drCand["FirstName"].ToString();
            txtEmailAddress.Text = drCand["Email"].ToString();
            txtPhoneNumber.Text = drCand["PhoneNumber"].ToString();
            lstApplications.Items.Clear();
            DataRow[] drCandApps = drCand.GetChildRows(DC.dtCadidates.ChildRelations["APP_CAND"]);

            foreach (DataRow drCandApp in drCandApps)
            {
                int aVacancyID = Convert.ToInt32(drCandApp["VacancyID"].ToString());
                DC.VacanciesView.Sort = "VacancyID ASC";
                cmVacancy.Position = DC.VacanciesView.Find(aVacancyID);
                DataRow drVacancy = DC.dtVacancies.Rows[cmVacancy.Position];

                lstApplications.Items.Add("Application Status: " + drCandApp["ApplicationStatus"] + "  " + "Date Applied: " + Convert.ToDateTime(drCandApp["ApplicationDate"]).ToShortDateString() + "  " + "Vacancy ID: " + drVacancy["VacancyID"] + "  " + drVacancy["VacancyDescription"]);
                aVacID = drCandApp["VacancyID"].ToString();
                aCandID = drCandApp["CandidateID"].ToString();
            }
        }

        private void btnRemoveApp_Click(object sender, EventArgs e)
        {
            if (lstCandidates.SelectedIndex != -1)
            {
                if (lstApplications.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Application");

                }
                else
                {

                    if (MessageBox.Show("Are you sure you want to remove this application?", "Warning",
                                          MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string Query = "DELETE FROM `application` WHERE VacancyID= " + aVacID + " AND CandidateID= " + aCandID + "";
                        MySqlCommand removeApplication = new MySqlCommand(Query, DC.ctcLookingGlass);
                        removeApplication.ExecuteNonQuery();

                        MessageBox.Show("Vacancy filled Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Fill another Vacancy?", "information",
                                              MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            return;
                        }
                        else
                        {
                            this.Close();
                            frmMenu.Show();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Select a Candidate First!");
            }
        }
    }
}
