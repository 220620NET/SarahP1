using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModels;

namespace ClassLibraryDAO
{
   public interface IUserRepository
    {
        List<UserModel> GetAllUsers();

        UserModel GetUser(int ID);

        UserModel GetUser(string userName);
        
        //UserModel CreateUser(UserModel user);
    }
}
