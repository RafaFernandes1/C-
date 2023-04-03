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

namespace WpfCalculos
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

        private void cmbOperacao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbOperacao.SelectedIndex != -1)
            {
                var selectedItem = ((ComboBoxItem)cmbOperacao.SelectedItem).Content.ToString();
                if (txtA != null && txtB != null && txtC != null)
                {
                    btnCalcular.IsEnabled = false;
                }
                lblA.Content = "";
                lblB.Content = "";
                lblC.Content = "";
                txtA.IsEnabled = false;
                txtB.IsEnabled = false;
                txtC.IsEnabled = false;
                txtA.Clear();
                txtB.Clear();
                txtC.Clear();
                lblResp.Content = "";
                switch (selectedItem)
                {
                    case "Área do Quadrado":
                        lblA.Content = "Digite o lado do quadrado";
                        txtA.IsEnabled = true;
                        imgDesenho.Source = new BitmapImage(new Uri("https://static.todamateria.com.br/upload/57/88/5788f902b7a87-area-do-quadrado.jpg"));
                        break;
                    case "Área do Retângulo":
                        lblA.Content = "Digite o lado do retângulo";
                        lblB.Content = "Digite a altura do retângulo";
                        txtA.IsEnabled = true;
                        txtB.IsEnabled = true;
                        imgDesenho.Source = new BitmapImage(new Uri("https://escolaeducacao.com.br/wp-content/uploads/2020/02/calcular-area-do-retangulo.png"));
                        break;
                    case "Área do Círculo":
                        lblA.Content = "Digite o raio do círculo";
                        txtA.IsEnabled = true;
                        imgDesenho.Source = new BitmapImage(new Uri("https://br.neurochispas.com/wp-content/uploads/2021/08/diagrama-de-um-circulo-com-raio.png"));
                        break;
                    case "Área do Trapézio":
                        lblA.Content = "Digite a base maior do trapézio";
                        lblB.Content = "Digite a base menor do trapézio";
                        lblC.Content = "Digite a altura do trapézio";
                        txtA.IsEnabled = true;
                        txtB.IsEnabled = true;
                        txtC.IsEnabled = true;
                        imgDesenho.Source = new BitmapImage(new Uri("https://media.geeksforgeeks.org/wp-content/uploads/20201215114426/Trapezoidsvg.png"));
                        break;
                    case "Perímetro do Quadrado":
                        lblA.Content = "Digite o lado do quadrado";
                        txtA.IsEnabled = true;
                        imgDesenho.Source = new BitmapImage(new Uri("https://static.todamateria.com.br/upload/57/88/5788f902b7a87-area-do-quadrado.jpg"));
                        break;
                    case "Perímetro do Retângulo":
                        lblA.Content = "Digite o lado do retângulo";
                        lblB.Content = "Digite a altura do retângulo";
                        txtA.IsEnabled = true;
                        txtB.IsEnabled = true;
                        imgDesenho.Source = new BitmapImage(new Uri("https://escolaeducacao.com.br/wp-content/uploads/2020/02/calcular-area-do-retangulo.png"));
                        break;
                }
            }
        }
        private void Window_Initialized(object sender, EventArgs e)
        {

        }
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (cmbOperacao.Text == "Área do Quadrado")
            {
                double areaQuad = Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtA.Text);
                lblResp.Content = ("A área do quadrado vale: " + areaQuad);   
            }
            else if (cmbOperacao.Text == "Área do Retângulo")
            {
                double areaRet = Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtB.Text);
                lblResp.Content = ("A área do retângulo vale: " + areaRet);
            }
            else if (cmbOperacao.Text == "Área do Círculo")
            {
                double areaCirc = 3.14 * (Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtA.Text));
                lblResp.Content = ("A área do círculo vale: " + areaCirc);
            }
            else if (cmbOperacao.Text == "Área do Trapézio")
            {
                double areaTrap = ((Convert.ToDouble(txtA.Text) + Convert.ToDouble(txtB.Text)) * Convert.ToDouble(txtC.Text)) / 2;
                lblResp.Content = ("A área do trapézio vale: " + areaTrap);
            }
            else if (cmbOperacao.Text == "Perímetro do Quadrado")
            {
                double PerQuad = Convert.ToDouble(txtA.Text) * 4;
                lblResp.Content = ("A perímetro do quadrado vale: " + PerQuad);
            }
            else if (cmbOperacao.Text == "Perímetro do Retângulo")
            {
                double PerRet = (Convert.ToDouble(txtA.Text) * 2) + (Convert.ToDouble(txtB.Text) * 2);
                lblResp.Content = ("A perímetro do retângulo vale: " + PerRet);
            }

        }
        public Boolean VerificaTexto()
        {
            if (cmbOperacao.Text == "Área do Quadrado")
            {
               if(txtA.Text != "")
                {
                    return true;
                }
            }
            else if (cmbOperacao.Text == "Área do Retângulo")
            {
                if (txtA.Text != "" && txtB.Text != "")
                {
                    return true;
                }
            }
            else if (cmbOperacao.Text == "Área do Círculo")
            {
                if (txtA.Text != "")
                {
                    return true;
                }
            }
            else if (cmbOperacao.Text == "Área do Trapézio")
            {
                if (txtA.Text != "" && txtB.Text != "" && txtC.Text != "")
                {
                    return true;
                }
            }
            else if (cmbOperacao.Text == "Perímetro do Quadrado")
            {
                if (txtA.Text != "")
                {
                    return true;
                }
            }
            else if (cmbOperacao.Text == "Perímetro do Retângulo")
            {
                if (txtA.Text != "" && txtB.Text != "")
                {
                    return true;
                }
            }
            return false;
        }
        private void txtA_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (VerificaTexto())
            {
                btnCalcular.IsEnabled = true;
            }
            else
            {
                btnCalcular.IsEnabled = false;
            }
        }
        private void txtB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (VerificaTexto())
            {
                btnCalcular.IsEnabled = true;
            }
            else
            {
                btnCalcular.IsEnabled = false;
            }
        }
        private void txtC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (VerificaTexto())
            {
                btnCalcular.IsEnabled = true;
            }
            else
            {
                btnCalcular.IsEnabled = false;
            }
        }
    }
}
