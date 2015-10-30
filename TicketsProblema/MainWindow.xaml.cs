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
using System.Data.SqlClient;
using System.Data;
using System.Security;

namespace TicketsProblema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source = SOPORTE-PC\GSISEVE;" + "Initial Catalog=Reporte;User ID=sa;Password=S.severino1718");
        public MainWindow()
        {
            InitializeComponent();
            //textBox1.InvalidateVisual();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT USER_GSI FROM gsi_user WHERE USER_GSI=@user and PASS_GSI=@pass and POSICION_GSI=@admin", con);
            cmd.Parameters.AddWithValue("user", textBox.Text);
            //string pas = passwordBox.SecurePassword();
            cmd.Parameters.AddWithValue("pass", passwordBox.Password);
            cmd.Parameters.AddWithValue("admin", comboBox.Text);
            con.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                if(comboBox.Text == "Administrator") { 
                    PanelMenu login = new PanelMenu();
                    login.Show();
                    Close();
                }
                else
                {
                    Window1 lote = new Window1();
                    lote.Show();
                    Close(); 
                }
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña no son validos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            con.Close();
        }
   
        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Administrator");
            data.Add("Usuario");

            var comboBox = sender as ComboBox;

            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;

            string value = comboBox.SelectedItem as string;
            this.Title = "Selected: " + value;
        }
    }
}
