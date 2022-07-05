namespace User;
using Exceptions;



    public class UserProfile 
    {
        private string FirstName;

        public string GetFirstName()
    {
        return FirstName;
    }
    public void SetFirstName(string firstNameToSet)
    {
        
        if(String.IsNullOrWhiteSpace(firstNameToSet))
        {
            
            throw new InputInvalidException("the name is invalid");
        }
        else
        {
            //We set the value we got passed in to the private field name
            this.FirstName = firstNameToSet;
        }
    }


        private string LastName;
        private string userName;
        private string Password;
        private int IdNumber;
        //array position + 100
        private bool IsManager;

        private string UserName;


    }
    

