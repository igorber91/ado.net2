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
    public partial class dataReader : Form
    {
        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";

        SqlCommand cmdLeer = new SqlCommand();


        public dataReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataReader myReader;


            conexion.ConnectionString = strconexion;

            cmdLeer.CommandType = CommandType.Text;

            cmdLeer.Connection = conexion;
            cmdLeer.CommandText = "SELECT precioVenta,nombre FROM productos";

            int RecordCount = 0;

            try
            {
                conexion.Open();
                myReader = cmdLeer.ExecuteReader();

                while (myReader.Read())
                {
                    //Write logic to process data for the first result.

                          RecordCount = RecordCount + 1;


                    string col1Value = myReader[0].ToString();

                    string col2Value = myReader[1].ToString();

                    MessageBox.Show(col1Value);
                    MessageBox.Show(col2Value);

                }
                MessageBox.Show("Total number of productos: " + RecordCount.ToString());

                myReader.NextResult();
                RecordCount = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
