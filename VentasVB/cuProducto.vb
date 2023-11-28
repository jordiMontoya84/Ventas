Public Class cuProducto
    Dim con As Conexion = New Conexion()
    Private Sub cuProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.datosProducto()

        cbProveedor.DataSource = con.proveedores()
        cbProveedor.DisplayMember = "nombre"
        cbProveedor.ValueMember = "id"

        cbSucursal.DataSource = con.sucursales()
        cbSucursal.DisplayMember = "nombre"
        cbSucursal.ValueMember = "id"
    End Sub

    Private Sub cbSucursal_DragDrop(sender As Object, e As DragEventArgs) Handles cbSucursal.DragDrop
        cbSucursal.DataSource = con.sucursales()
    End Sub

    Private Sub cbProveedor_DragDrop(sender As Object, e As DragEventArgs) Handles cbProveedor.DragDrop
        cbProveedor.DataSource = con.proveedores()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearProducto(tbDescripcion.Text, Convert.ToInt32(nudCosto.Value), Convert.ToInt32(nudExistencia.Value), Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), idUsuario)
        dgvDatos.DataSource = con.datosProducto()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarProducto(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbDescripcion.Text, Convert.ToInt32(nudCosto.Value), Convert.ToInt32(nudExistencia.Value), Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), idUsuario)
        dgvDatos.DataSource = con.datosProducto()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Producto", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.datosProducto()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbDescripcion.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
        nudCosto.Value = Convert.ToDecimal(dgvDatos.SelectedRows(0).Cells(2).Value)
        nudExistencia.Value = Convert.ToDecimal(dgvDatos.SelectedRows(0).Cells(3).Value)
    End Sub
End Class
