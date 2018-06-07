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

using Xceed.Wpf.Toolkit;

namespace WpfGodzinaMinuta
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBoxMasked.Text = DateTime.Now.ToShortTimeString();
           
        }

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {

            DateTime dt = new DateTime();
            if (DateTime.TryParse(txtBoxMasked.Text, out dt) == true)
            {
                GodzinaMinuta gm = new GodzinaMinuta(dt.Hour, dt.Minute);
               
                lblWynikStopnie.Content = gm.KatStopnie.ToString() + " stopni";
                lblWynikRadiany.Content = gm.KatRadiany.ToString() + " rad";
            }
        }

    }
}
