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
    /// <summary>
    /// Interaction logic for GenerateReport.xaml
    /// </summary>
    public partial class GenerateReport : Page
    {
        public GenerateReport()
        {
            InitializeComponent();

            string fullPath = TMSData.ReportFileDir + TMSData.ReportFileName;
            txtReportViewer.Text = File.ReadAllText(fullPath);
        }

        private void btnAllTime_Click(object sender, RoutedEventArgs e)
        {
            // a copy of logger, but has a seperate file and folder 
            // and will store the reports.
            Report.Generate("THIS IS A TEST");

            lblFeedback.Content = "[SUCCESS] Report has been generated.";
        }

        private void btnTwoWeeks_Click(object sender, RoutedEventArgs e)
        {
            // a copy of logger, but has a seperate file and folder 
            // and will store the reports.
            Report.Generate("THIS IS A TEST");

            lblFeedback.Content = "[SUCCESS] Report has been generated.";
        }
    }
}
