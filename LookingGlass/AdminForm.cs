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
    public partial class AdminForm : Form
    {
        private DataController DC;
        private LoginForm frmLogin;
        private MainForm frmCandidateClerk;
        private EmployersClerkForm frmEmployerClerk;
        
        public AdminForm(DataController dc, LoginForm login)
        {
            InitializeComponent();
            DC = dc;
            frmLogin = login;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Show();
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (frmCandidateClerk == null)
            {
                frmCandidateClerk = new MainForm(DC, frmLogin);
            }
            frmCandidateClerk.ShowDialog();


        }

        private void btnEmployerAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (frmEmployerClerk == null)
            {
                frmEmployerClerk = new EmployersClerkForm(DC, frmLogin);
            }
            frmEmployerClerk.ShowDialog();

        }
        private bool blnButtonDown = false;
        private void btnReturn_Paint(object sender, PaintEventArgs e)
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
