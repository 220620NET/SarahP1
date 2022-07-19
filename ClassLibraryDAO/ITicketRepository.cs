using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModels;

namespace ClassLibraryDAO
{
    interface ITicketRepository
    {
        TicketModel GetTicket(int ID);

        TicketModel GetTicket(string UserName);

        TicketModel GetTicket(char Status);

        void CreateTicket();

        void UpdateTicket();
    }
}
