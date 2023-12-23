using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Controllers
{
    public class SearchingPeople
    {
        string[] firstname = new string[100000];
        string[] lastname = new string[1000000];
        string[] username = new string[1000000];

        public int searchResult(string searchkey)
        {
            SearchPeople sp = new SearchPeople(firstname, lastname, username);
            int rows = 0;
            rows = sp.nameCheck(searchkey);
            return rows;
        }

        public string[] peopleDisplay(string searchkey, int flag)
        {
            SearchPeople sp = new SearchPeople(firstname, lastname, username);
            int rows = 0;
            rows = searchResult(searchkey);

            if (rows != 0)
            {
                if (flag == 1)
                {
                    return firstname = sp.showingData(searchkey, flag);
                }
                else if (flag == 2)
                {
                    return lastname = sp.showingData(searchkey, flag);
                }
                else
                {
                    return username = sp.showingData(searchkey, flag);
                }
            }

            else
            {
                MessageBox.Show("No Person Found!!!");
                return null;
            }
        }
    }
}
