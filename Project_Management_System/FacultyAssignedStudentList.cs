﻿using System;
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
    public partial class FacultyAssignedStudentList : Form
    {
        string username = "";
        public FacultyAssignedStudentList()
        {
            InitializeComponent();
        }
        public FacultyAssignedStudentList(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile ads = new facultyProfile(username);
            ads.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyProfileEdit ads = new FacultyProfileEdit();
            ads.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyChangePass ads = new FacultyChangePass();
            ads.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard();
            ads.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard(username);
            ads.Show();
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
            FacultyFacultyList ads = new FacultyFacultyList(username);
            ads.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyStudentist ads = new FacultyStudentist(username);
            ads.Show();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage ads = new LoginPage();
            ads.Show();
        }

        private void FacultyAssignedStudentList_Load(object sender, EventArgs e)
        {

        }
    }
}
