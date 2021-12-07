using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    class Invoice
    {
        //============================================================================
        // FUNCTION         : Generate
        // DESCRIPTION      :
        //      Function which passes the message parameter to the LogWrite function
        //      so the message can be written to the log file.
        // PARAMETERS       : message (holds the message to be logged)
        // RETURNS          : none
        //============================================================================
        public static void Generate(string message)
        {
            InvoiceWriter(message);
        }

        //============================================================================
        // FUNCTION         : InvoiceWriter
        // DESCRIPTION      :
        //      Function which is called so the passed logMessage can be written to 
        //      the log file. The function will get the current directory of the
        //      service and write to the log file there. If a log.txt file does
        //      not already exist, and new file will be created. The message
        //      then be written to the log file in a format which states the time
        //      and the message.
        // PARAMETERS       : logMessage (holds the message to be logged)
        // RETURNS          : none
        //============================================================================
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
