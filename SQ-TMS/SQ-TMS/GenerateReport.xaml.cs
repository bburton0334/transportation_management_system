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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class GenerateReport
    ///
    /// \brief The purpose of this class is to hold functions which allow to choose if they want a summary report which
    /// reports details from all time, or if they only want details which reports from the past two weeks.
    /// \details <b>Details</b>
    ///
    /// This class contains functions which deal with button click events corrosponding with all time or two weeks.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class GenerateReport : Page
    {
        //===============================================================================================================
        /// \brief btnInitiGenerateReportateCommand_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to generate a summary report of all Invoice data
        /// \param void, none
        ///
        /// \return void, none
        //===============================================================================================================
 
        public GenerateReport()
        {
            InitializeComponent();

            string fullPath = TMSData.ReportFileDir + TMSData.ReportFileName;
            txtReportViewer.Text = File.ReadAllText(fullPath);
        }

        //===============================================================================================================
        /// \brief btnAllTime_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to give feedback, for all time
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================
 
        private void btnAllTime_Click(object sender, RoutedEventArgs e)
        {
            // a copy of logger, but has a seperate file and folder 
            // and will store the reports.
            Report.Generate("THIS IS A TEST");

            lblFeedback.Content = "[SUCCESS] Report has been generated.";
        }

        //===============================================================================================================
        /// \brief btnTwoWeeks_Click
        /// \details <b>Details</b>
        ///
        /// This method is called to give feedback, for 2 weeks
        /// \param sender - <b>object</b> - object sender -> made by xaml
        /// \param RoutedEventArgs - <b>RotedEventArgs</b> - Event e -> made by xaml
        ///
        /// \return void, none
        //===============================================================================================================

        private void btnTwoWeeks_Click(object sender, RoutedEventArgs e)
        {
            // a copy of logger, but has a seperate file and folder 
            // and will store the reports.
            Report.Generate("THIS IS A TEST");

            lblFeedback.Content = "[SUCCESS] Report has been generated.";
        }
    }
}
