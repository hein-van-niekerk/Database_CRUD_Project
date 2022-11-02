using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG252_Assignment2_Milestone1
{
    internal class UserCredentials
    {
        private string username;
        private string password;

        public UserCredentials() { }

        public void UserDetails(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public string[] ToString()
        {
            string userPasswordCombo = username + password;
            string[] userPasswordArr = userPasswordCombo.Split(' ');
            return userPasswordArr;
            
        }
        
    }
}
