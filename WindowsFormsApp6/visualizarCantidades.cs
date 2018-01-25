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
    public partial class visualizarCantidades : Form
    {
        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();
        SqlDataAdapter adapCuenta = new SqlDataAdapter();
        SqlCommandBuilder bulCuenta = new SqlCommandBuilder();

        DataSet dsProductos = new DataSet();

        public visualizarCantidades()
        {
            InitializeComponent();
        }

        private void visualizarCantidades_Load(object sender, EventArgs e)
        {

            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;

            cmdLeer.CommandText = "select productos.nombre,departamentoProductos.cantidad from" +
                " productos inner join departamentoProductos on departamentoProductos.idProducto=productos.idProducto;";

            cmdLeer.Connection = conexion;

            adapCuenta.SelectCommand = cmdLeer;

            bulCuenta.DataAdapter = adapCuenta;





        }

        private void button1_Click(object sender, EventArgs e)
        {

            adapCuenta.Fill(dsProductos, "Productos");
            adapCuenta.Fill(dsProductos, "departamentoProductos");

            dataGridView1.DataSource = dsProductos.Tables[0];
            dataGridView1.DataSource = dsProductos.Tables[1];

        }
    }
}
