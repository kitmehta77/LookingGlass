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
    public partial class AddCandidateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;


        public AddCandidateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            clearfield();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
        private void clearfield()
        {
            txtCandidateID.Text = "";
            txtCity.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            cboStatus.Text = "Available";
            cboWorkType.Text = "FullTime";
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtCity.Text == "" || cboWorkType.Text == "" || txtEmailAddress.Text == "" || txtPhoneNumber.Text == "" || txtStreetAddress.Text == "" || txtSuburb.Text == "" || cboStatus.Text == "")
            {
                MessageBox.Show("Please Fill in all fields Correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string Query = "INSERT INTO `candidates`(`CandidateID`,`LastName`, `FirstName`, `StreetAddress`, `Suburb`,`City`, `Email`, `PhoneNumber`,`WorkType`, `Status`) VALUES('" + txtCandidateID.Text + "','" + txtLastName.Text + "','" + txtFirstName.Text + "', '" + txtStreetAddress.Text + "','" + txtSuburb.Text + "','" + txtCity.Text + "', '" + txtEmailAddress.Text + "', '" + txtPhoneNumber.Text + "', '" + cboWorkType.Text + "','" + cboStatus.Text + "');";

                MySqlCommand insertEmployer = new MySqlCommand(Query, DC.ctcLookingGlass);
                insertEmployer.ExecuteNonQuery();

                MessageBox.Show("Candidate added Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                if (MessageBox.Show("Add another Candidate?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clearfield();
                   

                    DataRow drCandID = DC.dtCadidates.Rows[DC.dtCadidates.Rows.Count - 1];
                    int CandID = Convert.ToInt32(drCandID["CandidateID"]);
                    txtCandidateID.Text = (CandID + 2).ToString();

                }
                else
                {
                    this.Hide();
                    frmMenu.Show();
                }

            }
        }

        private void AddCandidateForm_Load(object sender, EventArgs e)
        {
            DataRow drCandID = DC.dtCadidates.Rows[DC.dtCadidates.Rows.Count - 1];

            int CandID = Convert.ToInt32(drCandID["CandidateID"]);
            txtCandidateID.Text = (CandID + 1).ToString(); 

        }
    }
}
