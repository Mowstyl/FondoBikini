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
using System.IO;

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
            textNochesEstancia.Text = String.Empty;
            textNumeroTarjeta.Text = String.Empty;
        }

        private string[] habitaciones = { "Normal", "Vistas al mar", "Superior vistas al mar", "Suite" };

        private void textCrear_Click(object sender, RoutedEventArgs e)
        {
            String datos = String.Format("Cliente {0} {1} con DNI {2} y procedencia {3}, {4}, solicita tipo de habitación {5} durante {6} noches. Con numero de tarjeta {7}",
                textNombre.Text, textApellidos.Text, textDni.Text, textPoblación.Text, textProvincia.Text, tipoHabitacion.Text, textNochesEstancia.Text, textNumeroTarjeta.Text);

            StringBuilder detalles = new StringBuilder();
            detalles.AppendLine(datos);

            MessageBox.Show(detalles.ToString(), "Información reserva");

            /*using(StreamWriter writer=new StreamWriter("Información Reserva.txt"))
            {
                writer.WriteLine("Cliente: {0} {1}", textNombre.Text, textApellidos.Text);
                writer.WriteLine("DNI: {0}", textDni.Text);
                writer.WriteLine("Procedencia: {0}, {1}", textPoblación.Text, textProvincia.Text);
                writer.WriteLine("Tipo habitación: {0}", tipoHabitacion.Text);
                writer.WriteLine("Estancia: {0}", textNochesEstancia.Text);
                writer.WriteLine("Número tarjeta crédito: {0}", textNumeroTarjeta.Text);
            }

            using (StreamWriter writerdatos = new StreamWriter("Información Reserva Datos.txt"))
            {
                writerdatos.WriteLine("{0}", textNombre.Text);
                writerdatos.WriteLine("{0}", textApellidos.Text);
                writerdatos.WriteLine("{0}", textDni.Text);
                writerdatos.WriteLine("{0}", textPoblación.Text);
                writerdatos.WriteLine("{0}", textProvincia.Text);
                writerdatos.WriteLine("{0}", tipoHabitacion.Text);
                writerdatos.WriteLine("{0}", textNochesEstancia.Text);
                writerdatos.WriteLine("{0}", textNumeroTarjeta.Text);
            }

            MessageBox.Show("Reserva creada");*/
        }

        private void textAnular_Click(object sender, RoutedEventArgs e)
        {
            this.Reset();

            /*using (StreamWriter writer= new StreamWriter("Información Reserva.txt"))
            {
                writer.WriteLine("Cliente: {0} {1}", textNombre.Text, textApellidos.Text);
                writer.WriteLine("DNI: {0}", textDni.Text);
                writer.WriteLine("Procedencia: {0}, {1}", textPoblación.Text, textProvincia.Text);
                writer.WriteLine("Tipo habitación: {0}", tipoHabitacion.Text);
                writer.WriteLine("Estancia: {0}", textNochesEstancia.Text);
                writer.WriteLine("Número tarjeta crédito: {0}", textNumeroTarjeta.Text);
            }

            using (StreamWriter writerdatos = new StreamWriter("Información Reserva Datos.txt"))
            {
                writerdatos.WriteLine("{0}", textNombre.Text);
                writerdatos.WriteLine("{0}", textApellidos.Text);
                writerdatos.WriteLine("{0}", textDni.Text);
                writerdatos.WriteLine("{0}", textPoblación.Text);
                writerdatos.WriteLine("{0}", textProvincia.Text);
                writerdatos.WriteLine("{0}", tipoHabitacion.Text);
                writerdatos.WriteLine("{0}", textNochesEstancia.Text);
                writerdatos.WriteLine("{0}", textNumeroTarjeta.Text);
            }*/

            MessageBox.Show("Reserva anulada");

            
        }

        private void textModificar_Click(object sender, RoutedEventArgs e)
        {
            /*using(StreamReader reader=new StreamReader("Información Reserva Datos.txt"))
            {
                textNombre.Text = reader.ReadLine();
                textApellidos.Text = reader.ReadLine();
                textDni.Text = reader.ReadLine();
                textPoblación.Text = reader.ReadLine();
                textProvincia.Text = reader.ReadLine();
                tipoHabitacion.Text = reader.ReadLine();              
                textNochesEstancia.Text = reader.ReadLine();
                textNumeroTarjeta.Text = reader.ReadLine();
            }
            
            using (StreamWriter writer = new StreamWriter("Información Reserva.txt"))
            {
                writer.WriteLine("Cliente: {0} {1}", textNombre.Text, textApellidos.Text);
                writer.WriteLine("DNI: {0}", textDni.Text);
                writer.WriteLine("Procedencia: {0}, {1}", textPoblación.Text, textProvincia.Text);
                writer.WriteLine("Tipo habitación: {0}", tipoHabitacion.Text);
                writer.WriteLine("Estancia: {0}", textNochesEstancia.Text);
                writer.WriteLine("Número tarjeta crédito: {0}", textNumeroTarjeta.Text);
            }*/

                MessageBox.Show("Reserva modificada");
        }
    }
}
