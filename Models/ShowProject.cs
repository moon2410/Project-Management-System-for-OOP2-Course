using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Models
{
    public class ShowProject
    {
        public string[] projectDisplay(string username)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            int counter = 0;
            String[] info = new String[15];
            try
            {

                //1st Person
                String quary = "select * from Projects where user1username='" + username + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        info[counter++] = reader["Project"].ToString();

                    }
                }

                //2nd person
                quary = "select * from Projects where user2username='" + username + "'";
                cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        info[counter++] = reader1["Project"].ToString();
                    }
                }

                //3rd person
                quary = "select * from Projects where user3username='" + username + "'";
                cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        info[counter++] = reader2["Project"].ToString();
                    }
                }
                //4th person
                quary = "select * from Projects where user4username='" + username + "'";
                cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        info[counter++] = reader2["Project"].ToString();
                    }
                }
                //5th person
                quary = "select * from Projects where user5username='" + username + "'";
                cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        info[counter++] = reader2["Project"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            return info;



        }
        public string[] facultyprojectDisplay(string username)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            int counter = 0;
            String[] info = new String[15];
            try
            {

                //1st Person
                String quary = "select * from Projects where ProjectCreator='" + username + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        info[counter++] = reader["Project"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            return info;



        }

        public string[] projectInfo(string projectName)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            String[] info = new String[15];
            try
            {

                String quary = "select * from Projects where project='" + projectName + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    for (int i = 0; i < 15; i++)
                    {
                        info[i] = reader[i].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            return info;

        }
    }
}
