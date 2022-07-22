using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModels;

namespace ClassLibraryDAO
{
    public interface ITicketRepository
    {
        public bool CreateTicket(TicketModel newTicket);

        public TicketModel GetTicketByTicketNumber(int ticketNumber);

        public List<TicketModel> GetTicketByUserID(int user_fk);

        public List<TicketModel> GetTicketByStatus(string Status);

        public bool UpdateTicket(TicketModel update);
        public List<TicketModel> GetAllTickets();
    }
}
