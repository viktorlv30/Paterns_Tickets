using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patern_Tickets.Factories;

namespace Patern_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Travel trav = new Travel();

            //create client requests
            ClientRequire firstTrip  = new ClientRequire("Vinnitsya", "Zhutomir", Convert.ToDateTime("17 July 2016 10:20:35 AM"), 25);
            ClientRequire secondTrip = new ClientRequire("Zhutomir", "Liverpool", Convert.ToDateTime("25 August 2016 09:14:35 PM"), 50);
            ClientRequire thirdTrip  = new ClientRequire("Liverpool", "London", Convert.ToDateTime("24 August 2016 02:20:35 PM"), 17);
            ClientRequire fourTrip   = new ClientRequire("London", "Paris", Convert.ToDateTime("22 July 2016 12:20:35 AM"), 15000);

            //create our travel from four different trips
            trav.AddTicket(new PbKassaFactory().LuxuryTicket(firstTrip));
            trav.AddTicket(new PbKassaFactory().CheapTicket(secondTrip));
            trav.AddTicket(new UkrzaliznucyaKassaFactory().LuxuryTicket(thirdTrip));
            trav.AddTicket(new UrozhaiKassaFactory().CheapTicket(fourTrip));
           

            Console.WriteLine(trav.ShowTravel());
            Console.ReadKey();

        }
    }
}
