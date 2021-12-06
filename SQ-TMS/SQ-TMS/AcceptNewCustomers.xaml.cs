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
        List<Contract> newContract = new List<Contract>();

        public AcceptNewCustomers()
        {
            InitializeComponent();
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
            string clientName = null;
            int jobType = 0;
            int quantity = 0;
            string origin = null;
            string destination = null;
            int vanType = 0;

            foreach (DataRowView row in gridNewCustomers.SelectedItems)
            {
                System.Data.DataRow MyRow = row.Row;
                clientName = MyRow[0].ToString();
                jobType = int.Parse(MyRow[1].ToString());
                quantity = int.Parse(MyRow[2].ToString());
                origin = MyRow[3].ToString();
                destination = MyRow[4].ToString();
                vanType = int.Parse(MyRow[5].ToString());
            }

            // creating new contract object
            TMSData.contracts.Add(new Contract()
            {
                ClientName = clientName,
                JobType = jobType,
                Quantity = quantity,
                Origin = origin,
                Destination = destination,
                VanType = vanType
            });

        }

        private void gridNewCustomers_Loaded(object sender, RoutedEventArgs e)
        {
            gridNewCustomers.DataContext = LoadNewCustomerData();
        }
    }
}
