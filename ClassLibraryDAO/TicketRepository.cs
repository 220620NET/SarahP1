using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModels;
using Microsoft.Data.SqlClient;

namespace ClassLibraryDAO
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ConnectionFactory _connectionFactory;
        public TicketRepository(ConnectionFactory factory)
        {
            _connectionFactory = factory;
        }

        public bool CreateTicket(TicketModel newTicket)
        {
            SqlConnection conn = _connectionFactory.GetConnection();

            SqlCommand cmd = new SqlCommand("insert into p1.tickets(description, amount, userID) values(@description, @amount, @userID);", conn);

            cmd.Parameters.AddWithValue("@description", newTicket.Description);
            cmd.Parameters.AddWithValue("@amount", newTicket.Amount);
            cmd.Parameters.AddWithValue("@userID", newTicket.UserID);

            {
                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsAffected != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<TicketModel> GetAllTickets()
        {
            List<TicketModel> tickets = new List<TicketModel>();

            SqlConnection conn = _connectionFactory.GetConnection();

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from p1.tickets", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tickets.Add(new TicketModel((int)reader[0], (string)reader[1], (decimal)reader[2], (int)reader[3], (string)reader[4], (string)reader[5], (int)reader[6]));

            }
            reader.Close();
            conn.Close();
            return tickets;
        }
        public TicketModel GetTicketByTicketNumber(int TicketNumber)
        {
            SqlConnection conn = _connectionFactory.GetConnection();
            conn.Open();

            using SqlCommand cmd = new SqlCommand("Select * From p1.tickets where ticketNumber = @ticketNumber", conn);
            cmd.Parameters.AddWithValue("@ticketNumber", TicketNumber);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                return new TicketModel
                {
                    TicketNumber = (int)reader[0],
                    Description = (string)reader[1],
                    Amount = (decimal)reader[2],
                    UserID = (int)reader[3],
                    Status = (string)reader[4],
                    Resolver = (string)reader[5],
                    ResolverID = (int)reader[6],
                };

            }

            throw new NotImplementedException("No tickets found for that employee ID");

        }

        public List<TicketModel> GetTicketByUserID(int userID)
        {
            SqlConnection conn = _connectionFactory.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * From p1.tickets where userID = @userID", conn);
            cmd.Parameters.AddWithValue("@userID", userID);
            List<TicketModel> GetUserByUserID = new List<TicketModel>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GetUserByUserID.Add(new TicketModel((int)reader[0], (string)reader[1], (decimal)reader[2], (int)reader[3], (string)reader[4], (string)reader[5], (int)reader[6]));

            }
            reader.Close();
            conn.Close();
            return GetUserByUserID;
        }

        public List<TicketModel> GetTicketByStatus(string status)
        {
            SqlConnection conn = _connectionFactory.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * From p1.tickets where status = @status", conn);
            cmd.Parameters.AddWithValue("@status", status);
            List<TicketModel> GetUserByStatus = new List<TicketModel>();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    GetUserByStatus.Add(new TicketModel((int)reader[0], (string)reader[1], (decimal)reader[2], (int)reader[3], (string)reader[4], (string)reader[5], (int)reader[6]));

                }
                reader.Close();
                conn.Close();
                return GetUserByStatus;
            }
            catch (RecordNotFoundException)
            {
                throw new RecordNotFoundException();
            }

        }
        public bool UpdateTicket(TicketModel update)
        {
            SqlConnection conn = _connectionFactory.GetConnection();
            SqlCommand cmd = new SqlCommand("UPDATE p1.tickets SET status = @status, resolver = @resolver, resolverID = @resolverID where ticketNumber = @ticketNumber;", conn);

            cmd.Parameters.AddWithValue("@ticketNumber", update.ticketNumber);
            cmd.Parameters.AddWithValue("@status", update.status);
            cmd.Parameters.AddWithValue("@resolver", update.resolver);
            cmd.Parameters.AddWithValue("@resolverID", update.resolverID);
            
            conn.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            conn.Close();

            if (rowsAffected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
