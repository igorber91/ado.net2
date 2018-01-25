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
    public partial class sesion2 : Form
    {

        SqlConnection conexion = new SqlConnection();
        //string strconexion = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
        string strconexion = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";
        SqlCommand cmdLeer = new SqlCommand();

        public sesion2()
        {
            InitializeComponent();
        }

        private void sesion2_Load(object sender, EventArgs e)
        {

            MessageBox.Show(session.Nombre);
            MessageBox.Show(session.Password);



        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            sesion fl = new sesion();
            fl.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

       

        private void btVentas_Click(object sender, EventArgs e)
        {
            ventas fr = new ventas();
            fr.Show();
        }

       

       
        private void btDepartamentosProductos_Click(object sender, EventArgs e)
        {
            departamentosProductos fr = new departamentosProductos();
            fr.Show();
        }

        
    }
    
}
