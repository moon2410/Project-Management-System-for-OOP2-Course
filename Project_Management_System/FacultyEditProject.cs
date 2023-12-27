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
    public partial class FacultyEditProject : Form
    {
        string username = "";
        public FacultyEditProject()
        {
            InitializeComponent();
        }
        public FacultyEditProject(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyDashboard ads = new FacultyDashboard(username);
            ads.Show();
        }
    }
}
