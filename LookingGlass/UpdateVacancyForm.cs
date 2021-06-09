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
    public partial class UpdateVacancyForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmEmployer;
        



        public UpdateVacancyForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            loadCompany();
            bindControl();

        }
        private void bindControl()
        {
            cmVacancy = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "vacancies"];
            cmEmployer = (CurrencyManager)this.BindingContext[DC.dsLGdataCon, "employers"];

            dgvVacancy.DataSource = DC.dsLGdataCon;
            dgvVacancy.DataMember = "vacancies";


            txtVacID.DataBindings.Add("Text", DC.dsLGdataCon, "vacancies.VacancyID");
            txtVacDes.DataBindings.Add("Text", DC.dsLGdataCon, "vacancies.VacancyDescription");
            cboVacType.DataBindings.Add("Text", DC.dsLGdataCon, "vacancies.VacancyType");
            cboStatus.DataBindings.Add("Text", DC.dsLGdataCon, "vacancies.Status");
            nudSalary.DataBindings.Add("Text", DC.dsLGdataCon, "vacancies.Salary");
            cboEmpID.DataBindings.Add("Text", DC.dsLGdataCon, "vacancies.EmployerID");

        }
        private void loadCompany()
        {
            cboEmpID.DataSource = DC.dsLGdataCon;
            cboEmpID.ValueMember = "employers.EmployerID";
            cboEmpID.DisplayMember = "employers.EmployerID";

            cboCompName.DataSource = DC.dsLGdataCon;
            cboCompName.ValueMember = "employers.CompanyName";
            cboCompName.DisplayMember = "employers.CompanyName";
        }


        private void UpdateVacancyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLookingGlass.vacancies' table. You can move, or remove it, as needed.
            //this.vacanciesTableAdapter.Fill(this.dsLookingGlass.vacancies);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnUpdateVac_Click(object sender, EventArgs e)
        {
            if (txtVacDes.Text == "" )
            {
                MessageBox.Show("Please Fill in all Fields Correctly");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this Vacancy?", "Warning",
                              MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string Query = "UPDATE `vacancies` SET `VacancyID`= '" + txtVacID.Text + "',`VacancyDescription`= '" + txtVacDes.Text + "',`Status`= '" + cboStatus.Text + "',`VacancyType`= '" + cboVacType.Text + "',`Salary`= '" + Convert.ToInt32(nudSalary.Text) + "',`EmployerID`= '" + cboEmpID.Text + "' WHERE `VacancyID` = '" + txtVacID.Text + "';";
                    MySqlCommand updateVacancy = new MySqlCommand(Query, DC.ctcLookingGlass);
                    updateVacancy.ExecuteNonQuery();

                    MessageBox.Show("Employer updated Succesfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    if (MessageBox.Show("Update another Vacancy?", "information",
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
