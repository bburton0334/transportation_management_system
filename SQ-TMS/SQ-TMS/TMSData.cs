using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class TMSData
    ///
    /// \brief The purpose of this class is to hold static variables that hold information that is important with
    /// in the TMS: Transportation Management System. These elements are accesedd from mutiple functions.
    /// \details <b>Details</b>
    ///
    /// TMSData Class contains the following variables, TotalDaysPassed, LogFilePath, LogFileName, InvoiceFileName,
    /// ReportFileDir, ReportFileName, BackupFileName, BackupFileDir, FTLRate, LTLRate, and ReeferCharge.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public class TMSData
    {
        // holds list of Shipment objects
        // This list would later be inserted into the database
        public static List<Shipment> shipments = new List<Shipment>();

        public static List<Contract> contracts = new List<Contract>();
        
        // holds amount of days passed by Planner
        public static int TotalDaysPassed = 0;

        // holds default logfile path. Can be changed by 
        public static string logFilePath = "C:\\TMSTemp\\Log\\";

        // holds log file name
        public static string LogFileName = "log.txt";

        public static string InvoiceFilePath = "C:\\TMSTemp\\Invoice\\";

        public static string InvoiceFileName = "Invoice.txt";

        public static string ReportFileDir = "C:\\TMSTemp\\Report\\";

        public static string ReportFileName = "SummaryReport.txt";

        public static string BackupFileDir = "C:\\TMSTemp\\Backup\\";

        public static string BackupFileName = "BackupData.txt";

        public static double FTLRate = 4.985;   //default/ average according to document 

        public static double LTLRate = 0.2995; //default/ average according to document

        public static int ReeferCharge = 5;     // document says between 5-10%. i just put 5 cause im not sure. represents % value
    }
}
