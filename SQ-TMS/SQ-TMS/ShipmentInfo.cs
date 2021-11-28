using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    /// <summary>
    /// 
    /// </summary>
    class Shipments
    {
        public int ShipmentsInfoID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newShipmentsInfoID"></param>
        public Shipments (int newShipmentsInfoID)
        {
            ShipmentsInfoID = newShipmentsInfoID;
        }

        /// <summary>
        /// 
        /// </summary>
        public class Orders
        {
            public int Order_ID { get; set; }
            public string materials { get; set; }
            public string invoice { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Carriers
        {
            public int Carrier_ID { get; set; }
            public string Carrier_name { get; set; }
            public string Carrier_city { get; set; }
            public string Carrier_contactInfo { get; set; }
            public string Carrier_orderTracking { get; set; }
            public string Carrier_orderStatus { get; set; }  // can also be in bool, if deliverd true, otherwise false
        }

        /// <summary>
        /// 
        /// </summary>
        public class Trips
        {
            public int Trips_ID { get; set; }
            public int numberOfTrips { get; set; }
            public string Tripstatus { get; set; } // can also be in bool, if trip completed,true, otherwise false
        }
    }
}
