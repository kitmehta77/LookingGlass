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
    public partial class LoginForm : Form
    {
        private DataController DC;
        private EmployersClerkForm frmEmployerClerk;
        private MainForm frmCandidateClerk;
        private AdminForm frmadministrator;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DC.ctcLookingGlass.Close();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            MySqlDataAdapter admin = new MySqlDataAdapter("Select Count(*) From administrators where username='"+txtUserName.Text+"'And password='"+txtPassword.Text+"'", DC.ctcLookingGlass);
            DataTable dt = new DataTable();
            admin.Fill(dt);

            MySqlDataAdapter ECL = new MySqlDataAdapter("Select Count(*) From employerclerk where username='" + txtUserName.Text + "'And password='" + txtPassword.Text + "'", DC.ctcLookingGlass);
            DataTable dtECL = new DataTable();
            ECL.Fill(dtECL);

            MySqlDataAdapter CCL = new MySqlDataAdapter("Select Count(*) From candidateclerk where username='" + txtUserName.Text + "'And password='" + txtPassword.Text + "'", DC.ctcLookingGlass);
            DataTable dtCCL = new DataTable();
            CCL.Fill(dtCCL);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                if (frmadministrator == null)
                { 
                    frmadministrator = new AdminForm(DC, this);
                }
                frmadministrator.ShowDialog();

            }
            else if (dtECL.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                if (frmEmployerClerk == null)
                {
                    frmEmployerClerk = new EmployersClerkForm(DC, this);
                }
                frmEmployerClerk.ShowDialog();
            }
            else if (dtCCL.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                if (frmCandidateClerk == null)
                {
                    frmCandidateClerk = new MainForm(DC, this);
                }
                frmCandidateClerk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password!", "Error");
            }
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
            Refresh();

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
