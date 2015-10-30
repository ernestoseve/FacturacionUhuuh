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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source = SOPORTE-PC\GSISEVE;" + "Initial Catalog=Reporte;User ID=sa;Password=S.severino1718");
        public Window1(string usuario)
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*SqlCommand cmd = new SqlCommand("INSERT INTO LoteProblema(LOTE, IMAGEN, PLANILLA, OBSERVACION, USER_EMVIA, USER_CLOSE) VALUES (@lote, @img, @plani, @obse, @user, @close)", con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@user", textBox.Text);
            cmd.Parameters.AddWithValue("@pass", passwordBox.Password);
            cmd.Parameters.AddWithValue("@Posi", comboBox.Text);
            cmd.Parameters.AddWithValue("@Nom", textBox3.Text);
            cmd.Parameters.AddWithValue("@Ape", textBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();*/
            Window prueba = new Window();
            prueba. 
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            Close();
        }
    }
}
