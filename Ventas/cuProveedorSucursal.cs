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
    public partial class cuProveedorSucursal : UserControl
    {
        Conexion cone = new Conexion();
        public cuProveedorSucursal()
        {
            InitializeComponent();
            dgvDatos.DataSource = cone.datosSucursalProveedor();

            cbProveedor.DataSource = cone.proveedores();
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "id";

            cbSucursal.DataSource = cone.sucursales();
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "id";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            cone.crearSucursalProveedor(Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), global.id);
            dgvDatos.DataSource = cone.datosSucursalProveedor();
        }

        private void cbSucursal_DropDown(object sender, EventArgs e)
        {
            cbSucursal.DataSource = cone.sucursales();
        }

        private void cbProveedor_DropDown(object sender, EventArgs e)
        {
            cbProveedor.DataSource = cone.proveedores();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cone.actualizarSucursalProveedor(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), global.id);
            dgvDatos.DataSource = cone.datosSucursalProveedor();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cone.eliminarTabla("SucursalProveedor", Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = cone.datosSucursalProveedor();
        }
    }
}
