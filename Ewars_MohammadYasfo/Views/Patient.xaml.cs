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
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : Window
    {

        public Patient()
        {
            InitializeComponent();
        }

        private void Button3_Copy2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button3_Copy3_Click(object sender, RoutedEventArgs e)
        {
            PatientFile pf = new PatientFile();
            pf.ShowDialog();
        }
    }
}
