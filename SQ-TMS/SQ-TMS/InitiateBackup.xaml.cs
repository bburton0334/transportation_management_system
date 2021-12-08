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
    //===================================================================================================================
    /// \class InitiateBackup
    ///
    /// \brief The purpose of this class is to initiate the backup file for the TMS.
    /// \details <b>Details</b>
    ///
    /// InitiateBackup is used to show the user various buttons which will allow the user to pick weither or not they want
    /// to backup data from all time, or from two weeks ago.
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class InitiateBackup : Page
    {
        public InitiateBackup()
        {
            InitializeComponent();
        }

        //===============================================================================================================
        /// \brief btnGenerateBackup_Click
        /// \details <b>Details</b>
        ///
        ///  This method is called to generate a backup file and store it in C:\TMSTemp\Backup\BackupData.txt
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================
 
        private void btnGenerateBackup_Click(object sender, RoutedEventArgs e)
        {
            // used exactly like logger. Stores in C:\TMSTemp\Backup\BackupData.txt
            Backup.Generate("this is a test");

            lblGenerateBackupFeedback.Content = "[SUCCESS] Backup has been generated.";
        }

        //===============================================================================================================
        /// \brief btnSubmitBackupDir_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to change the direcorty for the back up file 
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================

        private void btnSubmitBackupDir_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = String.IsNullOrWhiteSpace(txtBackupDirectory.Text);

            if (!isValid)
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show("Are you sure you want to change the backup file directory? ", "Change Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    TMSData.BackupFileDir = txtBackupDirectory.Text;
                    lblChangeBackupFeedback.Content = "[SUCCESS] Backup directory has been changed.";
                }
            }
            else
            {
                lblChangeBackupFeedback.Content = "[FAILURE] You must eneter a value into the textbox.";
            }
        }
    }
}
