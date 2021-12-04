using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace SQ_TMS
{
    /// <summary>
    /// Interaction logic for AcceptNewCustomers.xaml
    /// </summary>
    public partial class AcceptNewCustomers : Page
    {
        List<Contract> newContract = new List<Contract>();

        public AcceptNewCustomers()
        {
            InitializeComponent();
            // LOADNEWCUSTOMERDATA() WOULD BE CALLED HERE
        }

        private bool LoadNewCustomerData()
        {
            bool dataLoaded = false;

            SqlDataReader dr = null;
            try
            {
                // HERE IS WHERE THE YOU WOULD CONNECT TO CONTRACT MARKET PLACE SQL DATABASE TO REVIEVE DATA

                // STORE DATA INTO LINE 24: LIST OF CONTRACT

                // while reading, instert data into list

                newContract.Add(new Contract()
                {
                    ClientName = dr.GetString(dr.GetOrdinal("CLIENT_NAME")),
                    JobType = dr.GetString(dr.GetOrdinal("JOB_TYPE")),
                    Quantity = dr.GetInt32(dr.GetOrdinal("QUANTITY")),
                    Origin = dr.GetString(dr.GetOrdinal("ORIGIN")),
                    Destination = dr.GetString(dr.GetOrdinal("DESTINATION")),
                    VanType = dr.GetString(dr.GetOrdinal("VAN_TYPE"))
                });

                // AFTERWARDS FILL DataGrid WITH DATABASE DATA
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // CALL TO LOGGER
            }

            return dataLoaded;
        }

        private void btnAcceptCustomer_Click(object sender, RoutedEventArgs e)
        {
            string customerID = txtCustomerName.Text;

            
        }
    }
}
