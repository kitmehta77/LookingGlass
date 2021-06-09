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
    public partial class AssignVacancyQualificationForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmQualification;
        private CurrencyManager cmVacancyQualification;
        public string aVacID;



        public AssignVacancyQualificationForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControls();
            loadSkills();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
        private void loadSkills()
        {
            cboQualificationID.DataSource = DC.dsLGdataCon;
            cboQualificationID.DisplayMember = "qualifications.QualificationID";
            cboQualificationID.ValueMember = "qualifications.QualificationID";

            cboQName.DataSource = DC.dsLGdataCon;
            cboQName.DisplayMember = "qualifications.QualificationDescription";
            cboQName.ValueMember = "qualifications.QualificationDescription";
        }
        private void bindControls()
        {
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancies"];
            cmVacancyQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancyqualification"];
            cmQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "qualifications"];

            dgvVacancy.DataSource = DC.dsLGdataCon;
            dgvVacancy.DataMember = "vacancies";

        }

        private void AssignVacancyQualificationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLookingGlass.vacancies' table. You can move, or remove it, as needed.
           // this.vacanciesTableAdapter.Fill(this.dsLookingGlass.vacancies);

        }

        private void dgvVacancy_Click(object sender, EventArgs e)
        {
                lstVacancy.Items.Clear();
                DataRow drVacancy = DC.dtVacancies.Rows[cmVacancy.Position];

                string aVacancy = drVacancy["EmployerID"].ToString();


                foreach (DataRow drEmployer in DC.dtEmployers.Rows)
                {
                    string anEmployer = drEmployer["EmployerID"].ToString();

                    if (aVacancy == anEmployer)
                    {

                        lstVacancy.Items.Add("Vacancy ID: " + drVacancy["VacancyID"] + "   " + drVacancy["VacancyDescription"] + "\t" + "Company Name:  " + drEmployer["CompanyName"]);
                        // lstVacancy.Size = new Size(500, 200);
                        lstVacancy.CustomTabOffsets.Add(60);
                        lstVacancy.UseCustomTabOffsets = true;
                        aVacID = drVacancy["VacancyID"].ToString();
                    }

                }


                lstAssignedQualification.Items.Clear();
                DataRow drVacancy1 = DC.dtVacancies.Rows[cmVacancy.Position];
                DataRow[] drVacancyQual = drVacancy1.GetChildRows(DC.dtVacancies.ChildRelations["VAC_VACQUAL"]);

                foreach (DataRow drVS in drVacancyQual)
                {
                    int aQualID = Convert.ToInt32(drVS["QualificationID"].ToString());
                    cmQualification.Position = DC.QualificationsView.Find(aQualID);
                    DataRow drQuals = DC.dtQulifications.Rows[cmQualification.Position];
                    lstAssignedQualification.Items.Add("Qualification ID: " + drQuals["QualificationID"] + "\t" + drQuals["QualificationDescription"]);
                    lstAssignedQualification.CustomTabOffsets.Add(80);
                    lstAssignedQualification.UseCustomTabOffsets = true;

                }
            
        }

        private void btnAssignVQ_Click(object sender, EventArgs e)
        {

            if (lstVacancy.Items.Count > 0)
            {
                DataRow AssignVS = DC.dtVacancyQualification.NewRow();

                AssignVS["VacancyID"] = Convert.ToInt32(aVacID);
                AssignVS["QualificationID"] = Convert.ToInt32(cboQualificationID.Text);

                DC.dtVacancyQualification.Rows.Add(AssignVS);
                lstAssignedQualification.Items.Add("Qualification ID: " + cboQualificationID.Text + "  " + cboQName.Text);
                lstAssignedQualification.CustomTabOffsets.Add(80);
                string Query = "INSERT INTO `vacancyqualification`(`VacancyID`,`QualificationID`) VALUES('" + Convert.ToInt32(aVacID) + "','" + cboQualificationID.Text + "');";

                MySqlCommand insertVacancyQualification = new MySqlCommand(Query, DC.ctcLookingGlass);
                insertVacancyQualification.ExecuteNonQuery();

                MessageBox.Show("Skill assigned to Vacancy Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (MessageBox.Show("Add another Skill to Vacancy?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Refresh();

                }
                else
                {
                    this.Hide();
                    frmMenu.Show();
                }

            }
            else
            {
                MessageBox.Show("Please Select a Vacancy from the list!", "Error");
            }
        }
    }
}
    
