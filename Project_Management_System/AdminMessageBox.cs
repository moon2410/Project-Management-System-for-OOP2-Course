using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Management_System
{
    public partial class AdminMessageBox : Form
    {
        public AdminMessageBox()
        {
            InitializeComponent();
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
            AdminAccount ads = new AdminAccount();
            ads.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard();
            ads.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ads = new AdminDashboard();
            ads.Show();
        }

        private void btn_facultylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard afb = new AdminFacultyBoard();
            afb.Show();
        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFacultyBoard afb = new AdminFacultyBoard();
            afb.Show();
        }

        private void btn_addfaculty_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddFaculty ads = new AdminAddFaculty();
            ads.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }
    }
}
