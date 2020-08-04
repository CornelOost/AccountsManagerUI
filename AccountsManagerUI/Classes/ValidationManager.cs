using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccountsManagerUI.Classes
{
    public class ValidationManager
    {
        MessageManager MM = new MessageManager("ValidationManager");
        public bool firstNameValid;
        public bool lastNameValid;
        public bool userNameValid;
        public bool passwordValid;
        public bool emailAddressValid;

        public bool ValidateUser(string firstName, string lastName, string givenUserName,
        string givenPassword,string confirmPassword, string emailAddress)
        {
            firstNameValid = ValidateFirstName(firstName);
            lastNameValid = ValidateLastName(lastName);
            userNameValid = ValidateUserName(givenUserName);
            passwordValid = ValidatePassword(givenPassword, confirmPassword);
            emailAddressValid = ValidateEmailAddress(emailAddress);

            if (firstNameValid && lastNameValid && userNameValid && passwordValid && emailAddressValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidatePassword(string givenPassword, string confirmPassword)
        {
            int passwordMinLength = 7;
            int passwordMaxLength = 20;

            if (givenPassword != null)
            {
                if(givenPassword == confirmPassword)
                {
                    if (givenPassword.Length >= passwordMinLength)
                    {
                        if (givenPassword.Length <= passwordMaxLength)
                        {
                            return true;
                        }
                        else
                        {
                            MM.ShowMessage("Password Invalid", "Password too long");
                            return false;
                        }
                    }
                    else
                    {
                        MM.ShowMessage("Password Invalid", "Password too short");
                        return false;
                    }
                }
                else
                {
                    MM.ShowMessage("Passwords Dont Match", "Password does not match confirm password.");
                    return false;
                }
                
            }
            else
            {
                MM.ShowMessage("GivenPassword null", "Password cannot be empty");
                return false;
            }
        }

        private bool ValidateFirstName(string firstName)
        {
            if(firstName.Length > 0 && firstName != null)
            {
                if(Regex.Match(firstName, "^[A-Z][a-zA-Z]*$").Success)
                {
                    return true;
                }
                else
                {
                    MM.ShowMessage("Invalid firstName", "First name is invalid. Can not contain any numbers or special characters");
                    return false;
                }
            }
            else
            {
                MM.ShowMessage("FirstName null", "First name cannot be empty");
                return false;
            }
        }

        private bool ValidateLastName(string lastName)
        {
            if (lastName.Length > 0 && lastName != null)
            {
                if (Regex.Match(lastName, "^[A-Z][a-zA-Z]*$").Success)
                {
                    return true;
                }
                else
                {
                    MM.ShowMessage("Invalid lastName", "Last name is invalid. Can not contain any numbers or special characters");
                    return false;
                }
            }
            else
            {
                MM.ShowMessage("LastName null", "Last name cannot be empty");
                return false;
            }
        }

        private bool ValidateEmailAddress(string emailAddress)
        {
            string[] _splitEmail = new string[2];
            string emailPrefix;
            string emailPostfix;

            if (emailAddress.Length > 0 && emailAddress != null)
            {
                if (emailAddress.Contains('@'))
                {
                    _splitEmail = emailAddress.Split('@');
                    emailPrefix = _splitEmail[0];
                    emailPostfix = _splitEmail[1];
                    if (emailPostfix.EndsWith(".com") || emailPostfix.EndsWith(".co.za"))
                    {
                        return true;
                    }
                    else
                    {
                        MM.ShowMessage("Incorrect EmailAddress Postfix", "Email Address postfix must end in .com or .co.za");
                        return false;
                    }
                }
                else
                {
                    MM.ShowMessage("No @ sign in Email", "Email Address must contain '@'.");
                    return false;
                }
            }
            else
            {
                MM.ShowMessage("EmailAddress empty", "Email address cannot be empty");
                return false;
            }
        }

        private bool ValidateUserName(string userName)
        {
            if (userName.Length > 0 && userName != null)
            {
                return true;
            }
            else
            {
                MM.ShowMessage("UserName empty", "UserName cannot be empty");
                return false;
            }
        }


    }
}
