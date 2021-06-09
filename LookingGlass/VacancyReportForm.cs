using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class VacancyReportForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmMenu;
        int numberOfRecords = 0;

        public VacancyReportForm(DataController dc, EmployersClerkForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            string vacancyText = "";
            txtVacReport.Text = "";


            foreach (DataRow drVacancy in DC.dtVacancies.Rows)
            {

                vacancyText += "Vacancy: " +drVacancy["VacancyDescription"] + "\r\n";
                vacancyText += "Vacancy ID: " + drVacancy["VacancyID"] + "  " + "\r\n";
                vacancyText += "Status: " + drVacancy["Status"] + "\r\n";
                vacancyText += "Vacancy Type: " + drVacancy["VacancyType"] + "  " + "\r\n";
                vacancyText += "Salary: $" + drVacancy["Salary"] + "  " + "\r\n";

                DC.VacanciesView.Sort = "VacancyID ASC";
                int vacancyID = Convert.ToInt32(drVacancy["VacancyID"]);
                DC.cmVacancies.Position = DC.VacanciesView.Find(vacancyID);
                DataRow employerID = DC.dtVacancies.Rows.Find(vacancyID);
                string empID = employerID["EmployerID"].ToString();

                DataRow drEmployerCount = DC.dtEmployers.Rows[DC.cmEmployer.Position];
                DC.cmEmployer.Position++;

                DataRow[] drVacs = drEmployerCount.GetChildRows(DC.dtEmployers.ChildRelations["EMP_VAC"]);
                foreach (DataRow drEMP in drVacs)
                {
                    DC.cmEmployer.Position = DC.EmployersView.Find(empID);
                    DataRow drEMP1 = DC.dtEmployers.Rows[DC.cmEmployer.Position];
                    vacancyText += "Company Name: " + drEMP1["CompanyName"] + "  " + "\r\n";
                    break;
                }
                DataRow drVac = DC.dtVacancies.Rows[DC.cmVacancies.Position];
                DC.cmVacancies.Position++;
                DataRow[] drAppVac = drVac.GetChildRows(DC.dtVacancies.ChildRelations["VAC_APP"]);
                numberOfRecords = drAppVac.Length;
                vacancyText += "Total Applications: " + numberOfRecords + "  " + "\r\n";
                vacancyText += "--------------------------------------------------------------------------------------------------------------------------" + "\r\n\r\n\r\n";
                txtVacReport.Text += vacancyText;

                vacancyText = "";
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
    
}
