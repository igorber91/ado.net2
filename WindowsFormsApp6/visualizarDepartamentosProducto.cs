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
    public partial class visualizarDepartamentosProducto : Form
    {


        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();
        SqlCommand cmdLeer3 = new SqlCommand();
        SqlCommand cmdLeer4 = new SqlCommand();

        SqlTransaction trans;


        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        DataSet dsProductos = new DataSet();


        DataSet dsCantidad = new DataSet();
        DataSet dsCantidad2 = new DataSet();
        SqlDataAdapter adapCantidades = new SqlDataAdapter();
        SqlCommandBuilder bulCantidades = new SqlCommandBuilder();

        DataSet dsDepartamentos = new DataSet();
        SqlDataAdapter adapDepartamentos = new SqlDataAdapter();
        SqlCommandBuilder bulDepartamentos = new SqlCommandBuilder();


        DataSet dsProductos2 = new DataSet();
        SqlDataAdapter adapProductos2 = new SqlDataAdapter();
        SqlCommandBuilder bulProductos2 = new SqlCommandBuilder();

        public visualizarDepartamentosProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapProductos.Fill(dsProductos, "Productos");
            dataGridView1.DataSource = dsProductos.Tables[0];

        

            adapCantidades.Fill(dsCantidad, "departamentoProductos");
            adapCantidades.Fill(dsCantidad, "Productos");


            dataGridView2.DataSource = dsCantidad.Tables[0];
            dataGridView2.DataSource = dsCantidad.Tables[1];

            adapDepartamentos.Fill(dsDepartamentos, "departamento");
            dataGridView3.DataSource = dsDepartamentos.Tables[0];

            adapProductos2.Fill(dsProductos2, "productos");
            dataGridView4.DataSource = dsProductos2.Tables[0];


        }

        private void Form7_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM departamentoProductos";

            // cmdLeer.CommandText = "SELECT * FROM productos where idProducto in " +
            //     "(select idProducto from ventasProductos )";
            cmdLeer.Connection = conexion;

            adapProductos.SelectCommand = cmdLeer;

            bulProductos.DataAdapter = adapProductos;
            adapProductos.UpdateCommand = bulProductos.GetUpdateCommand();



            conexion.ConnectionString = strconexion;
            cmdLeer2.CommandType = CommandType.Text;

            cmdLeer2.CommandText = "select productos.nombre,departamentoProductos.cantidad from" +
                " productos inner join departamentoProductos on departamentoProductos.idProducto=productos.idProducto;";

            cmdLeer2.Connection = conexion;

            adapCantidades.SelectCommand = cmdLeer2;



            conexion.ConnectionString = strconexion;
            cmdLeer3.CommandType = CommandType.Text;

            cmdLeer3.CommandText = "select * from departamento";
            cmdLeer3.Connection = conexion;

            adapDepartamentos.SelectCommand = cmdLeer3;



            conexion.ConnectionString = strconexion;
            cmdLeer4.CommandType = CommandType.Text;

            cmdLeer4.CommandText = "select nombre,departamento from productos";
            cmdLeer4.Connection = conexion;

            adapProductos2.SelectCommand = cmdLeer4;




        }
    }
}
