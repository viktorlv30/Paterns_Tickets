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

        public Travel()
        {
            _tickets = new List<Ticket>();
        }
         
        public void AddTicket(Ticket ticket)
        {
            try
            {
                _tickets.Add(ticket);
                //Console.WriteLine("This ticket is included good!");
            }
            catch 
            {
                Console.WriteLine("ERROR.\nCann't include ticket!!!");
            }
            
            
        }

        public void RemoveTicket(int index)
        {
            _tickets.RemoveAt(index);
        }

        public string ShowTravel()
        {
            //string travelDescription = "";
            try
            {
                //    foreach (var ticket in _tickets)
                //    {
                //        travelDescription += ticket.ShowTrip();
                //    }
                //    return travelDescription;

                return _tickets.Aggregate("", (current, ticket) => current + ticket.ShowTrip());
            }
            catch 
            {
                return "No tickets for show!!!";
            }
            
        }
    }
}
