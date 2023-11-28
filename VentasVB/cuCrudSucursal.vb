Public Class cuCrudSucursal
    Dim con As Conexion = New Conexion()
    Private Sub cuCrudSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.datosSucursales()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearSucursal(tbNombre.Text, tbTelefono.Text, tbEstado.Text, tbCiudad.Text, tbColonia.Text, tbCalle.Text, tbNumero.Text, idUsuario)
        dgvDatos.DataSource = con.datosSucursales()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarSucursal(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbNombre.Text, tbTelefono.Text, tbEstado.Text, tbCiudad.Text, tbColonia.Text, tbCalle.Text, tbNumero.Text, idUsuario)
        dgvDatos.DataSource = con.datosSucursales()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Sucursal", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.datosSucursales()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbNombre.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
        tbTelefono.Text = dgvDatos.SelectedRows(0).Cells(2).Value.ToString()
        tbEstado.Text = dgvDatos.SelectedRows(0).Cells(3).Value.ToString()
        tbCiudad.Text = dgvDatos.SelectedRows(0).Cells(4).Value.ToString()
        tbColonia.Text = dgvDatos.SelectedRows(0).Cells(5).Value.ToString()
        tbCalle.Text = dgvDatos.SelectedRows(0).Cells(6).Value.ToString()
        tbNumero.Text = dgvDatos.SelectedRows(0).Cells(7).Value.ToString()
    End Sub
End Class
