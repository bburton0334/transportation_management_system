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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newAu_updateID"></param>
        /// <param name="newAu_logfiles"></param>
        /// <param name="newAu_IPAddress"></param>
        /// <param name="newAu_ports"></param>
        /// <param name="newAu_rates"></param>
        /// <param name="newAu_carrierData"></param>
        /// <param name="newAu_routeTable"></param>
        /// <param name="newAu_backup"></param>
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

    }
}
