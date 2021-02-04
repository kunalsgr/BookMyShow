using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow1.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public string ShowId { get; set; }
        public string UserId { get; set; }
        public string AmountPaid { get; set; }
        public int Quantity { get; set; }

        public string ShowLocation { get; set; }
        public string Booked { get; set; }
        public DateTime CreatedOn { get; set; }
        
    }
}
