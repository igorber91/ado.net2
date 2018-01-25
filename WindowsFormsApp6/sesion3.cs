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
    public partial class sesion3 : Form
    {
        public sesion3()
        {
            InitializeComponent();
        }

        private void btVisualizarProductos_Click(object sender, EventArgs e)
        {
            visualizarVentasClientes fr = new visualizarVentasClientes();
            fr.Show();

        }

        private void btVisualizarCantidades_Click(object sender, EventArgs e)
        {
            visualizarCantidades fr = new visualizarCantidades();
            fr.Show();
        }

        private void btVisualizarVentas_Click(object sender, EventArgs e)
        {
            visualizarVentasProductos fr = new visualizarVentasProductos();
            fr.Show();

        }

        private void visualizarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            visualizarVentasClientes fr = new visualizarVentasClientes();
            fr.Show();

        }

        private void visualizarCantidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizarCantidades fr = new visualizarCantidades();
            fr.Show();

        }

        private void visualizarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizarVentasProductos fr = new visualizarVentasProductos();
            fr.Show();

        }
    }
}
