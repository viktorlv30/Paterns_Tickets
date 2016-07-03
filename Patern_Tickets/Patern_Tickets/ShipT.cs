using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    public class ShipT : Ticket, ITicket
    {

        private int _cabinNumber;

        public ShipT()
        { }

        public ShipT(string depart, string arrival, DateTime date, int cabNum)
            : base(depart, arrival, date)
        {
            _cabinNumber = cabNum;
        }

        public int CabinNumber
        {
            get { return _cabinNumber; }
            set { _cabinNumber = value; }
        }

        public void GetTicket()
        {
            Console.WriteLine("Get ship ticket!");
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + " on the CRUISER at "
                + DateAndTimeStart.ToLongDateString() + Environment.NewLine;
            return str;
        }



    }
}
