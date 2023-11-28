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
	public partial class cuPuntoVenta : UserControl
	{
		Conexion con = new Conexion();
		DataTable dt = new DataTable();

		public cuPuntoVenta()
		{
			InitializeComponent();
			cbCliente.DataSource = con.clientes();
			cbCliente.DisplayMember = "nombre";
			cbCliente.ValueMember = "id";
		}

		private void tbCodigo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				dt = con.articulo(tbCodigo.Text);
				if (dt.Rows.Count != 0)
				{
					dgvArticulos.Rows.Add(dt.Rows[0]["id"], dt.Rows[0]["Descripcion"], dt.Rows[0]["Costo"], nudCantidad.Value);
					tbCodigo.Text = "";
					dt = null;
				}

			}
		}

		private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
				if (e.ColumnIndex == 4)
				{
					dgvArticulos.Rows.Remove(dgvArticulos.SelectedRows[0]);
				}
		}

		private void dgvArticulos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			decimal total = 0;
			foreach (DataGridViewRow r in dgvArticulos.Rows)
			{
				total += Convert.ToDecimal(r.Cells["Costo"].Value) * Convert.ToDecimal(r.Cells["Cantidad"].Value);
			}

			tbImporte.Text = total.ToString();
		}

		private void dgvArticulos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			decimal total = 0;
			foreach (DataGridViewRow r in dgvArticulos.Rows)
			{
				total += Convert.ToDecimal(r.Cells["Costo"].Value)* Convert.ToDecimal(r.Cells["Cantidad"].Value);
			}

			tbImporte.Text = total.ToString();
		}

		private void cbCliente_DropDown(object sender, EventArgs e)
		{
			cbCliente.DataSource = con.clientes();
		}

		private void btnPagar_Click(object sender, EventArgs e)
		{
			con.registrarVenta(Convert.ToInt32(cbCliente.SelectedValue), Convert.ToDecimal(tbImporte.Text), global.id, dgvArticulos);
			dgvArticulos.Rows.Clear();
		}
	}
}
