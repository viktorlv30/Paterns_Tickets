using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    //ticket interfase describe main methods concrete ticket classes
    interface ITicket
    {
        void GetTicket();

        string ShowTrip();
    }
}
