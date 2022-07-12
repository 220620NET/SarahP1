using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class TicketModel
    {
        public int TicketNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public char Status { get; set; }
    }
}
