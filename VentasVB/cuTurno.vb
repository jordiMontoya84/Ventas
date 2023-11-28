Public Class cuTurno
    Dim con As Conexion = New Conexion()
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearTurno(tbEntrada.Text, tbSalida.Text, idUsuario)
        dgvDatos.DataSource = con.datosTurnos()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarTurno(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbEntrada.Text, tbSalida.Text, idUsuario)
        dgvDatos.DataSource = con.datosTurnos()
    End Sub

    Private Sub cuTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.datosTurnos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Turno", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.datosTurnos()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbEntrada.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
        tbSalida.Text = dgvDatos.SelectedRows(0).Cells(2).Value.ToString()
    End Sub
End Class
