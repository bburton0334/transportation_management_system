using System;
using System.Collections.Generic;
using System.IO;
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
    ///==================================================================================================================
    /// \class Configuration
    ///
    /// \brief The purpose of this class is to call the method that allows the user to change the log file name, and to
    ///  to allow the user to change the log file directory 
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    public partial class Configuration : Page
    {
        public Configuration()
        {
            InitializeComponent();
        }
        //===============================================================================================================
        /// \brief btnSubmitLogFile_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to allow the user to change the log file name
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================
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

        //===============================================================================================================
        /// \brief btnSubmitLogDir_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to allow the user to change the log file directory
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================
        
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

            string dir = txtLogFileDirectory.Text;
            string fileName = txtLogFileName.Text;

            File.Create(dir + fileName);
        }
    }
}
