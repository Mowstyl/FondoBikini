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
    /// Interaction logic for DataBase.xaml
    /// </summary>
    public partial class DataBase : Window
    {
        public DataBase()
        {
            InitializeComponent();
            this.reset();
        }

        public void reset()
        {
            foreach (string dbType in types)
            {
                dbTypes.Items.Add(dbType);
            }
            dbTypes.Text = dbTypes.Items[0] as string;
            textFolder.IsEnabled = true;
            textFolder.Text = String.Empty;
            bSelect.IsEnabled = true;
            textServer.IsEnabled = false;
            textServer.Text = String.Empty;
            textUser.IsEnabled = false;
            textUser.Text = String.Empty;
            textPassword.IsEnabled = false;
            textPassword.Text = String.Empty;
        }

        public string[] types = {"Archivos CSV", "SQLServer", "MySQL", "PostgreSQL" };

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bConnect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Si la base de datos no existe se creará. ¿Está usted seguro de continuar?"
                , "Advertencia", MessageBoxButton.YesNo);
            this.Close();
        }

        private void bSelect_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textFolder.Text = dialog.SelectedPath;
        }

        private void dbTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dbTypes.SelectedIndex == 0)
            {
                textFolder.IsEnabled = true;
                bSelect.IsEnabled = true;
                textServer.IsEnabled = false;
                textUser.IsEnabled = false;
                textPassword.IsEnabled = false;
            }
            else
            {
                textFolder.IsEnabled = false;
                bSelect.IsEnabled = false;
                textServer.IsEnabled = true;
                textUser.IsEnabled = true;
                textPassword.IsEnabled = true;
            }
        }
    }
}
