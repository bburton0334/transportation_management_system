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
    class RequestUpdate
    {
        public void CreateUpdate()
        {


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="existingAdmin"></param>
        /// <returns></returns>
        public bool ValidateAdminExists(Admin existingAdmin)
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
