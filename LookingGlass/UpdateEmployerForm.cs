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
    public partial class UpdateEmployerForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        CurrencyManager cmEmployer;

        public UpdateEmployerForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            bindcontrols();
        }

        private void bindcontrols()
        {
            cmEmployer = (CurrencyManager)this.BindingContext[dsEmployers, "Employers"];

           
            
        }
        private void UpdateEmployerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsEmployers.employers' table. You can move, or remove it, as needed.
            this.employersTableAdapter.Fill(this.dsEmployers.employers);
           
        }

        private void dgvEmployers_Click(object sender, EventArgs e)
        {
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void dgvEmployers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow employerRow = dgvEmployers.Rows[e.RowIndex];

                txtEmployerID.Text = employerRow.Cells[0].Value.ToString();
                txtCompanyName.Text = employerRow.Cells[1].Value.ToString();
                txtStreetAddress.Text = employerRow.Cells[2].Value.ToString();
                txtSuburb.Text = employerRow.Cells[3].Value.ToString();
                txtCity.Text = employerRow.Cells[4].Value.ToString();
                txtEmailAddress.Text = employerRow.Cells[5].Value.ToString();
                txtPhoneNumber.Text = employerRow.Cells[6].Value.ToString();
                cboStatus.Text = employerRow.Cells[7].Value.ToString();
            }
        }

        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            if (txtEmployerID.Text == "")
            {
                MessageBox.Show("Please Select the Employer First", "Error");
            }
            else
            {
                if (txtCity.Text == "" || txtCompanyName.Text == "" || txtEmailAddress.Text == "" || txtPhoneNumber.Text == "" || txtStreetAddress.Text == "" || cboStatus.Text == "" || txtSuburb.Text == "")
                {
                    MessageBox.Show("Please Fill in all Fields Correctly");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update this Employer?", "Warning",
                                  MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        string Query = "UPDATE `employers` SET `EmployerID`= '" + txtEmployerID.Text + "',`CompanyName`= '" + txtCompanyName.Text + "',`StreetAddress`= '" + txtStreetAddress.Text + "',`Suburb`= '" + txtSuburb.Text + "',`City`= '" + txtCity.Text + "',`EmailAddress`= '" + txtEmailAddress.Text + "',`PhoneNumber`= '" + txtPhoneNumber.Text + "',`Status`= '" + cboStatus.Text + "' WHERE `EmployerID` = '" + txtEmployerID.Text + "';";
                        MySqlCommand updateEmployer = new MySqlCommand(Query, DC.ctcLookingGlass);
                        updateEmployer.ExecuteNonQuery();

                        MessageBox.Show("Employer updated Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        if (MessageBox.Show("Update another employer?", "information",
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
