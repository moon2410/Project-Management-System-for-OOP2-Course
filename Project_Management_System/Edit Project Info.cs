using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace Project_Management_System
{
    public partial class Edit_Project_Info : Form
    {
        String[] info = new String[15];
        String[] name = new String[20];
        String[] uname = new String[20];
        LinkLabel[] lbl = new LinkLabel[100];
        int rows = 0;
        String username = "";
        
        public Edit_Project_Info()
        {
            InitializeComponent();
        }

        public Edit_Project_Info(string[] info,string username)
        {
            this.info = info;
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

        

        private void Edit_Project_Info_Load(object sender, EventArgs e)
        {
            panel_addpeople.Visible = false;

            textBox_name.Text = info[0];
            richTextBox_description.Text = info[1];
            if (!info[6].Equals(""))
            {
                label_colab1.Text = info[6];
                linkLabel_remove1.Left = label_colab1.Right+10;
            }
            if (!info[8].Equals(""))
            {
                label_colab2.Text = info[8];
                linkLabel_remove2.Left = label_colab2.Right + 10;
            }
            if (!info[10].Equals(""))
            {
                label_colab3.Text = info[10];
                linkLabel_remove3.Left = label_colab3.Right + 10;
            }if (!info[12].Equals(""))
            {
                label_colab2.Text = info[12];
                linkLabel_remove4.Left = label_colab4.Right + 10;
            }
            if (!info[14].Equals(""))
            {
                label_colab3.Text = info[14];
                linkLabel_remove5.Left = label_colab5.Right + 10;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Projects pj = new Projects();
            pj.editingProject(info, textBox_name.Text);
        }

        private void linkLabel_remove1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove "+label_colab1.Text+" ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;
                if (label_colab2.Text.Equals(""))
                    linkLabel_remove1.Visible = false;

                label_colab1.Text = label_colab2.Text;
                label_colab2.Text = label_colab3.Text;
                label_colab3.Text = label_colab4.Text;
                label_colab4.Text = label_colab5.Text;
                label_colab5.Text = "";
                linkLabel_remove3.Visible = false;
                for (int i = 5; i <= 12; i++)
                {
                    info[i] = info[i + 2];
                }

                info[13] = "";
                info[14] = "";
            }
        }

        private void linkLabel_remove2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove " + label_colab2.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;

                label_colab2.Text = label_colab3.Text;
                if (label_colab3.Text.Equals(""))
                    linkLabel_remove2.Visible = false;
                
                label_colab3.Text = label_colab4.Text;
                label_colab4.Text = label_colab5.Text;
                label_colab5.Text = "";
                linkLabel_remove3.Visible = false;
                for (int i = 7; i <= 12; i++)
                {
                    info[i] = info[i + 2];
                }

                info[13] = "";
                info[14] = "";
            }
        }

        private void linkLabel_remove3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove " + label_colab3.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;

                label_colab3.Text = label_colab4.Text;
                if (label_colab3.Text.Equals(""))
                    linkLabel_remove4.Visible = false;

                label_colab4.Text = label_colab5.Text;
                label_colab5.Text = "";
                linkLabel_remove3.Visible = false;
                for (int i = 9; i <= 12; i++)
                {
                    info[i] = info[i + 2];
                }

                info[13] = "";
                info[14] = "";
            }





            
        }

        private void linkLabel_remove4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove " + label_colab4.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;

                label_colab4.Text = label_colab5.Text;
                if (label_colab3.Text.Equals(""))
                    linkLabel_remove4.Visible = false;

                label_colab5.Text = "";
                linkLabel_remove3.Visible = false;
                for (int i = 4; i <= 5; i++)
                {
                    info[i] = info[i + 2];
                }

                info[13] = "";
                info[14] = "";
            }
        }

        private void linkLabel_remove5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove " + label_colab5.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;
                label_colab5.Text = "";
                linkLabel_remove3.Visible = false;
                info[13] = "";
                info[14] = "";
            }

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

                //lbl[i] = new LinkLabel();
                lbl[i].Text = name[i];
                lbl[i].Location = new Point(10, n);
                lbl[i].Size = new System.Drawing.Size(300, 30);
                listView_search.Controls.Add(lbl[i]);


                n = n + 40;
            }
        }


        private void lbl1Click(object sender, EventArgs e)
        {
            int a = 0;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }

        }

        private void lbl2Click(object sender, EventArgs e)
        {
            int a = 1;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl3Click(object sender, EventArgs e)
        {

            int a = 2;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl4Click(object sender, EventArgs e)
        {

            int a = 3;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl5Click(object sender, EventArgs e)
        {

            int a = 4;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl6Click(object sender, EventArgs e)
        {

            int a = 5;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl7Click(object sender, EventArgs e)
        {

            int a = 6;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl8Click(object sender, EventArgs e)
        {

            int a = 7;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl9Click(object sender, EventArgs e)
        {

            int a = 8;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            int a = 9;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl11Click(object sender, EventArgs e)
        {

            int a = 10;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl12Click(object sender, EventArgs e)
        {

            int a = 11;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl13Click(object sender, EventArgs e)
        {

            int a = 12;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }


        private void lbl14Click(object sender, EventArgs e)
        {

            int a = 13;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        private void lbl15Click(object sender, EventArgs e)
        {

            int a = 14;
            if (label_colab1.Text.Equals(name[a]) || label_colab2.Text.Equals(name[a]) || label_colab3.Equals(name[a]) || label_colab4.Equals(name[a]) || label_colab5.Equals(name[a]))
            {
                MessageBox.Show(name[a] + " " + "is already at the project!!!");
            }

            else
            {
                if (label_colab1.Text.Equals(""))
                {
                    info[5] = uname[a];
                    info[6] = name[a];
                    label_colab1.Text = name[a];
                    linkLabel_remove1.Left = label_colab1.Right + 10;
                    linkLabel_remove1.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);

                }
                else if (label_colab2.Text.Equals(""))
                {
                    info[7] = uname[a];
                    info[8] = name[a];
                    label_colab2.Text = name[a];
                    linkLabel_remove2.Left = label_colab2.Right + 10;
                    linkLabel_remove2.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab3.Text.Equals(""))
                {
                    info[9] = uname[a];
                    info[10] = name[a];
                    label_colab3.Text = name[a];
                    linkLabel_remove3.Left = label_colab3.Right + 10;
                    linkLabel_remove3.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab4.Text.Equals(""))
                {
                    info[11] = uname[a];
                    info[12] = name[a];
                    label_colab4.Text = name[a];
                    linkLabel_remove4.Left = label_colab3.Right + 10;
                    linkLabel_remove4.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else if (label_colab5.Text.Equals(""))
                {
                    info[13] = uname[a];
                    info[14] = name[a];
                    label_colab5.Text = name[a];
                    linkLabel_remove5.Left = label_colab3.Right + 10;
                    linkLabel_remove5.Visible = true;
                    listView_search.Controls.Remove(lbl[a]);
                }
                else
                {
                    MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
                }
            }
        }

        
    }
}
