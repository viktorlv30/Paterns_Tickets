using System;
using System.Collections.Generic;

namespace Patern_Tickets
{
    //struct for store client request, where he want to travel
    //this is will be parametr for constructors of each ticket factory
    public struct ClientRequire
    {
        
        public string Departure { get; set; }


        //I do not know what I want - but I learn merge conflicts


        public string Arrival { get; set; }

        public DateTime DateTimeTrip { get; set; }

        public int Parametr { get; set; }

        public ClientRequire(string dep, string arr, DateTime date, int param)
        {
            Departure = dep;
            Arrival = arr;
            DateTimeTrip = date;
            Parametr = param;
        }

        //private List<ClientRequire> _reqList;


        //public void AddReqList(ClientRequire req)
        //{
        //    _reqList.Add(req);
        //}

        //public List<ClientRequire> GetReqList()
        //{
        //    return _reqList;
        //}

    }
}