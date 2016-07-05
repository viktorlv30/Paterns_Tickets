using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Patern_Tickets
{
    public abstract class Ticket
    {

        protected Ticket()
        {
            
        }

        protected Ticket(string depart, string arrival, DateTime date)
        {
            Departure = depart;
            Arrival = arrival;
            DateAndTimeStart = date;
        }

        protected string Departure { get; set; }

        protected string Arrival { get; set; }

        protected DateTime DateAndTimeStart { get; set; }

        public abstract string ShowTrip();

    }
}
