using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Ticket
    {
        public int ticketId { get; set; }
        public string taskTitle { get; set; }
        public string taskDescription { get; set; }
        public DateTime taskCreateDate { get; set; }
        public TicketStatus taskStatus { get; set; }
        public int projectId { get; set; }
        public Guid assignUserId { get; set; } 

        public Project project { get; set; }

    }
}
