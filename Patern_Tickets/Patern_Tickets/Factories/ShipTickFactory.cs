using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets.Factories
{
    internal class ShipTickFactory : ITicketCreator
    {
        public Ticket CreateTicket()
        {
            return new ShipT();
        }
    }
}
