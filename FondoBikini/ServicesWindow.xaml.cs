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
    /// Interaction logic for ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {
        public ServicesWindow()
        {
            InitializeComponent();
            this.reset();
        }

        public void reset ()
        {
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/servicios editada.jpg", UriKind.Absolute));
            Background = ib;
            total.Text = "0 €";
            cbBuceo.IsChecked = false;

            foreach (string precio in buceo)
            
                comboBuceo.Items.Add(precio);
                comboBuceo.Text = comboBuceo.Items[0] as string;
                comboBuceo.IsEnabled = false;
            
        }

        public string[] buceo = { "120€ 3 días de iniciación", "250€ 3 días en alta mar" };

        private void cbBuceo_Checked(object sender, RoutedEventArgs e)
        {
            comboBuceo.IsEnabled = true;
        }

        private void cbBuceo_Unchecked(object sender, RoutedEventArgs e)
        {
            comboBuceo.IsEnabled = false;
        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.reset();
        }

        private void modificar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Información de servicios modificada.", "Modificar servicios");
        }

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Información de servicios guardada.", "Aceptar");
            int precioTotal=0;
            precioTotal = Convert.ToInt32(tenis.Text) * 10 + Convert.ToInt32(paddel.Text) * 10 + Convert.ToInt32(coche.Text) * 25 + Convert.ToInt32(bici.Text) * 2;
            if (cbBuceo.IsChecked == true)
            {
                switch ((int)comboBuceo.SelectedIndex)
                {
                    case 0:
                        precioTotal+=120;
                        break;
                    case 1:
                        precioTotal+=250;
                        break;
                }           
            }
            total.Text = precioTotal.ToString() + " €";
        }
    }
}
