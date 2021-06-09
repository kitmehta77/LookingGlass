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
    public partial class RemoveCandidateQualificationForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidates;
        private CurrencyManager cmQualification;
        private CurrencyManager cmCandidateQualification;
        public string QualID;


        public RemoveCandidateQualificationForm(DataController dc, MainForm mnu)
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
            cmCandidateQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "candidatequalification"];
            cmQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "qualifications"];

            dgvCandidatesQualification.DataSource = DC.dsLGdataCon;
            dgvCandidatesQualification.DataMember = "candidates";


           

        }
        private void dgvCandidatesQualification_Click(object sender, EventArgs e)
        {  

            DataRow drCandidate = DC.dtCadidates.Rows[cmCandidates.Position];

            txtCandidateID.Text = drCandidate["CandidateID"].ToString();
            txtFirstName.Text = drCandidate["FirstName"].ToString();
            txtLastName.Text = drCandidate["LastName"].ToString();
            cboStatus.Text = drCandidate["Status"].ToString();


            DataRow[] drCandidateQualifications = drCandidate.GetChildRows(DC.dtCadidates.ChildRelations["CAND_CANDQUAL"]);
            string currentQdetails = "";
            lstCurrentQualification.Text = "";
            lstCurrentQualification.ForeColor = Color.Black;


            if (drCandidateQualifications.Length == 0)
            {
                
                lstCurrentQualification.Items.Clear();
                currentQdetails += "No Qualifcations for this Candidate!";
                lstCurrentQualification.Items.Add(currentQdetails);
                lstCurrentQualification.ForeColor = Color.Red;
            }
            else
            {

                foreach (DataRow drCandQual in drCandidateQualifications)
                {

                    int QualDes = Convert.ToInt32(drCandQual["QualificationID"].ToString());
                    cmQualification.Position = DC.QualificationsView.Find(QualDes);
                    DataRow drQualifications = DC.dtQulifications.Rows[cmQualification.Position];
                    cmQualification.Position--;

                    currentQdetails += "ID: " + drQualifications["QualificationID"] + "\t";
                    currentQdetails += drQualifications["QualificationDescription"] + "\t";
                    currentQdetails += "Date Obtained: " + Convert.ToDateTime(drCandQual["DateObtained"]).ToShortDateString();
                    currentQdetails += ",";

                    lstCurrentQualification.Items.Clear();
                }

                lstCurrentQualification.Text += currentQdetails;
                String[] Values = lstCurrentQualification.Text.Split(',');

                foreach (string Value in Values)
                {
                    if (Value.Trim() == "")
                        continue;
                    lstCurrentQualification.Items.Add(Value.Trim());
                }
                currentQdetails = "";

            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void lstCurrentQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCurrentQualification.SelectedItem != null)
            {

                int startIndex = 3;
                int length = 3;
                string skill;
                skill = lstCurrentQualification.SelectedItem.ToString();
                QualID = skill.Substring(startIndex, length);

            }
        }

        private void btnRemoveQualification_Click(object sender, EventArgs e)
        {
            if (lstCurrentQualification.Items.Count > 0)
            {
                if (lstCurrentQualification.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Qualification to Remove!");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to remove this Qualification?", "Warning",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       

                        MySqlCommand cmd = DC.ctcLookingGlass.CreateCommand();
                        cmd.CommandText = "delete from candidatequalification where CandidateID='" + txtCandidateID.Text + "'and QualificationID='" + QualID + "'";
                        cmd.ExecuteNonQuery();


                        lstCurrentQualification.Items.Remove(lstCurrentQualification.SelectedItem);

                        MessageBox.Show("Qualification removed Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (MessageBox.Show("Remove another Qualification?", "information",
                                              MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        this.Refresh();
                        txtCandidateID.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        cboStatus.Text = "";

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

                MessageBox.Show("Please Select a Candidate from the list!", "Error");

            }
        }
    }
}
