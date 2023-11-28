Public Class cuProveedor
    Dim con As Conexion = New Conexion()
    Private Sub cuProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.datosProveedores()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearProveedor(tbNombre.Text, tbCorreo.Text, tbTelefono.Text, tbCuenta.Text, idUsuario)
        dgvDatos.DataSource = con.datosProveedores()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarProveedor(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbNombre.Text, tbCorreo.Text, tbTelefono.Text, tbCuenta.Text, idUsuario)
        dgvDatos.DataSource = con.datosProveedores()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Proveedor", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.datosProveedores()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbNombre.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
        tbCorreo.Text = dgvDatos.SelectedRows(0).Cells(2).Value.ToString()
        tbTelefono.Text = dgvDatos.SelectedRows(0).Cells(3).Value.ToString()
        tbCuenta.Text = dgvDatos.SelectedRows(0).Cells(4).Value.ToString()
    End Sub
End Class
