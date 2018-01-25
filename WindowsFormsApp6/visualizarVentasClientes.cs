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
    public partial class visualizarVentasClientes : Form
    {
        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();
        SqlCommand cmdLeer3 = new SqlCommand();

        SqlDataAdapter adapClientes = new SqlDataAdapter();
        SqlCommandBuilder bulClientes = new SqlCommandBuilder();

        SqlDataAdapter adapVentas = new SqlDataAdapter();
        SqlCommandBuilder bulVentas = new SqlCommandBuilder();

        SqlDataAdapter adapClientesVentas = new SqlDataAdapter();
        SqlCommandBuilder bulClientesVentas = new SqlCommandBuilder();

        DataSet dsCliente = new DataSet();
        DataSet dsVentas = new DataSet();

        DataSet dsClientesVentas = new DataSet();

        public visualizarVentasClientes()
        {
            InitializeComponent();
        }

        private void btVisualizarProductos_Click(object sender, EventArgs e)
        {
            adapClientes.Fill(dsCliente, "clientes");

            dataGridView1.DataSource = dsCliente.Tables[0];

            adapVentas.Fill(dsVentas, "venta");

            dataGridView2.DataSource = dsVentas.Tables[0];


            adapClientesVentas.Fill(dsClientesVentas, "ventasCliente");

            dataGridView3.DataSource = dsClientesVentas.Tables[0];

            
        }

        private void visualizarProductos_Load(object sender, EventArgs e)
        {

            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM clientes";
            cmdLeer.Connection = conexion;

            adapClientes.SelectCommand = cmdLeer;

            bulClientes.DataAdapter = adapClientes;
            adapClientes.UpdateCommand = bulClientes.GetUpdateCommand();

            cmdLeer2.CommandType = CommandType.Text;
            cmdLeer2.CommandText = "SELECT * FROM ventas";
            cmdLeer2.Connection = conexion;

            adapVentas.SelectCommand = cmdLeer2;
     
            bulVentas.DataAdapter = adapVentas;
            adapVentas.UpdateCommand = bulVentas.GetUpdateCommand();


            cmdLeer3.CommandType = CommandType.Text;
            cmdLeer3.CommandText = "SELECT * FROM ventasCliente";
            cmdLeer3.Connection = conexion;

            adapClientesVentas.SelectCommand = cmdLeer3;

            bulClientesVentas.DataAdapter = adapClientesVentas;
            adapClientesVentas.UpdateCommand = bulClientesVentas.GetUpdateCommand();


        }
    }
}
