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

namespace WpfOlaMundo
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

        private void btnBemVindo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Olá Mundo! SEXTOU JÁ JÁ. . . !");
        }
        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            double soma= 0.0;
            double v1= Convert.ToDouble(txtVal1.Text);
            double v2= Convert.ToDouble(txtVal2.Text);
            soma = (v1 + v2);
            lblResultado.Content = soma.ToString();
        }
        private void btnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            double sub = 0.0;
            double v1 = Convert.ToDouble(txtVal1.Text);
            double v2 = Convert.ToDouble(txtVal2.Text);
            sub = (v1 - v2);
            lblResultado.Content = sub.ToString();
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            double mult = 0.0;
            double v1 = Convert.ToDouble(txtVal1.Text);
            double v2 = Convert.ToDouble(txtVal2.Text);
            mult = (v1 * v2);
            lblResultado.Content = mult.ToString();
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            double dividir = 0.0;
            double v1 = Convert.ToDouble(txtVal1.Text);
            double v2 = Convert.ToDouble(txtVal2.Text);
            dividir = (v1 / v2);
            lblResultado.Content = dividir.ToString();
        }
        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtVal1.Clear();
            txtVal2.Clear();
            lblResultado.Content= '0';
            txtVal1.Focus();
        }
    }
}
