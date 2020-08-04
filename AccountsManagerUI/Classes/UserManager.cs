using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsManagerUI.Classes
{
    public class UserManager
    {
        MessageManager MM = new MessageManager("UserManager");
        ValidationManager VM = new ValidationManager();
        PasswordManager PM = new PasswordManager();
        public List<User> UserList; 
        public UserManager()
        {
            UserList = new List<User>();
        }
        public void CreateUser(string firstName, string lastName, string givenUserName,
        string givenPassword,string confirmPassword, string emailAddress)
        {
            if(VM.ValidateUser(firstName, lastName, givenUserName, givenPassword, confirmPassword, emailAddress))
            {
                UserList.Add(
                    new User(firstName, lastName, 
                    new UserName(givenUserName),
                    PM.CreatePassword(givenPassword),new EmailAddress(emailAddress)));
                MM.ShowMessage("User created", "Successfully created user");
            }
            else
            {
                MM.ShowMessage("Invalid user", "Unable to create user as not all fields are valid");
            }
        }

        public User GetUser()
        {
            //Only getting my hardcoded account
            return UserList[0];
        }
    }
}
