Public Class cuCliente
    Dim con As Conexion = New Conexion()

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearCliente(tbNombre.Text, tbCp.Text, tbRfc.Text, tbCfdi.Text, tbRegimen.Text, Convert.ToInt32(cbSucursal.SelectedValue), idUsuario)
        dgvDatos.DataSource = con.datosCliente()
    End Sub

    Private Sub cuCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.datosCliente()

        cbSucursal.DataSource = con.sucursales()
        cbSucursal.DisplayMember = "nombre"
        cbSucursal.ValueMember = "id"
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarCliente(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbNombre.Text, tbCp.Text, tbRfc.Text, tbCfdi.Text, tbRegimen.Text, Convert.ToInt32(cbSucursal.SelectedValue), idUsuario)
        dgvDatos.DataSource = con.datosCliente()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Cliente", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.datosCliente()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbNombre.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
        tbCp.Text = dgvDatos.SelectedRows(0).Cells(2).Value.ToString()
        tbRfc.Text = dgvDatos.SelectedRows(0).Cells(3).Value.ToString()
        tbCfdi.Text = dgvDatos.SelectedRows(0).Cells(4).Value.ToString()
        tbRegimen.Text = dgvDatos.SelectedRows(0).Cells(5).Value.ToString()
    End Sub

    Private Sub cbSucursal_DropDown(sender As Object, e As EventArgs) Handles cbSucursal.DropDown
        cbSucursal.DataSource = con.sucursales()
    End Sub
End Class
