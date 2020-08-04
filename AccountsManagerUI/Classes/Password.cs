using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsManagerUI.Classes
{
    public class Password
    {
        protected MessageManager MM = new MessageManager("Password");
        
        public string passwordString { get; set; }

        public Password(string password)
        {
            passwordString = password;
        }

        
    }
}
