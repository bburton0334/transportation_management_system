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
    /// Interaction logic for InitiateOrder.xaml
    /// </summary>
    public partial class InitiateOrder : Page
    {
        string customerName = null;
        string cityChoice = null;


        public InitiateOrder()
        {
            InitializeComponent();
        }

        private void btnInitiateOrder_Click(object sender, RoutedEventArgs e)
        {
            IOFeedback.Content = "";

            customerName = txtCustomerNameInitiate.Text;
            cityChoice = cmbboxCities.ToString();

            if (customerName == "" || cityChoice == "")
            {
                IOFeedback.Content = "[FAILURE]  YOU MUST SELECT CITY AND ENTER CUSTOMER NAME";

                // CHECK IF NAME CONTAINS INVALID CHARACTERS (NUMBERS, ECT)

                // CREATE "Shipment" OBJECT WITH "Contract" DETAILS

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
