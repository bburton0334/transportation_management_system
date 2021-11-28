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
    class Buyer
    {
        public int Buyer_ID { get; set; }
        public string Buyer_firstName { get; set; }
        public string Buyer_lastName { get; set; }
        public string Buyer_email { get; set; }
        public int Buyer_phoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newBuyerID"></param>
        /// <param name="newBuyerFirstName"></param>
        /// <param name="newBuyerLastName"></param>
        /// <param name="newBuyerEmail"></param>
        /// <param name="newBuyerPhoneNumber"></param>
        public Buyer (int newBuyerID, string newBuyerFirstName, string newBuyerLastName, string newBuyerEmail, int newBuyerPhoneNumber)
        {
            Buyer_ID = newBuyerID;
            Buyer_firstName = newBuyerFirstName;
            Buyer_lastName = newBuyerLastName;
            Buyer_email = newBuyerEmail;
            Buyer_phoneNumber = newBuyerPhoneNumber;
        }
    }
}
