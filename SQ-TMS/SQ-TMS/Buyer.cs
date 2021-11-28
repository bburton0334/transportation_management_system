using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class Buyer
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
    class Buyer
    {
        public int Buyer_ID { get; set; }
        public string Buyer_firstName { get; set; }
        public string Buyer_lastName { get; set; }
        public string Buyer_email { get; set; }
        public int Buyer_phoneNumber { get; set; }


        //===============================================================================================================
        /// \brief To instantiate a new AdminUpdate object - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Constructor that creates a new AdminUpdate object given the proper parameters.
        /// \param newBuyerID - <b>int</b> - representation of the radius of the circle
        /// \param newBuyerFirstName - <b>string</b> - representation of the radius of the circle
        /// \param newBuyerLastName - <b>string</b> - representation of the radius of the circle
        /// \param newBuyerEmail - <b>string</b> - representation of the radius of the circle
        /// \param newBuyerPhoneNumber - <b>int</b> - representation of the radius of the circle
        ///
        /// \return As this is a <i>constructor</i> for the Buyer class, nothing is returned
        ///
        /// \see ~Buyer()
        //===============================================================================================================
        public Buyer (int newBuyerID, string newBuyerFirstName, string newBuyerLastName, string newBuyerEmail, int newBuyerPhoneNumber)
        {
            Buyer_ID = newBuyerID;
            Buyer_firstName = newBuyerFirstName;
            Buyer_lastName = newBuyerLastName;
            Buyer_email = newBuyerEmail;
            Buyer_phoneNumber = newBuyerPhoneNumber;
        }
    }
}
