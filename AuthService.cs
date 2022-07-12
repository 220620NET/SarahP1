using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Data.SqlClient;

namespace ClassLibraryDataAccess
{
    public class UserProfile
    {
        string connectionString = "Server=tcp:mysqlserver-sr2.database.windows.net,1433;Initial Catalog=myTestDatabase;Persist Security Info=False;User ID=sqluser;Password=!ThisPass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public bool CreateUser(UserModel users)
        {

            string sql = "insert into p1.users (firstName, lastName, userName, password) values (@firstName, @lastName, @userName, @password);";


            SqlConnection connection = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@firstName", users.firstName);
            command.Parameters.AddWithValue("@lastName", users.lastName);
            command.Parameters.AddWithValue("@userName", users.userName);
            command.Parameters.AddWithValue("@password", users.password);

            try
            {
                
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                if (rowsAffected != 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return false;


        }

        /*login method
        {

        }*/
    }
}
