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
    /// \class InitiateOrder
    ///
    /// \brief The purpose of this class is to hold functions which deal with the initialize order component of the TMS.
    /// \details <b>Details</b>
    ///
    /// InitiateOrder class conatins 2 functions, one which validates the input and city choice by the user. The other
    /// function is used to initilize the elements found within the page.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class InitiateOrder : Page
    {
        string customerName = null;
        string cityChoice = null;
        //===============================================================================================================
        /// \brief InitiateOrder
        /// \details <b>Details</b>
        ///
        /// This method is called to initialize the components of this page
        /// \param void, none
        ///
        /// \return void, none
        //===============================================================================================================
    
        public InitiateOrder()
        {
            InitializeComponent();
        }

        
        //===============================================================================================================
        /// \brief btnInitiateOrder_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to start an order 
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================

        private void btnInitiateOrder_Click(object sender, RoutedEventArgs e)
        {
            IOFeedback.Content = "";

            customerName = txtCustomerNameInitiate.Text;

            cityChoice = cmbboxCities.ToString();

            if (customerName == "" || cityChoice == "")
            {
                IOFeedback.Content = "[FAILURE]  YOU MUST SELECT CITY AND ENTER CUSTOMER NAME";

                TMSData.shipments.Add(new Shipment()
                {
                    // currently, we only have 3 fields to add. later, once planner accepts, more data can be added to this new object of Shipment
                    ShipmentID = customerName,
                    ClientName = customerName,
                    Carrier_city = cityChoice
                });
            }
        }
    }
}
