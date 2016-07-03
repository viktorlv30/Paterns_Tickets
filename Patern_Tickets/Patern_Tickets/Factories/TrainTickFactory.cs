using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets.Factories
{
    public class TrainTickFactory : ITicketCreator
    {
        public Ticket CreateTicket()
        {
            return new TrainT();
        }

        public Ticket CreateTicket(string dep, string arr, DateTime dateTime, int wagNum)
        {
            return new TrainT(dep, arr, dateTime, wagNum);
        }
    }
}
