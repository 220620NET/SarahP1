using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels
{
    public class UserModel
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string isManager { get; set; }

        public UserModel(string firstName, string lastName, string userName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
    

        }
        public UserModel(int id, string firstName, string lastName, string userName, string password, string isManager)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
            this.isManager = isManager;


        }
        public UserModel(string firstName)
        {
            this.firstName = firstName;
        }

        public override string ToString()
        {
            return "id: " + this.id + ", first name: " + this.firstName + " last name: " + this.lastName + " user name: " + this.userName + " password: " + this.password + " Manager: " + this.isManager;
        }
    }
}