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

namespace FondoBikini
{
    /// <summary>
    /// Interaction logic for StockSpaWindow.xaml
    /// </summary>
    public partial class StockSpaWindow : Window
    {
        public StockSpaWindow()
        {
            InitializeComponent();
            Reset();
        }
        private void Reset()
        {
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/stock spa editada.jpg", UriKind.Absolute));
            Background = ib;

            incrementarStock.Text = String.Empty;
            reducirStock.Text = String.Empty;
            stock.Text = String.Empty;
            foreach (string articulos in articulosSpa)
            {
                articulo.Items.Add(articulos);
            }
            articulo.Text = articulo.Items[0] as string;
        }
        private string[] articulosSpa ={ "Aceite de masaje","Chanclas desechables","Gorro de piscina",
             "Toalla para Spa"};

        private void actualizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Stock actualizado.", "Actualizar Stock");
        }
    }
}
