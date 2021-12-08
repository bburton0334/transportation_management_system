using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
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
    /// \class ReviewExistingCustomers
    ///
    /// \brief The purpose of this class is to hold functions which are used in order to connect to the database so
    /// the the user can access review the exising customers within the database for TMS.
    /// \details <b>Details</b>
    ///
    /// StartLoadIn class conatins multiple functions, mainly used in order to deal with functions surronding the database.
    /// This class will connect to the database in order to retrieve information and load it within a text block for the
    /// user to view and observe. This class will open a connection to the database to do so.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class ReviewExistingCustomers : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;


        //==============================================================================================================
        /// \brief To Initialize the ReviewExistingCustomer Page
        /// \details <b>Details</b>
        ///
        /// This function initializes the elements within the ReviewExistingCustomers page. This function
        /// will store the elements needed in order to connect to certain databases. It will start a 
        /// connection in order to fill the table in with existing customers.
        /// \param none <b>Void</b> - no parameters
        ///
        /// \return void, none
        //==============================================================================================================

        // ------------------------------------------------------------
        // Function: btnGenerateInvoice_Click
        // Description: This method is called to generate the invoice that is associated with orders
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        public ReviewExistingCustomers()
        {
            InitializeComponent();

            server = "localhost";
            database = "tmsdata";
            uid = "root";
            password = "Dina@1989";
            port = "3306";

            string connectionString;

            connectionString = "SERVER=" + server + ";" + "port=" +port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            initiateContractsForBuyer();
       
        }

       

        //===============================================================================================================
        /// \brief updateColumForAdmin function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to connect to the database and update the colum for the admin. It will do
        /// so with a query.
        /// \param none- <b>void</b> - no parameter
        ///
        /// \see ~ReviewExistingCustomers()
        //===============================================================================================================
        private void updateColumForAdmin()
        {
            string columntoUpdate = "";

            string TextToUpdate = "";

            string query = "UPDATE rate_fee SET '" + columntoUpdate + "' '=' '" + TextToUpdate + "'";

            connection.Open();
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            connection.Close();
            
        }

        //===============================================================================================================
        /// \brief revewLogFiles 
        /// \details <b>Details</b>
        ///
        /// This method is called to enable the Admin to review log files
        /// \param none - <b>void</b> - no param
        ///
        /// \return void, none
        /// \see ~ReviewExistingCustomers()
        //===============================================================================================================
    
        private void revewLogFiles()
        {
            string currentPath = Directory.GetCurrentDirectory();

            Process.Start(currentPath);
        }


        //===============================================================================================================
        /// \brief BuyerInsertnewOrder 
        /// \details <b>Details</b>
        ///
        /// This method is called to create a new order
        /// \param none - <b>void</b> - no param
        ///
        /// \return void, none
        /// \see ~ReviewExistingCustomers()
        //===============================================================================================================
    
        private void BuyerInsertnewOrder()
        {
            string orderDate = "";
            string ShipAddress = "";
            string ShipCity = "";

            string query = "INSERT INTO orders (OrderDate, ShipAddress, ShipCity) VALUES('" + orderDate + "', '" + ShipAddress + "', '" + ShipCity + "')";

            connection.Open();
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            connection.Close();
            
        }


        //===============================================================================================================
        /// \brief selectRelevantCitiesforBuyer 
        /// \details <b>Details</b>
        ///
        /// This method is called to enable the buyer to select relevent cities for the order
        /// \param none - <b>void</b> - no param
        ///
        /// \return void, none
        /// \see ~ReviewExistingCustomers()
        //===============================================================================================================
    
        private void selectRelevantCitiesforBuyer()
        {
            string query = "select desCity, ShipCity from carriersRateFees, orders";

            connection.Open();
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            connection.Close();
            
        }

 
        //==============================================================================================================
        /// \brief  initiateContractsForBuyer function
        /// \details <b>Details</b>
        ///
        ///  This method is called to initiate contracts for buyers
        /// \param none - <b>void</b> - no param
        ///
        /// \return void, none
        //==============================================================================================================

        // ------------------------------------------------------------
        // Function: initiateContractsForBuyer
        // Description: This method is called to initiate contracts for buyers
        // Parameters: 
        // Returns: NOTHING
        // ------------------------------------------------------------
        public void initiateContractsForBuyer()
        {
            try
            {
                string query = "select * from tblmarketPlaceContract";

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
                            gridExistingCustomers.Text += data_reader.GetValue(i) + "\t";
                        }
                        gridExistingCustomers.Text += "\n";
                    }


                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }
        }


        //==============================================================================================================
        /// \brief  LoadeExistingCustomerData
        /// \details <b>Details</b>
        ///
        /// This method is called to to load the data for existing customers
        /// \param none - <b>void</b> - no param
        ///
        /// \return void, none
        //==============================================================================================================
        // ------------------------------------------------------------
        // Function: LoadeExistingCustomerData
        // Description: This method is called to load the data for existing customers
        // Parameters: 
        // Returns: NOTHING
        // ------------------------------------------------------------
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