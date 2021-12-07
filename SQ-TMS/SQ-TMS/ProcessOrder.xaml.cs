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
    /// <summary>
    /// Interaction logic for ProcessOrder.xaml
    /// </summary>
    public partial class ProcessOrder : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

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
