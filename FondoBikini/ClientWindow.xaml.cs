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
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }

        public void reset()
        {
            radioDesayuno.IsEnabled = true;
            cbIncluido.IsEnabled = false;

            foreach (string hora in horaComida)
                comboHoraCena.Items.Add(hora);
            comboHoraCena.Text = comboHoraCena.Items[0] as string;
        }

        public string[] horaComida = { "5:30 pm", "9:00 pm" };

    }
}
