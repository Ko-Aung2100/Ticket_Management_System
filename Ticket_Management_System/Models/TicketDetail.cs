using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket_Management_System.Models
{
    public class TicketDetail
    {
        public string From { get; set; }
        public string To { get; set; }
        public int ToID { get; set; }
        public int TicketCost { get; set; } = 20000;
    }
}