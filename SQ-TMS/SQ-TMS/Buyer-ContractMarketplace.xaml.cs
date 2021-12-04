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
    /// Interaction logic for Buyer_ContractMarketplace.xaml
    /// </summary>
    public partial class Buyer_ContractMarketplace : Page
    {
        public Buyer_ContractMarketplace()
        {
            InitializeComponent();
        }

        private void btnReviewCustomers_Click(object sender, RoutedEventArgs e)
        {
            frameCMPDetails.Content = new ReviewExistingCustomers();
            frameCMPDetails.Visibility = Visibility.Visible;
        }

        private void btnAcceptNewCustomers_Click(object sender, RoutedEventArgs e)
        {
            frameCMPDetails.Content = new AcceptNewCustomers();
            frameCMPDetails.Visibility = Visibility.Visible;
        }
    }
}
