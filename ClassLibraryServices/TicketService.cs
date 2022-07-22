using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAO;
using ClassLibraryModels;

namespace ClassLibraryServices
{
    public class TicketService
    {
        private readonly ITicketRepository _repo;

        public TicketService(ITicketRepository repo)
        {
            _repo = repo;
        }

        public bool CreateTicket(TicketModel newTicket)
        {
            return _repo.CreateTicket(newTicket);
        }
        public bool UpdateTicket(TicketModel update)
        {
            return _repo.UpdateTicket(update);
        }
        public TicketModel GetTicketByTicketNumber(int ticketNumber)
        {

            return _repo.GetTicketByTicketNumber(ticketNumber);

        }
        public List<TicketModel> GetTicketByUserID(int user_fk)
        {
            return _repo.GetTicketByUserID(user_fk);
        }
        public List<TicketModel> GetTicketByStatus(string status)
        {
            return _repo.GetTicketByStatus(status);
        }
        
        public List<TicketModel> GetAllTickets()
        {
            return _repo.GetAllTickets();
        }
    }
}
