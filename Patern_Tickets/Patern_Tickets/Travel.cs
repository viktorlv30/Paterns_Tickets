using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_Tickets
{
    public class Travel : ITravel
    {

        private List<Ticket> _tickets;
         
        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public void RemoveTicket(int index)
        {
            _tickets.RemoveAt(index);
        }

        public string ShowTravel(List<Ticket> tiketsList)
        {
            return tiketsList.Aggregate("", (current, tick) => current + tick.ShowTrip());
        }
    }
}
