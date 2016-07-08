using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    //concrete class for Avia tickets
    public class AviaT : Ticket
    {

        protected int Alt { get; set; }


        //I don't understand why I can use fields of my struct in this file ?????????????

        public ClientRequire _require;// = new ClientRequire();
        //_require.????????????????????????

        


        public AviaT()
        { }

        public AviaT(string depart, string arrival, DateTime date, int alt)
            : base(depart, arrival, date)
        {
            Alt = alt;
        }

        public override void GetTicket()
        {
            Console.WriteLine("Get avia ticket"); 
        }

        public override string ShowTrip()
        {
            string str = "Trip from " + Departure + " to " + Arrival + 
                " on the PLANE at " + DateAndTimeStart.ToLongDateString() + Environment.NewLine;
            return str;
        }

 
    }
}
