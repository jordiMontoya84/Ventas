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
    public partial class cuCliente : UserControl
    {
        Conexion con = new Conexion();
        public cuCliente()
        {
            InitializeComponent();
            dgvDatos.DataSource = con.datosCliente();

            cbSucursal.DataSource = con.sucursales();
            cbSucursal.DisplayMember = "nombre";
            cbSucursal.ValueMember = "id";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.crearCliente(tbNombre.Text, tbCp.Text, tbRfc.Text, tbCfdi.Text, tbRegimen.Text, Convert.ToInt32(cbSucursal.SelectedValue), global.id);
            dgvDatos.DataSource = con.datosCliente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.actualizarCliente(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbNombre.Text, tbCp.Text, tbRfc.Text, tbCfdi.Text, tbRegimen.Text, Convert.ToInt32(cbSucursal.SelectedValue), global.id);
            dgvDatos.DataSource = con.datosCliente();
        }

        private void cbSucursal_DropDown(object sender, EventArgs e)
        {
            cbSucursal.DataSource = con.sucursales();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
            tbCp.Text = dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
            tbRfc.Text = dgvDatos.SelectedRows[0].Cells[3].Value.ToString();
            tbCfdi.Text = dgvDatos.SelectedRows[0].Cells[4].Value.ToString();
            tbRegimen.Text = dgvDatos.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarTabla("Cliente", Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = con.datosCliente();
        }
    }
}
