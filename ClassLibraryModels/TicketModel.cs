using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels
{
    public class TicketModel
    {
        public int ticketNumber;
        public string description;
        public decimal amount;
        public char status;
        //Constructors
        public TicketModel(int ticketNumber, string description, decimal amount, char status)
        {
            this.TicketNumber = ticketNumber;
            this.Description = description;
            this.Amount = amount;
            this.Status = status;

        }
        // Properties
        public int TicketNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public char Status { get; set; }

        // Methods

        public void PrintDescription()
        {
            Console.WriteLine(Description);
        }
    }
}
