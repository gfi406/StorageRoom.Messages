using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageRoom.Messages
{
    public class BaggageMessages 
    {   
        public Guid BaggageId { get; set; }
        public string? BaggageTag { get; set; }
        public double Weight { get; set; }
        


    }
}
