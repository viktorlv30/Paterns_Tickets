using System;

namespace Patern_Tickets
{
    //Kassa interface for each kassa factory
    public interface IKassa
    {
        //return expensive ticket to airplane
        Ticket LuxuryTicket(string depart, string arrival, DateTime date, int alt);
       
        //Ticket LuxuryTicket();

        //return cheap ticket to train
        Ticket CheapTicket(string depart, string arrival, DateTime date, int alt);

    }
}