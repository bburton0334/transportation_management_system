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
using MySql.Data.MySqlClient;

namespace SQ_TMS
{
    ///==================================================================================================================
    /// \class AlterTMSData
    ///
    /// \brief The purpose of this class is to call the method that takes existing and firstName to validate and check if a 
    ///  previous version of them exist.
    /// \details <b>Details</b>
    ///
    /// It contains private attributes like, connection, server, database, uid, password and port, and a constructor AlterTMSData
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    public partial class AlterTMSData : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;
        //===============================================================================================================
        /// \brief AlterTMSData
        /// \details <b>Details</b>
        ///
        /// Constructor type function.
        /// \param void, none
        ///
        //===============================================================================================================
        public AlterTMSData()
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
        /// \brief btnInitiateCommand_Click
        /// \details <b>Details</b>
        ///
        /// Method that takes existing and firstName to validate and check if a previous version of them exist.
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================
        
 
       
       
        private void btnInitiateCommand_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtCarrier.Text);
            bool isCmdValid = String.IsNullOrWhiteSpace(cmbboxCommand.Text);

            if (!isValid && !isCmdValid)
            {
                string carrier = txtCarrier.Text;
                string command = cmbboxCommand.Text;
        
                    

                if (command == "Add")
                {
                    string query2 = "insert into carriersRateFees (cName, desCity, FTLA, LTLA, FTLRate, LTLRate, refCharge) values ('" + txtCarrier.Text + "',  '" + txtDesCity.Text + "',  '" + Convert.ToInt32(txtFTLARate.Text)+ "', '" + Convert.ToInt32(txtLTLARate.Text) + "',  '" + Convert.ToDecimal(txtFTLRate.Text) + "', '" + Convert.ToDecimal(txtLTLRate.Text) + "', '" + Convert.ToDecimal(txtReeferCharge.Text) + "');";
                    connection.Open();

                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query2;
                    //Assign the connection using Connection
                    cmd.Connection = connection;



                    //Execute query
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else if (command == "Update")
                {

                    string query = "UPDATE carriersRateFees SET refCharge = '" + txtReeferCharge.Text + "';";
                    query += "UPDATE carriersRateFees SET LTLRate = '" + txtCarrier.Text + "';";
                    query += "UPDATE carriersRateFees SET LTLRate = '" + txtDesCity.Text + "';";
                    query += "UPDATE carriersRateFees SET LTLRate = '" + txtFTLARate.Text + "';";
                    query += "UPDATE carriersRateFees SET LTLRate = '" + txtLTLARate.Text + "';";
                    query += "UPDATE carriersRateFees SET LTLRate = '" + txtLTLRate.Text + "';";
                    query += "UPDATE carriersRateFees SET LTLRate = '" + txtFTLRate.Text + "';";
                    connection.Open();

                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;



                    //Execute query
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else if (command == "Delete")
                {
                    string query2 = "Delete from carriersRateFees where cName = '" + txtCarrier.Text + "' ";
                    connection.Open();

                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query2;
                    //Assign the connection using Connection
                    cmd.Connection = connection;



                    //Execute query
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                lblFeedback.Content = "[SUCCESS] Value changed.";
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must data in both textbox and dropdown list.";
            }

            
        }

        
    }
}
