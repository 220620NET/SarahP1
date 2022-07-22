using ClassLibraryServices;
using ClassLibraryModels;
using ClassLibraryDAO;

namespace WebAPI.Controllers
{
    public class AuthController
    {
        private readonly AuthService _service;
        public AuthController(AuthService service)
        {
            _service = service;
        }
        public IResult CreateUser(UserModel newUser)
        {
            _service.CreateUser(newUser);
            return Results.Created("/user/register", newUser);
        }

        public IResult Login(UserModel loginUser)
        {
            _service.LogIn(loginUser);
            return Results.Ok(_service.LogIn(loginUser));
        }
    }

}
