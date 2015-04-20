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
            cbBicicletas.IsChecked = false;
            cbBuceo.IsChecked = false;
            cbCoche.IsChecked = false;
            cbPaddel.IsChecked = false;
            cbTenis.IsChecked = false;

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
    }
}
