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

namespace WpfPorcentagem
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAcr_Click(object sender, RoutedEventArgs e)
        {
                double result = 0.0;
                double v1 = Convert.ToDouble(txtVal1.Text);
                double v2 = Convert.ToDouble(txtVal2.Text)/100;
                result = (v1+(v1*v2));
                lblResult1.Content = result.ToString();
        }

        private void btnDesc_Click(object sender, RoutedEventArgs e)
        {
            double result = 0.0;
            double v1 = Convert.ToDouble(txtVal1.Text);
            double v2 = Convert.ToDouble(txtVal2.Text) / 100;
            result = (v1 - (v1 * v2));
            lblResult2.Content = result.ToString();
        }
    }
}
