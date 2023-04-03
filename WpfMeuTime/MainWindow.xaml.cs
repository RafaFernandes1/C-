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

namespace WpfMeuTime
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
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            int gol1 = Convert.ToInt32(txtPont.Text);
            int gol2 = Convert.ToInt32(txtAdver.Text);
            //att jogos
            lblJogo.Content = Convert.ToInt32(lblJogo.Content) + 1;
            //att gols 
            lblGolP.Content = Convert.ToInt32(lblGolP.Content) + gol1;
            lblGolC.Content = Convert.ToInt32(lblGolC.Content) + gol2;
            lblSaldo.Content = Convert.ToInt32(lblGolP.Content) - Convert.ToInt32(lblGolC.Content);

            if (gol1 > gol2){//vitoria
                lblVitoria.Content = Convert.ToInt32(lblVitoria.Content) + 1;
                lblPontos.Content = Convert.ToInt32(lblPontos.Content) + 3;
            }
            else if(gol1 < gol2){//derrota
                lblDerrota.Content = Convert.ToInt32(lblDerrota.Content) + 1;
            }
            else if(gol1 == gol2){//empate
                lblEmpate.Content = Convert.ToInt32(lblEmpate.Content) + 1;
                lblPontos.Content = Convert.ToInt32(lblPontos.Content) + 1;
            }
            imgPonte.Source = new BitmapImage(new Uri("https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTzkH-BTbJ-7JOXfAGWSYalofN_vfy9CYxRwbS4rY2KjeIEMeJh"));
            txtPont.Clear();
            txtAdver.Clear();
            txtPont.Focus();            
        }
    }
}
