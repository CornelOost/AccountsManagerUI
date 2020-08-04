using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsManagerUI.Classes
{
    public class EmailAddress
    {
        MessageManager MM = new MessageManager("EmailAddress");
        
        private string EmailAddressString { get; set; }


        public EmailAddress(string emailAddress)
        {
            EmailAddressString = emailAddress;
        }

    }
}
