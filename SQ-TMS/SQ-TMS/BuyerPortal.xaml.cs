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
    //===================================================================================================================
    /// \class BuyerPortal
    ///
    /// \brief The purpose of this class is to call function that
    /// \details <b>Details</b>
    ///  The purpose of this class is to call the function which transfers to the page that revews the customers and 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class BuyerPortal : Page
    {
        bool isCMPVisible = false;
        bool isInitiatingOrdersVisible = false;
        bool isProcessOrderVisible = false;
        public BuyerPortal()
        {
            InitializeComponent();

        }
        //===============================================================================================================
        /// \brief btnContractMarketplace_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to tranist to the window where the buyer could review and/or accept new customers
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        ///
        /// \see ~Buyer()
        //===============================================================================================================
    
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

        //===============================================================================================================
        /// \brief btnInitiateOrder_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to create a new order
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        ///
        /// \see ~Buyer()
        //===============================================================================================================
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

        //===============================================================================================================
        /// \brief btnProcessInvoice_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to proccess the invoice that is associated with the new order placed
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        ///
        /// \see ~Buyer()
        //===============================================================================================================
        
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
        }
    }
}
