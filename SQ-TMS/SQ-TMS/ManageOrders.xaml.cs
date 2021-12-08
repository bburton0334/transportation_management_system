using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace SQ_TMS
{
     //===================================================================================================================
    /// \class ManageOrders
    ///
    /// \brief The purpose of this class is to hold functions which will deal with initializing the elements needed
    /// in order to manage the orders for the TMS system.
    /// \details <b>Details</b>
    ///
    /// ManageOrder class conatins 2 functions, these functions are used in order to connect to the corrosponding 
    /// database and process the orders from the TMS. 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class ManageOrders : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //===============================================================================================================
        /// \brief ManageOrders function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// This method is called to initialize the components of this page and set up the connection credentials to mysql database 
        /// \param none - <b>void</b> - no param
        ///
        /// \see ~ManageOrders()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: ManageOrders
        // Description: This method is called to initialize the components of this page and set up the connection credentials to mysql database 
        // Parameters: 
        // Returns: NOTHING
        // ------------------------------------------------------------
        public ManageOrders()
        {
            InitializeComponent();
            server = "localhost";
            database = "tmsdata";
            uid = "root";
            password = "Dina@1989";
            port = "3306";

            string connectionString;

            connectionString = "SERVER=" + server + ";" + "port=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //===============================================================================================================
        /// \brief btnSubmitOrder_Click function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// This method is called to submit any order by the buyer so the palnner can approve it 
        /// \param sender - <b>object</b> - deals with object
        /// \param e - <b>RoutedEventsArgs</b> - deals with object
        ///
        /// \see ~ManageOrders()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: btnSubmitOrder_Click
        // Description: This method is called to submit any order by the buyer so the palnner can approve it 
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        private void btnSubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            bool isValidID = String.IsNullOrWhiteSpace(txtShipmentID.Text);
            bool isValidTrips = String.IsNullOrWhiteSpace(txtTrips.Text);

            if (!isValidID &&  !isValidTrips)
            {
                try
                {
                    int numTrips = int.Parse(txtTrips.Text);

                    int ID = int.Parse(txtShipmentID.Text);

                    string carrier = txtShipmentID.Text.ToString();

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

            string query = "INSERT INTO orders (NumberOfTrips, ShipmentID) values('" + txtTrips.Text + "','" + txtShipmentID.Text + "'); ";

            MySqlCommand cmd = new MySqlCommand(query);

            cmd.CommandType = CommandType.Text;

            cmd.Connection = connection;

            connection.Open();

            cmd.CommandText = query;

            cmd.Connection = connection;

            cmd.ExecuteNonQuery();

            connection.Close();

        }
    }
}
