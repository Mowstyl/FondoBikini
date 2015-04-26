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
using System.IO;

namespace FondoBikini
{
    /// <summary>
    /// Lógica de interacción para ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public ShopWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        public void Reset()
        {
            textComprador.Text = String.Empty;
            textHabitación.Text = String.Empty;
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/calamardo clientes editada.jpg", UriKind.Absolute));
            Background = ib;
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            /*using(StreamWriter writer=new StreamWriter("Información compra.txt"))
            {
                writer.WriteLine("Comprador: {0}   Habitación: {1}", textComprador.Text, textHabitación.Text);
                writer.WriteLine("Número de productos comprados:");
                writer.WriteLine("Agua: {0}", textAgua.Text);
                writer.WriteLine("Bañadores: {0}", textBañadores.Text);
                writer.WriteLine("Sombreros: {0}", textSombreros.Text);
                writer.WriteLine("Gafas: {0}", textGafas.Text);
                writer.WriteLine("Flotadores: {0}", textFlotadores.Text);
                writer.WriteLine("Sombrillas: {0}", textSombrillas.Text);
                writer.WriteLine("Souvenirs: {0}", textSouvenirs.Text);
            }*/

            MessageBox.Show("Información guardada. Compra realizada.");
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Reset();

            MessageBox.Show("Compra cancelada.");
        }

        private void textotal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
