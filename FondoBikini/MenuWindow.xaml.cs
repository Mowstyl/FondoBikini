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
            logIn.IsEnabled = false;
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/fondobikini editada.jpg", UriKind.Absolute));
            Background = ib;
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

        private void bShop_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.ShowDialog();
        }

        private void bReservas_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bookWindow = new BookWindow();
            bookWindow.ShowDialog();
        }

        private void logOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
