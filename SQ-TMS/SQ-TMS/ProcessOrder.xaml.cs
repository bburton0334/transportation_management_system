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
    /// \class ProcessOrder
    ///
    /// \brief The purpose of this class is to hold functions which will deal with initializing the elements needed
    /// in order to process the orders for the TMS system.
    /// \details <b>Details</b>
    ///
    /// ProcessOrder class conatins 2 functions, these functions are used in order to connect to the corrosponding 
    /// database and process the orders from the TMS. 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class ProcessOrder : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        //===============================================================================================================
        /// \brief ProcessOrder function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to connect to the database and process the order. It will do
        /// so with a query. It holds values within the function in order to connect to database.
        /// \param none- <b>void</b> - no parameter
        ///
        /// \see ~ProcessOrder()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: ProcessOrder
        // Description: This method is called to initialize the components for this page and set up a connection to mysql database in order to proccess orders
        // Parameters: 
        // Returns: NOTHING
        // ------------------------------------------------------------
        public ProcessOrder()
        {
            try
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

                string query = "select * from orders";

                MySqlCommand cmd = new MySqlCommand(query);

                cmd.CommandType = CommandType.Text;

                cmd.Connection = connection;

                connection.Open();

                var data_reader = cmd.ExecuteReader();

                if (data_reader.HasRows)
                {
                    int count = data_reader.FieldCount;

                    while (data_reader.Read())
                    {
                        for (var i = 0; i < count; i++)
                        {
                            gridCompletedOrders.Text += data_reader.GetValue(i) + "\t";
                        }
                        gridCompletedOrders.Text += "\n";
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }

        }

        //===============================================================================================================
        /// \brief btnGenerateInvoice_Click function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to connect to the database and process the order. It will do
        /// so with a query. It holds values within the function in order to connect to database. This
        /// function will generate an invoice for the user on the button click.
        /// \param sender - <b>object</b> - elements which represents sender
        /// \param e - <b>RoutedEventsArgs</b> - elements which represents e
        ///
        /// \see ~ProcessOrder()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: btnGenerateInvoice_Click
        // Description: This method is called to generate the invoice that is associated with orders
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        private void btnGenerateInvoice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "select * from orders";

                string temp = "";

                MySqlCommand cmd = new MySqlCommand(query);

                cmd.CommandType = CommandType.Text;

                cmd.Connection = connection;

                connection.Open();

                var data_reader = cmd.ExecuteReader();

                if (data_reader.HasRows)
                {
                    int count = data_reader.FieldCount;
                    while (data_reader.Read())
                    {
                        for (var i = 0; i < count; i++)
                        {
                            temp += data_reader.GetValue(i) + "\t";

                        }

                        temp += "\n";
                    }

                    Invoice.Generate(temp);

                    connection.Close();

                    lblProcessOrderFeedback.Content = "[SUCCESS] Invoice has been generated.";
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                lblProcessOrderFeedback.Content = "[FAILURE] There was an issue creating invoice.";
            }
        }
    }
}
