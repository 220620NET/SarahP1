using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserModel
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public bool isManager { get; set; }

        public UserModel(string firstName, string lastName, string userName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
    

        }
        public UserModel(string firstName)
        {
            this.firstName = firstName;
        }
    }
}