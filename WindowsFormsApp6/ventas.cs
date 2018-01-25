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

//Factura
using System.IO;

namespace WindowsFormsApp6
{
    public partial class ventas : Form
    {

        SqlConnection conexion = new SqlConnection();
        string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        //string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();
        SqlCommand cmdLeer3 = new SqlCommand();
        SqlCommand cmdLeer3b = new SqlCommand();
        SqlCommand cmdLeer4 = new SqlCommand();
        SqlCommand cmdLeer5 = new SqlCommand();
        SqlCommand cmdLeer6 = new SqlCommand();
        SqlCommand cmdLeer7 = new SqlCommand();



        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        SqlTransaction trans;


        DataSet dsProductos = new DataSet();
        DataGridViewImageColumn img = new DataGridViewImageColumn();
        SqlCommand cmdLeerImagen = new SqlCommand();
        SqlParameter prmImagen = new SqlParameter();


        //Prueba Listbox
        string idVenta;
        DataSet dsVentas = new DataSet();
        SqlCommand cmdIdVenta = new SqlCommand();

        SqlDataAdapter adapVentas = new SqlDataAdapter();
        SqlCommandBuilder bulVentas = new SqlCommandBuilder();


        //Compra
        string nombreProducto;

        SqlCommand cmdCompra = new SqlCommand();

        //LBLPRECIOS
        SqlCommand cmdPrecios = new SqlCommand();
        string precioVenta;

        //Imprimir
        SqlCommand cmdFactura = new SqlCommand();
        SqlCommand cmdFactura2 = new SqlCommand();
        SqlCommand cmdFactura4 = new SqlCommand();
        SqlCommand cmdFactura5 = new SqlCommand();
        SqlCommand cmdFactura6 = new SqlCommand();
        SqlCommand cmdFactura7 = new SqlCommand();
        SqlCommand cmdFactura8 = new SqlCommand();


        SqlCommand cmdCantidad = new SqlCommand();


        //Parar por saldo
        SqlCommand cmdFactura3 = new SqlCommand();

        string saldo;

        string cantidad;



        public ventas()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            //sesion
            lblUsuario.Text = session.Nombre.ToString();




            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT idProducto,nombre,precioVenta,departamento,descuento,imagen FROM productos";


            cmdLeer.Connection = conexion;

            adapProductos.SelectCommand = cmdLeer;

            bulProductos.DataAdapter = adapProductos;
            adapProductos.UpdateCommand = bulProductos.GetUpdateCommand();


            //rellenar datagrid
            adapProductos.Fill(dsProductos, "Productos");
            dataGridView1.DataSource = dsProductos.Tables[0];

            //Ajustar imagen del datagrid
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }


            //Prueba Listbox

            cmdIdVenta.Connection = conexion;


            conexion.ConnectionString = strconexion;
            cmdIdVenta.CommandType = CommandType.Text;
            cmdIdVenta.CommandText = "select max(IdVenta)+1 from ventas;";

            conexion.Open();
            idVenta = cmdIdVenta.ExecuteScalar().ToString();
            lbIdVenta.Items.Add(idVenta);
            conexion.Close();



            //Prueba listbox

        }

        private void btVenta_Click(object sender, EventArgs e)
        {


            //autoincrement sql 
            cmdLeer3.CommandType = CommandType.Text;
            cmdLeer3.CommandText = "INSERT INTO ventasProductos values ((select isnull(MAX(idVentaProducto),0)+1 from ventasProductos),'" + idVenta + "','" + dataGridView1.CurrentCell.Value.ToString() + "')";
            cmdLeer3.Connection = conexion;



            cmdLeer4.CommandType = CommandType.Text;
            cmdLeer4.CommandText = " UPDATE departamentoProductos SET cantidad = cantidad - 1 WHERE departamentoProductos.idProducto = '" + dataGridView1.CurrentCell.Value.ToString() + "'";
            cmdLeer4.Connection = conexion;

            cmdCantidad.CommandType = CommandType.Text;
            cmdCantidad.CommandText = "Select cantidad from departamentoProductos WHERE departamentoProductos.idProducto = '" + dataGridView1.CurrentCell.Value.ToString() + "'";
            cmdCantidad.Connection = conexion;



            // Carro compra


            cmdCompra.Connection = conexion;


            conexion.ConnectionString = strconexion;
            cmdCompra.CommandType = CommandType.Text;
            cmdCompra.CommandText = "select nombre from productos where idProducto='" + dataGridView1.CurrentCell.Value.ToString() + "'";

            conexion.Open();
            cmdCompra.ExecuteNonQuery();


            nombreProducto = cmdCompra.ExecuteScalar().ToString();
            lblCompra.Items.Add(nombreProducto);
            conexion.Close();
            //
            
            
            // Carro precios


            cmdPrecios.Connection = conexion;


            conexion.ConnectionString = strconexion;
            cmdPrecios.CommandType = CommandType.Text;
            cmdPrecios.CommandText = "select precioVenta from productos where idProducto='" + dataGridView1.CurrentCell.Value.ToString() + "'";

            conexion.Open();
            cmdPrecios.ExecuteNonQuery();


            precioVenta = cmdPrecios.ExecuteScalar().ToString();
            lblPrecios.Items.Add(precioVenta);


            double suma = 0;

            foreach (object item in lblPrecios.Items)
            {
                double val = Convert.ToDouble(item);

                suma += val;

            }

            txtPrecio.Text = suma.ToString();

         

            cmdFactura3.Connection = conexion;

            //Mostrar dinero del cliente
            cmdFactura3.CommandType = CommandType.Text;
            cmdFactura3.CommandText = "select dinero from cuentas inner join clientesCuenta on cuentas.idCuenta = clientesCuenta.idCuenta inner join clientes on clientes.idCliente = clientesCuenta.idCliente " +
                "where clientes.idCliente ="+session.UserID.ToString() +"";


            // Parar si saldo 0

            saldo = cmdFactura3.ExecuteScalar().ToString();
            lblSaldo.Text = saldo;


            if (float.Parse(saldo)<=0)
            {
                MessageBox.Show("Saldo insuficiente ingresa mas dinero");

                sesion fr = new sesion();
                fr.Show();
                this.Close();

            }

            conexion.Close();
            //




            try
            {
                conexion.Open();
                
                cmdLeer4.ExecuteNonQuery();

                //Cantidad de producto
              /*   cantidad = cmdCantidad.ExecuteScalar().ToString();


                if (int.Parse(cantidad) <= 0)
                {
                    MessageBox.Show("Cantidad insuficiente del producto pide mas al almacen");
                    cmdLeer3b.Connection = conexion;
                    cmdLeer3b.CommandType = CommandType.Text;
                    cmdLeer3b.CommandText = "DELETE  from ventasProductos where idVentaProducto=(select top 1 idVentaProducto  from ventasProductos order by idVentaProducto desc)";
                    cmdLeer3b.Connection = conexion;
                    cmdLeer3b.ExecuteNonQuery();

                    visualizarActualizarDepartamentos fr = new visualizarActualizarDepartamentos();
                    
                    fr.Show();
                    this.Close();
                       
                }

                */
                
                cmdLeer3.ExecuteNonQuery();

                //Cantidad
                label1.Text = "producto añadido a la compra";
                MessageBox.Show("Producto añadido a la compra");


            }
            catch (SqlException ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {

                conexion.Close();
            }

        }

        private void btFinalizarVenta_Click(object sender, EventArgs e)
        {


            DateTime fecha;
            fecha = dateTimePicker1.Value;


            MessageBox.Show(session.UserID.ToString());
            string numero = session.UserID.ToString();

            conexion.ConnectionString = strconexion;

            cmdLeer2.CommandType = CommandType.Text;
            cmdLeer2.CommandText = "INSERT INTO ventas values ('" + idVenta + "','" + txtPrecio.Text + "' ,'" + fecha + "' )";
            cmdLeer2.Connection = conexion;


            cmdLeer5.CommandType = CommandType.Text;
            cmdLeer5.CommandText = "insert into ventasCliente values((select isnull(MAX(idVentaCliente), 0)+1 from ventasCliente),'" + idVenta + "', '" + numero + "')";
            cmdLeer5.Connection = conexion;

            cmdLeer6.CommandType = CommandType.Text;
            cmdLeer6.CommandText = "update clientes set gastos = (gastos + (select precio from ventas where IdVenta = '" + idVenta + "' )) where idCliente='" + numero + "'";
            cmdLeer6.Connection = conexion;


            cmdLeer7.CommandType = CommandType.Text;
            cmdLeer7.CommandText = "update cuentas set dinero = dinero - (select precio from ventas where IdVenta = '" + idVenta + "' )" +
                "where idCuenta=(select idCuenta from clientesCuenta where idCliente='" + numero + "')";
            cmdLeer7.Connection = conexion;



            conexion.Open();

            string file = @"C:\Users\igorberistain\Dropbox\&DAM\&&Ignacio\deberes\casa\factura" + session.Nombre + ".txt";
            //string file = @"C:\Users\igor\Dropbox\&DAM\&&Ignacio\deberes\casa\factura"+session.Nombre+".txt";
            using (StreamWriter outputFile = new StreamWriter(file, true))
            {

                // conexion.ConnectionString = strconexion;

                cmdFactura.CommandType = CommandType.Text;

                cmdFactura.Connection = conexion;
                cmdFactura.CommandText = "select 'numero factura: '";
                outputFile.WriteLine(cmdFactura.ExecuteScalar().ToString());

                cmdFactura4.CommandType = CommandType.Text;

                cmdFactura4.Connection = conexion;
                cmdFactura4.CommandText = "select "+idVenta;
                outputFile.WriteLine(cmdFactura4.ExecuteScalar().ToString());


                cmdFactura5.CommandType = CommandType.Text;

                cmdFactura5.Connection = conexion;
                cmdFactura5.CommandText = "select 'precio total: '";
                outputFile.WriteLine(cmdFactura5.ExecuteScalar().ToString());

                cmdFactura2.CommandType = CommandType.Text;

                cmdFactura2.Connection = conexion;

                cmdFactura2.CommandText = "select  " + txtPrecio.Text;

                //Execute command and write output to file
                outputFile.WriteLine(cmdFactura2.ExecuteScalar().ToString());


                cmdFactura6.CommandType = CommandType.Text;

                cmdFactura6.Connection = conexion;
                cmdFactura6.CommandText = "select 'productos: '";
                outputFile.WriteLine(cmdFactura6.ExecuteScalar().ToString());

                cmdFactura7.CommandType = CommandType.Text;

                cmdFactura7.Connection = conexion;

                cmdFactura7.CommandText = "select nombre,precioVenta from productos inner join ventasProductos on productos.idProducto = ventasProductos.idProducto " +
                    "where ventasProductos.IdVenta = " + idVenta;

              
                SqlDataReader myReader;

                myReader = cmdFactura7.ExecuteReader();

                while (myReader.Read())
                {
                    //Write logic to process data for the first result.


                    string colValue = myReader[0].ToString();
                    string colValue2 = myReader[1].ToString();

                    outputFile.WriteLine(colValue);
                    outputFile.WriteLine(colValue2);




                }

                myReader.Close();
                

                cmdFactura8.CommandType = CommandType.Text;

                cmdFactura8.Connection = conexion;


                cmdFactura8.CommandText = "select  '-----------------------------------------------'" ;

                //Execute command and write output to file
                outputFile.WriteLine(cmdFactura8.ExecuteScalar().ToString());

                conexion.Close();

                //
            }


            try
            {
                conexion.Open();
                trans = conexion.BeginTransaction();

                cmdLeer2.Transaction = trans;
                cmdLeer2.ExecuteNonQuery();

                cmdLeer5.Transaction = trans;
                cmdLeer5.ExecuteNonQuery();


                cmdLeer6.Transaction = trans;
                cmdLeer6.ExecuteNonQuery();

               /* cmdLeer7.Transaction = trans;
                cmdLeer7.ExecuteNonQuery();
                */



               label1.Text = "venta realizada";
                MessageBox.Show("Venta realizada");



            }
            catch (SqlException ex)
            {
                trans.Rollback();
                label1.Text = ex.Message;
            }
            finally
            {
                trans.Commit();

                ventas ft = new ventas();
                ft.Show();
                this.Close();

                conexion.Close();
            }
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            cliente fr = new cliente();
            fr.Show();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            visualizarClientesCuenta fr = new visualizarClientesCuenta();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visualizarCuentas fr = new visualizarCuentas();
            fr.Show();

        }




        private void button8_Click(object sender, EventArgs e)
        {

            visualizarActualizarDepartamentos fr = new visualizarActualizarDepartamentos();
            fr.Show();

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

        private void btInsertarProductos_Click(object sender, EventArgs e)
        {
            insertarProductos fr = new insertarProductos();
            fr.Show();
        }

    }
}
