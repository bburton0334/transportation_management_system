using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class Logger
    ///
    /// \brief The purpose of this class is to hold functions which allow the user to log to a text file.
    /// \details <b>Details</b>
    ///
    /// Logger class conatins 2 functions, one which takes the string as a parameter, and onother whic writes the log
    /// to a text file in a corrosponding directory.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public static class Logger
    {

        //===============================================================================================================
        /// \brief GLog
        /// \details <b>Details</b>
        ///
        /// Function which passes the message parameter to the LogWrite function
        /// so the message can be written to the log file.
        /// \param message - <b>string</b> - contains the message that will be sent to the report file.
        ///
        /// \see ~Logger()
        //===============================================================================================================
        public static void Log(string message)
        {
            LogWriter(message);
        }

        //===============================================================================================================
        /// \brief LogWriter function
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
        /// \see ~Logger()
        //===============================================================================================================
        public static void LogWriter(string logMessage)
        {
            // getting directory location
            string path = TMSData.logFilePath;
            string file = TMSData.LogFileName;

            // creating directory if does not exist
            Directory.CreateDirectory(path);

            // Creating a log file if one does not already exist
            if (!File.Exists(path + "\\" + file))
            {
                // Create a file to write to. Writting message to log.
                using (StreamWriter sw = File.CreateText(path + "\\" + file))
                {
                    sw.Write("\r\nLog Entry : ");
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
                        w.Write("\r\nLog Entry : ");
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
