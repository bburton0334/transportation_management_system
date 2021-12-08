using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class Contracts
    ///
    /// \brief The purpose of this class is to hold functions which allow the user to log to a text file.
    /// \details <b>Details</b>
    ///
    /// Logger class conatins 2 functions, one which takes the string as a parameter, and onother whic writes the log
    /// to a text file in a corrosponding directory.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public class Contract
    {
        public int ContractID { get; set; }
        public string ClientName { get; set; }
        public int JobType { get; set; }
        public int Quantity { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int VanType { get; set; }
    }
}
