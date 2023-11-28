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
    public partial class cuEmpleado : UserControl
    {
        Conexion con = new Conexion();
        public cuEmpleado()
        {
            InitializeComponent();
            dgvDatos.DataSource = con.datosEmpleado();

            cbCargo.DataSource = con.cargos();
            cbCargo.DisplayMember = "Descripcion";
            cbCargo.ValueMember = "Id";

            cbSucursal.DataSource = con.sucursales();
            cbSucursal.DisplayMember = "Nombre";
            cbSucursal.ValueMember = "Id";

            cbTurno.DataSource = con.turno();
            cbTurno.DisplayMember = "hraentrada";
            cbTurno.ValueMember = "Id";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.crearEmpleado(tbNombre.Text, tbApPat.Text, tbApMat.Text, tbTel.Text, tbRfc.Text, tbCorreo.Text, tbContra.Text, Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbCargo.SelectedValue), Convert.ToInt32(cbTurno.SelectedValue), global.id);
            dgvDatos.DataSource = con.datosEmpleado();
        }

        private void cbSucursal_DropDown(object sender, EventArgs e)
        {
            cbSucursal.DataSource = con.sucursales();
        }

        private void cbCargo_DropDown(object sender, EventArgs e)
        {
            cbCargo.DataSource = con.cargos();
        }

        private void cbTurno_DropDown(object sender, EventArgs e)
        {
            cbTurno.DataSource = con.turno();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.actualizarEmpleado(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbNombre.Text, tbApPat.Text, tbApMat.Text, tbTel.Text, tbRfc.Text, tbCorreo.Text, tbContra.Text, Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbCargo.SelectedValue), Convert.ToInt32(cbTurno.SelectedValue), global.id);
            dgvDatos.DataSource = con.datosEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarTabla("Empleado", Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = con.datosEmpleado();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
            tbApPat.Text = dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
            tbApMat.Text = dgvDatos.SelectedRows[0].Cells[3].Value.ToString();
            tbTel.Text = dgvDatos.SelectedRows[0].Cells[4].Value.ToString();
            tbRfc.Text = dgvDatos.SelectedRows[0].Cells[5].Value.ToString();
            tbCorreo.Text = dgvDatos.SelectedRows[0].Cells[6].Value.ToString();
            tbContra.Text = dgvDatos.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
