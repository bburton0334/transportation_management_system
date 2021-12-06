using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    // USED FOR CONTRACT MARKET PLACE TO STORE ACCEPTED CUSTOMER CONTRACTS
    public class Contract
    {
        public string ClientName { get; set; }
        public int JobType { get; set; }
        public int Quantity { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int VanType { get; set; }
    }
}
