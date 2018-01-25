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
    public partial class Form3 : Form
    {

        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();
        SqlDataAdapter adapCuenta = new SqlDataAdapter();
        SqlCommandBuilder bulCuenta = new SqlCommandBuilder();

        DataSet dsProductos = new DataSet();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM usuarios where idUsuario in " +
                "(select idUsuario from usuariosCliente )";
            cmdLeer.Connection = conexion;

            adapCuenta.SelectCommand = cmdLeer;

            bulCuenta.DataAdapter = adapCuenta;
            adapCuenta.UpdateCommand = bulCuenta.GetUpdateCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapCuenta.Fill(dsProductos, "usuarios");

            dataGridView1.DataSource = dsProductos.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.Show();
        }
    }
}
