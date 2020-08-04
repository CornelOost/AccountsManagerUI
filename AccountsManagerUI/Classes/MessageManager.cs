using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsManagerUI.Classes
{
    public class MessageManager
    {
        protected string _messageName;
        protected string _message;
        protected string _callingClassName;
        public MessageManager(string callingClassName)
        {
            if(callingClassName != null && callingClassName.Length > 0)
            {
                _callingClassName = callingClassName;
            }
        }

        public void ShowMessage(string messageName, string message)
        {
            _message = message;
            _messageName = messageName;
            MessageBox.Show(_message.ToString());
            LogMessage();
        }

        protected void LogMessage()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Lappie\Source\Repos\AccountsManager\AccountsManagerUI\AccountsManagerUI\Logs\Logs.txt"))
            {
                file.WriteLine("Message Manager:\n" + DateTime.Now + "\nCalling Class: " + _callingClassName + "\nMessage Name: " + _messageName + "\n Message:" + _message);
            }
        }
    }
}
