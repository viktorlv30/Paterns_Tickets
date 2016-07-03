using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    public abstract class Ticket
    {
        private string _departure;
        private string _arrival;
        private DateTime _date;

        protected Ticket()
        {
            
        }

        protected Ticket(string depart, string arrival, DateTime date)
        {
            _departure = depart;
            _arrival = arrival;
            _date = date;
        }

        protected string Departure { get; set; }

        protected string Arrival { get; set; }

        public DateTime DateTime { get; set; }
    }
}
