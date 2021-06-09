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
    public partial class DeleteCandidateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        public string candidateID;
        public DeleteCandidateForm(DataController dc, MainForm mnu)
        {

            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
            clearFields();

        }
        private void BindControls()
        {
            foreach (DataRow drCandidate in DC.dtCadidates.Rows)
            {
                string aCandidate = drCandidate["CandidateID"].ToString();
                Boolean found = false;

                foreach (DataRow drApplication in DC.dtApplication.Rows)
                {
                    string anApplication = drApplication["CandidateID"].ToString();
                    if (anApplication == aCandidate)
                    {
                        found = true;
                    }
                }
                if (found == false)
                {
                    lstCandidate.Items.Add(drCandidate["CandidateID"] + "   " +"\t"+drCandidate["LastName"] + ", " + drCandidate["FirstName"]);

                }
                found = false;

            }
        }
        private void clearFields()
        {
            txtCandidateID.Text = "";
            txtCity.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            cboStatus.Text = "";

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void lstCandidate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCandidate.SelectedItem != null)
            {

                int startIndex = 0;
                int length = 3;
                string candidate;
                candidate = lstCandidate.SelectedItem.ToString();
                candidateID = candidate.Substring(startIndex, length);
                txtCandidateID.Text = candidateID;

            }

            MySqlCommand cmd = DC.ctcLookingGlass.CreateCommand();
            cmd.CommandText = "Select * from candidates where CandidateID='" + candidateID.ToString() + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow drCandidate in dt.Rows)
            {
                txtCandidateID.Text = drCandidate["CandidateID"].ToString();
                txtLastName.Text = drCandidate["LastName"].ToString();
                txtFirstName.Text = drCandidate["FirstName"].ToString();
                txtStreetAddress.Text = drCandidate["StreetAddress"].ToString();
                txtSuburb.Text = drCandidate["Suburb"].ToString();
                txtCity.Text = drCandidate["City"].ToString();
                cboStatus.Text = drCandidate["Status"].ToString();
            }
        }

        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            if (txtCandidateID.Text == "")
            {
                MessageBox.Show("Please Select a Candidate First", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this Candidate?", "Warning",
                                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    MySqlCommand cmd = DC.ctcLookingGlass.CreateCommand();
                    cmd.CommandText = "delete from candidates where CandidateID='" + candidateID + "'";
                    cmd.ExecuteNonQuery();

                    txtCandidateID.Text = "";
                    txtCity.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtStreetAddress.Text = "";
                    txtSuburb.Text = "";
                    cboStatus.Text = "";
                    lstCandidate.Items.Remove(lstCandidate.SelectedItem);

                    MessageBox.Show("Candidate deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (MessageBox.Show("Delete another Candidate?", "information",
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
    }
}
