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

namespace SQ_TMS
{
    /// <summary>
    /// Interaction logic for AlterTMSData.xaml
    /// </summary>
    public partial class AlterTMSData : Page
    {
        public AlterTMSData()
        {
            InitializeComponent();
        }

        private void btnSubmitLTLRate_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtLTLRate.Text);

            if (!isValid)
            {
                try
                {
                    TMSData.LTLRate = Double.Parse(txtLTLRate.Text);

                    // do something with new rate here.


                    lblFeedback.Content = "[SUCCESS] Value changed.";
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                    lblFeedback.Content = "[FAILURE] MUST be numeric and double.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }

        private void btnSubmitFTLRate_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtFTLRate.Text);

            if (!isValid)
            {
                try
                {
                    TMSData.FTLRate = Double.Parse(txtFTLRate.Text);

                    // do something with new rate here

                    lblFeedback.Content = "[SUCCESS] Value changed.";
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                    lblFeedback.Content = "[FAILURE] MUST be numeric and double.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }

        private void btnSubmitReeferCharge_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtReeferCharge.Text);

            if (!isValid)
            {
                try
                {
                    TMSData.ReeferCharge = int.Parse(txtReeferCharge.Text);

                    // do something with new rate here

                    lblFeedback.Content = "[SUCCESS] Value changed.";
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                    lblFeedback.Content = "[FAILURE] MUST be numeric.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }

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

                }
                else if (command == "Update")
                {

                }
                else if (command == "Delete")
                {

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
