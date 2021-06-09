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
    public partial class RemoveVacancySkillForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmSkills;
        private CurrencyManager cmVacancySkills;
        public string VacID;
        public string SkillIDtoRemove;



        public RemoveVacancySkillForm(DataController dc, EmployersClerkForm mnu)
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

                        lstVacancy.Items.Add("Vacancy ID: " + drVacancy["VacancyID"] + "  \t" + drVacancy["VacancyDescription"] + "\t" + "Company Name:  " + drEmployer["CompanyName"]);
                        // lstVacancy.Size = new Size(500, 200);
                        lstVacancy.CustomTabOffsets.Add(100);
                        lstVacancy.UseCustomTabOffsets = true;
                    }

                }

            }
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
                    lstAssignedSkills.Items.Add("Skill ID: " + drSkills["SkillID"] + "  \t" + drSkills["SkillDescription"]);
                    lstAssignedSkills.CustomTabOffsets.Add(80);
                    lstAssignedSkills.UseCustomTabOffsets = true;

                }
            }
        }

        private void btnRemoveVS_Click(object sender, EventArgs e)
        {

            if (lstAssignedSkills.Items.Count > 0)
            {
                if (lstAssignedSkills.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Skill!");
                    return;
                }
                else
                {
                    if (lstAssignedSkills.SelectedItem != null)
                    {
                        int startIndex = 10;
                        int length = 3;
                        string skill;
                        skill = lstAssignedSkills.SelectedItem.ToString();
                        SkillIDtoRemove = skill.Substring(startIndex, length);

                    }

                    DC.SkillsView.Sort = "SkillID ASC";
                    int SkID = Convert.ToInt32(SkillIDtoRemove);
                    cmSkills.Position = DC.SkillsView.Find(SkID);
                    lstAssignedSkills.Items.Remove(lstAssignedSkills.SelectedItem);

                    string Query = "delete from vacancyskills where VacancyID='" + Convert.ToInt32(VacID) + "'and SkillID='" + Convert.ToInt32(SkID) + "'";

                    MySqlCommand removeVacancySkill = new MySqlCommand(Query, DC.ctcLookingGlass);
                    removeVacancySkill.ExecuteNonQuery();

                    MessageBox.Show("Skill removed from Vacancy Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (MessageBox.Show("Remove another Skill from the Vacancy?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        reLoadForm();
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
                MessageBox.Show("Please Select a Vacancy from the list!");
            }
        }

        private void RemoveVacancySkillForm_Load(object sender, EventArgs e)
        {
          
        }
        private void reLoadForm()
        {
            this.Invalidate();
            lstVacancy.SelectedItems.Clear();
            lstAssignedSkills.Items.Clear();
            lstVacancy.Update();
        }
    }
}
