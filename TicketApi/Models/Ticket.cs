using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApi.Models
{
    public class Ticket
    {
        [Key]
        public int idTicket { get; set; }
        public DateTime? creationDate { get; set; }
        public DateTime? updateDate { get; set; }
        public string username { get; set; }
        public string status { get; set; }

    }
}
