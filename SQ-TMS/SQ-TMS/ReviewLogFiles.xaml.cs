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
    /// <summary>
    /// Interaction logic for ReviewLogFiles.xaml
    /// </summary>
    public partial class ReviewLogFiles : Page
    {
        public ReviewLogFiles()
        {
            InitializeComponent();

            string fullPath = TMSData.logFilePath + TMSData.LogFileName;

            txtLogFileViewer.Text = File.ReadAllText(fullPath);
        }
    }
}
