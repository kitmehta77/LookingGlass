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
    public partial class AddApplicationForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        public CurrencyManager cmVacancy;
        public CurrencyManager cmEmployer;
        public CurrencyManager cmApplication;
        public CurrencyManager cmCandidate;
        public string aVacID;
        public string aCandidateID;
        public string anEmpID;
        public string aCandID;

        public int aCandSkillID;
        public int aCandQualID;
        public int aVacSkillID;
        public int aVacQualID;


        public AddApplicationForm(DataController dc, MainForm mnu)
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

            cboVacID.DataSource = DC.dsLGdataCon;
            cboVacID.DisplayMember = "vacancies.VacancyID";
            cboVacID.ValueMember = "vacancies.VacancyID";

            cboVacDescription.DataSource = DC.dsLGdataCon;
            cboVacDescription.DisplayMember = "vacancies.VacancyDescription";
            cboVacDescription.ValueMember = "vacancies.VacancyDescription";

            foreach (DataRow drCandidate in DC.dtCadidates.Rows)
            {
                if (drCandidate["Status"].ToString() != "Unavailable")
                {
                    if (drCandidate["Status"].ToString() != "Employed")
                    {
                        lstCandidates.Items.Add("Candidate ID: " + drCandidate["CandidateID"] + "\t" + drCandidate["LastName"] + ", " + drCandidate["FirstName"]);
                        aCandID = drCandidate["CandidateID"].ToString();

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


        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            if (lstCandidates.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Candidate");
                return;
            }
            else
            {

                cmCandidate.Position = DC.CandidatesView.Find(Convert.ToInt32(aCandID));
                DataRow drCandidate = DC.dtCadidates.Rows[cmCandidate.Position];
                DataRow[] drCandidateSkill = drCandidate.GetChildRows(DC.dtCadidates.ChildRelations["CAND_CANDSK"]);

                foreach (DataRow drCandSkill in drCandidateSkill)
                {
                    int aSkillID = Convert.ToInt32(drCandSkill["SkillID"].ToString());
                    DC.cmSkills.Position = DC.SkillsView.Find(aSkillID);
                    aCandSkillID = Convert.ToInt32(aSkillID);
                    if (aCandSkillID == aVacSkillID)
                    {
                        break;
                    }
                }

                DataRow[] drCandQuals = drCandidate.GetChildRows(DC.dtCadidates.ChildRelations["CAND_CANDQUAL"]);

                foreach (DataRow drCandQual in drCandQuals)
                {
                    int aQualID = Convert.ToInt32(drCandQual["QualificationID"].ToString());
                    DC.cmQualifications.Position = DC.QualificationsView.Find(aQualID);
                    aCandQualID = Convert.ToInt32(aQualID);
                    if (aCandQualID == aVacQualID)
                    {
                        break;
                    }
                }

                aVacID = cboVacID.Text;
                DC.VacanciesView.Sort = "VacancyID ASC";
                cmVacancy.Position = DC.VacanciesView.Find(Convert.ToInt32(aVacID));
                DataRow drVacancy = DC.dtVacancies.Rows[cmVacancy.Position];

                DataRow[] drVacSkills = drVacancy.GetChildRows(DC.dtVacancies.ChildRelations["VAC_VACSKIL"]);

                foreach (DataRow drVacSkill in drVacSkills)
                {
                    int aSkillID = Convert.ToInt32(drVacSkill["SkillID"].ToString());
                    DC.cmSkills.Position = DC.SkillsView.Find(aSkillID);
                    aVacSkillID = Convert.ToInt32(aSkillID);
                    if (aCandSkillID == aVacSkillID)
                    {
                        break;
                    }

                }

                DataRow[] drVacQuals = drVacancy.GetChildRows(DC.dtVacancies.ChildRelations["VAC_VACQUAL"]);

                foreach (DataRow drVacQual in drVacQuals)
                {
                    int aQualID = Convert.ToInt32(drVacQual["QualificationID"].ToString());
                    DC.cmQualifications.Position = DC.QualificationsView.Find(aQualID);

                    aVacQualID = Convert.ToInt32(aQualID);
                    if (aCandQualID == aVacQualID)
                    {
                        break;
                    }

                }

                if (aCandSkillID == aVacSkillID)
                {
                    textBox1.Text = "True";
                }
                else
                {
                    textBox1.Text = "False";
                }
                if (aCandQualID == aVacQualID)
                {
                    textBox2.Text = "True";
                }
                else
                {
                    textBox2.Text = "False";
                }

                string dt;
                DateTime date = DateTime.Now;
                dt = date.ToString("yyyy-MM-dd");

                if (textBox1.Text == "True" && textBox2.Text == "True")
                {
                    string Query = "INSERT INTO `application`(`CandidateID`, `VacancyID`, `ApplicationDate`, `ApplicationStatus`) VALUES('" + aCandID + "', '" + aVacID + "', '" + dt + "', 'Pending')";
                    MySqlCommand AddApplication = new MySqlCommand(Query, DC.ctcLookingGlass);
                    AddApplication.ExecuteNonQuery();
                    MessageBox.Show("Application added Successfully");

                    if (MessageBox.Show("Add another Application?", "information",
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
                    MessageBox.Show("Candidate is not suitable for this Vacancy");
                    return;
                }
            }
        }
    }
}
