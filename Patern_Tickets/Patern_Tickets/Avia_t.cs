using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    public class Avia_t : Ticket, ITicket
    {
 
        public void GetTicket()
        {
            Console.WriteLine("Get avia ticket"); 
        }

        public string Trip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + " on the plane.";
            return str;
        }
    }
}
