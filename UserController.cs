using ClassLibraryServices;
using ClassLibraryModels;

namespace WebAPI.Controllers;

public class UserController
{
    private readonly UserService _service;
    public UserController(UserService service)
    {
        _service = service;
    }

    public List<UserModel> GetAllUsers()
    {
        return _service.GetAllUsers();
    }
    public UserModel GetUser(int id)
    {
        return _service.GetUser(id);
    }
    public UserModel GetUserByUserName(string userName)
    {
        return _service.GetUserByUserName(userName);
    }
}