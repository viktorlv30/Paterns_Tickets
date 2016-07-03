using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    class BusT : Ticket, ITicket
    {

        private int _placeNumber;

        public BusT()
        { }

        public BusT(string depart, string arrival, DateTime date, int plNum)
            : base(depart, arrival, date)
        {
            _placeNumber = plNum;
        }

        public int PlaceNumber { get; set; }

        public void GetTicket()
        {
            Console.WriteLine("Get bus ticket!");
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + " on the plane at " + DateAndTimeStart.ToLongDateString();
            return str;
        }
    }
}
