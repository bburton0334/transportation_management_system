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
    /// \class ActiveOrders 
    ///
    /// \brief The purpose of this class is to intilizes the connection attributes and reveal the active customers from the database.
    /// \details <b>Details</b>
    ///  It contains private attributes like, connection, server, database, uid, password and port
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class ActiveOrders : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;
  
        ///==============================================================================================================
        /// \brief To Initialize ActiveOrder
        /// \details <b>Details</b>
        ///
        /// This function intilizes the connection attributes and reveal the active customers from the database.
        /// \param void, none
        /// \return void, none
        ///
        ///==============================================================================================================

        public ActiveOrders()
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
            string yes = "yes";
            string query = "select * from orders where IS_ACTIVE='" + yes + "';";

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
                        gridActiveOrders.Text += data_reader.GetValue(i) + "\t";
                    }
                    gridActiveOrders.Text += "\n";
                }

            }
        }
    }
}
