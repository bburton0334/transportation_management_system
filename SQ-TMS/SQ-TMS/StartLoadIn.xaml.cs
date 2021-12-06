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
    /// <summary>
    /// Interaction logic for StartLoadIn.xaml
    /// </summary>
    public partial class StartLoadIn : Page
    {
        public StartLoadIn()
        {
            InitializeComponent();
        }

        private void Image_Initialized(object sender, EventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation(0, TimeSpan.FromSeconds(3));
            imgLoad.BeginAnimation(Image.OpacityProperty, da);
        }
    }
}
