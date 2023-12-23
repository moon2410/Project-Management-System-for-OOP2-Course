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
using System.Xml.Linq;

namespace Project_Management_System
{
    public partial class FacultyAddproject : Form
    {
        String Username = "";
        int rows = 0;
        LinkLabel[] lbl = new LinkLabel[100];
        int[] counter = new int[3];
        int test = 0;
        String[] name;
        String[] uname;
        public FacultyAddproject()
        {
            InitializeComponent();
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
    }
}
