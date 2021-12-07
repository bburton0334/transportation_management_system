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
    /// <summary>
    /// Interaction logic for AcceptNewCustomers.xaml
    /// </summary>
    public partial class AcceptNewCustomers : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;
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

        private void btnAcceptCustomer_Click(object sender, RoutedEventArgs e)
        {
            lblFeedback.Content = "";

            if (gridNewCustomers.SelectedCells.Count > 0)
            {
                try
                {
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


                    string query = "INSERT INTO tblmarketplacecontract (ContractID, ClientName, JobType, Quantity, Origin, Destination, VanType) values('" + newID + "','" + clientName + "','" + jobType + "','" + quantity + "','" + origin + "','" + destination + "','" + vanType + "'); ";

                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    connection.Close();


                    lblFeedback.Content = "[SUCCESS] Client contract has been accepted.";
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                    lblFeedback.Content = "[FAILURE] A Critical error has occured. Check Log.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must select a row to accept client contract.";
            }
        }

        private void gridNewCustomers_Loaded(object sender, RoutedEventArgs e)
        {
            gridNewCustomers.DataContext = LoadNewCustomerData();
        }
    }
}
