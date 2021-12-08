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
using System.Windows.Media.Animation;

namespace SQ_TMS
{
    //===================================================================================================================
    /// \class StartLoadIn
    ///
    /// \brief The purpose of this class is to hold functions which will initiate the load in animation for TMS
    /// \details <b>Details</b>
    ///
    /// StartLoadIn class conatins 2 functions, a constructor which initizalizes the components, and a function
    /// which is triggered when the image within the page is loaded. This class only deals with one page for TMS.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    public partial class StartLoadIn : Page
    {
        public StartLoadIn()
        {
            InitializeComponent();
        }

        ///==============================================================================================================
        /// \brief To Initialize the Image animation
        /// \details <b>Details</b>
        ///
        /// This function initializes the image in order to start the load in animation.
        /// It takes two parameters in order to complete this. 
        /// \param sender - <b>object</b> - representation of the sender for image
        /// \param e - <b>EventArgs</b> - representation of Eventargs for image
        ///
        /// \return void, none
        ///==============================================================================================================
        private void Image_Initialized(object sender, EventArgs e)
        {
            // start animation
            DoubleAnimation da = new DoubleAnimation(0, TimeSpan.FromSeconds(1.5));
            imgLoad.BeginAnimation(Image.OpacityProperty, da);
        }
    }
}
