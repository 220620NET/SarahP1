// See https://aka.ms/new-console-template for more information
using Ticket;
using User;
using Exceptions;


Console.WriteLine("***************************************************************************");
Console.WriteLine("       Welcome to S.Lynns Hobby Shop Employee Reimbursement Platform:      ");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Press ENTER to continue:");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Please choose from the following options:");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("1.) New user");
Console.WriteLine("2.) Returning user");
Console.WriteLine("3.) Exit Program");

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("We will now create your user profile");
    //UserProfile 1 = new UserProfile();


    break;
    case "2":
      Console.WriteLine("Log in page");
      //LogIn();
    break;
    case "3":
    break;
    default:
      Console.WriteLine("Incorrect input, please choose again");
    break;
}