﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    class Train_t : ITicket
    {
        public void CreateTicket()
        {
            Console.WriteLine("Create train ticket!");
        }
    }
}
