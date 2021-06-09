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
    public partial class DeleteEmployerForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        public string employerID;
        public DeleteEmployerForm(DataController dc, EmployersClerkForm mnu)
        {
            
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
            clearFields();
      
        }

        public void BindControls()
        {
            foreach (DataRow drEmployers in DC.dtEmployers.Rows)
            {
                string anEmployer = drEmployers["EmployerID"].ToString();
                Boolean found = false;

                foreach (DataRow drVacancy in DC.dtVacancies.Rows)
                {
                    string aVacancy = drVacancy["EmployerID"].ToString();
                    if (aVacancy == anEmployer)
                    {
                        found = true;
                    }
                }
                if (found == false)
                {
                    lstEmployers.Items.Add(drEmployers["EmployerID"] + "  " +"\t"+ drEmployers["CompanyName"]);

                }
                found = false;

            }
        }

        public void clearFields()
        {
            txtEmployerID.Text = "";
            txtCompanyName.Text = "";
            txtEmailAddress.Text = "";
            txtStatus.Text = "";
        }

        private void DeleteEmployerForm_Load(object sender, EventArgs e)
        {
           

        }

        private void lstCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployers.SelectedItem != null)
            {
                
                int startIndex = 0;
                int length = 3;
                string employer;
                employer = lstEmployers.SelectedItem.ToString();
                employerID = employer.Substring(startIndex, length);
                txtEmployerID.Text = employerID;

            }

            MySqlCommand cmd = DC.ctcLookingGlass.CreateCommand();
            cmd.CommandText = "Select * from employers where EmployerID='" + employerID.ToString() + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow drEmp in dt.Rows)
            {
                txtEmployerID.Text = drEmp["EmployerID"].ToString();
                txtCompanyName.Text = drEmp["CompanyName"].ToString();
                txtEmailAddress.Text = drEmp["EmailAddress"].ToString();
                txtStatus.Text = drEmp["Status"].ToString();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            if (txtEmployerID.Text == "")
            {
                MessageBox.Show("Please Select the Employer First", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this Employer?", "Warning",
                              MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    MySqlCommand cmd = DC.ctcLookingGlass.CreateCommand();
                    cmd.CommandText = "delete from employers where EmployerID='" + employerID + "'";
                    cmd.ExecuteNonQuery();

                    txtEmployerID.Text = "";
                    txtCompanyName.Text = "";
                    txtEmailAddress.Text = "";
                    txtStatus.Text = "";
                    lstEmployers.Items.Remove(lstEmployers.SelectedItem);

                    MessageBox.Show("Employer deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (MessageBox.Show("Delete another employer?", "information",
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
