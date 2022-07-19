using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModels;
using Microsoft.Data.SqlClient;

namespace ClassLibraryDAO
{
    public class UserRepository : IUserRepository
    {
        private readonly ConnectionFactory _connectionFactory;
        public UserRepository(ConnectionFactory factory)
        {
            _connectionFactory = factory ;
        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();

            SqlConnection conn = _connectionFactory.GetConnection();

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from p1.users", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                users.Add(new UserModel((int) reader[0], (string) reader[3], (string) reader[4], (string) reader[1], (string) reader[2], (string) reader[5]));

            }
            reader.Close();
            conn.Close();
            return users;
        }
        public UserModel GetUser(int id)
        {
            UserModel foundUser;
            SqlConnection conn = _connectionFactory.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * From p1.users where id = @userID", conn);

            cmd.Parameters.AddWithValue("@userID", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                return new UserModel
                {
                    ID = (int)reader[0],
                    UserName = (string)reader[1],
                    FirstName = (string)reader[3],
                    LastName = (string)reader[4],
                    Password = (string)reader[2],
                    IsManager = (string)reader[5],
                };

            }

            throw new NotImplementedException("User ID not found");

        }

        public UserModel GetUser(string userName)
        {

            UserModel foundUser;
            SqlConnection conn = _connectionFactory.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * From p1.users where userName = @userName", conn);

            cmd.Parameters.AddWithValue("@userName", userName);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                return new UserModel
                {
                    ID = (int)reader[0],
                    UserName = (string)reader[1],
                    FirstName = (string)reader[3],
                    LastName = (string)reader[4],
                    Password = (string)reader[2],
                    IsManager = (string)reader[5],
                };

            }

            throw new NotImplementedException("Could not find user");
        }


        public bool CreateUser(UserModel users)
        {

            SqlConnection conn = _connectionFactory.GetConnection();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into p1.users(firstName, lastName, userName, password) values(@firstName, @lastName, @userName, @password);", conn);
            SqlDataReader reader = cmd.ExecuteReader();


            cmd.Parameters.AddWithValue("@firstName", users.FirstName);
            cmd.Parameters.AddWithValue("@lastName", users.LastName);
            cmd.Parameters.AddWithValue("@userName", users.UserName);
            cmd.Parameters.AddWithValue("@password", users.Password);

            reader.Close();
            conn.Close();
            return false;


        }


    }
}