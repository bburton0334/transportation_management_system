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
using System.Windows.Threading;

namespace SQ_TMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            frameLoadIn.Visibility = Visibility.Visible;
            frameLoadIn.Content = new StartLoadIn();

            LoadWait();

            BtnBack.Visibility = Visibility.Hidden;
            LiveTimeLabel.Content = "Thursday, Dec, 02 2021 10:35:22 PM";

            Logger.Log("TMS Started");
        }

        private async void LoadWait()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            frameLoadIn.Visibility = Visibility.Hidden;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = "Thursday, Dec, 02 2021 10:35:22 PM";
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnButtonPortal_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BuyerPortal();
            Main.Visibility = Visibility.Visible;
            BtnBack.Visibility = Visibility.Visible;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            BtnBack.Visibility = Visibility.Hidden;
        }

        private void btnPlannerPortal_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PlannerPortal();
            Main.Visibility = Visibility.Visible;
            BtnBack.Visibility = Visibility.Visible;
        }

        private void btnAdminPortal_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new AdminPortal();
            Main.Visibility = Visibility.Visible;
            BtnBack.Visibility = Visibility.Visible;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Logger.Log("TMS Terminated");
        }
    }
}
