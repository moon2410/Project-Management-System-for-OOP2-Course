using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class AdminChangePass : Form
    {
        string username = "";
        public AdminChangePass()
        {
            InitializeComponent();
        }
        public AdminChangePass(string username )
        {
            this.username = username;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccount loginPage = new AdminAccount(username);
            loginPage.Show();
        }

        private void AdminChangePass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationProcedure ap = new AuthenticationProcedure();
            if (txt_oldpassword.Text.Equals("") || txt_newpassword.Text.Equals("") || txt_confirmpassword.Text.Equals(""))
            {
                MessageBox.Show("Please give your passwords!!!");
            }
            else if (ap.authenticationCheckadmin(username, txt_oldpassword.Text))
            {
                if (txt_newpassword.Text.Equals(txt_confirmpassword.Text))
                {
                    Edit ed = new Edit();
                    ed.changePasswordadmin(username, txt_newpassword.Text);
                    MessageBox.Show("Your Password has been updated!!!");
                    this.Hide();
                    FacultyDashboard sdb = new FacultyDashboard(username);
                    sdb.Show();
                }
                else
                {
                    MessageBox.Show("Wrong password!!!");
                    txt_oldpassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
                txt_oldpassword.Focus();
            }
        }
    }
}
