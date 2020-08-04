using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsManagerUI.Classes
{
    public class User
    {
        UserManager UM = new UserManager();
        MessageManager MM = new MessageManager("User");
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserName UserName { get; set; }
        private Password MasterPassword { get; set; }
        public UserID UserID { get; set; }
        private EmailAddress Email { get; set; }

        public User(string firstName, string lastName, UserName userName,
        Password password, EmailAddress emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            SetUserName(userName);
            SetMasterPassword(password);
            SetEmailAddress(emailAddress);
        }

        public void SetMasterPassword(Password masterPassword)
        {
            MasterPassword = masterPassword;
        }

        public void SetEmailAddress(EmailAddress emailAddress)
        {
            Email = emailAddress;
        }

        public void SetUserID(UserID userID)
        {
            UserID = userID;
        }

        public void SetUserName(UserName userName)
        {
            UserName = userName;
        }

        

    }
}
