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
    public partial class sesion : Form
    {

        public sesion()
        {
            InitializeComponent();
        }

        


        private void sesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cs = @"data source=LAPTOP-3HIKQTUO;initial catalog=AVAN_Igor; integrated security=true";
            //string cs = @"data source=primero100\primero;initial catalog=AVAN_Igor; integrated security=true";


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                

                
                //Conexion SQL
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select idCliente from clientes where nombre=@username and contrasegna=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);



                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);


                //creo variables para el cliente
                session.Nombre = textBox1.Text;
                session.Password = textBox2.Text;
                session.UserID = int.Parse(cmd.ExecuteScalar().ToString());
                MessageBox.Show(session.UserID.ToString());



                con.Close();
                int count = ds.Tables[0].Rows.Count;

                //Si la cuenta es igual a 1 mostrar otro formulario
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    sesion2 fm = new sesion2();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            sesion3 fm = new sesion3();
            fm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sesion4 fm = new sesion4();
            fm.Show();

        }

        private void btRegistrarCliente_Click(object sender, EventArgs e)
        {
            registrarCliente fm = new registrarCliente();
            fm.Show();
        }
    }
}
