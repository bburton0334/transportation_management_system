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

namespace SQ_TMS
{
    /// <summary>
    /// Interaction logic for BuyerPortal.xaml
    /// </summary>
    /// 

    public partial class BuyerPortal : Page
    {
        bool isCMPVisible = false;
        bool isInitiatingOrdersVisible = false;
        bool isProcessOrderVisible = false;

        public BuyerPortal()
        {
            InitializeComponent();

        }

        private void btnContractMarketplace_Click(object sender, RoutedEventArgs e)
        {
            frameContractMarketplace.Visibility = Visibility.Hidden;

            if (isCMPVisible == false)
            {
                frameContractMarketplace.Content = new Buyer_ContractMarketplace();
                frameContractMarketplace.Visibility = Visibility.Visible;
                isCMPVisible = true;
            }
            else
            {
                frameContractMarketplace.Visibility = Visibility.Hidden;
                isCMPVisible = false;
            }
        }

        private void btnInitiateOrder_Click(object sender, RoutedEventArgs e)
        {
            frameContractMarketplace.Visibility = Visibility.Hidden;

            if (isInitiatingOrdersVisible == false)
            {
                frameContractMarketplace.Content = new InitiateOrder();
                frameContractMarketplace.Visibility = Visibility.Visible;
                isInitiatingOrdersVisible = true;
            }
            else
            {
                frameContractMarketplace.Visibility = Visibility.Hidden;
                isInitiatingOrdersVisible = false;
            }
        }

        private void btnProcessInvoice_Click(object sender, RoutedEventArgs e)
        {
            // showing or hiding process invoice page
            frameContractMarketplace.Visibility = Visibility.Hidden;

            if (isProcessOrderVisible == false)
            {
                frameContractMarketplace.Content = new ProcessOrder();
                frameContractMarketplace.Visibility = Visibility.Visible;
                isProcessOrderVisible = true;
            }
            else
            {
                frameContractMarketplace.Visibility = Visibility.Hidden;
                isProcessOrderVisible = false;
            }


            //string query = "INSERT INTO orders (OrderDate, ShipAddress, ShipCity) VALUES('" + orderDate + "', '" + ShipAddress + "', '" + ShipCity + "')";

            //if (this.OpenConnection() == true)
            //{
            //    //create mysql command
            //    MySqlCommand cmd = new MySqlCommand();
            //    //Assign the query using CommandText
            //    cmd.CommandText = query;
            //    //Assign the connection using Connection
            //    cmd.Connection = connection;

            //    //Execute query
            //    cmd.ExecuteNonQuery();

            //    //close connection
            //    this.CloseConnection();
            //}

        }
    }
}
