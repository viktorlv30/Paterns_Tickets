using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    public class TrainT : Ticket, ITicket
    {

        private int _wagonNumber;

        public TrainT(string depart, string arrival, DateTime date, int wagNum)
            : base(depart, arrival, date)
        {
            _wagonNumber = wagNum;
        }

        public int Wagon { get; set; }

        public void GetTicket()
        {
            Console.WriteLine("Get train ticket!");
        }

        public string Trip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + " by train.";
            return str;
        }
    }
}
