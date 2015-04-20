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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void bTrabajadores_Click(object sender, RoutedEventArgs e)
        {
            WorkersWindow workersWindow = new WorkersWindow();
            workersWindow.ShowDialog();
        }

        private void bReservasSpa_Click(object sender, RoutedEventArgs e)
        {
            BookSpaWindow bookSpaWindow = new BookSpaWindow();
            bookSpaWindow.ShowDialog();
        }

        private void bStockSpa_Click(object sender, RoutedEventArgs e)
        {
            StockSpaWindow stockSpaWindow = new StockSpaWindow();
            stockSpaWindow.ShowDialog();
        }

        private void bClient_Click(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.ShowDialog();
        }

        private void bServices_Click(object sender, RoutedEventArgs e)
        {
            ServicesWindow servicesWindow = new ServicesWindow();
            servicesWindow.ShowDialog();
        }
    }
}
