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
    public partial class RemoveVacancyQualificationForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmQualification;
        private CurrencyManager cmVacancyQualification;
        public string aVacID;
        public string aQfID;
        public string aQualificationID;



        public RemoveVacancyQualificationForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControls();
        
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void bindControls()
        {

            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancies"];
            cmVacancyQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancyqualification"];
            cmQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "qualifications"];

            dgvVacancy.DataSource = DC.dsLGdataCon;
            dgvVacancy.DataMember = "vacancies";

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
                aQfID = aQualID.ToString();
                lstAssignedQualification.Items.Add("Qualification ID: " + drQuals["QualificationID"] + "  " + "\t" + drQuals["QualificationDescription"]);
                lstAssignedQualification.CustomTabOffsets.Add(80);
                lstAssignedQualification.UseCustomTabOffsets = true;

            }
        }

        private void RemoveVacancyQualificationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveVQ_Click(object sender, EventArgs e)
        {
            if (lstVacancy.Items.Count > 0)
            {
                if (lstAssignedQualification.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an Applicant first!");
                    return;
                }
                else
                {
                    lstAssignedQualification.Items.Remove(lstAssignedQualification.SelectedItem);

                    DataRow VQ = DC.dtVacancyQualification.NewRow();

                    VQ["VacancyID"] = Convert.ToInt32(aVacID);
                    VQ["QualificationID"] = Convert.ToInt32(aQualificationID);

                    
                    
                    lstAssignedQualification.CustomTabOffsets.Add(80);
                    string Query = "delete from vacancyqualification where VacancyID='" + Convert.ToInt32(aVacID) + "'and QualificationID='" + Convert.ToInt32(aQualificationID) + "'";
                    MySqlCommand removeVacancyQualification = new MySqlCommand(Query, DC.ctcLookingGlass);
                    removeVacancyQualification.ExecuteNonQuery();

                    MessageBox.Show("Qualification removed from Vacancy Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (MessageBox.Show("Remove another Qualification?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Refresh();

                    }
                    else
                    {
                        this.Hide();
                        frmMenu.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Vacancy from the list!", "Error");
            }
        }

        private void lstAssignedQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAssignedQualification.SelectedItem != null)
            {

                int startIndex = 17;
                int length = 3;
                string qualification;
                qualification = lstAssignedQualification.SelectedItem.ToString();
                aQualificationID = qualification.Substring(startIndex, length);

            }
        }
    }
}
