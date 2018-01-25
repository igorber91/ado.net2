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
    public partial class departamentosProductos : Form
    {
        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();
        SqlCommand cmdLeer2 = new SqlCommand();

        SqlDataAdapter adapDepartamentos = new SqlDataAdapter();

        SqlDataAdapter adapProductos = new SqlDataAdapter();
        SqlCommandBuilder bulProductos = new SqlCommandBuilder();
        DataSet dsProductos = new DataSet();
        DataSet dsDepartamentos = new DataSet();



        public departamentosProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {



            string curItem = listBox1.Text;

            conexion.ConnectionString = strconexion;
            cmdLeer.CommandType = CommandType.Text;

            cmdLeer.CommandText ="select * from productos inner join departamentoProductos on departamentoProductos.idProducto " +
                "= productos.idProducto inner join departamento on departamento.idDepartamento = departamentoProductos.idDepartamento " +
                "where departamento.nombre = '"+curItem+"'";

            cmdLeer.Connection = conexion;

            adapProductos.SelectCommand = cmdLeer;

            bulProductos.DataAdapter = adapProductos;



            adapProductos.Fill(dsProductos, "Productos");
            adapProductos.Fill(dsProductos, "departamentoProductos");

            dataGridView1.DataSource = dsProductos.Tables[0];
            dataGridView1.DataSource = dsProductos.Tables[1];

        }

        private void departamentosProductos_Load(object sender, EventArgs e)
        {


            cmdLeer2.Connection = conexion;


            conexion.ConnectionString = strconexion;
            cmdLeer2.CommandType = CommandType.Text;
            cmdLeer2.CommandText = "select * from departamento";

            adapDepartamentos.SelectCommand = cmdLeer2;

            adapDepartamentos.Fill(dsDepartamentos, "departamentos");

            listBox1.DataSource = dsDepartamentos.Tables["departamentos"];
            listBox1.DisplayMember = "nombre";

        }
        
    }
}
