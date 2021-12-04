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
    /// Interaction logic for ReviewExistingCustomers.xaml
    /// </summary>
    public partial class ReviewExistingCustomers : Page
    {
        public ReviewExistingCustomers()
        {
            InitializeComponent();
            // CALL FUNCTION
        }

        private bool LoadeExistingCustomerData()
        {
            bool dataLoaded = false;

            try
            {
                // HERE IS WHERE THE YOU WOULD CONNECT TO DATABASE HOLDING EXISTING CUTSOMER DATA


                // AFTERWARDS FILL DataGrid WITH DATABASE DATA
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // CALL TO LOGGER
            }

            return dataLoaded;
        }
    }
}
