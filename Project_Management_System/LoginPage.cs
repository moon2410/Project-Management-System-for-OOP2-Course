using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Models;
using Controllers;
namespace Project_Management_System
{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            RegisterPage signUp = new RegisterPage();
            signUp.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            AuthenticationProcedure ap = new AuthenticationProcedure();
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))

            {

                MessageBox.Show(" Please Enter Username and Password");

            }
            else if (radioButton3.Checked)
            {
                if (ap.authenticationCheckadmin(txt_username.Text, txt_password.Text))
                {
                    this.Hide();
                    AdminDashboard rg = new AdminDashboard(txt_username.Text);
                    rg.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password Try again!");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
                

            }

            else if (radioButton2.Checked)
            {
                if (ap.authenticationCheckfaculty(txt_username.Text, txt_password.Text))
                {
                    this.Hide();
                    FacultyDashboard rg = new FacultyDashboard(txt_username.Text);
                    rg.Show();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password Try again!");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }

            else if (radioButton1.Checked) 
            {
                if(ap.authenticationCheck(txt_username.Text,txt_password.Text))
                {

                    this.Hide();
                    StudentDeshBoard sdb = new StudentDeshBoard(txt_username.Text);
                    sdb.Show();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password Try again!");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }

            } 
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
