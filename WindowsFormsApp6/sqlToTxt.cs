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
    public partial class sqlToTxt : Form
    {
        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();

        public sqlToTxt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\igor\Dropbox\&DAM\&&Ignacio\deberes\casa\prueba2.txt";
            using (StreamWriter outputFile = new StreamWriter(file, true))
            {



                conexion.ConnectionString = strconexion;

                cmdLeer.CommandType = CommandType.Text;

                cmdLeer.Connection = conexion;
                cmdLeer.CommandText = "SELECT nombre FROM productos WHERE idProducto = 1";

                conexion.Open();
                
                //Execute command and write output to file
                outputFile.WriteLine(cmdLeer.ExecuteScalar().ToString());

                conexion.Close();

            }
        }
    }
}
