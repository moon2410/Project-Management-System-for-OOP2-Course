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
    public partial class StudentmyProjects : Form
    {
        string username = "username";
        LinkLabel[] lbl = new LinkLabel[100];
        public StudentmyProjects()
        {
            InitializeComponent();
        }
        public StudentmyProjects(string username)
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeshBoard rg = new StudentDeshBoard();
            rg.Show();
        }

        private void LogOut_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();
        }

        private void Fac_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void Camp_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk rg = new StudentTsk();
            rg.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk rg = new StudentTsk();
            rg.Show();
        }

        private void Course_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects rg = new StudentAllProjects();
            rg.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects rg = new StudentAllProjects();
            rg.Show();
        }

        private void Home_Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDeshBoard rg = new StudentDeshBoard(username);
            rg.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rg = new LoginPage();
            rg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentProjectSubmit rg = new StudentProjectSubmit();
            rg.Show();
        }

        private void facultyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFacultyListShow rg = new StudentFacultyListShow();
            rg.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTsk rg = new StudentTsk();
            rg.Show();
        }

        private void myProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentmyProjects rg = new StudentmyProjects();
            rg.Show();
        }

        private void allProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAllProjects rg = new StudentAllProjects();
            rg.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentProfileEdit rg = new StudentProfileEdit();
            rg.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChangePass rg = new StudentChangePass();
            rg.Show();
        }

        private void StudentmyProjects_Load(object sender, EventArgs e)
        {

            Projects pj = new Projects();
            String[] info = pj.showingProject(username);
            int n = 0;
            int length = info.Length;

            if (info != null && info.Length > 0)
            {

                for (int i = 0; i < length; i++)
                {
                    lbl[i].Text = info[i];
                    lbl[i].Location = new Point(90, n);
                    lbl[i].Size = new System.Drawing.Size(300, 30);
                    listView_projects.Controls.Add(lbl[i]);


                    n = n + 40;
                }
            }




        }

        private void listView_projects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
