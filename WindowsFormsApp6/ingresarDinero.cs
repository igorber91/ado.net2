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
    public partial class ingresarDinero : Form
    {
        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdModificarCuenta = new SqlCommand();

        SqlDataAdapter adapCuentas = new SqlDataAdapter();
        SqlCommandBuilder bulCuentas = new SqlCommandBuilder();
        SqlTransaction trans;


        DataSet dsCuenta = new DataSet();

        string dinero;
        string idCuenta;

        public ingresarDinero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dinero = txtDinero.Text;
            idCuenta = txtIdCuenta.Text;

            conexion.ConnectionString = strconexion;
            cmdModificarCuenta.Connection = conexion;

            conexion.Open();
            cmdModificarCuenta.CommandType = CommandType.Text;
            cmdModificarCuenta.CommandText ="Update  cuentas set dinero="+dinero+"where idCuenta="+idCuenta+"";

            cmdModificarCuenta.ExecuteNonQuery();
            
            conexion.Close();

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            ventas fr = new ventas();
            fr.Show();
            this.Close();
        
        }
    }
}
