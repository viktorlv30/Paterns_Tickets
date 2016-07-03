using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets.Factories
{
    internal class BusTickFactory : ITicketCreator
    {
        public Ticket CreateTicket()
        {
            return new BusT();
        }
    }
}
