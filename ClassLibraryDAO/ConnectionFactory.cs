using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

    public class ConnectionFactory
    {
        private static ConnectionFactory? _instance;

        private readonly string _connectionString; 
        private ConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
     
        public static ConnectionFactory GetInstance(string connectionString)
        {
            if(_instance == null)
            {
                _instance = new ConnectionFactory(connectionString);
            }
        
            return _instance;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
