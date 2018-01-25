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
    public partial class Form1 : Form
    {

        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();
        SqlCommand cmdLeer3 = new SqlCommand();
        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        SqlTransaction trans;


        DataSet dsProductos = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapProductos.Fill(dsProductos, "Productos");

            dataGridView1.DataSource = dsProductos.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM productos";

             // cmdLeer.CommandText = "SELECT * FROM productos where idProducto in " +
             //     "(select idProducto from ventasProductos )";
             cmdLeer.Connection = conexion;

            adapProductos.SelectCommand = cmdLeer;

            bulProductos.DataAdapter = adapProductos;
            adapProductos.UpdateCommand = bulProductos.GetUpdateCommand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string texto1;
            texto1 = int.Parse(textBox1.Text).ToString();
            string texto2;
            texto2 = textBox2.Text;
            string texto3;
            texto3 = int.Parse(textBox3.Text).ToString();
            string texto4;
            texto4 = int.Parse(textBox4.Text).ToString();
            string texto5;
            texto5 = textBox5.Text;
            string texto6;
            texto6 = int.Parse(textBox6.Text).ToString();


            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "INSERT INTO productos values ('" + texto1 + "','" + texto2 + "','" + texto3 + "','" + texto4 + "','" + texto5 + "','" + texto6 + "')";
            //cmdLeer.CommandText = "INSERT INTO productos values ('" + texto1 + "','prueba',50,100,'pruebaDep',0)";

            cmdLeer.Connection = conexion;
            
            /*
             Quitar esto si se quiere usar transaccion
             */
            adapProductos.SelectCommand = cmdLeer;
            bulProductos.DataAdapter = adapProductos;
            adapProductos.UpdateCommand = bulProductos.GetUpdateCommand();

           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string texto7;
            texto7 = int.Parse(textBox7.Text).ToString();
            

            conexion.ConnectionString = strconexion;
            cmdLeer2.CommandType = CommandType.Text;
            cmdLeer2.CommandText = "INSERT INTO ventas values ('" + texto7 + "','" + texto8 + "','2012-12-12')";
            //            cmdLeer.CommandText = "INSERT INTO productos values ('" + texto1 + "','prueba',50,100,'pruebaDep',0)";

            cmdLeer2.Connection = conexion;


            //Cursor vendria bien
            cmdLeer3.CommandType = CommandType.Text;
            cmdLeer3.CommandText = "INSERT INTO ventasProductos values ('4','" + texto7 + "','" + dataGridView1.CurrentCell.Value.ToString() + "')";
            //            cmdLeer.CommandText = "INSERT INTO productos values ('" + texto1 + "','prueba',50,100,'pruebaDep',0)";

            cmdLeer3.Connection = conexion;


            try
            {
                conexion.Open();
                trans = conexion.BeginTransaction();

                cmdLeer2.Transaction = trans;
                cmdLeer2.ExecuteNonQuery();
                cmdLeer3.Transaction = trans;
                cmdLeer3.ExecuteNonQuery();

                /*                
                 cmdAltaMovim.Transaction = trans;
                cmdActuaOrigen.Transaction = trans;
                cmdActuaDestino.Transaction = trans;

                cmdAltaMovim.ExecuteNonQuery();
                cmdActuaOrigen.ExecuteNonQuery();
                cmdActuaDestino.ExecuteNonQuery();
                */
                trans.Commit();
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                label1.Text = ex.Message;
            }
            finally
            {
                conexion.Close();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form4 fr = new Form4();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form5 fr = new Form5();
            fr.Show();

        }
    }
}
