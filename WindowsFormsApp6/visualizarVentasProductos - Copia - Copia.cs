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
    public partial class visualizarVentasProductos : Form
    {

        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();
        SqlCommand cmdLeer3 = new SqlCommand();

        SqlDataAdapter adapVentas = new SqlDataAdapter();
        SqlCommandBuilder bulVentas = new SqlCommandBuilder();

        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        SqlDataAdapter adapVentaProductos = new SqlDataAdapter();
        SqlCommandBuilder bulVentaProductos = new SqlCommandBuilder();

        SqlTransaction trans;



        DataSet dsProductos = new DataSet();
        DataSet dsVentas = new DataSet();
        DataSet dsventasProductos = new DataSet();

        

        public visualizarVentasProductos()
        {
            InitializeComponent();
        }

        private void visualizarVentas_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM ventas";
            cmdLeer.Connection = conexion;

            adapVentas.SelectCommand = cmdLeer;

            bulVentas.DataAdapter = adapVentas;
            adapVentas.UpdateCommand = bulVentas.GetUpdateCommand();

            cmdLeer2.CommandType = CommandType.Text;
            cmdLeer2.CommandText = "SELECT * FROM productos";
            cmdLeer2.Connection = conexion;

            adapProductos.SelectCommand = cmdLeer2;

            bulProductos.DataAdapter = adapProductos;
            adapProductos.UpdateCommand = bulProductos.GetUpdateCommand();

            cmdLeer3.CommandType = CommandType.Text;
            cmdLeer3.CommandText = "SELECT * FROM ventasProductos";
            cmdLeer3.Connection = conexion;

            adapVentaProductos.SelectCommand = cmdLeer3;

            bulVentaProductos.DataAdapter = adapVentaProductos;
            adapVentaProductos.UpdateCommand = bulVentaProductos.GetUpdateCommand();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            adapVentas.Fill(dsVentas, "ventas");

            dataGridView1.DataSource = dsVentas.Tables[0];

            adapProductos.Fill(dsProductos, "productos");

            dataGridView2.DataSource = dsProductos.Tables[0];

            adapVentaProductos.Fill(dsventasProductos, "ventasProductos");

            dataGridView3.DataSource = dsventasProductos.Tables[0];
        }
    }
}
