using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAO;
using ClassLibraryModels;

namespace ClassLibraryServices
{
    public class UserService
    {
        private UserRepository userRepository = new UserRepository();

        public List<UserModel> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }
        /*GetByUsername()
        {

        }
        GetByID()
        {

        }*/

    }
}
