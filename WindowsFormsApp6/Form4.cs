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
    public partial class Form4 : Form
    {

        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();
        SqlParameter prmCodVenta = new SqlParameter();
        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        DataSet dsProductos = new DataSet();
        DataSet dsProductos2 = new DataSet();



        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

            /*PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "C:/Users/igorberistain/Dropbox/&DAM/&&Ignacio/deberes/investigarparaMartes24Octubre.PNG";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            */

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
            string texto1;
            texto1 = int.Parse(textBox1.Text).ToString();

         
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT nombre FROM productos where idProducto " +
                "in  (select idProducto from ventasProductos where idVenta='" + texto1 + "')";


            adapProductos.Fill(dsProductos, "Productos");

            dataGridView1.DataSource = dsProductos.Tables[0];
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string texto1;
            texto1 = int.Parse(textBox1.Text).ToString();


            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT sum(precioVenta) as precioFactura from productos  where idProducto in (select idProducto from ventasProductos where idVenta ='" + texto1 + "')";


            adapProductos.Fill(dsProductos, "Productos");

            dataGridView1.DataSource = dsProductos.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT nombre,precioVenta from productos";

            adapProductos.Fill(dsProductos2, "Productos");

            dataGridView2.DataSource = dsProductos2.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
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

