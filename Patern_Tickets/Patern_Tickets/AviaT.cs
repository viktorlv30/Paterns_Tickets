using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    public class AviaT : Ticket, ITicket
    {

        private int _alt;

        public AviaT()
        { }

        public AviaT(string depart, string arrival, DateTime date, int alt)
            : base(depart, arrival, date)
        {
            _alt = alt;
        }

        protected int Alt
        {
            get { return _alt; }
            set { _alt = value; }
        }

        public void GetTicket()
        {
            Console.WriteLine("Get avia ticket"); 
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + 
                " on the PLANE at " + DateAndTimeStart.ToLongDateString() + Environment.NewLine;
            return str;
        }

 
    }
}
