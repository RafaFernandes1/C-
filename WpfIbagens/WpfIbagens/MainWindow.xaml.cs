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

namespace WpfIbagens
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

        private void cmbDesenho_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbDesenho.SelectedIndex != -1)
            {
                var selectedItem = ((ComboBoxItem)cmbDesenho.SelectedItem).Content.ToString();
                switch (selectedItem)
                {
                    case "Boost":
                        lblDesenho.Content = "Boost";
                        imgDesenho.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/pixar/images/f/f0/Boost3.jpg/revision/latest?cb=20100627055218"));
                        break;
                    case "Dj":
                        lblDesenho.Content = "Dj";
                        imgDesenho.Source = new BitmapImage(new Uri("https://static.wikia.nocookie.net/pixar/images/5/5e/Devon-Montegomery-Johnston-III-Render.png/revision/latest/scale-to-width-down/1000?cb=20210808165817"));
                        break;
                }
            }
        }
    }
}
