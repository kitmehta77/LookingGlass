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
    public partial class DeleteVacancyForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        public CurrencyManager cmVacancy;
        public CurrencyManager cmEmployer;
        public CurrencyManager cmApplication;
        public CurrencyManager cmCandidate;
        public string aVacID;
        public string aCandidateID;
        public string aCandID;

        public DeleteVacancyForm(DataController dc, EmployersClerkForm mnu)
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

            foreach (DataRow drVacancy in DC.dtVacancies.Rows)
            {
                if (drVacancy["Status"].ToString() != "Unfilled")
                {
                    lstVacancy.Items.Add("Vacancy ID: " + drVacancy["VacancyID"] + "\t" + drVacancy["VacancyDescription"]);
                    aVacID = drVacancy["VacancyID"].ToString();

                }

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

            }
        }

        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            if (lstVacancy.SelectedIndex == -1)
            {

                MessageBox.Show("Please select a Vacancy");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this Vacancy?", "Warning",
                                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lstVacancy.Items.Remove(lstVacancy.SelectedItem);

                    txtVacancyID.Text = "";
                    txtVacDes.Text = "";
                    txtCompanyName.Text = "";

                    string Query = "DELETE FROM `vacancies` WHERE `VacancyID` = '" + Convert.ToInt32(aVacID) + "';";
                    MySqlCommand updateVacancy = new MySqlCommand(Query, DC.ctcLookingGlass);
                    updateVacancy.ExecuteNonQuery();

                    string Query1 = "DELETE FROM `vacancyskills` WHERE `VacancyID` = '" + Convert.ToInt32(aVacID) + "';";
                    MySqlCommand updateApplication1 = new MySqlCommand(Query1, DC.ctcLookingGlass);
                    updateApplication1.ExecuteNonQuery();

                    string Query2 = "DELETE FROM `vacancyqualification` WHERE `VacancyID` = '" + Convert.ToInt32(aVacID) + "';";
                    MySqlCommand updateApplication2 = new MySqlCommand(Query2, DC.ctcLookingGlass);
                    updateApplication2.ExecuteNonQuery();

                    string Query3 = "DELETE FROM `application` WHERE `VacancyID` = '" + Convert.ToInt32(aVacID) + "';";
                    MySqlCommand updateApplication3 = new MySqlCommand(Query3, DC.ctcLookingGlass);
                    updateApplication3.ExecuteNonQuery();

                    MessageBox.Show("Vacancy deleted Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Delete another Vacancy?", "information",
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

                else
                {
                    MessageBox.Show("Please Select a Vacancy First!", "Error");
                }
            }
        }
    }
    
                
}
