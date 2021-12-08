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
    //===================================================================================================================
    /// \class MainWindow
    ///
    /// \brief The purpose of this class is to hold the functions needed to the TMS window to function correctly.
    /// \details <b>Details</b>
    ///
    /// MainWindow class is what the entire TMS application is dependant on. It is a window. This is where the root of
    /// all the pages take place in. This class is designed to initialize the window and show the user various portal
    /// buttons which they may choose. 
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class MainWindow : Window
    {

        //===============================================================================================================
        /// \brief MainWindow function
        /// \details <b>Details</b>
        ///
        /// Function loads in the main window for the TMS system.
        /// \param none - <b>void</b> - no param
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
        public MainWindow()
        {
            InitializeComponent();

            frameLoadIn.Visibility = Visibility.Visible;
            frameLoadIn.Content = new StartLoadIn();

            LoadWait();

            BtnBack.Visibility = Visibility.Hidden;
            LiveTimeLabel.Content = "Thursday, Dec, 02 2021 10:35:22 PM";

            Invoice.Generate("This is a test");
            Logger.Log("TMS Started");
        }

        //===============================================================================================================
        /// \brief LoadWait function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// This method starts async method in order to load elements in background
        /// \param none - <b>void</b> - no param
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
        private async void LoadWait()
        {
            await Task.Delay(TimeSpan.FromSeconds(1.5));
            frameLoadIn.Visibility = Visibility.Hidden;
        }

        //===============================================================================================================
        /// \brief timer_tick function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// This method is called to start a tick
        /// \param sender - <b>object</b> - deals with object
        /// \param e - <b>RoutedEventsArgs</b> - deals with object
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = "Thursday, Dec, 02 2021 10:35:22 PM";
        }

        //===============================================================================================================
        /// \brief Rectangle_MouseLeftButtonDown function- given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// This method allows bar to move window
        /// \param sender - <b>object</b> - deals with object
        /// \param e - <b>RoutedEventsArgs</b> - deals with object
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //===============================================================================================================
        /// \brief  BtnButtonPortal_Click function - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Goes to buyer portal
        /// \param sender - <b>object</b> - deals with object
        /// \param e - <b>RoutedEventsArgs</b> - deals with object
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
        private void BtnButtonPortal_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BuyerPortal();
            Main.Visibility = Visibility.Visible;
            BtnBack.Visibility = Visibility.Visible;
        }

        //===============================================================================================================
        /// \brief  BtnBack_Click function - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Goes back to main page
        /// \param sender - <b>object</b> - deals with object
        /// \param e - <b>RoutedEventsArgs</b> - deals with object
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Hidden;
            BtnBack.Visibility = Visibility.Hidden;
        }


        //===============================================================================================================
        /// \brief  btnPlannerPortal_Click - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Goes back to planner portal
        /// \param sender - <b>object</b> - deals with object
        /// \param e - <b>RoutedEventsArgs</b> - deals with object
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
        private void btnPlannerPortal_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PlannerPortal();
            Main.Visibility = Visibility.Visible;
            BtnBack.Visibility = Visibility.Visible;
        }


        //===============================================================================================================
        /// \brief  btnAdminPortal_Click - given a set of attribute values
        /// \details <b>Details</b>
        ///
        /// Goes back to admin portal
        /// \param sender - <b>object</b> - deals with object
        /// \param e - <b>RoutedEventsArgs</b> - deals with object
        ///
        /// \see ~MainWindow()
        //===============================================================================================================
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
