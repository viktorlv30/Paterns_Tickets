﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    //concrete class for Ship tickets
    public class ShipT : Ticket
    {
        protected int CabinNumber { get; set; }

        public ShipT()
        { }

        public ShipT(string depart, string arrival, DateTime date, int cabNum)
            : base(depart, arrival, date)
        {
            CabinNumber = cabNum;
        }

        public ShipT(ClientRequire require)
            : base(require.Departure, require.Arrival, require.DateTimeTrip)
        {
            CabinNumber = require.Parametr;
        }

        public override void GetTicket()
        {
            Console.WriteLine("Get ship ticket!");
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + " on the CRUISER at "
                + DateAndTimeStart.ToLongDateString() + Environment.NewLine;
            return str;
        }



    }
}
