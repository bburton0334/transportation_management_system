using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    public class TMSData
    {
        // holds list of Shipment objects
        // This list would later be inserted into the database
        public static List<Shipment> shipments = new List<Shipment>();

        public static List<Contract> contracts = new List<Contract>();
        
        // holds amount of days passed by Planner
        public static int TotalDaysPassed = 0;

        // holds default logfile path. Can be changed by 
        public static string logFilePath = "C:\\TMSTemp\\";

        // holds log file name
        public static string LogFileName = "log.txt";

        public static string currentNotification = null;
    }
}
