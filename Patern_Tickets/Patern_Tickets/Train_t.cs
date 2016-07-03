using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    class Train_t : Ticket, ITicket
    {
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
