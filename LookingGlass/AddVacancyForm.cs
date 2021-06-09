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
    public partial class AddVacancyForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;


        public AddVacancyForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            clearfield();
            bindControl();

        }
        private void bindControl()
        {
            cboEmpID.DataSource = DC.dsLGdataCon;
            cboEmpID.DisplayMember = "employers.EmployerID";
            cboEmpID.ValueMember = "employers.EmployerID";

            cboCompName.DataSource = DC.dsLGdataCon;
            cboCompName.DisplayMember = "employers.CompanyName";
            cboCompName.ValueMember = "employers.CompanyName";
        }

       private void clearfield()
        {
            txtVacDes.Text = "";
            cboStatus.Text = "Current";
            cboVacType.Text = "FullTime";
          
        }

        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            if (txtVacDes.Text == "" || cboCompName.Text == "" || cboEmpID.Text == "" || cboStatus.Text == "" || cboVacType.Text == "")
            {
                MessageBox.Show("Please Fill in all fields Correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string Query = "INSERT INTO `vacancies`(`VacancyDescription`, `Status`, `VacancyType`,`Salary`, `EmployerID`) VALUES('" + txtVacDes.Text + "', '" + cboStatus.Text + "','" + cboVacType.Text + "','" + string.Format("{0:#,##0.00}", nudSalary.Text) + "', '" + Convert.ToInt32(cboEmpID.Text) + "');";

                MySqlCommand insertVacancy = new MySqlCommand(Query, DC.ctcLookingGlass);
                insertVacancy.ExecuteNonQuery();

                MessageBox.Show("Vacancy added Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (MessageBox.Show("Add another Vacancy?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void btnReturn_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmMenu.Show();
        }
    }
}
