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
    public partial class AdminAccount : Form
    {
        string username = "";
        public AdminAccount()
        {
            InitializeComponent();
        }
        public AdminAccount(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard ads = new AdminFacultyBoard();
            ads.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard ads = new AdminFacultyBoard();
            ads.Show();
        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddFaculty ads = new AdminAddFaculty();
            ads.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddFaculty ads = new AdminAddFaculty();
            ads.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard(username);
            ads.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard();
            ads.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccount ads = new AdminAccount();
            ads.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();

            string[] result = ds.datashowfaculty(username, "admin");

            label_Username.Text = result[0];
            label_FirstName.Text = result[1];
            label_LastName.Text = result[2];
            label_PhoneNumber.Text = result[3];
            label_Email.Text = result[4];
            label_Gender.Text = result[5];
            label_BirthDate.Text = result[6];
            label_Department.Text = result[7];
            label_CurrentAddress.Text = result[8];
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard loginPage = new AdminFacultyBoard();
            loginPage.Show();
        }
    }
}
