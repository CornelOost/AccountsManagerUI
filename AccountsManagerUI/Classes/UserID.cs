using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsManagerUI.Classes
{
    public class UserID
    {
        int IDNumMax = 9999;
        int IDNumMin = 1000;
        List<int> IDNumList = new List<int>();
        Random rnd = new Random();
        public int UserIDNum { get; set; }
        public string UserIDString { get; set; }

        public UserID(UserName userName)
        {
            GenerateID(userName);
        }

        private void GenerateID(UserName userName)
        {
            int tempIDNum = rnd.Next(IDNumMin, IDNumMax);
            if (!IDNumList.Contains(tempIDNum))
            {
                UserIDNum = tempIDNum;
                UserIDString = userName.userName + "#" + tempIDNum.ToString();
            }
        }
    }
}
