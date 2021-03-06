﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    //concrete class for Bus tickets
    class BusT : Ticket
    {

        protected int PlaceNumber { get; set; }

        public BusT()
        { }

        public BusT(string depart, string arrival, DateTime date, int plNum)
            : base(depart, arrival, date)
        {
            PlaceNumber = plNum;
        }

        public BusT(ClientRequire require)
            : base(require.Departure, require.Arrival, require.DateTimeTrip)
        {
            PlaceNumber = require.Parametr;
        }

        public override void GetTicket()
        {
            Console.WriteLine("Get bus ticket!");
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + this.Departure + " to " + this.Arrival + 
                " by the BUS at " + this.DateAndTimeStart.ToLongDateString() + Environment.NewLine;
            return str;
        }
    }
}
