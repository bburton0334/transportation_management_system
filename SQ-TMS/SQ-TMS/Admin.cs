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
    /// \brief The purpose of this class is to realistically model the attributes of a circle
    /// \details <b>Details</b>
    ///
    /// Circle class which contains private attribute radius which holds the radius of the circle.
    /// This class contains a default consructor and another constructor which takes a radius as a
    /// parameter. This class contains accessors and mutators for the private attributes, along with
    /// virtual function which do calculations for the circles area, perimeter, and diameter.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    class Admin
    {
        public int AdminID { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }


        ///==============================================================================================================
        /// \brief To instantiate a new Admin object - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Constructor that creates a new AdminUpdate object given the proper parameters.
        /// \param newAdminID - <b>int</b> - representation of the radius of the circle
        /// \param newAdminFirstName - <b>string</b> - representation of the radius of the circle
        /// \param newAdminLastName - <b>string</b> - representation of the radius of the circle
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

    }
}
