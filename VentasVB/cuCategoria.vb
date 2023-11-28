Public Class cuCategoria
    Dim con As Conexion = New Conexion()

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearCategoria(tbDescripcion.Text, idUsuario)
        dgvDatos.DataSource = con.categorias()
    End Sub

    Private Sub cuCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.categorias()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarCategoria(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbDescripcion.Text, idUsuario)
        dgvDatos.DataSource = con.categorias()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Categoria", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.categorias()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbDescripcion.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
    End Sub
End Class
