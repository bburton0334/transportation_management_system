using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace SQ_TMS
{
    
    ///==================================================================================================================
    /// \class Backup
    ///
    /// \brief The purpose of this class is to call the Function which passes the message parameter to the LogWrite function so the message can be written to the log file
    /// Function which is called so the passed logMessage can be written to  the log file. The function will get the current directory of the
    /// service and write to the log file there. If a log.txt file does not already exist, and new file will be created. The message
    /// then be written to the log file in a format which states the time and the message.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    public static class Backup
    {
        //===============================================================================================================
        /// \brief Generate
        /// \details <b>Details</b>
        ///    Function which passes the message parameter to the LogWrite function so the message can be written to the log file.
        /// 
        /// \param message - <b>string</b> - holds the message to be logged
        ///
        /// \return void, none
        //===============================================================================================================
        public static void Generate(string message)
        {
            BackupWriter(message);
        }
    
        //===============================================================================================================
        /// \brief GeReportWriternerate
        /// \details <b>Details</b>
        ///     Function which is called so the passed logMessage can be written to  the log file. The function will get the current directory of the
        ///     service and write to the log file there. If a log.txt file does not already exist, and new file will be created. The message
        ///     then be written to the log file in a format which states the time and the message.
        /// 
        /// \param logMessage - <b>string</b> - holds the message to be logged
        ///
        /// \return void, none
        //===============================================================================================================
        private static void BackupWriter(string logMessage)
        {
            // getting directory location
            string path = TMSData.BackupFileDir;
            string file = TMSData.BackupFileName;

            // creating directory if does not exist
            Directory.CreateDirectory(path);

            // Creating a log file if one does not already exist
            if (!File.Exists(path + "\\" + file))
            {
                // Create a file to write to. Writting message to log.
                using (StreamWriter sw = File.CreateText(path + "\\" + file))
                {
                    sw.Write("\r\nBackup Data Entry : ");
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
                        w.Write("\r\nBackup Data Entry : ");
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

       