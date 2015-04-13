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
            nombre.Text = String.Empty;
            apellidos.Text = String.Empty;
            dni.Text = String.Empty;
            fecha.Text = DateTime.Today.ToString();
            foreach (string servicios in serviciosSpa)
            {
                servicio.Items.Add(serviciosSpa);
            }
            servicio.Text = servicio.Items[0] as string;
        }
        private string[] serviciosSpa ={ "Piscina de chorros de agua","Circuito de aguas","Masaje relajante",
            "Masaje Terapeutico", "Masaje Terapeutico (Masajista 2)"};
    }
}
