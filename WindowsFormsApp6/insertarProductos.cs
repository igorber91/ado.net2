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
    public partial class insertarProductos : Form
    {
        SqlConnection conexion = new SqlConnection();
        string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        //string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();

        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        SqlTransaction trans;


        DataSet dsProductos = new DataSet();
        DataGridViewImageColumn img = new DataGridViewImageColumn();
        string imgLoc = "";
        SqlCommand cmdLeerImagen = new SqlCommand();
        SqlParameter prmImagen = new SqlParameter();

        public insertarProductos()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM productos";
            cmdLeer.Connection = conexion;

            adapProductos.SelectCommand = cmdLeer;

            bulProductos.DataAdapter = adapProductos;
            adapProductos.UpdateCommand = bulProductos.GetUpdateCommand();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }
        

        private void button9_Click(object sender, EventArgs e)
        {
           


        }

        private void btInsertarProducto_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = strconexion;

            cmdLeerImagen.Connection = conexion;


            //imagen
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            cmdLeerImagen.Parameters.Add(new SqlParameter("@img", img));

            string texto1;
            texto1 = int.Parse(txtIdProducto.Text).ToString();
            string texto2;
            texto2 = txtNombre.Text;
            string texto3;
            texto3 = int.Parse(txtPrecioVenta.Text).ToString();
            string texto4;
            texto4 = int.Parse(txtPrecioCompra.Text).ToString();
            string texto5;
            texto5 = txtDepartamento.Text;
            string texto6;
            texto6 = int.Parse(txtDescuento.Text).ToString();


            try
            {

                conexion.Open();
                cmdLeerImagen.CommandType = CommandType.Text;
                cmdLeerImagen.CommandText = "INSERT INTO productos values ('" + texto1 + "','" + texto2 + "','" + texto3 + "','" + texto4 + "','" + texto5 + "','" + texto6 + "',@img)";
                //cmdLeer.CommandText = "INSERT INTO productos values ('" + texto1 + "','prueba',50,100,'pruebaDep',0)";
                cmdLeerImagen.ExecuteNonQuery();

                lblResultado.Text = "insertado";

            }

            catch (SqlException ex)
            {

                lblResultado.Text = ex.Message;

            }

            finally
            {
                conexion.Close();
            }



        }

        private void btRecuperarDatos_Click(object sender, EventArgs e)
        {
            adapProductos.Fill(dsProductos, "Productos");

            dataGridView1.DataSource = dsProductos.Tables[0];
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg) | *.jpg|ALL files (*.*)|*.*";
                dlg.Title = "Select product Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;

                }

            }

            catch
            {

            }
        }

        
    }


}


            