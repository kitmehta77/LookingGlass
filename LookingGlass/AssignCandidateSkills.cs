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
    public partial class AssignCandidateSkills : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidates;
        private CurrencyManager cmSkills;
        private CurrencyManager cmCandidateSkills;
        


        public AssignCandidateSkills(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            loadSkills();
            bindControl();

        }
        private void bindControl()
        {
            cmCandidates = (CurrencyManager)this.BindingContext[DC.dsLGdataCon,"candidates"];
            cmCandidateSkills = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "candidateskill"];
            cmSkills = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "skills"];

            dgvCandidates.DataSource = DC.dsLGdataCon;
            dgvCandidates.DataMember = "candidates";

        }
        private void loadSkills()
        {
            cboSkillID.DataSource = DC.dsLGdataCon;
            cboSkillID.DisplayMember = "skills.SkillID";
            cboSkillID.ValueMember = "skills.SkillID";

            cboSkillDescription.DataSource = DC.dsLGdataCon;
            cboSkillDescription.DisplayMember = "skills.SkillDescription";
            cboSkillDescription.ValueMember = "skills.SkillDescription";
        }

        private void AssignCandidateSkills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLookingGlass.candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.dsLookingGlass.candidates);
 
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void dgvCandidates_Click(object sender, EventArgs e)
        {

            DataRow drCandidate = DC.dtCadidates.Rows[cmCandidates.Position];
            txtCandidateID.Text = drCandidate["CandidateID"].ToString();
            txtFirstName.Text = drCandidate["FirstName"].ToString();
            txtLastName.Text = drCandidate["LastName"].ToString();
            cboStatus.Text = drCandidate["Status"].ToString();
            DataRow[] drCandidateSkills = drCandidate.GetChildRows(DC.dtCadidates.ChildRelations["CAND_CANDSK"]);
            string currentskilldetails = "";
            lstCurrentSkills.Text = "";
            lstCurrentSkills.ForeColor = Color.Black;


            if (drCandidateSkills.Length == 0)
            {
                lstCurrentSkills.Items.Clear();
                currentskilldetails += "No Skills Attached to this Candidate!";
                lstCurrentSkills.Items.Add(currentskilldetails);
                lstCurrentSkills.ForeColor = Color.Red;
            }
            else
            {
                
                foreach (DataRow drCandSkill in drCandidateSkills)
                {
                   
                    int skillsDes = Convert.ToInt32(drCandSkill["SkillID"].ToString());
                    cmSkills.Position = DC.SkillsView.Find(skillsDes);
                    DataRow drSkills = DC.dtSkills.Rows[cmSkills.Position];
                    cmSkills.Position--;
                    lstCurrentSkills.CustomTabOffsets.Add(100);
                    currentskilldetails += "ID: " + drSkills["SkillID"] + "\t";
                    currentskilldetails += "Skill: " + drSkills["SkillDescription"] + "\t";
                    currentskilldetails += "Experience: " + drCandSkill["Years"] + " Years"; ;
                    currentskilldetails += ",";

                    lstCurrentSkills.Items.Clear();
                }

                lstCurrentSkills.Text += currentskilldetails;
                
                String[] Values = lstCurrentSkills.Text.Split(',');

                foreach (string Value in Values)
                {
                    if (Value.Trim() == "")
                        continue;
                    lstCurrentSkills.Items.Add(Value.Trim());
                }
                currentskilldetails = "";
                
            }
        }

        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            if (lstCurrentSkills.Items.Count > 0)
            {

                DataRow AssignSkills = DC.dtCandidateSkill.NewRow();

                AssignSkills["CandidateID"] = txtCandidateID.Text;
                AssignSkills["SkillID"] = cboSkillID.Text;
                AssignSkills["Years"] = nudYears.Value;

                DC.dtCandidateSkill.Rows.Add(AssignSkills);


                string Query = "INSERT INTO `candidateskill`(`CandidateID`,`SkillID`, `Years`) VALUES('" + txtCandidateID.Text + "','" + cboSkillID.Text + "','" + nudYears.Value + "');";

                MySqlCommand insertSkill = new MySqlCommand(Query, DC.ctcLookingGlass);
                insertSkill.ExecuteNonQuery();

                MessageBox.Show("Skills assigned Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (MessageBox.Show("Add another Skill?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                MessageBox.Show("Please Select a Candidate", "Error");
            }
        }
    }
}
