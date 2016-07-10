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

            /*
            trav.AddTicket(new BusTickFactory().CreateTicket("Vinnitsya", "Zhutomir", Convert.ToDateTime("17 July 2016 10:20:35 AM"), 25));
            trav.AddTicket(new AirTickFactory().CreateTicket("Zhutomir", "Liverpool", Convert.ToDateTime("22 July 2016 12:20:35 AM"), 15000));
            trav.AddTicket(new TrainTickFactory().CreateTicket("Liverpool", "London", Convert.ToDateTime("24 August 2016 02:20:35 PM"), 17));
            trav.AddTicket(new ShipTickFactory().CreateTicket("London", "Paris", Convert.ToDateTime("25 August 2016 09:14:35 PM"), 50));
            */

            ClientRequire request = new ClientRequire("Vinnitsya", "Zhutomir", Convert.ToDateTime("17 July 2016 10:20:35 AM"), 25, 1);
        

            //create our travel from four different trips
            trav.AddTicket(new PbKassaFactory().LuxuryTicket(request));
            trav.AddTicket(new PbKassaFactory().CheapTicket("Zhutomir", "Liverpool", Convert.ToDateTime("25 August 2016 09:14:35 PM"), 50));
            trav.AddTicket(new UkrzaliznucyaKassaFactory().LuxuryTicket("Liverpool", "London", Convert.ToDateTime("24 August 2016 02:20:35 PM"), 17));
            trav.AddTicket(new UrozhaiKassaFactory().CheapTicket("London", "Paris", Convert.ToDateTime("22 July 2016 12:20:35 AM"), 15000));

            //the struct ClientRequire works in Program.cs Main() function but doesn't work in AviaT class
            //---------------?????????
           

            Console.WriteLine(trav.ShowTravel());
            Console.ReadKey();

        }
    }
}
