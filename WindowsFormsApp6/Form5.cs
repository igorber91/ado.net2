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
    public partial class Form5 : Form
    {
        SqlConnection conexion = new SqlConnection();
        string strConexion = @"data source=primero100\primero;initial catalog=AVAN_Igor;integrated security=true;";

        SqlCommand cmd = new SqlCommand();
        SqlParameter prmIdDepartamento = new SqlParameter();
        SqlParameter prmNombre = new SqlParameter();
        SqlParameter prmCantidadTotal = new SqlParameter();
        SqlParameter prmSalida = new SqlParameter();


        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
               //prmSalida.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(prmIdDepartamento);
                cmd.Parameters.Add(prmNombre);
                cmd.Parameters.Add(prmCantidadTotal);
              cmd.Parameters.Add(prmSalida);
            
        }


      

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Parameters[0].Value = int.Parse(textBox1.Text);
            cmd.Parameters[1].Value = textBox2.Text;
            cmd.Parameters[2].Value = int.Parse(textBox3.Text);

     

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
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
