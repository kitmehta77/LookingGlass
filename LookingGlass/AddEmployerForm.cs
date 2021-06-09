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
    public partial class AddEmployerForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        
       

        public AddEmployerForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            clearfield();
          
        }

        private void clearfield()
        {
            txtCity.Text = "";
            txtCompanyName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "" || txtCompanyName.Text == "" || txtEmailAddress.Text == "" || txtPhoneNumber.Text == "" || txtStreetAddress.Text == "" || txtSuburb.Text == "" || cboStatus.Text == "")
            {
                MessageBox.Show("Please Fill in all fields Correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string Query = "INSERT INTO `employers`(`CompanyName`, `StreetAddress`, `Suburb`,`City`, `EmailAddress`, `PhoneNumber`, `Status`) VALUES('" + txtCompanyName.Text + "', '" + txtStreetAddress.Text + "','" + txtSuburb.Text + "','"+txtCity.Text+"', '" + txtEmailAddress.Text + "', '" + txtPhoneNumber.Text + "', '" + cboStatus.Text + "');";
                
                MySqlCommand insertEmployer = new MySqlCommand(Query, DC.ctcLookingGlass);
                insertEmployer.ExecuteNonQuery();

                MessageBox.Show("Employer added Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                if(MessageBox.Show("Add another employer?", "Information", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    clearfield();
                    
                }
                else
                {
                    this.Hide();
                    frmMenu.Show();
                }

            }
        }

        private void lblEmployer_Click(object sender, EventArgs e)
        {

        }
    }
}
