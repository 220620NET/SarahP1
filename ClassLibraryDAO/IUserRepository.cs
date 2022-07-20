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
        public List<UserModel> GetAllUsers();

        public UserModel GetUser(int ID);

        public UserModel GetUserByUserName(string userName);
        
        public bool CreateUser(UserModel newUser);  //AddPokeTrainer(PokeTrainer newTrainerToRegister
    }
}
