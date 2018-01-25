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
using System.IO;
namespace WindowsFormsApp6
{
    public partial class cliente : Form
    {

        SqlConnection conexion = new SqlConnection();
        string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        //string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();
        SqlCommand cmdLeer3= new SqlCommand();
        SqlCommand cmdLeer4 = new SqlCommand();
        SqlCommand cmdLeer5 = new SqlCommand();
        SqlCommand cmdLeer6 = new SqlCommand();
        SqlCommand cmdLeer7 = new SqlCommand();
        SqlCommand cmdLeer8 = new SqlCommand();
        SqlCommand cmdLeer9 = new SqlCommand();


        TextBox texto1 = new TextBox();
        TextBox texto2 = new TextBox();
        TextBox texto3 = new TextBox();
        TextBox texto4 = new TextBox();
        TextBox texto5 = new TextBox();
        TextBox texto6 = new TextBox();
        TextBox texto7 = new TextBox();
        TextBox texto8 = new TextBox();



        public cliente()
        {
            InitializeComponent();
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            conexion.Open();


            txtIdCliente.Text= session.UserID.ToString();

            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT nombre FROM clientes where idCliente="+session.UserID+"";
            cmdLeer.Connection = conexion;
            texto1.Text = cmdLeer.ExecuteScalar().ToString();
            txtNombre.Text = texto1.Text;

            
            cmdLeer3.CommandType = CommandType.Text;
            cmdLeer3.CommandText = "SELECT contrasegna FROM clientes where idCliente=" + session.UserID + "";
            cmdLeer3.Connection = conexion;
            texto3.Text = cmdLeer3.ExecuteScalar().ToString();
            txtContrasegna.Text = texto3.Text;


            cmdLeer4.CommandType = CommandType.Text;
            cmdLeer4.CommandText = "SELECT apellido FROM clientes where idCliente=" + session.UserID + "";
            cmdLeer4.Connection = conexion;
            texto4.Text = cmdLeer4.ExecuteScalar().ToString();
            txtApellido.Text = texto4.Text;

            cmdLeer5.CommandType = CommandType.Text;
            cmdLeer5.CommandText = "SELECT telefono FROM clientes where idCliente=" + session.UserID + "";
            cmdLeer5.Connection = conexion;
            texto5.Text = cmdLeer5.ExecuteScalar().ToString();
            txtTelefono.Text = texto5.Text;

            cmdLeer6.CommandType = CommandType.Text;
            cmdLeer6.CommandText = "SELECT edad FROM clientes where idCliente=" + session.UserID + "";
            cmdLeer6.Connection = conexion;
            texto6.Text = cmdLeer6.ExecuteScalar().ToString();
            txtEdad.Text = texto6.Text;

            cmdLeer7.CommandType = CommandType.Text;
            cmdLeer7.CommandText = "SELECT ciudad FROM clientes where idCliente=" + session.UserID + "";
            cmdLeer7.Connection = conexion;
            texto7.Text = cmdLeer7.ExecuteScalar().ToString();
            txtCiudad.Text = texto7.Text;


            cmdLeer8.CommandType = CommandType.Text;
            cmdLeer8.CommandText = "SELECT gastos FROM clientes where idCliente=" + session.UserID + "";
            cmdLeer8.Connection = conexion;
            texto8.Text = cmdLeer8.ExecuteScalar().ToString();
            txtGastos.Text = texto8.Text;

            cmdLeer9.CommandType = CommandType.Text;
            cmdLeer9.CommandText = "SELECT imagen FROM clientes where idCliente=" + session.UserID + "";
            cmdLeer9.Connection = conexion;

            SqlDataReader reader = cmdLeer9.ExecuteReader();
            if (reader.Read())
            {
                try
                {

                Byte[] byteImagen = new Byte[0];
                byteImagen = (Byte[])((byte[])reader["imagen"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImagen);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            // Cambiar tamaño imagen.
            pictureBox1.Size = new System.Drawing.Size(140, 140);
            //centrar imagen
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            //cambiar tamaños imagen
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;





            conexion.Close();

        }
    }
}
