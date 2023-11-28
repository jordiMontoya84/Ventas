Public Class cuEmpleado
    Dim con As Conexion = New Conexion()
    Private Sub cuEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDatos.DataSource = con.datosEmpleado()

        cbCargo.DataSource = con.cargos()
        cbCargo.DisplayMember = "Descripcion"
        cbCargo.ValueMember = "Id"

        cbSucursal.DataSource = con.sucursales()
        cbSucursal.DisplayMember = "Nombre"
        cbSucursal.ValueMember = "Id"

        cbTurno.DataSource = con.turno()
        cbTurno.DisplayMember = "hraentrada"
        cbTurno.ValueMember = "Id"
    End Sub

    Private Sub cbSucursal_DragDrop(sender As Object, e As DragEventArgs) Handles cbSucursal.DragDrop
        cbSucursal.DataSource = con.sucursales()
    End Sub

    Private Sub cbCargo_DragDrop(sender As Object, e As DragEventArgs) Handles cbCargo.DragDrop
        cbCargo.DataSource = con.cargos()
    End Sub

    Private Sub cbTurno_DragDrop(sender As Object, e As DragEventArgs) Handles cbTurno.DragDrop
        cbTurno.DataSource = con.turno()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        con.crearEmpleado(tbNombre.Text, tbApPat.Text, tbApMat.Text, tbTel.Text, tbRfc.Text, tbCorreo.Text, tbContra.Text, Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbCargo.SelectedValue), Convert.ToInt32(cbTurno.SelectedValue), idUsuario)
        dgvDatos.DataSource = con.datosEmpleado()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        con.actualizarEmpleado(Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), tbNombre.Text, tbApPat.Text, tbApMat.Text, tbTel.Text, tbRfc.Text, tbCorreo.Text, tbContra.Text, Convert.ToInt32(cbSucursal.SelectedValue), Convert.ToInt32(cbCargo.SelectedValue), Convert.ToInt32(cbTurno.SelectedValue), idUsuario)
        dgvDatos.DataSource = con.datosEmpleado()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        con.eliminarTabla("Empleado", Convert.ToInt32(dgvDatos.SelectedRows(0).Cells(0).Value), idUsuario)
        dgvDatos.DataSource = con.datosEmpleado()
    End Sub

    Private Sub dgvDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellClick
        tbNombre.Text = dgvDatos.SelectedRows(0).Cells(1).Value.ToString()
        tbApPat.Text = dgvDatos.SelectedRows(0).Cells(2).Value.ToString()
        tbApMat.Text = dgvDatos.SelectedRows(0).Cells(3).Value.ToString()
        tbTel.Text = dgvDatos.SelectedRows(0).Cells(4).Value.ToString()
        tbRfc.Text = dgvDatos.SelectedRows(0).Cells(5).Value.ToString()
        tbCorreo.Text = dgvDatos.SelectedRows(0).Cells(6).Value.ToString()
        tbContra.Text = dgvDatos.SelectedRows(0).Cells(7).Value.ToString()
    End Sub
End Class
