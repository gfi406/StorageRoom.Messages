using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageRoom.Messages
{
    public class PassengerMessages 
    {

        public Guid PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public Guid FlightId { get; set; }
    }
}
