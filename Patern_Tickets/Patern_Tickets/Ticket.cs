using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Patern_Tickets
{
    //abstract basic class for concrete ticket classes
    public abstract class Ticket : ITicket
    {
        protected string Departure { get; set; }

        protected string Arrival { get; set; }

        protected DateTime DateAndTimeStart { get; set; }

        protected Ticket()
        {
            
        }

        protected Ticket(string depart, string arrival, DateTime date)
        {
            Departure = depart;
            Arrival = arrival;
            DateAndTimeStart = date;
        }

        public abstract void GetTicket();

        public abstract string ShowTrip();
        
    }
}
