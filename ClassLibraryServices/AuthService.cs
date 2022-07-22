using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibraryModels;
using ClassLibraryDAO;

namespace ClassLibraryServices;
public class AuthService
{
    private readonly IUserRepository _repo;
    public AuthService(IUserRepository repository)
    {
        _repo = repository;
    }

    public bool CreateUser(UserModel newUser)
    {
        return _repo.CreateUser(newUser);
        //you need some checks here
    }

    public UserModel LogIn(UserModel loginUser)
    {
        return _repo.GetUserByUserName(loginUser.UserName);
    }

}
    