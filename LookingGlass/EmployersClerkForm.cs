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
    
    public partial class EmployersClerkForm : Form
    {
        private DataController DC;

        private AddEmployerForm frmAddEmployer;
        private UpdateEmployerForm frmUpdateEmployer;
        private DeleteEmployerForm frmDeleteEmployer;
        private EmployerReportForm frmEmployerReport;
        private AssignVacancySkillForm frmAssignVacancySkill;
        private RemoveVacancySkillForm frmRemoveVacancySkill;
        private AssignVacancyQualificationForm frmAssignVacancyQualification;
        private RemoveVacancyQualificationForm frmRemoveVacancyQualification;
        private AddVacancyForm frmAddVacancy;
        private UpdateVacancyForm frmUpdateVacancy;
        private FillVacancyForm frmFillVacancy;
        private DeleteVacancyForm frmDeleteVacancy;
        private VacancyReportForm frmVacancyReport;
        private LoginForm frmLogin;

        public EmployersClerkForm(DataController dc, LoginForm login)
        {
            InitializeComponent();
            frmLogin = login;
            DC = dc;
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Show();
        }

        private void EmployersClerkForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
            Refresh();
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            {
                if (frmAddEmployer == null)
                {
                    frmAddEmployer = new AddEmployerForm(DC, this);
                }
                frmAddEmployer.ShowDialog();
            }
        }

        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            {
                if (frmUpdateEmployer == null)
                {
                    frmUpdateEmployer = new UpdateEmployerForm(DC, this);
                }
                frmUpdateEmployer.ShowDialog();
            }
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            {
                if (frmDeleteEmployer == null)
                {
                    frmDeleteEmployer = new DeleteEmployerForm(DC, this);
                }
                frmDeleteEmployer.ShowDialog();
            }
        }

        private void btnEmployerReport_Click(object sender, EventArgs e)
        {
            {
                if (frmEmployerReport == null)
                {
                    frmEmployerReport = new EmployerReportForm(DC, this);
                }
                frmEmployerReport.ShowDialog();
            }
        }

        private void btnAssignVS_Click(object sender, EventArgs e)
        {

            {
                if (frmAssignVacancySkill == null)
                {
                    frmAssignVacancySkill = new AssignVacancySkillForm(DC, this);
                }
                frmAssignVacancySkill.ShowDialog();
            }
        }

        private void btnRemoveVS_Click(object sender, EventArgs e)
        {
            {
                if (frmRemoveVacancySkill == null)
                {
                    frmRemoveVacancySkill = new RemoveVacancySkillForm(DC, this);
                }
                frmRemoveVacancySkill.ShowDialog();
            }
        }

        private void btnAssignVQ_Click(object sender, EventArgs e)
        {
            if (frmAssignVacancyQualification == null)
            {
                frmAssignVacancyQualification = new AssignVacancyQualificationForm(DC, this);
            }
            frmAssignVacancyQualification.ShowDialog();
        }

        private void btnRemoveVQ_Click(object sender, EventArgs e)
        {
            if (frmRemoveVacancyQualification == null)
            {
                frmRemoveVacancyQualification = new RemoveVacancyQualificationForm(DC, this);
            }
            frmRemoveVacancyQualification.ShowDialog();
        }

        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            if (frmAddVacancy == null)
            {
                frmAddVacancy = new AddVacancyForm(DC, this);
            }
            frmAddVacancy.ShowDialog();
        }

        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            if (frmUpdateVacancy == null)
            {
                frmUpdateVacancy = new UpdateVacancyForm(DC, this);
            }
            frmUpdateVacancy.ShowDialog();
        }

        private void btnFillVacancy_Click(object sender, EventArgs e)
        {
            if (frmFillVacancy == null)
            {
                frmFillVacancy = new FillVacancyForm(DC, this);
            }
            frmFillVacancy.ShowDialog();
        }

        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            if (frmDeleteVacancy == null)
            {
                frmDeleteVacancy = new DeleteVacancyForm(DC, this);
            }
            frmDeleteVacancy.ShowDialog();
        }

        private void btnVacanyReport_Click(object sender, EventArgs e)
        {
            if (frmVacancyReport == null)
            {
                frmVacancyReport = new VacancyReportForm(DC, this);
            }
            frmVacancyReport.ShowDialog();
        }

        private bool blnButtonDown = false;
        private void btnExit_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void button_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            blnButtonDown = true;
            (sender as System.Windows.Forms.Button).Invalidate();
        }

        private void button_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            blnButtonDown = false;
            (sender as System.Windows.Forms.Button).Invalidate();

        }
    }
    
}
