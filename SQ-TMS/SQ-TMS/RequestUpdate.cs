using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    // 
    class RequestUpdate
    {
        public void CreateUpdate()
        {


        }

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
