using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    ///==================================================================================================================
    /// \class AdminUpdate
    ///
    /// \brief The purpose of this class is to create a AdminUpdate Object
    /// \details <b>Details</b>
    ///
    /// AdminUpdate which contains public attribute AdminUpdate_ID which holds AdminUpdate ID .
    /// This class contains a default consructor, along with a UpdateID function 
    /// This class contains accessors and mutators for the private attributes, 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    class AdminUpdate
    {

        public int Au_updateID { get; set; }
        public string Au_logFiles { get; set; }

        public string Au_IPAddress { get; set; } //need to parse in numbers i think
        public int Au_ports { get; set; }

        public string Au_rates { get; set; } // need to parse in int (since rate can be 34.5)

        public string Au_carrierData { get; set; }
        public string Au_routeTable { get; set; }
        public string Au_backup { get; set; }

        ///==============================================================================================================
        /// \brief To instantiate a new AdminUpdate object - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Constructor that creates a new AdminUpdate object given the proper parameters.
        /// \param newAu_updateID - <b>int</b> - representation of the newAu_updateID
        /// \param newAu_logfiles - <b>string</b> - representation of the newAu_logfiles
        /// \param newAu_IPAddress - <b>string</b> - representation of the newAu_IPAddress
        /// \param newAu_ports - <b>int</b> - representation of the newAu_ports
        /// \param newAu_rates - <b>string</b> - representation of the newAu_rates
        /// \param newAu_carrierData - <b>string</b> - representation of the newAu_carrierData
        /// \param newAu_routeTable - <b>string</b> - representation of the newAu_routeTable
        /// \param newAu_backup - <b>string</b> - representation of the newAu_backup 
        ///
        /// \return As this is a <i>constructor</i> for the AdminUpdate class, nothing is returned
        ///
        /// \see ~AdminUpdate()
        ///==============================================================================================================
        public AdminUpdate(int newAu_updateID, string newAu_logfiles, string newAu_IPAddress, int newAu_ports, string newAu_rates, string newAu_carrierData, string newAu_routeTable, string newAu_backup)
        {
            // SET ALL OF THE VALUES

            Au_updateID = newAu_updateID;
            Au_logFiles = newAu_logfiles;
            Au_IPAddress = newAu_IPAddress;
            Au_ports = newAu_ports;
            Au_rates = newAu_rates;
            Au_carrierData = newAu_carrierData;
            Au_routeTable = newAu_routeTable;
            Au_backup = newAu_backup;
        }

        //===============================================================================================================
        /// \brief updateID function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Method that takes existing and new_ID to validate and check if a previous version of them exist.
        /// \param existing - <b>existing</b> - representation of existing
        /// \param newID - <b>newID</b> - representation new buyer's First Name
        /// \return As this is a <i>method</i> for the Buyer class, bool is returned
        ///
        /// \return As this is a <i>function</i> for the UpdateID class,bool is returned
        ///
        /// \see ~AdminUpdate()
        //===============================================================================================================
        public bool UpdateID(AdminUpdate existing, int newID)
        {
            bool isIDValid = false;
            const int MIN = 0;

            if (existing != null)
            {
                if (newID > MIN)
                {
                    existing.Au_updateID = newID;
                    isIDValid = true;
                }
            }

            return isIDValid;
        }
    }
}
