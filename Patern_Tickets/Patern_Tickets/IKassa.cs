using System;

namespace Patern_Tickets
{
    public interface IKassa
    {
        Ticket LuxuryTicket(string d, string a, DateTime dat, int i);
       
        //Ticket LuxuryTicket();

        Ticket CheapTicket(string d, string a, DateTime dat, int i);

    }
}