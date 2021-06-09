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
    public partial class AssignCandidateQualification : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCandidates;
        private CurrencyManager cmQualification;
        private CurrencyManager cmCandidateQualification;



        public AssignCandidateQualification(DataController dc, MainForm mnu)
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
            cmCandidates = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "candidates"];
            cmCandidateQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "candidatequalification"];
            cmQualification = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "qualifications"];

            dgvCandidates.DataSource = DC.dsLGdataCon;
            dgvCandidates.DataMember = "candidates";


        }
        private void loadSkills()
        {
            cboQualificationID.DataSource = DC.dsLGdataCon;
            cboQualificationID.DisplayMember = "qualifications.QualificationID";
            cboQualificationID.ValueMember = "qualifications.QualificationID";

            cboQualificationDescription.DataSource = DC.dsLGdataCon;
            cboQualificationDescription.DisplayMember = "qualifications.QualificationDescription";
            cboQualificationDescription.ValueMember = "qualifications.QualificationDescription";
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
                    lstCurrentQualification.CustomTabOffsets.Add(100);
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

        private void btnAssignQualification_Click(object sender, EventArgs e)
        {
            if (lstCurrentQualification.Items.Count > 0)
            {

                DataRow AssignQualification = DC.dtCandidateQualification.NewRow();

                AssignQualification["CandidateID"] = txtCandidateID.Text;
                AssignQualification["QualificationID"] = cboQualificationID.Text;
                string dt;
                DateTime date = dateTimePicker1.Value;
                dt = date.ToString("yyyy-MM-dd");
                AssignQualification["DateObtained"] = dt;

                lstCurrentQualification.ForeColor = Color.Black;
                lstCurrentQualification.Items.Add((cboQualificationID.Text + "\t" + cboQualificationDescription.Text + "\t" + dt).ToString());
                DC.dtCandidateQualification.Rows.Add(AssignQualification);

                string Query = "INSERT INTO `candidatequalification`(`CandidateID`,`QualificationID`, `DateObtained`) VALUES('" + txtCandidateID.Text + "','" + cboQualificationID.Text + "','" + dt + "');";

                MySqlCommand insertQualification = new MySqlCommand(Query, DC.ctcLookingGlass);
                insertQualification.ExecuteNonQuery();

                MessageBox.Show("Qualification assigned Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (MessageBox.Show("Add another Qualification?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
