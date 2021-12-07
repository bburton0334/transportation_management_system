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
    /// <summary>
    /// Interaction logic for PlannerPortal.xaml
    /// </summary>
    public partial class PlannerPortal : Page
    {
        bool isManageOrdersVisible = false;
        bool isConfirmOrdersVisible = false;
        bool isActiveOrdersVisible = false;
        bool isGRVisible = false;
        //bool isGenerateReportVisible = false;

        public PlannerPortal()
        {
            InitializeComponent();
        }

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
