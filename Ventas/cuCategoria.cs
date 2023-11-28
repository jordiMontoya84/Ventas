using System;
using System.Windows.Forms;

namespace Ventas
{
    public partial class cuCategoria : UserControl
    {
        Conexion con = new Conexion();
        public cuCategoria()
        {
            InitializeComponent();
            dgvDatos.DataSource = con.categorias();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.crearCategoria(tbDescripcion.Text, global.id);
            dgvDatos.DataSource = con.categorias();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.actualizarCategoria(Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), tbDescripcion.Text, global.id);
            dgvDatos.DataSource = con.categorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminarTabla("Categoria", Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value), global.id);
            dgvDatos.DataSource = con.categorias();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDescripcion.Text = dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
