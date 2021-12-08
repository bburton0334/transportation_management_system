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
    ///==================================================================================================================
    /// \class  Buyer_ContractMarketplace
    ///
    /// \brief The purpose of this class is to call the function which  transfers to the page that //////// revews the customers, transfers to the page that wllows to accept new customers.
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    public partial class Buyer_ContractMarketplace : Page
    {
        public Buyer_ContractMarketplace()
        {
            InitializeComponent();
        }
        //===============================================================================================================
        /// \brief btnReviewCustomers_Click
        /// \details <b>Details</b>
        ///     transfers to the page that revews the customers.
        /// 
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RoutedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================

        private void btnReviewCustomers_Click(object sender, RoutedEventArgs e)
        {
            frameCMPDetails.Content = new ReviewExistingCustomers();
            frameCMPDetails.Visibility = Visibility.Visible;
        }
        //===============================================================================================================
        /// \brief btnAcceptNewCustomers_Click
        /// \details <b>Details</b>
        ///     transfers to the page that wllows to accept new customers.
        /// 
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RoutedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================
        private void btnAcceptNewCustomers_Click(object sender, RoutedEventArgs e)
        {
            frameCMPDetails.Content = new AcceptNewCustomers();
            frameCMPDetails.Visibility = Visibility.Visible;
        }
    }
}
