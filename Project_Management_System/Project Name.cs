﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Project_Management_System
{
    public partial class Project_Name : Form
    {
        String username="";
        String projectname = "";
        String[] info = new String[15];
        //Label[] check = new Label[100];
        LinkLabel[] lbl_edit = new LinkLabel[100];
        MyReturnType information;
        public Project_Name()
        {
            InitializeComponent();
        }

        public Project_Name(string username, string projectname)
        {
            this.username = username;
            this.projectname = projectname;
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                lbl_edit[i] = new LinkLabel();
            }

            lbl_edit[0].Click += new System.EventHandler(lbl1Click);
            lbl_edit[1].Click += new System.EventHandler(lbl2Click);
            lbl_edit[2].Click += new System.EventHandler(lbl3Click);
            lbl_edit[3].Click += new System.EventHandler(lbl4Click);
            lbl_edit[4].Click += new System.EventHandler(lbl5Click);
            lbl_edit[5].Click += new System.EventHandler(lbl6Click);
            lbl_edit[6].Click += new System.EventHandler(lbl7Click);
            lbl_edit[7].Click += new System.EventHandler(lbl8Click);
            lbl_edit[8].Click += new System.EventHandler(lbl9Click);
            lbl_edit[9].Click += new System.EventHandler(lbl10Click);
            lbl_edit[10].Click += new System.EventHandler(lbl11Click);
            lbl_edit[11].Click += new System.EventHandler(lbl12Click);
            lbl_edit[12].Click += new System.EventHandler(lbl13Click);
            lbl_edit[13].Click += new System.EventHandler(lbl14Click);
            lbl_edit[14].Click += new System.EventHandler(lbl15Click);
        }

        

        private void Project_Name_Load(object sender, EventArgs e)
        {
            Projects pj = new Projects();
            info = pj.showProjectInfo(projectname);
            label_projectname.Text = info[0];
            label_projectdescrip.Text = info[1];
            projectCreator_lbl.Text = info[2];
            if (!info[6].Equals(""))
            {
                colab_lbl1.Text = info[6];
            }
            if (!info[8].Equals(""))
            {
                colab_lbl2.Text = info[8];
            }
            if (!info[10].Equals(""))
            {
                colab_lbl3.Text = info[10];
            }
            if (!info[12].Equals(""))
            {
                colab_lbl4.Text = info[12];
            }
            if (!info[14].Equals(""))
            {
                colab_lbl5.Text = info[14];
            }

            //To Do List
            ToDoList td = new ToDoList();
            information= td.showList(label_projectname.Text);

            if (information!=null && information.MyINT > 0)
            {
                int n = 0, j = 20;
                for (int i = 0; i < information.MyINT; i++)
                {
                    Label check = new Label();
                    check.Text = information.MyStringArray[i, 2];
                    check.Location = new Point(10, n);
                    check.Font = new Font(check.Font.FontFamily, 12);
                    check.Size = new System.Drawing.Size(300, 20);
                    listView_todolist.Controls.Add(check);


                    Label lbl = new Label();
                    lbl.Text = information.MyStringArray[i, 1] + "-";
                    lbl.Location = new Point(13, j);
                    lbl.Font = new Font(lbl.Font.FontFamily, 8);
                    lbl.Size = new System.Drawing.Size(lbl.Right, 12);
                    listView_todolist.Controls.Add(lbl);


                    Label date = new Label();
                    date.Text = information.MyStringArray[i, 3];
                    date.Location = new Point(lbl.Right, j);
                    date.Font = new Font(lbl.Font.FontFamily, 8);
                    date.Size = new System.Drawing.Size(100, 12);
                    listView_todolist.Controls.Add(date);

                    Label status = new Label();
                    if(information.MyStringArray[i,4].Equals("false"))
                      status.Text = "Assaigned";
                    else
                      status.Text = "Completed";
                    status.Location = new Point(date.Right, j);
                    status.Font = new Font(status.Font.FontFamily, 8);
                    status.Size = new System.Drawing.Size(70, 12);
                    listView_todolist.Controls.Add(status);



                    lbl_edit[i].Text = "Edit";
                    lbl_edit[i].Location = new Point(status.Right, j);
                    lbl_edit[i].Font = new Font(lbl_edit[i].Font.FontFamily, 8);
                    lbl_edit[i].Size = new System.Drawing.Size(lbl_edit[i].Right, 12);
                    listView_todolist.Controls.Add(lbl_edit[i]);

                    n += 20;
                    j += 20;

                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Edit_Project_Info ep = new Edit_Project_Info(info,username);
            ep.Show();
            this.Hide();
        }

        private void button_addtodolist_Click(object sender, EventArgs e)
        {
            Add_To_Do_List at = new Add_To_Do_List(info);
            at.Show();
            this.Hide();
        }

        private void lbl1Click(object sender, EventArgs e)
        {
            Edit_To_Do ed=new Edit_To_Do(info,information.MyStringArray[0,0],information.MyStringArray[0,1],information.MyStringArray[0,2],information.MyStringArray[0,3],information.MyStringArray[0,4]);
            ed.Show();
            this.Hide();
        }

        private void lbl2Click(object sender, EventArgs e)
        {
            Edit_To_Do ed=new Edit_To_Do(info,information.MyStringArray[1,0],information.MyStringArray[1,1],information.MyStringArray[1,2],information.MyStringArray[1,3],information.MyStringArray[1,4]);
            ed.Show();
            this.Hide();
        }

        private void lbl3Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl4Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl5Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl6Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl7Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl8Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl9Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl11Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl12Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl13Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl14Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl15Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
