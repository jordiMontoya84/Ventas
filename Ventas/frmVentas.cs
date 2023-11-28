using System;
using System.Windows.Forms;

namespace Ventas
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
            cuPuntoVenta1.BringToFront();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuProveedor1.BringToFront();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuCrudSucursal1.BringToFront();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuCrudCargos1.BringToFront();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuTurno1.BringToFront();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuEmpleado1.BringToFront();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuCategoria1.BringToFront();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuCliente1.BringToFront();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuProducto1.BringToFront();
        }

        private void sucursalProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuProveedorSucursal1.BringToFront();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuPuntoVenta1.BringToFront();
        }

        private void listaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuVentas1.BringToFront();
        }

        private void frmVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
