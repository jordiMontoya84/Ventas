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
    public partial class cuCrudSucursal : UserControl
    {
        Conexion con = new Conexion();
        public cuCrudSucursal()
        {
            InitializeComponent();
            dgvDatos.DataSource = con.datosSucursales();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.crearSucursal(tbNombre.Text, tbTelefono.Text, tbEstado.Text, tbCiudad.Text, tbColonia.Text, tbCalle.Text, tbNumero.Text, global.id);
            dgvDatos.DataSource = con.datosSucursales();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.actualizarSucursal(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbNombre.Text, tbTelefono.Text, tbEstado.Text, tbCiudad.Text, tbColonia.Text, tbCalle.Text, tbNumero.Text, global.id);
            dgvDatos.DataSource = con.datosSucursales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarTabla("Sucursal",Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = con.datosSucursales();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
            tbTelefono.Text = dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
            tbEstado.Text = dgvDatos.SelectedRows[0].Cells[3].Value.ToString();
            tbCiudad.Text = dgvDatos.SelectedRows[0].Cells[4].Value.ToString();
            tbColonia.Text = dgvDatos.SelectedRows[0].Cells[5].Value.ToString();
            tbCalle.Text = dgvDatos.SelectedRows[0].Cells[6].Value.ToString();
            tbNumero.Text = dgvDatos.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
