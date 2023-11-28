using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class cuProveedor : UserControl
    {
        Conexion con = new Conexion();
        public cuProveedor()
        {
            InitializeComponent();
            dgvDatos.DataSource = con.datosProveedores();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.crearProveedor(tbNombre.Text, tbCorreo.Text, tbTelefono.Text, tbCuenta.Text, global.id);
            dgvDatos.DataSource = con.datosProveedores();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.actualizarProveedor(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbNombre.Text, tbCorreo.Text, tbTelefono.Text, tbCuenta.Text, global.id);
            dgvDatos.DataSource = con.datosProveedores();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
            tbCorreo.Text = dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
            tbTelefono.Text = dgvDatos.SelectedRows[0].Cells[3].Value.ToString();
            tbCuenta.Text = dgvDatos.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarTabla("Proveedor",Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = con.datosProveedores();
        }
    }
}
