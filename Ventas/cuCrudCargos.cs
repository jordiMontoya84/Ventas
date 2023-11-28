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
    public partial class cuCrudCargos : UserControl
    {
        Conexion con = new Conexion();
        public cuCrudCargos()
        {
            InitializeComponent();
            dgvDatos.DataSource = con.datosCargos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.crearCargo(tbDescripcion.Text,Convert.ToInt32(nudSueldo.Value), global.id);
            dgvDatos.DataSource = con.datosCargos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.actualizarCargo(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbDescripcion.Text, Convert.ToInt32(nudSueldo.Value), global.id);
            dgvDatos.DataSource = con.datosCargos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarTabla("Cargo",Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = con.datosCargos();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDescripcion.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
            nudSueldo.Value = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[2].Value);
        }
    }
}
