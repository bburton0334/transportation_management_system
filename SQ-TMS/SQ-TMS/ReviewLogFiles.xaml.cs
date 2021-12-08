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
using System.IO;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class ReviewLogFiles
    ///
    /// \brief The purpose of this class is to hold functions which will initiate the load in animation for TMS
    /// \details <b>Details</b>
    ///
    /// ReviewLogFiles class conatins 1 functions, a constructor which initizalizes the components.
    /// This class only deals with one page for TMS. Its purpose is to load the log file within a text box to read.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class ReviewLogFiles : Page
    {

        ///==============================================================================================================
        /// \brief To Initialize the the elements within the ReviewLogFiles page
        /// \details <b>Details</b>
        ///
        /// This function initializes all of the elements present within the page. It will load
        /// a text file containing the log information for the TMS system. The user can scroll.
        ///
        /// \return void, none
        ///==============================================================================================================
        public ReviewLogFiles()
        {
            InitializeComponent();

            string fullPath = TMSData.logFilePath + TMSData.LogFileName;

            txtLogFileViewer.Text = File.ReadAllText(fullPath);
        }

        private void txtLogFileViewer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
