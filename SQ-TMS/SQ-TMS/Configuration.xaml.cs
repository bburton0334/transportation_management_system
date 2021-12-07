using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQ_TMS
{
    /// <summary>
    /// Interaction logic for Configuration.xaml
    /// </summary>
    public partial class Configuration : Page
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void btnSubmitInvFile_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtInvoiceFileName.Text);

            if (isValid == false)
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Are you sure you want to change the invoice file name? ", "Change Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    TMSData.InvoiceFileName = txtInvoiceFileName.Text;
                    lblFeedback.Content = "[SUCCESS] Value changed.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }

        private void btnSubmitInvDir_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtInvoiceFileDirectory.Text);

            if (!isValid)
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Are you sure you want to change the invoice file name? ", "Change Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    TMSData.InvoiceFilePath = txtInvoiceFileDirectory.Text;
                    lblFeedback.Content = "[SUCCESS] Value changed.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }

        private void btnSubmitLogFile_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtLogFileName.Text);

            if (!isValid)
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Are you sure you want to change the Log file name? ", "Change Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    TMSData.LogFileName = txtLogFileName.Text;
                    lblFeedback.Content = "[SUCCESS] Value changed.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }

        private void btnSubmitLogDir_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtLogFileDirectory.Text);

            if (!isValid)
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Are you sure you want to change the Log file directory? ", "Change Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    TMSData.logFilePath = txtLogFileDirectory.Text;
                    lblFeedback.Content = "[SUCCESS] Value changed.";
                }
            }
            else
            {
                lblFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }
    }
}
