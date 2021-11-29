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
    /// \brief The purpose of this class is to create a Buyer Object
    /// \details <b>Details</b>
    ///
    /// Buyer which contains public attribute Buyer_ID which holds Buyer ID .
    /// This class contains a default consructor, along with a UpdateBuyerID function 
    /// This class contains accessors and mutators for the private attributes, 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public class Buyer
    {
        public int Buyer_ID { get; set; }
        public string Buyer_firstName { get; set; }
        public string Buyer_lastName { get; set; }
        public string Buyer_email { get; set; }
        public string Buyer_phoneNumber { get; set; }


        //===============================================================================================================
        /// \brief To instantiate a new Buyer object - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Constructor that creates a new buyer object given the proper parameters.
        /// \param newBuyerID - <b>int</b> - representation of the newBuyerID
        /// \param newBuyerFirstName - <b>string</b> - representation of the newBuyerFirstName
        /// \param newBuyerLastName - <b>string</b> - representation of the newBuyerLastName
        /// \param newBuyerEmail - <b>string</b> - representation of the newBuyerEmail
        /// \param newBuyerPhoneNumber - <b>string</b> - representation of the newBuyerPhoneNumber
        ///
        /// \return As this is a <i>constructor</i> for the Buyer class, nothing is returned
        ///
        /// \see ~Buyer()
        //===============================================================================================================
        public Buyer (int newBuyerID, string newBuyerFirstName, string newBuyerLastName, string newBuyerEmail, string newBuyerPhoneNumber)
        {
            Buyer_ID = newBuyerID;
            Buyer_firstName = newBuyerFirstName;
            Buyer_lastName = newBuyerLastName;
            Buyer_email = newBuyerEmail;
            Buyer_phoneNumber = newBuyerPhoneNumber;
        }

        //===============================================================================================================
        /// \brief updateBuyerID function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Method that takes existingBuyer and NewBuyer IDs to validate and check if a previous version of them exist.
        /// \param existingBueyr - <b>Buyer</b> - representation of the new buyer's ID
        /// \param newBuyerID - <b>newBuyerID</b> - representation new buyer's First Name
        /// \return As this is a <i>method</i> for the Buyer class, bool is returned
        ///
        /// \return As this is a <i>function</i> for the Buyer class, nothing is returned
        ///
        /// \see ~Buyer()
        //===============================================================================================================
        public bool UpdateBuyerID(Buyer existingBuyer, int newBuyerID)
        {
            bool isIDValid = false;
            const int MIN = 0;

            if (existingBuyer != null)
            {
                if (newBuyerID > MIN)
                {
                    existingBuyer.Buyer_ID = newBuyerID;
                    isIDValid = true;
                }
            }

            return isIDValid;
        }
    }
}
