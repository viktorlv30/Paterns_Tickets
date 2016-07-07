using System;

namespace Patern_Tickets
{
    public struct ClientRequire
    {
        public string _departure;

        public string _arrival;

        public DateTime _dateTimeTrip;

        public int _parametr;

        public int _dictionaryKey;

        public ClientRequire(string dep, string arr, DateTime date, int param, int key)
        {
            _departure = dep;
            _arrival = arr;
            _dateTimeTrip = date;
            _parametr = param;
            _dictionaryKey = key;
        }
    }
}