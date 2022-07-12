using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModels;
using Microsoft.Data.SqlClient;

namespace ClassLibraryDAO
{
    public class UserRepository
    {
        private readonly ConnectionFactory _connectionFactory;
        public UserRepository()
        {
            _connectionFactory = ConnectionFactory.GetInstance();
        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> userModel = new List<UserModel>();
            SqlConnection conn = _connectionFactory.GetConnection();

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from p1.users", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                userModel.Add(new UserModel((int) reader[0], (string) reader[3], (string) reader[4], (string) reader[1], (string) reader[2], (string) reader[5]));

            }
            reader.Close();
            conn.Close();
            return userModel;
        }

    }
}