using System;

namespace Patern_Tickets.Factories
{
    ////Urozhai kassa - gets client request and return only Bus ticket
    /// both methods return Bus ticket
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