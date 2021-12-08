using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class Report
    ///
    /// \brief The purpose of this class is to hold functions which will handel the creation of the report
    /// \details <b>Details</b>
    ///
    /// Report class contains 2 functions, one that is called outside the class which passes a string as a message,
    /// and another with will store the passed string into a text folder in a specified directory.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public static class Report
    {

        //===============================================================================================================
        /// \brief Generate function
        /// \details <b>Details</b>
        ///
        /// Function which passes the message parameter to the LogWrite function
        /// so the message can be written to the log file.
        /// \param message - <b>string</b> - contains the message that will be sent to the report file.
        ///
        /// \see ~Report()
        //===============================================================================================================
        public static void Generate(string message)
        {
            ReportWriter(message);
        }

        //===============================================================================================================
        /// \brief ReportWriter function
        /// \details <b>Details</b>
        ///
        /// Function which is called so the passed logMessage can be written to 
        ///      the log file. The function will get the current directory of the
        ///      service and write to the log file there. If a log.txt file does
        ///      not already exist, and new file will be created. The message
        ///      then be written to the log file in a format which states the time
        ///      and the message.
        /// \param logMessage - <b>string</b> - contains the message that will be sent to the report file.
        ///
        /// \see ~Report()
        //===============================================================================================================
        private static void ReportWriter(string logMessage)
        {
            // getting directory location
            string path = TMSData.ReportFileDir;
            string file = TMSData.ReportFileName;

            // creating directory if does not exist
            Directory.CreateDirectory(path);

            // Creating a log file if one does not already exist
            if (!File.Exists(path + "\\" + file))
            {
                // Create a file to write to. Writting message to log.
                using (StreamWriter sw = File.CreateText(path + "\\" + file))
                {
                    sw.Write("\r\nSummary Report Entry : ");
                    sw.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    sw.WriteLine("  :");
                    sw.WriteLine("  :{0}", logMessage);
                    sw.WriteLine("-------------------------------");
                }
            }
            else
            {
                try
                {
                    // log file already exists. Writting log message to file.
                    using (StreamWriter w = File.AppendText(path + "\\" + file))
                    {
                        w.Write("\r\nSummary Report Entry : ");
                        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                        w.WriteLine("  :");
                        w.WriteLine("  :{0}", logMessage);
                        w.WriteLine("-------------------------------");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error: Exception");
                }
            }
        }
    }
}
