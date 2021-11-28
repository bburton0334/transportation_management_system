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
    class Admin
    {
        public int AdminID { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newAdminID"></param>
        /// <param name="newAdminFirstName"></param>
        /// <param name="newAdminLastName"></param>
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
