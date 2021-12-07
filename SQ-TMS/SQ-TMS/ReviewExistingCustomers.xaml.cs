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
    /// <summary>
    /// Interaction logic for ReviewExistingCustomers.xaml
    /// </summary>
    public partial class ReviewExistingCustomers : Page
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;



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
            // CALL FUNCTION
        }





        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;



                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }




        private void accessConfigInfo()
        {
            //show.Text = connection;
        }
        private void updateColumForAdmin()
        {
            string columntoUpdate = "";
            string TextToUpdate = "";



            string query = "UPDATE rate_fee SET '" + columntoUpdate + "' '=' '" + TextToUpdate + "'";
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;



                //Execute query
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }
        }



        private void revewLogFiles()
        {
            string currentPath = Directory.GetCurrentDirectory();
            Process.Start(currentPath);
        }




        private void BuyerInsertnewOrder()
        {
            string orderDate = "";
            string ShipAddress = "";
            string ShipCity = "";



            string query = "INSERT INTO orders (OrderDate, ShipAddress, ShipCity) VALUES('" + orderDate + "', '" + ShipAddress + "', '" + ShipCity + "')";



            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;



                //Execute query
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }



        }




        private void selectRelevantCitiesforBuyer()
        {
            string query = "select desCity, ShipCity from carriersRateFees, orders";
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;



                //Execute query
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }




        }




        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        //Insert statement
        public void Insert()
        {
            string aID = "", aF = "", aL = "", aU = "";



            string query = "INSERT INTO tbladmin (adminID, adminF, adminL, updateID) VALUES('" + aID + "', '" + aF + "', '" + aL + "', '" + aU + "')";



            //open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;



                //Execute query
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }
        }



        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";



            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;



                //Execute query
                cmd.ExecuteNonQuery();



                //close connection
                this.CloseConnection();
            }
        }



        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";



            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }



        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";



            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();



            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();



                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }



                //close Data Reader
                dataReader.Close();



                //close Connection
                this.CloseConnection();



                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }



        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;



            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);



                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");



                //close Connection
                this.CloseConnection();



                return Count;
            }
            else
            {
                return Count;
            }
        }



        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;



                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);




                ProcessStartInfo psi = new ProcessStartInfo();



                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;



                Process process = Process.Start(psi);



                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!\nError: " + ex.Message);
            }
        }



        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();




                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;




                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!\nError: " + ex.Message);
            }
        }



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