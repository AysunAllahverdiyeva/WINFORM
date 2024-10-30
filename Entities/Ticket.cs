using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm_EfCore_Final_Project.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int TicketCount { get; set; }
        public string TicketType { get; set; }
    }
}
