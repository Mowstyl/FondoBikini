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
    /// Interaction logic for BookSpaWindow.xaml
    /// </summary>
    public partial class BookSpaWindow : Window
    {
        public BookSpaWindow()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/reservas spa editada.jpg", UriKind.Absolute));
            Background = ib;
            nombre.Text = String.Empty;
            apellidos.Text = String.Empty;
            dni.Text = String.Empty;
            fecha.Text = DateTime.Today.ToString();
            for (int i = 8; i <= 20; i++)
            {
                hora.Items.Add(i.ToString()+":00");
                hora.Items.Add(i.ToString()+":30");
                if (i == 14)
                {
                    i += 1;
                }
            }
            hora.Text = hora.Items[0] as string;
            
            foreach (string servicios in serviciosSpa)
                {
                    servicio.Items.Add(servicios);
                }
            servicio.Text = servicio.Items[0] as string;
        }
        private string[] serviciosSpa ={ "Piscina de chorros de agua","Circuito de aguas","Masaje relajante",
            "Masaje Terapeutico", "Masaje Terapeutico (Masajista 2)"};

        private void nueva_Reserva_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reserva guardada.", "Nueva reserva");
        }

        private void anular_Reserva_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reserva anulada.", "Anular reserva");
        }

    }
}
