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
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public List<UserModel> GetAllUsers()
        {
            return _repo.GetAllUsers();
        }

        public UserModel GetUser(int id)             
        {
            return _repo.GetUser(id);
        }

        public UserModel GetUserByUserName(string userName)
        {
            return _repo.GetUserByUserName(userName);
        }
    }
}
