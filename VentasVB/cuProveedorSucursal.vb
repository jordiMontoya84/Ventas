Public Class cuProveedorSucursal
    Dim cone As Conexion = New Conexion()
    Private Sub cuProveedorSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = cone.datosSucursalProveedor()

        cbProveedor.DataSource = cone.proveedores()
        cbProveedor.DisplayMember = "nombre"
        cbProveedor.ValueMember = "id"

        cbSucursal.DataSource = cone.sucursales()
        cbSucursal.DisplayMember = "nombre"
        cbSucursal.ValueMember = "id"
    End Sub

    Private Sub cbSucursal_DragDrop(sender As Object, e As DragEventArgs) Handles cbSucursal.DragDrop
        cbSucursal.DataSource = cone.sucursales()
    End Sub

    Private Sub cbProveedor_DragDrop(sender As Object, e As DragEventArgs) Handles cbProveedor.DragDrop
        cbProveedor.DataSource = cone.proveedores()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        cone.crearSucursalProveedor(Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), idUsuario)
        dgvDatos.DataSource = cone.datosSucursalProveedor()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cone.actualizarSucursalProveedor(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbProveedor.SelectedValue), idUsuario)
        dgvDatos.DataSource = cone.datosSucursalProveedor()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        cone.eliminarTabla("SucursalProveedor", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = cone.datosSucursalProveedor()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick

    End Sub
End Class
