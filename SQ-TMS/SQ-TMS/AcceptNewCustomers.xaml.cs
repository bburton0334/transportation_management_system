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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class AcceptNewCustomers
    ///
    /// \brief The purpose of this class is to intilizes the connetion attributes, inserting the result of the query that retrieve the data from the database, 
    /// and calling the function that loads the customer's data into the customer's grid
    /// \details <b>Details</b>
    ///  It  contains private attributes like, connection, server, database, uid, password and port
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class AcceptNewCustomers : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;
        
        ///==============================================================================================================
        /// \brief To AcceptNewCustomers
        /// \details <b>Details</b>
        ///
        /// Intilizes the connetion attributes.
        ///
        /// \param void, none
        /// \return void, none
        ///==============================================================================================================

        public AcceptNewCustomers()
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
        ///==============================================================================================================
        /// \brief To LoadNewCustomerData
        /// \details <b>Details</b>
        ///
        ///  Inserts the result of the query that retrieve the data from the database.
        /// \param void, none
        /// 
        /// \return void, none
        ///==============================================================================================================

        private DataTable LoadNewCustomerData()
        {
            DataTable custInfo = new DataTable();

            string conStr = ConfigurationManager.ConnectionStrings["cmp"].ConnectionString;

            using(MySqlConnection con = new MySqlConnection(conStr))
            {
                using(MySqlCommand cmd = new MySqlCommand("SELECT * FROM cmp.Contract", con))
                {
                    con.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    custInfo.Load(dr);
                }
            }

            return custInfo;
        }

        ///============================================================================================================== 
        /// \brief To btnAcceptCustomer_Click
        /// \details <b>Details</b>
        ///
        ///  It takes the inputted customer's data into the database.
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param newAdminFirstName - <b>RotedEventArgs</b> - Event e -> made by xaml
        /// 
        /// \return void, none
        ///==============================================================================================================
    
        private void btnAcceptCustomer_Click(object sender, RoutedEventArgs e)
        {
            lblFeedback.Content = "";

            if (gridNewCustomers.SelectedCells.Count > 0)
            {
                //try
                //{
                    string clientName = null;
                    int jobType = 0;
                    int quantity = 0;
                    string origin = null;
                    string destination = null;
                    int vanType = 0;

                    foreach (DataRowView row in gridNewCustomers.SelectedItems)
                    {
                        System.Data.DataRow MyRow = row.Row;

                        if (!string.IsNullOrWhiteSpace(MyRow[0].ToString()))
                        {
                            clientName = MyRow[0].ToString();
                            jobType = int.Parse(MyRow[1].ToString());
                            quantity = int.Parse(MyRow[2].ToString());
                            origin = MyRow[3].ToString();
                            destination = MyRow[4].ToString();
                            vanType = int.Parse(MyRow[5].ToString());
                        }
                        else
                        {
                            lblFeedback.Content = "[FAILURE] You must select a row that contains data.";
                        }
                    }

                    int newID = 0;
                    if (TMSData.contracts?.Any() != true)
                    {
                        newID = 1;
                    }
                    else
                    {
                        int maxID = TMSData.contracts.Max(t => t.ContractID);
                        newID = maxID + 1;
                    }


                    string query = "INSERT INTO tblmarketplacecontract (ClientName, JobType, Quantity, Origin, Destination, VanType) values('" + clientName + "','" + jobType + "','" + quantity + "','" + origin + "','" + destination + "','" + vanType + "'); ";

                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    connection.Close();


                    lblFeedback.Content = "[SUCCESS] Client contract has been accepted.";
                //}
                //catch (Exception ex)
                //{
                //    Logger.Log(ex.Message);
                //    lblFeedback.Content = "[FAILURE] A Critical error has occured. Check Log.";
                //}
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must select a row to accept client contract.";
            }
        }

        ///============================================================================================================== 
        /// \brief To gridNewCustomers_Loaded
        /// \details <b>Details</b>
        ///
        ///  it calls the function that loads the customer's data into the customer's grid.
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param newAdminFirstName - <b>RotedEventArgs</b> - Event e -> made by xaml
        /// 
        /// \return void, none
        ///==============================================================================================================
    
        private void gridNewCustomers_Loaded(object sender, RoutedEventArgs e)
        {
            gridNewCustomers.DataContext = LoadNewCustomerData();
        }
    }
}
