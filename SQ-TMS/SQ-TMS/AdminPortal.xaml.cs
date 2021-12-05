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
    /// Interaction logic for AdminPortal.xaml
    /// </summary>
    public partial class AdminPortal : Page
    {
        bool isConfigVisible = false;
        bool isReviewVisible = false;

        public AdminPortal()
        {
            InitializeComponent();
        }

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

        private void btnAlterData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("havent created this page yet");
        }

        private void btnBackup_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("havent created this page yet");
        }
    }
}
