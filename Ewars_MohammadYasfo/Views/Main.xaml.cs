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
using System.Windows.Shapes;

namespace Ewars.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ChartForm CF = new ChartForm();
            CF.ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Patient p = new Patient();
            p.ShowDialog();
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            healthSector hs = new healthSector();
            hs.ShowDialog();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Report Rp = new Report();
            Rp.ShowDialog();
        }
    }
}
