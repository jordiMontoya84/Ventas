Imports Npgsql
Public Class frmVentas
	Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim con As NpgsqlConnection = New NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Ventas;User Id=postgres;Password=jordi123;")
		CuPuntoVenta1.BringToFront()

	End Sub

	Private Sub proveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles proveedorToolStripMenuItem.Click
		CuProveedor1.BringToFront()

	End Sub

	Private Sub sucursalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sucursalToolStripMenuItem.Click
		CuCrudSucursal1.BringToFront()

	End Sub

	Private Sub cargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cargoToolStripMenuItem.Click
		CuCrudCargos1.BringToFront()

	End Sub

	Private Sub turnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles turnoToolStripMenuItem.Click
		CuTurno1.BringToFront()
	End Sub

	Private Sub empleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles empleadoToolStripMenuItem.Click
		CuEmpleado1.BringToFront()

	End Sub

	Private Sub categoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles categoriaToolStripMenuItem.Click
		CuCategoria1.BringToFront()

	End Sub

	Private Sub clienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clienteToolStripMenuItem.Click
		CuCliente1.BringToFront()

	End Sub

	Private Sub productoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles productoToolStripMenuItem.Click
		CuProducto1.BringToFront()

	End Sub

	Private Sub sucursalProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sucursalProveedorToolStripMenuItem.Click
		CuProveedorSucursal1.BringToFront()

	End Sub

	Private Sub nuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles nuevaVentaToolStripMenuItem.Click
		CuPuntoVenta1.BringToFront()
	End Sub

	Private Sub listaVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles listaVentasToolStripMenuItem.Click
		CuVentas1.BringToFront()

	End Sub

	Private Sub frmVentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		Application.Exit()

	End Sub
End Class
