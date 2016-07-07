using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    public class TrainT : Ticket
    {
        protected int Wagon { get; set; }

        public TrainT()
        { }

        public TrainT(string depart, string arrival, DateTime date, int wagNum)
            : base(depart, arrival, date)
        {
            Wagon = wagNum;
        }

        public override void GetTicket()
        {
            Console.WriteLine("Get train ticket!");
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + " on the TRAIN at " 
                + DateAndTimeStart.ToLongDateString() + Environment.NewLine;
            return str;
        }
    }
}
