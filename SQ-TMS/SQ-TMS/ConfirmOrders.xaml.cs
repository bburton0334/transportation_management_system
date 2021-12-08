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
    /// \class ConfirmOrders
    ///
    /// \brief The purpose of this class is to allow the user to mark the order as completed
    /// \details <b>Details</b>
    ///
    /// This class contains various functions which allow the user to connect to the database in order to execute the
    /// appropriate queries relating to confirming orders.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class ConfirmOrders : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public ConfirmOrders()
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
        /// \brief btnCompleteOrder_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to allow the user to mark the order as completed
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================
 
        private void btnCompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtShipmentID.Text);

            if (!isValid)
            {
                lblFeedback.Content = "[SUCCESS] Order has been confirmed.";
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
            string yes = "yes";
            string query = "update orders set IS_ACTIVE = '"+yes+"' where ShipmentID = '"+ txtShipmentID.Text+ "'";
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
