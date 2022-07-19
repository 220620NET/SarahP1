using ClassLibraryServices;


namespace WebAPI.Controllers
{
    public class AuthController
    {
        private readonly AuthService _service;
        public AuthController(AuthService service)
        {
            _service = service;
        }
    }
}
