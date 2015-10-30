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

namespace TicketsProblema
{
    /// <summary>
    /// Interaction logic for PanelMenu.xaml
    /// </summary>
    public partial class PanelMenu : Window
    {
        public PanelMenu()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RegistroUsuario regis = new RegistroUsuario();
            regis.Show();
            Close();
        }
    }
}
