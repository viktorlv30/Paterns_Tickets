using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    struct ClientRequirements
    {
        private string _departure;

        private string _arrival;

        private DateTime _dateTimeTrip;

        private int _parametr;

        private int _dictionaryKey;

        public ClientRequirements(string dep, string arr, DateTime date, int param, int key)
        {
            _departure = dep;
            _arrival = arr;
            _dateTimeTrip = date;
            _parametr = param;
            _dictionaryKey = key;
        }


    }
}
