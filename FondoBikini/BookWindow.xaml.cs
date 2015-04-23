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
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        public BookWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        public void Reset()
        {
            textNombre.Text = String.Empty;
            textApellidos.Text = String.Empty;
            textDni.Text = String.Empty;
            textPoblación.Text = String.Empty;
            textProvincia.Text = String.Empty;
            tipoHabitacion.Items.Clear();
            foreach (string tipo in habitaciones)
            {
                tipoHabitacion.Items.Add(tipo);
            }
            tipoHabitacion.Text = tipoHabitacion.Items[0] as string;
        }

        private string[] habitaciones = { "Normal", "Vistas al mar", "Superior vistas al mar", "Suite" };

        private void textGuardar_Click(object sender, RoutedEventArgs e)
        {
            String datos=String.Format("Cliente {0} {1} con DNI {2} y procedencia {3}, {4}, solicita {5} durante {6}. Con numero tarjeta {7}",
                textNombre.Text, textApellidos.Text, textDni.Text, textPoblación.Text, textProvincia.Text, tipoHabitacion.Text, textNochesEstancia.Text, textNumeroTarjeta.Text);

            StringBuilder detalles=new StringBuilder();
            detalles.AppendLine(datos);

            MessageBox.Show(detalles.ToString(), "Información reserva");
        }

        private void textAnular_Click(object sender, RoutedEventArgs e)
        {
            this.Reset();
        }
    }
}
