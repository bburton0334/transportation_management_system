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
    /// Interaction logic for ManageOrders.xaml
    /// </summary>
    public partial class ManageOrders : Page
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void btnSubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            bool isValidID = String.IsNullOrWhiteSpace(txtShipmentID.Text);
            bool isValidCarr = String.IsNullOrWhiteSpace(txtCarriers.Text);
            bool isValidTrips = String.IsNullOrWhiteSpace(txtTrips.Text);

            if (!isValidID && !isValidCarr && !isValidTrips)
            {
                try
                {
                    int numTrips = int.Parse(txtTrips.Text);
                    int ID = int.Parse(txtShipmentID.Text);
                    string carrier = txtShipmentID.Text.ToString();

                    // do something with values

                    lblFeedback.Content = "[SUCCESS] Order has been approved by Planner.";

                }
                catch
                {
                    lblFeedback.Content = "[FAILURE] textbox values must be in correct format.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] All textboxes must have values.";
            }
        }
    }
}
