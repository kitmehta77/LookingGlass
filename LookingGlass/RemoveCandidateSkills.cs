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
    public partial class RemoveCandidateSkills : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidates;
        private CurrencyManager cmSkills;
        private CurrencyManager cmCandidateSkills;
        public string skillID;



        public RemoveCandidateSkills(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            
            bindControl();

        }
        private void bindControl()
        {
            cmCandidates = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "candidates"];
            cmCandidateSkills = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "candidateskill"];
            cmSkills = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "skills"];

            dgvCandidates.DataSource = DC.dsLGdataCon;
            dgvCandidates.DataMember = "candidates";


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
                    
                    currentskilldetails += "ID:" + drSkills["SkillID"] + "    ";
                    currentskilldetails += drSkills["SkillDescription"] + "\t";
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


        private void lstCurrentSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCurrentSkills.SelectedItem != null)
            {

                int startIndex = 3;
                int length = 3;
                string skill;
                skill = lstCurrentSkills.SelectedItem.ToString();
                skillID = skill.Substring(startIndex, length);
                
            }

        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if (lstCurrentSkills.Items.Count > 0)
            {
                if (lstCurrentSkills.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Skill!");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to remove this Skill?", "Warning",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        MySqlCommand cmd = DC.ctcLookingGlass.CreateCommand();
                        cmd.CommandText = "delete from candidateskill where CandidateID='" + txtCandidateID.Text + "'and SkillID='" + skillID + "'";
                        cmd.ExecuteNonQuery();



                        lstCurrentSkills.Items.Remove(lstCurrentSkills.SelectedItem);

                        MessageBox.Show("Skill removed Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (MessageBox.Show("Remove another Skill?", "information",
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
            else
            {
                MessageBox.Show("Please Select a Candidate", "Error");
            }
        }
    }
}
