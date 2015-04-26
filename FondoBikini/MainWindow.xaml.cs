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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FondoBikini
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            logOut.IsEnabled = false;
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/fondo de bikini inicio editada.jpg", UriKind.Absolute));
            Background = ib;
        }

        private void iniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            bool usrpwd = false;
            foreach (userPassword userpass in userPasswords)
                if (userpass.checkUser(loginWindow.user.Text) && userpass.checkPass(loginWindow.password.Password))
                    usrpwd = true;
            if (usrpwd)
            {
                loginWindow.Close();
                MenuWindow menu = new MenuWindow();
                this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrectos");
            }
            
        }

        private void cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public class userPassword
        {
            private string user;
            private string password;
            public userPassword(string user, string password)
            {
                this.user = user;
                this.password = password;
            }
            public bool checkUser(string user)
            {
                return this.user==user;
            }
            public bool checkPass(string password)
            {
                return this.password==password;
            }
        }

        private userPassword[] userPasswords = { new userPassword("",""), new userPassword("Gato", "Ninja") };

        private void logOut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataBase_Click(object sender, RoutedEventArgs e)
        {
            DataBase db = new DataBase();
            db.ShowDialog();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
