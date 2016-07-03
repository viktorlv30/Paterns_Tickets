using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    class Ship_t : Ticket, ITicket
    {
        public void GetTicket()
        {
            Console.WriteLine("Get ship ticket!");
        }

        public string Trip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + " on the ship.";
            return str;
        }
    }
}
