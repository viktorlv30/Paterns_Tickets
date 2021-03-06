﻿using System;

namespace Patern_Tickets.Factories
{
    ////Privat Bank kassa - gets client request and return only either Avia or Ship ticket
    /// this tickets divide to Luxury and Cheap
    /// Luxury returns Avia ticket
    /// Cheap returns Ship ticket
    public class PbKassaFactory : IKassa
    {
        public Ticket LuxuryTicket(string dep, string arr, DateTime date, int alt)
        {
            return new AirTickFactory().CreateTicket(dep, arr, date, alt);
        }

        public Ticket LuxuryTicket(ClientRequire req)
        {
            return new AirTickFactory().CreateTicket(req.Departure, req.Arrival, req.DateTimeTrip, req.Parametr);
        }

        public Ticket CheapTicket(string dep, string arr, DateTime date, int cabNum)
        {
            return new ShipTickFactory().CreateTicket(dep, arr, date, cabNum);
        }

        public Ticket CheapTicket(ClientRequire req)
        {
            return new ShipTickFactory().CreateTicket(req.Departure, req.Arrival, req.DateTimeTrip, req.Parametr);
        }
    }
}