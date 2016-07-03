﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets.Factories
{
    public class AirTickFactory : ITicketCreator
    {
        public Ticket CreateTicket()
        {
            return new AviaT();
        }

        public Ticket CreateTicket(string dep, string arr, DateTime dateTime, int alt)
        {
            return new AviaT(dep, arr, dateTime, alt);
        }

    }
}
