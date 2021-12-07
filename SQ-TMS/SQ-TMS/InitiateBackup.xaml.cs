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
    /// Interaction logic for InitiateBackup.xaml
    /// </summary>
    public partial class InitiateBackup : Page
    {
        public InitiateBackup()
        {
            InitializeComponent();
        }

        private void btnGenerateBackup_Click(object sender, RoutedEventArgs e)
        {
            // used exactly like logger. Stores in C:\TMSTemp\Backup\BackupData.txt
            Backup.Generate("this is a test");

            lblGenerateBackupFeedback.Content = "[SUCCESS] Backup has been generated.";
        }

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
