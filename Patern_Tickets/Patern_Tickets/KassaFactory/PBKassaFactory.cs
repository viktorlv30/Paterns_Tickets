using System;

namespace Patern_Tickets.Factories
{
    public class PbKassaFactory : IKassa
    {
        public Ticket LuxuryTicket(string dep, string arr, DateTime date, int alt)
        {
            return new AirTickFactory().CreateTicket(dep, arr, date, alt);
        }

        public Ticket CheapTicket(string dep, string arr, DateTime date, int alt)
        {
            return new TrainTickFactory().CreateTicket(dep, arr, date, alt);
        }
    }
}