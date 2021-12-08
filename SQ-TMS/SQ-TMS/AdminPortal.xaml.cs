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
    ///==================================================================================================================
    /// \class AdminPortal
    ///
    /// \brief The purpose of this class is to, call the function that loads the customer's data into the customer's grid, to displays the log file's content,
    ///  it allows the admin to initiate a backup job. 
    /// \details <b>Details</b>
    ///  It contains bool type vars like,isConfigVisible, isReviewVisible, isBackupVisible and isAlterDataVisibled
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    ///==================================================================================================================
    public partial class AdminPortal : Page
    {
        bool isConfigVisible = false;
        bool isReviewVisible = false;
        bool isBackupVisible = false;
        bool isAlterDataVisible = false;

        public AdminPortal()
        {
            InitializeComponent();
        }

        ///============================================================================================================== 
        /// \brief To btnConfiguration_Click
        /// \details <b>Details</b>
        ///
        ///  it calls the function that loads the customer's data into the customer's grid.
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param newAdminFirstName - <b>RotedEventArgs</b> - Event e -> made by xaml
        /// 
        /// \return void, none
        ///==============================================================================================================
    
        private void btnConfiguration_Click(object sender, RoutedEventArgs e)
        {
            frameAdminPortal.Visibility = Visibility.Hidden;

            if (isConfigVisible == false)
            {
                frameAdminPortal.Content = new Configuration();
                frameAdminPortal.Visibility = Visibility.Visible;
                isConfigVisible = true;
            }
            else
            {
                frameAdminPortal.Visibility = Visibility.Hidden;
                isConfigVisible = false;
            }
        }

        ///============================================================================================================== 
        /// \brief To btnReviewLog_Click
        /// \details <b>Details</b>
        ///
        ///  it displays the log file's content.
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param newAdminFirstName - <b>RotedEventArgs</b> - Event e -> made by xaml
        /// 
        /// \return void, none
        ///==============================================================================================================
    
        private void btnReviewLog_Click(object sender, RoutedEventArgs e)
        {
            frameAdminPortal.Visibility = Visibility.Hidden;

            if (isReviewVisible == false)
            {
                frameAdminPortal.Content = new ReviewLogFiles();
                frameAdminPortal.Visibility = Visibility.Visible;
                isReviewVisible = true;
            }
            else
            {
                frameAdminPortal.Visibility = Visibility.Hidden;
                isReviewVisible = false;
            }
        }
        ///============================================================================================================== 
        /// \brief To btnAlterData_Click
        /// \details <b>Details</b>
        ///
        ///  it allows to edit the database
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param newAdminFirstName - <b>RotedEventArgs</b> - Event e -> made by xaml
        /// 
        /// \return void, none
        ///==============================================================================================================
    
        private void btnAlterData_Click(object sender, RoutedEventArgs e)
        {
            frameAdminPortal.Visibility = Visibility.Hidden;

            if (isAlterDataVisible == false)
            {
                frameAdminPortal.Content = new AlterTMSData();
                frameAdminPortal.Visibility = Visibility.Visible;
                isAlterDataVisible = true;
            }
            else
            {
                frameAdminPortal.Visibility = Visibility.Hidden;
                isAlterDataVisible = false;
            }
        }
        
        ///============================================================================================================== 
        /// \brief To btnBackup_Click
        /// \details <b>Details</b>
        ///
        ///  it allows the admin to initiate a backup job. 
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param newAdminFirstName - <b>RotedEventArgs</b> - Event e -> made by xaml
        /// 
        /// \return void, none
        ///==============================================================================================================

        private void btnBackup_Click(object sender, RoutedEventArgs e)
        {
            frameAdminPortal.Visibility = Visibility.Hidden;

            if (isBackupVisible == false)
            {
                frameAdminPortal.Content = new InitiateBackup();
                frameAdminPortal.Visibility = Visibility.Visible;
                isBackupVisible = true;
            }
            else
            {
                frameAdminPortal.Visibility = Visibility.Hidden;
                isBackupVisible = false;
            }
        }
    }
}
