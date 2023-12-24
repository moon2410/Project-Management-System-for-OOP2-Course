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
    public partial class AdminDashboard : Form
    {
        string username = "";
        public AdminDashboard()
        {
            InitializeComponent();
        }
        public AdminDashboard(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage hm = new LoginPage();
            hm.Show();
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
            AdminAddFaculty ads = new AdminAddFaculty(username);
            ads.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAccount ads = new AdminAccount(username);
            ads.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDBDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.pMSDBDataSet.Projects);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_facultylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard afb = new AdminFacultyBoard(username);
            afb.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminMessageBox adminMessageBox = new AdminMessageBox(username);
            adminMessageBox.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminChangePass adminChangePass = new AdminChangePass(username);
            adminChangePass.Show();
        }
    }
}
