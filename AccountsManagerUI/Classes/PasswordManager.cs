using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsManagerUI.Classes
{
    public class PasswordManager
    {
        protected List<Password> _passwordList;
        public bool isValidPassword = false;
        protected Password pw;
        
        //public MessageManager MM = new MessageManager("PasswordManager");
        public PasswordManager()
        {
            _passwordList = new List<Password>();
        }

        protected void StorePassword(Password password)
        {
                _passwordList.Add(password);
               // MM.ShowMessage("Password added", "Created password: " + password.passwordString);
        }

        public Password CreatePassword(string givenPassword)
        {
            pw = new Password(givenPassword);
            StorePassword(pw);
            return pw;
            
        }
    }
}
