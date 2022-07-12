using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

    public class ConnectionFactory
    {
        private static ConnectionFactory? _instance;
        private readonly static string _connectionString = "Server=tcp:mysqlserver-sr2.database.windows.net,1433;Initial Catalog=myTestDatabase;Persist Security Info=False;User ID=sqluser;Password=!ThisPass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        private ConnectionFactory()
        {

        }
        public static ConnectionFactory GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ConnectionFactory();
            }
        
            return _instance;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
