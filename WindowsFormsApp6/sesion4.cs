using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class sesion4 : Form
    {
        public sesion4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visualizarActualizarDepartamentos fr = new visualizarActualizarDepartamentos();
            fr.Show();
        }

        private void btInsertarProductos_Click(object sender, EventArgs e)
        {
            insertarProductos fr = new insertarProductos();
            fr.Show();

        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            ventas2 fr = new ventas2();
            fr.Show();
        }

        private void btGastado_Click(object sender, EventArgs e)
        {
            visualizarClientesCuenta fr = new visualizarClientesCuenta();
            fr.Show();

        }

        private void actualizarDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizarActualizarDepartamentos fr = new visualizarActualizarDepartamentos();
            fr.Show();

        }

        private void insertarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertarProductos fr = new insertarProductos();
            fr.Show();

        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventas2 fr = new ventas2();
            fr.Show();

        }

        private void verGastadoPorClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizarClientesCuenta fr = new visualizarClientesCuenta();
            fr.Show();

        }
    }
}
