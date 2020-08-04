using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsManagerUI.Classes
{
    public class UserName
    {
        public List<UserName> UserNamesList = new List<UserName>();
        public string userName { get; set; }
        protected Random rnd = new Random();

        public UserName(string userName)
        {
            userName = userName;
        }
    }
}
