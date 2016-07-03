using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    internal interface ITravel
    {
        void AddTicket(Ticket ticket);

        void RemoveTicket(int index);

        string ShowTravel();

    }
}
