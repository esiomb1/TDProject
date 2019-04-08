using System;

namespace Class_Library
{
    public class clsTicket
    {
        public string TicketType { get; set; }
        public string Price { get; set; }
        public int TicketId { get; set; }

        public string Valid(string someTicket)
        {
            throw new NotImplementedException();
        }
    }
}