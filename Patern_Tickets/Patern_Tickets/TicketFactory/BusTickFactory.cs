﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets.Factories
{
    //factory gets client request and return Bus ticket (without data checkig yet)
    public class BusTickFactory : ITicketCreator
    {
        public Ticket CreateTicket()
        {
            return new BusT();
        }

        public Ticket CreateTicket(string dep, string arr, DateTime dateTime, int plNum)
        {
            return new BusT(dep, arr, dateTime, plNum);
        }
    }
}
