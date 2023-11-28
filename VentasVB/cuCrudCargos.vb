Public Class cuCrudCargos
    Dim con As Conexion = New Conexion()
    Private Sub cuCrudCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.datosCargos()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearCargo(tbDescripcion.Text, Convert.ToInt32(nudSueldo.Value), idUsuario)
        dgvDatos.DataSource = con.datosCargos()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarCargo(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbDescripcion.Text, Convert.ToInt32(nudSueldo.Value), idUsuario)
        dgvDatos.DataSource = con.datosCargos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Cargo", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.datosCargos()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbDescripcion.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
        nudSueldo.Value = Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(2).Value)
    End Sub
End Class
