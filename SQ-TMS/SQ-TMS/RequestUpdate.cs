using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class RequestUpdate
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
    class RequestUpdate
    {
        public void CreateUpdate()
        {


        }

        //===============================================================================================================
        /// \brief Function which checks if an admin exists.
        /// \details <b>Details</b>
        ///
        /// \param existingAdmin - <b>Admin</b> - representation of an Admin Object
        ///
        /// \return Returns a bool if the admin exist. False if non-existant, true if Admin object is not null.
        ///
        /// \see ~RequestUpdate()
        //===============================================================================================================
        public static bool ValidateAdminExists(Admin existingAdmin)
        {
            bool adminExists = false;

            if (existingAdmin != null)
            {
                adminExists = true;
            }

            return adminExists;
        }
    }
}
