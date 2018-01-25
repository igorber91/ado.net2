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
    public partial class registrarCliente : Form
    {

        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdCliente = new SqlCommand();
        SqlCommand cmdcuenta = new SqlCommand();
        SqlCommand cmdClientesCuenta = new SqlCommand();
        //imagen
        DataGridViewImageColumn img = new DataGridViewImageColumn();
        string imgLoc = "";
        SqlCommand cmdLeerImagen = new SqlCommand();
        SqlParameter prmImagen = new SqlParameter();
        //imagen

        string idCliente;
        string nombre ;
        string contrasegna;
        string apellido;
        string telefono;
        string edad;
        string ciudad;
        string gastos;

        string idCuenta;
        string numeroCuenta;
        string dinero;

        public registrarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            idCliente = int.Parse(txtIdCliente.Text).ToString();
            nombre = txtNombre.Text;
            contrasegna = txtContrasegna.Text;
            apellido = txtApellido.Text;
            telefono = int.Parse(txtTelefono.Text).ToString();
            edad = int.Parse(txtEdad.Text).ToString();
            ciudad = txtCiudad.Text;
            gastos = int.Parse(txtGastos.Text).ToString();

            //imagen
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            cmdCliente.Parameters.Add(new SqlParameter("@img", img));

            //

            conexion.ConnectionString = strconexion;
            conexion.Open();
            cmdCliente.Connection = conexion;


            cmdCliente.CommandType = CommandType.Text;
            cmdCliente.CommandText = "insert into clientes (idCliente,nombre,contrasegna,apellido,telefono,edad,ciudad,gastos,imagen) values ('"+idCliente.ToString()+"','"+nombre.ToString()+"','"+contrasegna.ToString()+"','"+apellido.ToString()+"',"+telefono+","+edad+",'"+ciudad.ToString()+"',"+gastos+ ",@img)";

            cmdCliente.ExecuteNonQuery();


            idCuenta = int.Parse(txtIdCuenta.Text).ToString();
            numeroCuenta = int.Parse(txtNumeroCuenta.Text).ToString();
            dinero = int.Parse(txtDinero.Text).ToString();

            cmdcuenta.Connection = conexion;


            cmdcuenta.CommandType = CommandType.Text;
            cmdcuenta.CommandText = "insert into cuentas  values ('" + idCuenta + "' , '" + numeroCuenta + "' , '" + dinero + "')";

            cmdcuenta.ExecuteNonQuery();



            cmdClientesCuenta.Connection = conexion;


            cmdClientesCuenta.CommandType = CommandType.Text;
            cmdClientesCuenta.CommandText = "insert into clientesCuenta values ((select max(clientesCuenta.idClienteCuenta)+1 from clientesCuenta),'" + idCliente.ToString() + "','" + idCuenta + "')";
            cmdClientesCuenta.ExecuteNonQuery();

            conexion.Close();



        }

        private void btImagen_Click(object sender, EventArgs e)
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
