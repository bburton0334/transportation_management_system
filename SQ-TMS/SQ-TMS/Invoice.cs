using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class Invoice
    ///
    /// \brief The purpose of this class is to hold functions which allow the user to log to an invoice text file.
    /// \details <b>Details</b>
    ///
    /// Invoice class conatins 2 functions, one which takes the string as a parameter, and onother whic writes the invoice
    /// to a text file in a corrosponding directory.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    class Invoice
    {
        //===============================================================================================================
        /// \brief Generate
        /// \details <b>Details</b>
        ///
        /// Function which passes the message parameter to the LogWrite function so the message can be written to the log file.
        /// \param message - <b>string</b> - holds the message to be logged
        ///
        /// \return void, none
        //===============================================================================================================

        public static void Generate(string message)
        {
            InvoiceWriter(message);
        }

        //===============================================================================================================
        /// \brief InvoiceWriter
        /// \details <b>Details</b>
        ///
        /// Function which is called so the passed logMessage can be written to the log file. The function will get the current directory of the
        /// service and write to the log file there. If a log.txt file does not already exist, and new file will be created. The message
        /// then be written to the log file in a format which states the timeand the message.
        /// \param InvoiceMessage - <b>string</b> - holds the message to be logged
        ///
        /// \return void, none
        //===============================================================================================================

        public static void InvoiceWriter(string InvoiceMessage)
        {
            // getting directory location
            string path = TMSData.InvoiceFilePath;
            string file = TMSData.InvoiceFileName;

            // creating directory if does not exist
            Directory.CreateDirectory(path);

            // Creating a log file if one does not already exist
            if (!File.Exists(path + "\\" + file))
            {
                // Create a file to write to. Writting message to log.
                using (StreamWriter sw = File.CreateText(path + "\\" + file))
                {
                    sw.Write("\r\nInvoice Entry : ");
                    sw.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                    sw.WriteLine("  :");
                    sw.WriteLine("  :{0}", InvoiceMessage);
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
                        w.Write("\r\nInvoice Entry : ");
                        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                        w.WriteLine("  :");
                        w.WriteLine("  :{0}", InvoiceMessage);
                        w.WriteLine("-------------------------------");
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log("Error: Exception - " + ex.ToString());
                }
            }
        }
    }
}
