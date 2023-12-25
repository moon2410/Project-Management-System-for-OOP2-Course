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
    public partial class FacultyDashboard : Form
    {
        string username = "username";
        LinkLabel[] lbl = new LinkLabel[100];
        public FacultyDashboard()
        {
            InitializeComponent();
        }
        public FacultyDashboard(string username)
        {
            this.username = username;
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                lbl[i] = new LinkLabel();
            }

            lbl[0].Click += new System.EventHandler(lbl1Click);
            lbl[1].Click += new System.EventHandler(lbl2Click);
            lbl[2].Click += new System.EventHandler(lbl3Click);
            lbl[3].Click += new System.EventHandler(lbl4Click);
            lbl[4].Click += new System.EventHandler(lbl5Click);
            lbl[5].Click += new System.EventHandler(lbl6Click);
            lbl[6].Click += new System.EventHandler(lbl7Click);
            lbl[7].Click += new System.EventHandler(lbl8Click);
            lbl[8].Click += new System.EventHandler(lbl9Click);
            lbl[9].Click += new System.EventHandler(lbl10Click);
            lbl[10].Click += new System.EventHandler(lbl11Click);
            lbl[11].Click += new System.EventHandler(lbl12Click);
            lbl[12].Click += new System.EventHandler(lbl13Click);
            lbl[13].Click += new System.EventHandler(lbl14Click);
            lbl[14].Click += new System.EventHandler(lbl15Click);
        }
        private void lbl1Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[0].Text);
            pn.Text = lbl[0].Text;
            pn.Show();
        }

        private void lbl2Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[1].Text);
            pn.Text = lbl[1].Text;
            pn.Show();
        }

        private void lbl3Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[2].Text);
            pn.Text = lbl[2].Text;
            pn.Show();
        }

        private void lbl4Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[3].Text);
            pn.Text = lbl[3].Text;
            pn.Show();
        }

        private void lbl5Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[4].Text);
            pn.Text = lbl[4].Text;
            pn.Show();
        }

        private void lbl6Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[5].Text);
            pn.Text = lbl[5].Text;
            pn.Show();
        }

        private void lbl7Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[6].Text);
            pn.Text = lbl[6].Text;
            pn.Show();
        }

        private void lbl8Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[7].Text);
            pn.Text = lbl[7].Text;
            pn.Show();
        }

        private void lbl9Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[8].Text);
            pn.Text = lbl[8].Text;
            pn.Show();
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[9].Text);
            pn.Text = lbl[9].Text;
            pn.Show();
        }

        private void lbl11Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[10].Text);
            pn.Text = lbl[10].Text;
            pn.Show();
        }

        private void lbl12Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[11].Text);
            pn.Text = lbl[11].Text;
            pn.Show();
        }

        private void lbl13Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[12].Text);
            pn.Text = lbl[12].Text;
            pn.Show();
        }

        private void lbl14Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[13].Text);
            pn.Text = lbl[13].Text;
            pn.Show();
        }

        private void lbl15Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[14].Text);
            pn.Text = lbl[14].Text;
            pn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage hm = new LoginPage();
            hm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyGroups ads = new FacultyGroups();
            ads.Show();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyGroups ads = new FacultyGroups();
            ads.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculty_TaskBoard ads = new Faculty_TaskBoard();
            ads.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculty_TaskBoard ads = new Faculty_TaskBoard();
            ads.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard();
            ads.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyProfileEdit ads = new FacultyProfileEdit(username);
            ads.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyChangePass ads = new FacultyChangePass(username);
            ads.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveStudentList ads = new RemoveStudentList();
            ads.Show();
        }

        private void currentStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyStudentist ads = new FacultyStudentist();
            ads.Show();
        }

        private void appliedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyAppliedStudent ads = new facultyAppliedStudent();
            ads.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FacultyDashboard_Load(object sender, EventArgs e)
        {








        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyFacultyList ads = new FacultyFacultyList();
            ads.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyFacultyList ads = new FacultyFacultyList();
            ads.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile ads = new facultyProfile(username);
            ads.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Project ads = new Add_Project(username);
            ads.Show();
        }

        private void listView_projects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
