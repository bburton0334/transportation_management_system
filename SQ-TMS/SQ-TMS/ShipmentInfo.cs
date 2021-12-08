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
    /// \brief The purpose of this class is to hold all of the attributes and classes in relation to the
    ///         shipments carried out by the TMS: Transport Management System. 
    /// \details <b>Details</b>
    ///
    /// Shipments class holds the shipmentsID attribue and holds the various classes within it that relate to 
    /// handeling shipments for the TMS: Transportation Managment System. The attributes include: ShipmentsInfoID.
    /// There are three other classes within this main class: Orders, Carriers, Trips.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public class Shipment
    {
        //------shipment --------------------------------
        public string ShipmentID { get; set; }


        //------CUSTOMER---------------------------------
        public string ClientName { get; set; }
        //------ORDER------------------------------------
        public int Order_ID { get; set; }
        public string materials { get; set; }
        public string invoice { get; set; }
        //------CARRIER----------------------------------
        public int Carrier_ID { get; set; }
        public string Carrier_name { get; set; }
        public string Carrier_city { get; set; }
        public string Carrier_contactInfo { get; set; }
        public string Carrier_orderTracking { get; set; }
        public string Carrier_orderStatus { get; set; }  // can also be in bool, if deliverd true, otherwise false
        //------TRIPS------------------------------------
        public int Trips_ID { get; set; }
        public int numberOfTrips { get; set; }
        public string Tripstatus { get; set; } // can also be in bool, if trip completed,true, otherwise false


        ////===============================================================================================================
        ///// \brief To instantiate a new shipments object - given a set of attribute values
        ///// \details <b>Details</b>
        /////
        ///// Constructor that creates a new AdminUpdate object given the proper parameters.
        ///// \param newShipmentsID - <b>int</b> - representation of the shipments ID
        /////
        ///// \return As this is a <i>constructor</i> for the Buyer class, nothing is returned
        /////
        ///// \see ~Buyer()
        ////===============================================================================================================
        //public Shipment (int newShipmentsInfoID)
        //{
        //    ShipmentID = newShipmentsInfoID;
        //}

        //public class Customer
        //{
        //    public string ClientName { get; set; }
        //}

        ////===================================================================================================================
        ///// \class Orders
        /////
        ///// \brief The purpose of this class is to hold all of the attributes and classes in relation to the
        /////         orders carried out by the TMS: Transport Management System. 
        ///// \details <b>Details</b>
        /////
        ///// orders class holds the order ID attribue, materials, invoice.
        ///// These deal with handeling carriers for the TMS: Transportation Managment System.
        /////
        ///// \author BNSM <i>Transportation Management System Experts</i>
        ///// =================================================================================================================
        //public class Order
        //{
        //    public int Order_ID { get; set; }
        //    public string materials { get; set; }
        //    public string invoice { get; set; }
        //}

        ////===================================================================================================================
        ///// \class Carriers
        /////
        ///// \brief The purpose of this class is to hold all of the attributes and classes in relation to the
        /////         carriers carried out by the TMS: Transport Management System. 
        ///// \details <b>Details</b>
        /////
        ///// Carriers class holds the carrierID attribue, carrier name, carrier city, carrier contact info, carrier tracking
        ///// and carrier order status. These deal with handeling carriers for the TMS: Transportation Managment System.
        /////
        ///// \author BNSM <i>Transportation Management System Experts</i>
        ///// =================================================================================================================
        //public class Carrier
        //{
        //    public int Carrier_ID { get; set; }
        //    public string Carrier_name { get; set; }
        //    public string Carrier_city { get; set; }
        //    public string Carrier_contactInfo { get; set; }
        //    public string Carrier_orderTracking { get; set; }
        //    public string Carrier_orderStatus { get; set; }  // can also be in bool, if deliverd true, otherwise false
        //}

        ////===================================================================================================================
        ///// \class Trips
        /////
        ///// \brief The purpose of this class is to hold all of the attributes and classes in relation to the
        /////         trips carried out by the TMS: Transport Management System. 
        ///// \details <b>Details</b>
        /////
        ///// Trips class holds the trips ID attribue, number of trips, and trip status.
        ///// These deal with handeling carriers for the TMS: Transportation Managment System.
        /////
        ///// \author BNSM <i>Transportation Management System Experts</i>
        ///// =================================================================================================================
        //public class Trip
        //{
        //    public int Trips_ID { get; set; }
        //    public int numberOfTrips { get; set; }
        //    public string Tripstatus { get; set; } // can also be in bool, if trip completed,true, otherwise false
        //}

        /////==============================================================================================================
        ///// \brief To validate the update of the shipments ID
        ///// \details <b>Details</b>
        /////
        ///// Updates the shipmentsID for the shipments class. It will return false if update failed, or it will
        ///// return true if the shipmentsID update was a sucsess. It takes two parameters in order to complete this.
        ///// \param existing - <b>Shipments</b> - representation of shipments object to change their ID
        ///// \param newID - <b>int</b> - representationof new id for the shipments
        /////
        ///// \return bool, true if set, fase if not set.
        /////==============================================================================================================
        //public bool UpdateShipmentsID(Shipment existing, string newID)
        //{
        //    bool isIDValid = false;

        //    if (existing != null)
        //    {
        //            existing.ShipmentID = newID;
        //            isIDValid = true;
        //    }

        //    return isIDValid;
        //}
    }
}
