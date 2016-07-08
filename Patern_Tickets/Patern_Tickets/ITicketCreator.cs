using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    //main interface for ticket factorys
    internal interface ITicketCreator
    {
        Ticket CreateTicket();
    }
}
