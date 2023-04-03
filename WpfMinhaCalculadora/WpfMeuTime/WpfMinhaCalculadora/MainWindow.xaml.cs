using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfMinhaCalculadora
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        double valor1 = 0;
        string op = "";
        Boolean virg = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "1";

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "2";

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text += "0";
        }

        private void btnMais_Click(object sender, RoutedEventArgs e)
        {
            valor1 += Convert.ToDouble(txtTela.Text);
            txtTela.Clear();
            op = "soma";
            lblValor.Content = (Convert.ToString(valor1) + " +");
            virg = false;
        }
        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            valor1 += Convert.ToDouble(txtTela.Text);
            txtTela.Clear();
            op = "subt";
            lblValor.Content = (Convert.ToString(valor1) + " -");
            virg = false;
        }
        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            valor1 += Convert.ToDouble(txtTela.Text);
            txtTela.Clear();
            op = "mult";
            lblValor.Content = (Convert.ToString(valor1) + " x");
            virg = false;
        }
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (txtTela.Text == "0")
            {
                txtTela.Text = ("null!");
            }
            else
            {
                valor1 += Convert.ToDouble(txtTela.Text);
                txtTela.Clear();
                op = "div";
                lblValor.Content = (Convert.ToString(valor1) + " ÷");
                virg = false;
            }
        }
        private void btnRaiz_Click(object sender, RoutedEventArgs e)
        {
            valor1 += Convert.ToDouble(txtTela.Text);
            txtTela.Clear();
            if (valor1 == 0)
            {
                txtTela.Text = ("null!");
            }
            else
            {
                txtTela.Text = (Math.Sqrt(valor1)).ToString();                
            }
            lblValor.Content = ("√" + Convert.ToString(valor1));
            virg = false;
        }
        private void btnPot_Click(object sender, RoutedEventArgs e)
        {
            valor1 += Convert.ToDouble(txtTela.Text);
            txtTela.Clear();
            op = "pot";
            lblValor.Content = Convert.ToString(valor1);
            virg = false;
        }
        private void btnPorc_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Text = (valor1 * Convert.ToDouble(txtTela.Text) / 100).ToString();
            lblValor.Content = (Convert.ToString(valor1) + "%");
            virg = false;
        }
        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "soma":
                    lblValor.Content = Convert.ToString(valor1) + " + " + txtTela.Text;
                    txtTela.Text = (valor1 + Convert.ToDouble(txtTela.Text)).ToString();
                    break;
                case "subt":
                    lblValor.Content = Convert.ToString(valor1) + " - " + txtTela.Text;
                    txtTela.Text = (valor1 - Convert.ToDouble(txtTela.Text)).ToString();
                    break;
                case "mult":
                    lblValor.Content = Convert.ToString(valor1) + " x " + txtTela.Text;
                    txtTela.Text = (valor1 * Convert.ToDouble(txtTela.Text)).ToString();
                    break;
                case "div":
                    lblValor.Content = Convert.ToString(valor1) + " ÷ " + txtTela.Text;
                    txtTela.Text = (valor1 / Convert.ToDouble(txtTela.Text)).ToString();
                    break;
                case "pot":
                    lblpoten.Content = txtTela.Text;
                    txtTela.Text = Math.Pow(valor1, (Convert.ToDouble(txtTela.Text))).ToString();
                    lblValor.Content = Convert.ToString(valor1);
                    break;
            }
            op = "";
            valor1 = 0;
            virg = false;
        }
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtTela.Clear();
            valor1 = 0;
            op = "";
            virg = false;
            lblValor.Content = "";
            lblpoten.Content = "";
        }
        private void btnBS_Click(object sender, RoutedEventArgs e)
        {
            if (txtTela.Text != "")
            {
                txtTela.Text = txtTela.Text.Remove(txtTela.Text.Length - 1);
            }
        }
        private void btnVirgula_Click(object sender, RoutedEventArgs e)
        {
            if(txtTela.Text == "" && !virg) 
            {
                txtTela.Text = "0,";
            }
            else if(!virg) 
            {
                txtTela.Text += ",";
            }
            virg = true;
        }
    }
}
