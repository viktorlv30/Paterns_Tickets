using System;

namespace Patern_Tickets.Factories
{
    public class UkrzaliznucyaKassaFactory : IKassa
    {

        public Ticket LuxuryTicket(string dep, string arr, DateTime date, int wagNum)
        {
            return new TrainTickFactory().CreateTicket(dep, arr, date, wagNum);
        }

        public Ticket CheapTicket(string dep, string arr, DateTime date, int wagNum)
        {
            return new TrainTickFactory().CreateTicket(dep, arr, date, wagNum);
        }
    }
}