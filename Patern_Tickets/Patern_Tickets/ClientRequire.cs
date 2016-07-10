using System;

namespace Patern_Tickets
{
    //struct for store client request, where he want to travel
    //this is will be parametr for constructors of each ticket factory
    public struct ClientRequire
    {
        public string Departure { get; set; }

        public string Arrival { get; set; }

        public DateTime DateTimeTrip { get; set; }

        public int Parametr { get; set; }

        public int DictionaryKey { get; set; }


        public ClientRequire(string dep, string arr, DateTime date, int param, int key)
        {
            Departure = dep;
            Arrival = arr;
            DateTimeTrip = date;
            Parametr = param;
            DictionaryKey = key;
        }
    }
}