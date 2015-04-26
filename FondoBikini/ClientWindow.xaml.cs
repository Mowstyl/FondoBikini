using Microsoft.Win32;
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

namespace FondoBikini
{
    /// <summary>
    /// Lógica de interacción para ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private void Reset()
        {
            cbDniRes.Items.Add("DNI Reserva");
            cbDniRes.Text = cbDniRes.Items[0] as string;
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/calamardo clientes editada.jpg", UriKind.Absolute));
            Background = ib;
        }

        private void Comidas_Click(object sender, RoutedEventArgs e)
        {
            FoodClientWindow food = new FoodClientWindow();
            food.ShowDialog();
        }

        private void bReserva_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos reserva asociados al DNI seleccionado");
        }

        private void image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
        }

        private void bBorrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos borrados.");
        }

        private void bModificar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos modificados.");
        }

        private void bGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos guardados.");
        }

        private void openBook_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
