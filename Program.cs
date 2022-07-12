
using ClassLibraryDataAccess;
using ClassLibraryModels;

//test database entry. Will move to proper location.

UserProfile user = new UserProfile();

Console.WriteLine("Please enter your first name:");
string firstName = Console.ReadLine();
Console.WriteLine("Please enter your last name");
string lastName = Console.ReadLine();
Console.WriteLine("Please create a user name");
string userName = Console.ReadLine();
Console.WriteLine("Please create a password");
string password = Console.ReadLine();

bool isSuccessful = user.CreateUser(new UserModel(firstName, lastName, userName, password));
if (isSuccessful)
{
    Console.WriteLine(firstName + " " + lastName + " " + userName + " " + password);
} else
{
    Console.WriteLine("not created");
}
