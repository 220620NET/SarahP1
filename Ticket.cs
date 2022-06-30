namespace Ticket;


    class TicketInfo
    {
        private int ticketNum;
        private int idAuthor;
        private int idResolver;
        private string author;
        private string resolver;
        private string description;
        private string status;
        private decimal amount;

        public TicketInfo(int ticketNum, int idAuthor, string author, string description,  decimal amount,  int idResolver = 0,  string resolver = "Not yet assigned:", string status = "Pending")
        {
            this.ticketNum = ticketNum;
            this.idAuthor = idAuthor;
            this.idResolver = idResolver;
            this.author = author;
            this.resolver = resolver;
            this.description = description;
            this.status = status;
            this.amount = amount;
        }

        public string ViewTicketInfo()
        {
            string ticketInfo = $"Ticket Number: {ticketNum} \nEmployee: {author}    Employee ID: {idAuthor} \nAmount Requested: {amount} \nDescription of charges: {description} \nRequest managed by {resolver}  ID Number: {idResolver} Status {status}";
            return ticketInfo;
        }


    }
