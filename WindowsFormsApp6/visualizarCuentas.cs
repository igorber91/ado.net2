using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp6
{
    public partial class visualizarCuentas : Form
    {

        SqlConnection conexion = new SqlConnection();
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();
        SqlDataAdapter adapCuenta = new SqlDataAdapter();
        SqlCommandBuilder bulCuenta = new SqlCommandBuilder();

        DataSet dsProductos = new DataSet();
        public visualizarCuentas()
        {
            InitializeComponent();
        }

        

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            adapCuenta.Fill(dsProductos, "Cuentas");

            dataGridView1.DataSource = dsProductos.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visualizarClientesCuenta fr = new visualizarClientesCuenta();
            fr.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM cuentas where idCuenta = " +
                "(select idCuenta from clientesCuenta where idCliente=1 )";
            cmdLeer.Connection = conexion;

            adapCuenta.SelectCommand = cmdLeer;

            bulCuenta.DataAdapter = adapCuenta;
            adapCuenta.UpdateCommand = bulCuenta.GetUpdateCommand();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visualizarCuentas fr = new visualizarCuentas();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventas fr = new ventas();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ventas2 fr = new ventas2();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visualizarActualizarDepartamentos fr = new visualizarActualizarDepartamentos();
            fr.Show();
        }
    }
}
