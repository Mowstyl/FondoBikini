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
using Microsoft.Win32;

namespace FondoBikini
{
    /// <summary>
    /// Interaction logic for WorkersWindow.xaml
    /// </summary>
    public partial class WorkersWindow : Window
    {
        public WorkersWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private void Reset()
        {
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/trabajadores editada.jpg", UriKind.Absolute));
            Background = ib;

            nombre.Text = String.Empty;
            apellidos.Text = String.Empty;
            dni.Text = String.Empty;
            salario.Text = String.Empty;
            telefono.Text = String.Empty;
            notas.Text = String.Empty;
            fechaInicio.Text = DateTime.Today.ToString();
            fechaFin.Text = DateTime.Today.ToString();
            foreach (string puestoTrabajo in puestosTrabajo)
            {
                puesto.Items.Add(puestoTrabajo);
            }
            puesto.Text = puesto.Items[0] as string;
        }

        private string[] puestosTrabajo ={ "Administrativo/a","Auxiliar de recepción","Ayudante de cocina","Camarero/a",   "Cocinero/a",  "Director/a gerente del hotel", 
           "Fisioterapeuta", "Gobernante/a","Limpiador/a","Mantenimiento",  "Médico", "Recepcionista" , 
         "Socorrista"};

        private void loadWorker_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.ShowDialog();
        }

        private void nuevoEmpleado_Click(object sender, RoutedEventArgs e)
        {        
            MessageBox.Show("Nuevo trabajador.", "Dar de alta");
        }

        private void modificar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos modificados.", "Modificar información trabajador");
        }

        private void baja_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Trabajador dado de baja.", "Dar de baja");
        }
    }
}
