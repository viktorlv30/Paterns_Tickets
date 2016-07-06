using System;

namespace Patern_Tickets.Factories
{
    public class UrozhaiKassaFactory : IKassa
    {
        public Ticket LuxuryTicket(string dep, string arr, DateTime date, int plNum)
        {
            return new BusTickFactory().CreateTicket(dep, arr, date, plNum);
        }

        public Ticket CheapTicket(string dep, string arr, DateTime date, int plNum)
        {
            return new BusTickFactory().CreateTicket(dep, arr, date, plNum);
        }
    }
}