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
using System.Data.SqlClient;
namespace TicketsProblema
{
    /// <summary>
    /// Interaction logic for RegistroUsuario.xaml
    /// </summary>
    public partial class RegistroUsuario : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source = SOPORTE-PC\GSISEVE;" + "Initial Catalog=Reporte;User ID=sa;Password=S.severino1718");
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO gsi_user(USER_GSI, PASS_GSI, POSICION_GSI, NAME_GSI, APP_GSI) VALUES (@user, @pass, @Posi, @Nom, @Ape)", con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@user", textBox.Text);
            cmd.Parameters.AddWithValue("@pass", passwordBox.Password);
            cmd.Parameters.AddWithValue("@Posi", comboBox.Text);
            cmd.Parameters.AddWithValue("@Nom", textBox3.Text);
            cmd.Parameters.AddWithValue("@Ape", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            PanelMenu menu = new PanelMenu();
            menu.Show();
            Close();
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
