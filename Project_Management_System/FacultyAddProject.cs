﻿using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Models;
namespace Project_Management_System
{
    public partial class FacultyAddproject : Form
    {
        String username = "";
        int rows = 0;
        LinkLabel[] lbl = new LinkLabel[100];
        int[] counter = new int[5];
        int test = 0;
        String[] name;
        String[] uname;
        public FacultyAddproject()
        {
            InitializeComponent();
        }
        public FacultyAddproject(string username)
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

        private void button_search_Click(object sender, EventArgs e)
        {
            listView_search.Controls.Clear();

            SearchingPeople sp = new SearchingPeople();
            rows = sp.searchResult(textBox_search.Text);
            name = new String[rows + 1];
            uname = new String[rows + 1];

            name = sp.peopleDisplay(textBox_search.Text, 1);
            uname = sp.peopleDisplay(textBox_search.Text, 2);
            int n = 0;

            for (int i = 0; i <= rows; i++)
            {

                lbl[i] = new LinkLabel();
                lbl[i].Text = name[i];
                lbl[i].Location = new Point(10, n);
                lbl[i].Size = new System.Drawing.Size(300, 30);
                listView_search.Controls.Add(lbl[i]);


                n = n + 40;
            }
        }

        private void listView_assaignedpeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            String[] token = textBox_projectname.Text.Split();
            string table = "";
            for (int k = 0; k < token.Length; k++)
            {
                table += token[k];
            }
            if (textBox_projectname.Text.Equals(""))
            {
                MessageBox.Show("Please Enter the Project Title");
            }
            else
            {
                Projects pj = new Projects();
                int j = 0;
                String username1 = uname[counter[j]];
                String name1 = name[counter[j++]];
                String username2 = uname[counter[j]];
                String name2 = name[counter[j++]];
                String username3 = uname[counter[j]];
                String name3 = name[counter[j++]];
                String username4 = uname[counter[j]];
                String name4 = name[counter[j++]];
                String username5 = uname[counter[j]];
                String name5 = name[counter[j++]];
                if (username1=="")
                {
                    MessageBox.Show("Please Assign Atleast one people in the project!!!");
                }
                else
                {
                    pj.addingProject(table, textBox_projectname.Text, richTextBox_projectdescription.Text, dateTimePicker2.Text , dateTimePicker1.Text, username1, name1, username2, name2, username3, name3, username4, name4, username5, name5);
                }
            }
        }

        private void lbl15Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {
                listView_assaignedpeople.Controls.Add(lbl[14]);
                counter[test++] = 14;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl14Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[13]);
                counter[test++] = 13;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl13Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {
                listView_assaignedpeople.Controls.Add(lbl[12]);
                counter[test++] = 12;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl12Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[11]);
                counter[test++] = 11;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl11Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[10]);
                counter[test++] = 10;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[9]);
                counter[test++] = 9;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl9Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[8]);
                counter[test++] = 8;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl8Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[7]);
                counter[test++] = 7;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl7Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[6]);
                counter[test++] = 6;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl6Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[5]);
                counter[test++] = 5;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl5Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[4]);
                counter[test++] = 4;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl4Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {
                listView_assaignedpeople.Controls.Add(lbl[3]);
                counter[test++] = 3;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl3Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[2]);
                counter[test++] = 2;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl2Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[1]);
                counter[test++] = 1;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void lbl1Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count < 5)
            {

                listView_assaignedpeople.Controls.Add(lbl[0]);
                counter[test++] = 0;
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 5!!!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FacultyAddproject_Load(object sender, EventArgs e)
        {

        }

        private void listView_search_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard();
            ads.Show();
        }
    }
}
