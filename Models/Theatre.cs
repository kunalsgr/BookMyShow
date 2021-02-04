using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow1.Models
{
    public class Theatre
    {
        public int Id { get; set; }
        public string TheatreName { get; set; }
        public string TheatreAddress { get; set; }
        public string Category { get; set; }
        public int FrontRowSeatsPrice { get; set; }
        public int MiddleRowSeatsPrice { get; set; }
        public int LastRowSeatsPrice { get; set; }
        public int TotalNumberOfSeats { get; set; }
        public int FrontRowLastSeat { get; set; }
        public int MiddleRowLastSeat { get; set; }
        public int LastRowLastSeat { get; set; }

    }
}
