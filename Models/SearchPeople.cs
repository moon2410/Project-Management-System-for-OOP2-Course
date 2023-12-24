using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Models
{
    public class SearchPeople
    {
        string[] FirstName = new string[100000];
        string[] LastName = new string[100000];
        string[] UserName = new string[1000000];


        public SearchPeople(string[] FirstName, string[] LastName, string[] UserName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserName = UserName;
        }


        public int nameCheck(string name)
        {
            int rows = 0;

            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                string query = "Select * from Students where FirstName like '%" + name + "%' or LastName like '%" + name + "%' or UserName like '%" + name +"%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                rows = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rows;
        }

        public string[] showingData(string username, int flag)
        {

            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            string query = "Select * from Students where FirstName like '%" + username + "%'  or LastName like '%" + username + "%' or UserName like '%" + username + "%'";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader reader = com.ExecuteReader();
            for (int i = 1; reader.Read(); i++)
            {
                FirstName[i] = reader[1].ToString();
                LastName[i] = reader[1].ToString();
                UserName[i] = reader[0].ToString();
            }
            reader.Close();
            con.Close();
            if (flag == 1)
            {
                return FirstName;
            }
            else if (flag == 2)
            {
                return LastName;
            }
            else
            {
                return UserName;
            }

        }
        public int nameCheckfaculty(string name)
        {
            int rows = 0;

            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                string query = "Select * from Faculties where FirstName like '%" + name + "%' or LastName like '%" + name + "%' or UserName like '%" + name + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                rows = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rows;
        }

        public string[] showingDatafaculty(string username, int flag)
        {

            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            string query = "Select * from Faculties where FirstName like '%" + username + "%' or LastName like '%" + username + "%' or UserName like '%" + username + "%'";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader reader = com.ExecuteReader();
            for (int i = 1; reader.Read(); i++)
            {
                FirstName[i] = reader[1].ToString();
                LastName[i] = reader[1].ToString();
                UserName[i] = reader[0].ToString();
            }
            reader.Close();
            con.Close();
            if (flag == 1)
            {
                return FirstName;
            }
            else if (flag == 2)
            {
                return LastName;
            }
            else
            {
                return UserName;
            }

        }
    }
}
