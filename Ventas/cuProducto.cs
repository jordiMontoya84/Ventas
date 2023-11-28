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
    public partial class cuProducto : UserControl
    {
        Conexion con = new Conexion();
        public cuProducto()
        {
            InitializeComponent();
            dgvDatos.DataSource = con.datosProducto();

            cbProveedor.DataSource = con.proveedores();
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "id";

            cbSucursal.DataSource = con.sucursales();
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "id";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.crearProducto(tbDescripcion.Text, Convert.ToInt32(nudCosto.Value), Convert.ToInt32(nudExistencia.Value), Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), global.id);
            dgvDatos.DataSource = con.datosProducto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.actualizarProducto(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbDescripcion.Text, Convert.ToInt32(nudCosto.Value), Convert.ToInt32(nudExistencia.Value), Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), global.id);
            dgvDatos.DataSource = con.datosProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarTabla("Producto", Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = con.datosProducto();
        }

        private void cbSucursal_DropDown(object sender, EventArgs e)
        {
            cbSucursal.DataSource = con.sucursales();
        }

        private void cbProveedor_DropDown(object sender, EventArgs e)
        {
            cbProveedor.DataSource = con.proveedores();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDescripcion.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
            nudCosto.Value= Convert.ToDecimal(dgvDatos.SelectedRows[0].Cells[2].Value);
            nudExistencia.Value= Convert.ToDecimal(dgvDatos.SelectedRows[0].Cells[3].Value);
        }
    }
}
