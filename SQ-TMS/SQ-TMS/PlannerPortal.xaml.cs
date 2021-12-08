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
using MessageBox = System.Windows.MessageBox;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class PlannerPortal
    ///
    /// \brief The purpose of this class is to hold functions which will initiate the load in animation for TMS
    /// \details <b>Details</b>
    ///
    /// PlannerPortal class conatins 5 functions. The majority of these functions are used in order to hide and show certain pages
    /// depending on if the user has clicked the button corrospondng with that page. One other function is used in order to ask
    /// the user if they would like to increment the day by one.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class PlannerPortal : Page
    {
        bool isManageOrdersVisible = false;
        bool isConfirmOrdersVisible = false;
        bool isActiveOrdersVisible = false;
        bool isGRVisible = false;
        //bool isGenerateReportVisible = false;

        // ------------------------------------------------------------
        // Function: PlannerPortal
        // Description: This method is called to initialize the components for this page
        // Parameters: 
        // Returns: NOTHING
        // ------------------------------------------------------------
        public PlannerPortal()
        {
            InitializeComponent();
        }

        //===============================================================================================================
        /// \brief btnManageOrders_Click function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to either show or hide the window for ManageOrders.
        /// \param sender - <b>object</b> - elements which represents sender
        /// \param e - <b>RoutedEventsArgs</b> - elements which represents e
        ///
        /// \see ~PlannerPortal()
        //===============================================================================================================
        // ------------------------------------------------------------
        // Function: btnManageOrders_Click
        // Description: This method is called to either show or hide the window for ManageOrders
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        private void btnManageOrders_Click(object sender, RoutedEventArgs e)
        {
            framePlannerPortal.Visibility = Visibility.Hidden;

            if (isManageOrdersVisible == false)
            {
                framePlannerPortal.Content = new ManageOrders();
                framePlannerPortal.Visibility = Visibility.Visible;
                isManageOrdersVisible = true;
            }
            else
            {
                framePlannerPortal.Visibility = Visibility.Hidden;
                isManageOrdersVisible = false;
            }
        }

        //===============================================================================================================
        /// \brief btnManageOrders_Click function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to prompt the user if they would like to increment the days by 1 day
        /// \param sender - <b>object</b> - elements which represents sender
        /// \param e - <b>RoutedEventsArgs</b> - elements which represents e
        ///
        /// \see ~PlannerPortal()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: btnPassTime_Click
        // Description: This method is called to prompt the user if they would like to increment the days by 1
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        private void btnPassTime_Click(object sender, RoutedEventArgs e)
        {
            int daysPassed = TMSData.TotalDaysPassed;
            const int DAY = 1;

            DialogResult dr = System.Windows.Forms.MessageBox.Show("Are you sure you want to increment time by 1-day?\n\nCurrent days passed: " + daysPassed, "Time Simulation Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        
            if (dr == DialogResult.Yes)
            {
                daysPassed = daysPassed + DAY;
                TMSData.TotalDaysPassed = daysPassed;
            }
        }

        //===============================================================================================================
        /// \brief btnConfirmOrders_Click function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to either show or hide the window for ConfirmOrders.
        /// \param sender - <b>object</b> - elements which represents sender
        /// \param e - <b>RoutedEventsArgs</b> - elements which represents e
        ///
        /// \see ~PlannerPortal()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: btnConfirmOrders_Click
        // Description: This method is called to either show or hide the window for ConfirmOrders
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        private void btnConfirmOrders_Click(object sender, RoutedEventArgs e)
        {
            framePlannerPortal.Visibility = Visibility.Hidden;

            if (isConfirmOrdersVisible == false)
            {
                framePlannerPortal.Content = new ConfirmOrders();
                framePlannerPortal.Visibility = Visibility.Visible;
                isConfirmOrdersVisible = true;
            }
            else
            {
                framePlannerPortal.Visibility = Visibility.Hidden;
                isConfirmOrdersVisible = false;
            }
        }

        //===============================================================================================================
        /// \brief btnActiveOrders_Click function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to either show or hide the window for ActiveOrders.
        /// \param sender - <b>object</b> - elements which represents sender
        /// \param e - <b>RoutedEventsArgs</b> - elements which represents e
        ///
        /// \see ~PlannerPortal()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: btnActiveOrders_Click
        // Description: This method is called to either show or hide the window for ActiveOrders
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        private void btnActiveOrders_Click(object sender, RoutedEventArgs e)
        {
            framePlannerPortal.Visibility = Visibility.Hidden;

            if (isActiveOrdersVisible == false)
            {
                framePlannerPortal.Content = new ActiveOrders();
                framePlannerPortal.Visibility = Visibility.Visible;
                isActiveOrdersVisible = true;
            }
            else
            {
                framePlannerPortal.Visibility = Visibility.Hidden;
                isActiveOrdersVisible = false;
            }
        }

        //===============================================================================================================
        /// \brief btnGenerateReport_Click function
        /// \details <b>Details</b>
        ///
        /// Method which is used in order to either show or hide the window for GenerateReport.
        /// \param sender - <b>object</b> - elements which represents sender
        /// \param e - <b>RoutedEventsArgs</b> - elements which represents e
        ///
        /// \see ~PlannerPortal()
        //===============================================================================================================

        // ------------------------------------------------------------
        // Function: btnGenerateReport_Click
        // Description: This method is called to either show or hide the window for GenerateReport
        // Parameters: object sender, RoutedEventArgs e
        // Returns: NOTHING
        // ------------------------------------------------------------
        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            framePlannerPortal.Visibility = Visibility.Hidden;

            if (isGRVisible == false)
            {
                framePlannerPortal.Content = new GenerateReport();
                framePlannerPortal.Visibility = Visibility.Visible;
                isGRVisible = true;
            }
            else
            {
                framePlannerPortal.Visibility = Visibility.Hidden;
                isGRVisible = false;
            }
        }
    }
}
