using ClassLibraryModels;
using ClassLibraryServices;

Console.WriteLine("Hello, World!");

UserService userService = new UserService();
List<UserModel> users = userService.GetAllUsers();
foreach (UserModel userModel in users)
{
    Console.WriteLine(userModel);
}
