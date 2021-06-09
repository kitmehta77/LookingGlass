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
    public partial class AssignVacancySkillForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmSkills;
        private CurrencyManager cmVacancySkills;
        public string VacID;



        public AssignVacancySkillForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindControls();
            loadSkills();

        }
        private void loadSkills()
        {
            cboSkillID.DataSource = DC.dsLGdataCon;
            cboSkillID.DisplayMember = "skills.SkillID";
            cboSkillID.ValueMember = "skills.SkillID";

            cboSkillName.DataSource = DC.dsLGdataCon;
            cboSkillName.DisplayMember = "skills.SkillDescription";
            cboSkillName.ValueMember = "skills.SkillDescription";
        }
        private void bindControls()
        {
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancies"];
            cmVacancySkills = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancyskills"];
            cmSkills = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "skills"];


            foreach (DataRow drVacancy in DC.dtVacancies.Rows)
            {
                string aVacancy = drVacancy["EmployerID"].ToString();
                

                foreach (DataRow drEmployer in DC.dtEmployers.Rows)
                {
                    string anEmployer = drEmployer["EmployerID"].ToString();

                    if (aVacancy == anEmployer)
                    {
                        
                        lstVacancy.Items.Add("Vacancy ID: " + drVacancy["VacancyID"] + "\t" + drVacancy["VacancyDescription"] + "\t" + "Company Name:  " + drEmployer["CompanyName"]);
                       
                        lstVacancy.CustomTabOffsets.Add(100);
                        lstVacancy.UseCustomTabOffsets = true;
                    }
                    
                }

            }

            
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void lstVacancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVacancy.SelectedItem != null)
            {
                int startIndex = 11;
                int length = 3;
                string skill;
                skill = lstVacancy.SelectedItem.ToString();
                VacID = skill.Substring(startIndex, length);
              
            }

            foreach (DataRow drVacancy in DC.dtVacancies.Rows)
            {
                DC.VacanciesView.Sort = "VacancyID ASC";
                int vacancyID = Convert.ToInt32(VacID);
                cmVacancy.Position = DC.VacanciesView.Find(vacancyID);

                lstAssignedSkills.Items.Clear();
                DataRow drVacancy1 = DC.dtVacancies.Rows[cmVacancy.Position];
                DataRow[] drVacancyskills = drVacancy1.GetChildRows(DC.dtVacancies.ChildRelations["VAC_VACSKIL"]);

                foreach (DataRow drVS in drVacancyskills)
                {
                    int aSkillID = Convert.ToInt32(drVS["SkillID"].ToString());
                    cmSkills.Position = DC.SkillsView.Find(aSkillID);
                    DataRow drSkills = DC.dtSkills.Rows[cmSkills.Position];
                    lstAssignedSkills.Items.Add("Skill ID: " + drSkills["SkillID"] + "\t" + drSkills["SkillDescription"]);
                    lstAssignedSkills.CustomTabOffsets.Add(80);
                    lstAssignedSkills.UseCustomTabOffsets = true;

                }
            }
        }

        private void btnAssignVS_Click(object sender, EventArgs e)
        {
            if (lstVacancy.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Vacancy!");
                return;
            }
            else
            {
                DataRow AssignVacancySkill = DC.dtVacancySkills.NewRow();

                AssignVacancySkill["VacancyID"] = Convert.ToInt32(VacID);
                AssignVacancySkill["SkillID"] = Convert.ToInt32(cboSkillID.Text);

                DC.dtVacancySkills.Rows.Add(AssignVacancySkill);
                lstAssignedSkills.Items.Add("Skill ID: " + cboSkillID.Text + "  " + cboSkillName.Text);
                lstAssignedSkills.CustomTabOffsets.Add(80);
                string Query = "INSERT INTO `vacancyskills`(`VacancyID`,`SkillID`) VALUES('" + Convert.ToInt32(VacID) + "','" + Convert.ToInt32(cboSkillID.Text) + "');";

                MySqlCommand insertVacancySkill = new MySqlCommand(Query, DC.ctcLookingGlass);
                insertVacancySkill.ExecuteNonQuery();

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
           
        }

        private void AssignVacancySkillForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
