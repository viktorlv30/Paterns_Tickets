using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    //describe the main methods of travel
    internal interface ITravel
    {
        void AddTicket(Ticket ticket);

        void RemoveTicket(int index);

        string ShowTravel();

    }
}
