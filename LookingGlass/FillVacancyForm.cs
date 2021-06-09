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
    public partial class FillVacancyForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        public CurrencyManager cmVacancy;
        public CurrencyManager cmEmployer;
        public CurrencyManager cmApplication;
        public CurrencyManager cmCandidate;
        public string aVacID;
        public string aCandidateID;
        public string anEmpID;
        public string aCandID;


        public FillVacancyForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControl();
            // clearfield();

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

            foreach (DataRow drVacancy in DC.dtVacancies.Rows)
            {
                string aVacancy = drVacancy["VacancyID"].ToString();
                Boolean found = false;

                foreach (DataRow drApplication in DC.dtApplication.Rows)
                {
                    string anApplication = drApplication["VacancyID"].ToString();
                    if (aVacancy == anApplication)
                    {
                        found = true;
                        lstVacancy.Items.Add("Vacancy ID: " + drVacancy["VacancyID"] + "\t" + drVacancy["VacancyDescription"]);
                        aVacID = drVacancy["VacancyID"].ToString();
                        aCandidateID = drApplication["CandidateID"].ToString();

                        break;
                    }
                }
                found = false;

            }
        }

        private void lstVacancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVacancy.SelectedItem != null)
            {
                int startIndex = 11;
                int length = 3;
                string vacancy;
                vacancy = lstVacancy.SelectedItem.ToString();
                aVacID = vacancy.Substring(startIndex, length);

            }

            foreach (DataRow drVacancy in DC.dtVacancies.Rows)
            {
                DC.VacanciesView.Sort = "VacancyID ASC";
                int vacancyID = Convert.ToInt32(aVacID);
                cmVacancy.Position = DC.VacanciesView.Find(vacancyID);
                DataRow employerID = DC.dtVacancies.Rows.Find(vacancyID);
                string empID = employerID["EmployerID"].ToString();


                lstVacDetails.Items.Clear();
                DataRow drEmployer = DC.dtEmployers.Rows[cmEmployer.Position];
                DataRow[] drVacEMPs = drEmployer.GetChildRows(DC.dtEmployers.ChildRelations["EMP_VAC"]);


                foreach (DataRow drEMP in drVacEMPs)
                {
                    cmEmployer.Position = DC.EmployersView.Find(empID);
                    DataRow drEMP1 = DC.dtEmployers.Rows[cmEmployer.Position];
                    DataRow drVacancy1 = DC.dtVacancies.Rows[cmVacancy.Position];


                    lstVacDetails.Items.Add("Vacancy ID: " + drVacancy1["VacancyID"] + "\t" + drVacancy1["VacancyDescription"] + "\t Status: " + drVacancy1["Status"] + "\t Company Name: " + drEMP1["CompanyName"]);
                    lstVacDetails.CustomTabOffsets.Add(30);
                    lstVacDetails.UseCustomTabOffsets = true;

                    txtVacancyID.Text = drVacancy1["VacancyID"].ToString();
                    txtVacDes.Text = drVacancy1["VacancyDescription"].ToString();
                    txtCompanyName.Text = drEMP1["CompanyName"].ToString();

                    break;
                }

               
                lstApplicants.Items.Clear();

                DataRow drVacancy2 = DC.dtVacancies.Rows[cmVacancy.Position];
                DataRow[] drVAs = drVacancy2.GetChildRows(DC.dtVacancies.ChildRelations["VAC_APP"]);

                foreach (DataRow drVA in drVAs)
                {
                    int aCandidateID = Convert.ToInt32(drVA["CandidateID"].ToString());
                    DC.ApplicationView.Sort = "CandidateID ASC";
                    cmApplication.Position = DC.ApplicationView.Find(aCandidateID);

                    DataRow drCandidate = DC.dtCadidates.Rows[cmCandidate.Position = aCandidateID - 1];
                    lstApplicants.Items.Add("Candidate ID: " + drVA["CandidateID"] + "\t" + drCandidate["LastName"] + "," + drCandidate["FirstName"] + "\t" + "Application Status: " + drVA["ApplicationStatus"] + "\tApplication Date: " + Convert.ToDateTime(drVA["ApplicationDate"]).ToShortDateString());
                    lstApplicants.CustomTabOffsets.Add(30);
                    lstApplicants.UseCustomTabOffsets = true;

                }
            }



        }
        private void lstApplicants_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstApplicants.SelectedItem != null)
            {
                int startIndex = 13;
                int length = 3;
                string vacancy;
                vacancy = lstApplicants.SelectedItem.ToString();
                aCandID = vacancy.Substring(startIndex, length);
            }
        }

        private void btnFillVac_Click(object sender, EventArgs e)
        {
            if (lstApplicants.Items.Count > 0)
            {
                if (lstApplicants.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Candidate");
                    return;
                }
                else 
                {
                    if (MessageBox.Show("Are you sure you want to select this application for the Vacancy?", "Warning",
                                          MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        string Query = "UPDATE `vacancies` SET `VacancyID`= '" + Convert.ToInt32(aVacID) + "',`Status`= '" + "Filled" + "' WHERE `VacancyID` = '" + Convert.ToInt32(aVacID) + "';";
                        MySqlCommand updateVacancy = new MySqlCommand(Query, DC.ctcLookingGlass);
                        updateVacancy.ExecuteNonQuery();

                        string Query1 = "UPDATE `application` SET `ApplicationStatus` = 'Successful' WHERE `VacancyID` = " + Convert.ToInt32(aVacID) + " AND `CandidateID` = " + Convert.ToInt32(aCandID) + "";
                        MySqlCommand updateApplication1 = new MySqlCommand(Query1, DC.ctcLookingGlass);
                        updateApplication1.ExecuteNonQuery();

                        string Query2 = "UPDATE `application` SET `ApplicationStatus` = 'Unsuccessful' WHERE `VacancyID` = " + Convert.ToInt32(aVacID) + " AND `CandidateID` != " + Convert.ToInt32(aCandID) + "";
                        MySqlCommand updateApplication2 = new MySqlCommand(Query2, DC.ctcLookingGlass);
                        updateApplication2.ExecuteNonQuery();

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
                MessageBox.Show("Please Select a Vacancy First!", "Error");
            }

        }


    }
}

