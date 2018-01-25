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
    public partial class visualizarActualizarDepartamentos : Form
    {
        SqlConnection conexion = new SqlConnection();
        string strConexion = @"data source=primero100\primero;initial catalog=AVAN_Igor;integrated security=true;";
        //string strConexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmd = new SqlCommand();
        SqlParameter prmIdDepartamento = new SqlParameter();
        SqlParameter prmNombre = new SqlParameter();
        SqlParameter prmCantidadTotal = new SqlParameter();
        SqlParameter prmSalida = new SqlParameter();

        SqlCommand cmd2 = new SqlCommand();
        SqlParameter prmIdDepartamento2 = new SqlParameter();
        SqlParameter prmIdProducto = new SqlParameter();
        SqlParameter prmCantidad = new SqlParameter();
        SqlParameter prmSalida2 = new SqlParameter();



        SqlCommand cmdLeer = new SqlCommand();
        SqlDataAdapter adapDepartamentos = new SqlDataAdapter();
        SqlCommandBuilder bulDepartamentos = new SqlCommandBuilder();
        DataSet dsDepartamentos = new DataSet();
        DataSet dsDepartamentos2 = new DataSet();


        public visualizarActualizarDepartamentos()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            
        }




        private void button1_Click(object sender, EventArgs e)
        {

            conexion.ConnectionString = strConexion;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.departamentos";
            cmd.Connection = conexion;

            prmIdDepartamento.ParameterName = "@p_id";
            prmIdDepartamento.SqlDbType = SqlDbType.TinyInt;
            prmIdDepartamento.Direction = ParameterDirection.Input;

            prmNombre.ParameterName = "@p_nombre";
            prmNombre.SqlDbType = SqlDbType.VarChar;
            prmNombre.Size = 50;
            prmNombre.Direction = ParameterDirection.Input;

            prmCantidadTotal.ParameterName = "@p_cantidad";
            prmCantidadTotal.SqlDbType = SqlDbType.Int;
            // prmCantidadTotal.Size = 2000;
            prmCantidadTotal.Direction = ParameterDirection.Input;


            prmSalida.ParameterName = "@p_salida";
            prmSalida.SqlDbType = SqlDbType.TinyInt;
            prmSalida.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(prmIdDepartamento);
            cmd.Parameters.Add(prmNombre);
            cmd.Parameters.Add(prmCantidadTotal);
            cmd.Parameters.Add(prmSalida);




            try
            {
                conexion.Open();

                cmd2.Parameters[0].Value = int.Parse(textBox1.Text);
                cmd2.Parameters[1].Value = textBox2.Text;
                cmd2.Parameters[2].Value = int.Parse(textBox3.Text);

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Departamento actualizado correctamente");


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion.Close();
            }


          


        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = strConexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM departamento";

            cmdLeer.Connection = conexion;

            adapDepartamentos.SelectCommand = cmdLeer;

            bulDepartamentos.DataAdapter = adapDepartamentos;
            adapDepartamentos.UpdateCommand = bulDepartamentos.GetUpdateCommand();

            adapDepartamentos.Fill(dsDepartamentos, "departamento");
            dataGridView1.DataSource = dsDepartamentos.Tables[0];

          

        }

        private void btCantidad_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = strConexion;

            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "dbo.departamentos2";
            cmd2.Connection = conexion;

            prmIdDepartamento2.ParameterName = "@p_idDepartamento2";
            prmIdDepartamento2.SqlDbType = SqlDbType.TinyInt;
            prmIdDepartamento2.Direction = ParameterDirection.Input;

            prmIdProducto.ParameterName = "@p_idProducto";
            prmIdProducto.SqlDbType = SqlDbType.TinyInt;
            prmIdProducto.Size = 50;
            prmIdProducto.Direction = ParameterDirection.Input;

            prmCantidad.ParameterName = "@p_cantidad";
            prmCantidad.SqlDbType = SqlDbType.Int;
            // prmCantidadTotal.Size = 2000;
            prmCantidad.Direction = ParameterDirection.Input;


            prmSalida2.ParameterName = "@p_salida";
            prmSalida2.SqlDbType = SqlDbType.TinyInt;
            prmSalida2.Direction = ParameterDirection.Output;

            cmd2.Parameters.Add(prmIdDepartamento2);
            cmd2.Parameters.Add(prmIdProducto);
            cmd2.Parameters.Add(prmCantidad);
            cmd2.Parameters.Add(prmSalida2);


            try
            {
                conexion.Open();

                cmd2.Parameters[0].Value = int.Parse(textBox4.Text);
                cmd2.Parameters[1].Value = int.Parse(textBox5.Text);
                cmd2.Parameters[2].Value = int.Parse(textBox6.Text);

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Cantidad actualizado correctamente");


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexion.Close();
            }



        }

        private void btDepartamentosProductos_Click(object sender, EventArgs e)
        {

            conexion.ConnectionString = strConexion;
            cmdLeer.CommandType = CommandType.Text;
            cmdLeer.CommandText = "SELECT * FROM departamentoProductos";

            cmdLeer.Connection = conexion;

            adapDepartamentos.SelectCommand = cmdLeer;

            bulDepartamentos.DataAdapter = adapDepartamentos;
            adapDepartamentos.UpdateCommand = bulDepartamentos.GetUpdateCommand();

            adapDepartamentos.Fill(dsDepartamentos2, "departamentosProductos");
            dataGridView2.DataSource = dsDepartamentos2.Tables[0];



        }
    }


}

          