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
	public partial class cuTurno : UserControl
	{
		Conexion con = new Conexion();
		public cuTurno()
		{
			InitializeComponent();
			dgvDatos.DataSource = con.datosTurnos();
		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			con.crearTurno(tbEntrada.Text, tbSalida.Text, global.id);
			dgvDatos.DataSource = con.datosTurnos();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			con.actualizarTurno(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbEntrada.Text, tbSalida.Text, global.id);
			dgvDatos.DataSource = con.datosTurnos();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			con.eliminarTabla("Turno",Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
			dgvDatos.DataSource = con.datosTurnos();
		}

		private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tbEntrada.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
			tbSalida.Text = dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
		}
	}
}
