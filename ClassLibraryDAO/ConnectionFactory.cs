using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;



namespace ClassLibraryDAO
{
    public class ConnectionFactory
    {
        string connectionString = "Server=tcp:mysqlserver-sr2.database.windows.net,1433;Initial Catalog=myTestDatabase;Persist Security Info=False;User ID=sqluser;Password=!ThisPass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        /*public static void CreateInstance()
        {
        SqlConnection connection = new SqlConnection(connectionString);
        }
        public static void GetConnection()
        {
        
        }*/
    }
}
