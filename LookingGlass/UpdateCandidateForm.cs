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
    public partial class UpdateCandidateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        

        public UpdateCandidateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindcontrols();
        }
        private void bindcontrols()
        {
            
        }

        private void UpdateCandidateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLookingGlass.candidates' table. You can move, or remove it, as needed.
            this.candidatesTableAdapter.Fill(this.dsLookingGlass.candidates);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
                
        }

        private void dgvCandidates_Click(object sender, EventArgs e)
        {
         
        }

        private void dgvCandidates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow CandidateRow = dgvCandidates.Rows[e.RowIndex];

                txtCandidateID.Text = CandidateRow.Cells[0].Value.ToString();
                txtLastName.Text = CandidateRow.Cells[1].Value.ToString();
                txtFirstName.Text = CandidateRow.Cells[2].Value.ToString();
                txtStreetAddress.Text = CandidateRow.Cells[3].Value.ToString();
                txtSuburb.Text = CandidateRow.Cells[4].Value.ToString();
                txtCity.Text = CandidateRow.Cells[5].Value.ToString();
                txtEmailAddress.Text = CandidateRow.Cells[6].Value.ToString();
                txtPhoneNumber.Text = CandidateRow.Cells[7].Value.ToString();
                cboWorkType.Text = CandidateRow.Cells[8].Value.ToString();
                cboStatus.Text = CandidateRow.Cells[9].Value.ToString();
            }
        }

        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            if (txtCandidateID.Text == "")
            {
                MessageBox.Show("Please Select a Candidate First", "Error");
            }
            else
            {

                if (txtCity.Text == "" || txtLastName.Text == "" || txtFirstName.Text == "" || txtEmailAddress.Text == "" || txtPhoneNumber.Text == "" || txtStreetAddress.Text == "" || cboStatus.Text == "" || txtSuburb.Text == "" || cboWorkType.Text == "")
                {
                    MessageBox.Show("Please Fill in all Fields Correctly");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update this Candidate?", "Warning",
                                  MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        string Query = "UPDATE `candidates` SET `CandidateID`= '" + txtCandidateID.Text + "',`LastName`= '" + txtLastName.Text + "',`FirstName`= '" + txtFirstName.Text + "',`StreetAddress`= '" + txtStreetAddress.Text + "',`Suburb`= '" + txtSuburb.Text + "',`City`= '" + txtCity.Text + "',`Email`= '" + txtEmailAddress.Text + "',`PhoneNumber`= '" + txtPhoneNumber.Text + "',`WorkType`= '" + cboWorkType.Text + "',`Status`= '" + cboStatus.Text + "' WHERE `CandidateID` = '" + txtCandidateID.Text + "';";
                        MySqlCommand updateCandidate = new MySqlCommand(Query, DC.ctcLookingGlass);
                        updateCandidate.ExecuteNonQuery();

                        MessageBox.Show("Candidate updated Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        if (MessageBox.Show("Update another Candidate?", "information",
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

    }
}
