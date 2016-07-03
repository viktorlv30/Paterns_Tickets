using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    class BusT : Ticket, ITicket
    {
        public BusT()
        { }

        public BusT(string depart, string arrival, DateTime date, int plNum)
            : base(depart, arrival, date)
        {
            PlaceNumber = plNum;
        }

        protected int PlaceNumber { get; set; }

        public void GetTicket()
        {
            Console.WriteLine("Get bus ticket!");
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + this.Departure + " to " + this.Arrival + 
                " by the BUS at " + this.DateAndTimeStart.ToLongDateString() + Environment.NewLine;
            return str;
        }
    }
}
