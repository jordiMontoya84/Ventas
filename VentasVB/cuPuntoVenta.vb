Public Class cuPuntoVenta
    Dim con As Conexion = New Conexion()
    Dim dt As DataTable = New DataTable()
    Private Sub cuPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbCliente.DataSource = con.clientes()
        cbCliente.DisplayMember = "nombre"
        cbCliente.ValueMember = "id"
    End Sub

    Private Sub cbCliente_DragDrop(sender As Object, e As DragEventArgs) Handles cbCliente.DragDrop
        cbCliente.DataSource = con.clientes()
    End Sub

    Private Sub tbCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            dt = con.articulo(tbCodigo.Text)
            If dt.Rows.Count <> 0 Then
                dgvArticulos.Rows.Add(dt.Rows(0)("id"), dt.Rows(0)("Descripcion"), dt.Rows(0)("Costo"), nudCantidad.Value)
                tbCodigo.Text = ""
                dt = Nothing
            End If

        End If
    End Sub

    Private Sub dgvArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellClick
        If e.ColumnIndex = 4 Then
            dgvArticulos.Rows.Remove(dgvArticulos.SelectedRows(0))
        End If
    End Sub

    Private Sub dgvArticulos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvArticulos.RowsAdded
        Dim total As Decimal = 0
        Dim r As DataGridViewRow
        For Each r In dgvArticulos.Rows
            total += Convert.ToDecimal(r.Cells("Costo").Value) * Convert.ToDecimal(r.Cells("Cantidad").Value)
        Next

        tbImporte.Text = total.ToString()
    End Sub

    Private Sub dgvArticulos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvArticulos.RowsRemoved
        Dim total As Decimal = 0
        Dim r As DataGridViewRow
        For Each r In dgvArticulos.Rows
            total += Convert.ToDecimal(r.Cells("Costo").Value) * Convert.ToDecimal(r.Cells("Cantidad").Value)
        Next

        tbImporte.Text = total.ToString()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        con.registrarVenta(Convert.ToInt32(cbCliente.SelectedValue), Convert.ToDecimal(tbImporte.Text), idUsuario, dgvArticulos)
        dgvArticulos.Rows.Clear()
    End Sub
End Class
