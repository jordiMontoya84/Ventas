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
	public partial class cuVentas : UserControl
	{
		Conexion con = new Conexion();
		public cuVentas()
		{
			InitializeComponent();
			dgvDatos.DataSource = con.datosVenta();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			con.eliminarTabla("venta", Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
			dgvDatos.DataSource = con.datosVenta();
		}
	}
}
