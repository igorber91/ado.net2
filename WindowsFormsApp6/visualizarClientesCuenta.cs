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
    public partial class visualizarClientesCuenta : Form
    {

        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();
        SqlCommand cmdLeer3 = new SqlCommand();

        SqlDataAdapter adapCuenta = new SqlDataAdapter();
        SqlCommandBuilder bulCuenta = new SqlCommandBuilder();

        SqlDataAdapter adapCliente = new SqlDataAdapter();
        SqlCommandBuilder bulCliente = new SqlCommandBuilder();

        SqlDataAdapter adapClientesCuentas = new SqlDataAdapter();
        SqlCommandBuilder bulClientesCuentas = new SqlCommandBuilder();


        DataSet dsCuentas = new DataSet();
        DataSet dsClientes = new DataSet();
        DataSet dsClientesCuentas = new DataSet();


        public visualizarClientesCuenta()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT idCliente,nombre,ciudad,telefono,gastos FROM clientes";
            cmdLeer.Connection = conexion;

            adapCliente.SelectCommand = cmdLeer;

            bulCliente.DataAdapter = adapCliente;
            adapCliente.UpdateCommand = bulCliente.GetUpdateCommand();


            cmdLeer2.CommandType = CommandType.Text;
            cmdLeer2.CommandText = "SELECT * FROM cuentas";
            cmdLeer2.Connection = conexion;

            adapCuenta.SelectCommand = cmdLeer2;

            bulCuenta.DataAdapter = adapCuenta;
            adapCuenta.UpdateCommand = bulCuenta.GetUpdateCommand();


            cmdLeer3.CommandType = CommandType.Text;
            cmdLeer3.CommandText = "SELECT * FROM clientesCuenta";
            cmdLeer3.Connection = conexion;

            adapClientesCuentas.SelectCommand = cmdLeer3;

            bulClientesCuentas.DataAdapter = adapClientesCuentas;
            adapClientesCuentas.UpdateCommand = bulClientesCuentas.GetUpdateCommand();


        }




        private void button1_Click(object sender, EventArgs e)
        {
            adapCliente.Fill(dsClientes, "clientes");

            dataGridView1.DataSource = dsClientes.Tables[0];


            adapCuenta.Fill(dsCuentas, "cuentas");

            dataGridView2.DataSource = dsCuentas.Tables[0];

            adapClientesCuentas.Fill(dsClientesCuentas, "clientesCuenta");

            dataGridView3.DataSource = dsClientesCuentas.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventas fr = new ventas();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visualizarClientesCuenta fr = new visualizarClientesCuenta();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visualizarCuentas fr = new visualizarCuentas();
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
