﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets.Factories
{
    //factory gets client request and return Ship ticket (without data checkig yet)
    public class ShipTickFactory : ITicketCreator
    {
        public Ticket CreateTicket()
        {
            return new ShipT();
        }

        public Ticket CreateTicket(string dep, string arr, DateTime dateTime, int cabNum)
        {
            return new ShipT(dep, arr, dateTime, cabNum);
        }
    }
}
