using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    ///==================================================================================================================
    /// \class Admin
    ///
    /// \brief The purpose of this class is to create a Admin Object
    /// \details <b>Details</b>
    ///
    /// Admin which contains public attribute Admin_ID which holds Admin ID.
    /// This class contains a default consructor, along with a UpdateAdminID and UpdateFirstName function 
    /// This class contains accessors and mutators for the private attributes, 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }


        ///==============================================================================================================
        /// \brief To instantiate a new Admin object - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Constructor that creates a new AdminUpdate object given the proper parameters.
        /// \param dminID - <b>int</b> - representation of the AdminID
        /// \param newAdminFirstName - <b>string</b> - representation of newAdminFistName
        /// \param newAdminLastName - <b>string</b> - representation of newAdminLastName
        ///
        /// \return As this is a <i>constructor</i> for the Admin class, nothing is returned
        ///
        /// \see ~Admin()
        ///==============================================================================================================
        public Admin(int newAdminID, string newAdminFirstName, string newAdminLastName)
        {
            /* CREATE SOME SORT OF VALIDATION FOR ADMIN ID FORMAT */
            //bool creatingAdmin = false;

            /*  SETTING VALUES FOR NEW INSTANCE OF ADMIN CLASS */
            AdminID = newAdminID;
            AdminFirstName = newAdminFirstName;
            AdminLastName = newAdminLastName;
        }

        //===============================================================================================================
        /// \brief updateAdminID function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Method that takes existing and new_ID to validate and check if a previous version of them exist.
        /// \param existingAdmin - <b>existingAdmin</b> - representation of existingAdmin
        /// \param newAdminID - <b>newID</b> - representation new admin ID
        /// \return As this is a <i>method</i> for the Buyer class, bool is returned
        ///
        /// \return As this is a <i>function</i> for the UpdateAdminID class, bool is returned
        ///
        /// \see ~Admin()
        //===============================================================================================================
        public bool UpdateAdminID(Admin existingAdmin, int newAdminID)
        {
            bool isIDValid = false;
            const int MIN = 0;

            if (existingAdmin != null)
            {
                if (newAdminID > MIN)
                {
                    existingAdmin.AdminID = newAdminID;
                    isIDValid = true;
                }
            }  
            return isIDValid;
        }

        //===============================================================================================================
        /// \brief updateFirstName function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Method that takes existing and firstName to validate and check if a previous version of them exist.
        /// \param existing - <b>existing</b> - representation of existing
        /// \param firstName - <b>firstName</b> - representation new Admin's First Name
        /// \return As this is a <i>method</i> for the Admin class, bool is returned
        ///
        /// \see ~Admin()
        //===============================================================================================================
        public bool UpdateFirstName(Admin existing, string firstname)
        {
            bool isIDValid = false;

            if (existing != null)
            {
                existing.AdminFirstName = firstname;
                isIDValid = true;
            }

            return isIDValid;
        }
    }
}
