using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Controllers
{
    public class EditProject
    {
        public void updateProject(string name, string description, string projectcreator, string creationdate, string completationdate, string user1, string name1, string user2, string name2, string user3, string name3,  string user4, string name4, string user5, string name5, string projectname)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE Projects SET project='" + name + "',projectdescription='" + description + "',ProjectCreator='" + projectcreator + "',Creationdate='" + creationdate + "',Completationdate='" + completationdate + "',user1username='" + user1 + "',user1name='" + name1 + "',user2username='" + user2 + "',user2name='" + name2 + "',user3username='" + user3 + "',user3name='" + name3+ "',user4username='" + user4 + "',user4name='" + name4 + "',user5username='" + user5 + "',user5name='" + name5 + "'where project='" + projectname + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                // MessageBox.Show(name+" "+description+" "+user1+" "+name1+" "+user2+" "+name2+" "+user3+" "+name3+" Edited!!!!");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateTable(string oldname, string newname)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            //try
            //{
            String query = "sp_rename '" + oldname +
                    "','" + newname + "'";
            


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show(oldname + " " + " Edited");
            con.Close();
            //}

            //catch (Exception ex)
            //{
            //MessageBox.Show(ex.Message);
            //}
        }
    }
}
