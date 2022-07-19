using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels
{
    public class UserModel
    {

        // fields

        int id;
        string firstName;
        string lastName;
        string userName;
        string password;
        string isManager;

        // constructors
        public UserModel()
        {

        }
        public UserModel(int id, string firstName, string lastName, string userName, string password, string isManager)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Password = password;
            this.IsManager = isManager;
        }
        // properties
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string IsManager { get; set; }

    }
}

       // Methods

        /*public override string ToString()
        {
            return "id: " + this.ID + ", first name: " + this.FirstName + " last name: " + this.lastName + " user name: " + this.userName + " password: " + this.password + " Manager: " + this.isManager;
        }*/
