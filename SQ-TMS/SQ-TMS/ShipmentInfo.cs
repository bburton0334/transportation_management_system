using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class Shipments
    ///
    /// \brief The purpose of this class is to realistically model the attributes of a circle
    /// \details <b>Details</b>
    ///
    /// Circle class which contains private attribute radius which holds the radius of the circle.
    /// This class contains a default consructor and another constructor which takes a radius as a
    /// parameter. This class contains accessors and mutators for the private attributes, along with
    /// virtual function which do calculations for the circles area, perimeter, and diameter.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
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
