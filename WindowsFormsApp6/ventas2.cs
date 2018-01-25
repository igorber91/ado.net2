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
//NUEVO
using System.IO;



namespace WindowsFormsApp6
{
    public partial class ventas2 : Form
    {

        SqlConnection conexion = new SqlConnection();
        string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        //string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();
        SqlParameter prmCodVenta = new SqlParameter();
        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        DataSet dsProductos = new DataSet();
        DataSet dsProductos2 = new DataSet();



        SqlParameter prmIdVenta = new SqlParameter();
        SqlParameter prmResultado = new SqlParameter();
        SqlParameter prmCantidad = new SqlParameter();

        public ventas2()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM productos";
            

            cmdLeer.Connection = conexion;

            adapProductos.SelectCommand = cmdLeer;

            bulProductos.DataAdapter = adapProductos;
            adapProductos.UpdateCommand = bulProductos.GetUpdateCommand();


        }

     
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            visualizarCuentas fr = new visualizarCuentas();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visualizarClientesCuenta fr = new visualizarClientesCuenta();
            fr.Show();
        }

      

        private void button8_Click(object sender, EventArgs e)
        {
            visualizarActualizarDepartamentos fr = new visualizarActualizarDepartamentos();
            fr.Show();
        }

     



        private void btProductosVendidos_Click(object sender, EventArgs e)
        {
            string texto1;
            texto1 = int.Parse(txtIdVenta.Text).ToString();


            cmdLeer.CommandType = CommandType.Text;

            cmdLeer.CommandText = "  select count(*) as cantidad,productos.nombre FROM ventasProductos inner join productos on ventasproductos.idProducto = productos.idProducto" +
                "      where idVenta = '" + texto1 + "'   GROUP BY ventasProductos.idProducto,productos.nombre";


            adapProductos.Fill(dsProductos, "Productos");

            dataGridView1.DataSource = dsProductos.Tables[0];

            }

            private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btPrecioProductos_Click(object sender, EventArgs e)
        {

            string texto1;
            texto1 = int.Parse(txtIdVenta.Text).ToString();


            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT precioVenta from productos  where idProducto in (select idProducto from ventasProductos where idVenta ='" + texto1 + "')";
            //cmdLeer.CommandText = "SELECT sum(precioVenta) as precioFactura from productos  where idProducto in (select idProducto from ventasProductos where idVenta ='" + texto1 + "')";


            adapProductos.Fill(dsProductos, "Productos");

            dataGridView1.DataSource = dsProductos.Tables[0];
        }

        private void btPrecioTotal_Click(object sender, EventArgs e)
        {


            conexion.ConnectionString = strconexion;


            prmIdVenta.ParameterName = "@p_id";
            prmIdVenta.SqlDbType = SqlDbType.Int;
            prmIdVenta.Direction = ParameterDirection.Input;


            prmResultado.ParameterName = "@p_resultado";
            prmResultado.SqlDbType = SqlDbType.Int;
            prmResultado.Direction = ParameterDirection.Output;

            prmCantidad.ParameterName = "@p_numcategorias";
            prmCantidad.SqlDbType = SqlDbType.Int;
            prmCantidad.Direction = ParameterDirection.Output;

            cmdLeer.Parameters.Add(prmResultado);
            cmdLeer.Parameters.Add(prmCantidad);
            cmdLeer.Parameters.Add(prmIdVenta);



            string texto1;
            texto1 = int.Parse(txtIdVenta.Text).ToString();


            cmdLeer.CommandType = CommandType.StoredProcedure;
            cmdLeer.CommandText = "dbo.pr_precio";
            cmdLeer.Connection = conexion;

            prmIdVenta.Value = texto1;

            conexion.Open();
            cmdLeer.ExecuteNonQuery();

            var resultado = prmResultado.Value;

            lblPrecioTotal.Text = resultado.ToString();
            conexion.Close();


        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            ventas fr = new ventas();
            fr.Show();
        }

        private void btVentas2_Click(object sender, EventArgs e)
        {
            ventas2 fr = new ventas2();
            fr.Show();
        }

        private void btVerProductos_Click(object sender, EventArgs e)
        {
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT nombre,precioVenta from productos";

            adapProductos.Fill(dsProductos2, "Productos");

            dataGridView2.DataSource = dsProductos2.Tables[0];



            //Abrir cerrar
            ventas2 fr = new ventas2();
            fr.Show();
            this.Close();

        }
    }
}

