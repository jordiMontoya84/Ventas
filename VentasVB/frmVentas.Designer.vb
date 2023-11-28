<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.cRUDsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.proveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.sucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.cargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.turnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.empleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.categoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.clienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.productoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.sucursalProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ventasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.nuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.listaVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CuProveedorSucursal1 = New VentasVB.cuProveedorSucursal()
		Me.CuProducto1 = New VentasVB.cuProducto()
		Me.CuCliente1 = New VentasVB.cuCliente()
		Me.CuEmpleado1 = New VentasVB.cuEmpleado()
		Me.CuVentas1 = New VentasVB.cuVentas()
		Me.CuTurno1 = New VentasVB.cuTurno()
		Me.CuPuntoVenta1 = New VentasVB.cuPuntoVenta()
		Me.CuProveedor1 = New VentasVB.cuProveedor()
		Me.CuCrudSucursal1 = New VentasVB.cuCrudSucursal()
		Me.CuCrudCargos1 = New VentasVB.cuCrudCargos()
		Me.CuCategoria1 = New VentasVB.cuCategoria()
		Me.menuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cRUDsToolStripMenuItem, Me.ventasToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(800, 24)
		Me.menuStrip1.TabIndex = 2
		Me.menuStrip1.Text = "menuStrip1"
		'
		'cRUDsToolStripMenuItem
		'
		Me.cRUDsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.proveedorToolStripMenuItem, Me.sucursalToolStripMenuItem, Me.cargoToolStripMenuItem, Me.turnoToolStripMenuItem, Me.empleadoToolStripMenuItem, Me.categoriaToolStripMenuItem, Me.clienteToolStripMenuItem, Me.productoToolStripMenuItem, Me.sucursalProveedorToolStripMenuItem})
		Me.cRUDsToolStripMenuItem.Name = "cRUDsToolStripMenuItem"
		Me.cRUDsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
		Me.cRUDsToolStripMenuItem.Text = "CRUDs"
		'
		'proveedorToolStripMenuItem
		'
		Me.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem"
		Me.proveedorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.proveedorToolStripMenuItem.Text = "Proveedor"
		'
		'sucursalToolStripMenuItem
		'
		Me.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem"
		Me.sucursalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.sucursalToolStripMenuItem.Text = "Sucursal"
		'
		'cargoToolStripMenuItem
		'
		Me.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem"
		Me.cargoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.cargoToolStripMenuItem.Text = "Cargo"
		'
		'turnoToolStripMenuItem
		'
		Me.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem"
		Me.turnoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.turnoToolStripMenuItem.Text = "Turno"
		'
		'empleadoToolStripMenuItem
		'
		Me.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem"
		Me.empleadoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.empleadoToolStripMenuItem.Text = "Empleado"
		'
		'categoriaToolStripMenuItem
		'
		Me.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem"
		Me.categoriaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.categoriaToolStripMenuItem.Text = "Categoria"
		'
		'clienteToolStripMenuItem
		'
		Me.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem"
		Me.clienteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.clienteToolStripMenuItem.Text = "Cliente"
		'
		'productoToolStripMenuItem
		'
		Me.productoToolStripMenuItem.Name = "productoToolStripMenuItem"
		Me.productoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.productoToolStripMenuItem.Text = "Producto"
		'
		'sucursalProveedorToolStripMenuItem
		'
		Me.sucursalProveedorToolStripMenuItem.Name = "sucursalProveedorToolStripMenuItem"
		Me.sucursalProveedorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
		Me.sucursalProveedorToolStripMenuItem.Text = "Sucursal-Proveedor"
		'
		'ventasToolStripMenuItem
		'
		Me.ventasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevaVentaToolStripMenuItem, Me.listaVentasToolStripMenuItem})
		Me.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem"
		Me.ventasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
		Me.ventasToolStripMenuItem.Text = "Ventas"
		'
		'nuevaVentaToolStripMenuItem
		'
		Me.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem"
		Me.nuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
		Me.nuevaVentaToolStripMenuItem.Text = "Nueva Venta"
		'
		'listaVentasToolStripMenuItem
		'
		Me.listaVentasToolStripMenuItem.Name = "listaVentasToolStripMenuItem"
		Me.listaVentasToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
		Me.listaVentasToolStripMenuItem.Text = "Lista Ventas"
		'
		'CuProveedorSucursal1
		'
		Me.CuProveedorSucursal1.Location = New System.Drawing.Point(23, 27)
		Me.CuProveedorSucursal1.Name = "CuProveedorSucursal1"
		Me.CuProveedorSucursal1.Size = New System.Drawing.Size(738, 430)
		Me.CuProveedorSucursal1.TabIndex = 13
		'
		'CuProducto1
		'
		Me.CuProducto1.Location = New System.Drawing.Point(23, 27)
		Me.CuProducto1.Name = "CuProducto1"
		Me.CuProducto1.Size = New System.Drawing.Size(738, 430)
		Me.CuProducto1.TabIndex = 12
		'
		'CuCliente1
		'
		Me.CuCliente1.Location = New System.Drawing.Point(23, 27)
		Me.CuCliente1.Name = "CuCliente1"
		Me.CuCliente1.Size = New System.Drawing.Size(738, 430)
		Me.CuCliente1.TabIndex = 11
		'
		'CuEmpleado1
		'
		Me.CuEmpleado1.Location = New System.Drawing.Point(23, 27)
		Me.CuEmpleado1.Name = "CuEmpleado1"
		Me.CuEmpleado1.Size = New System.Drawing.Size(738, 430)
		Me.CuEmpleado1.TabIndex = 10
		'
		'CuVentas1
		'
		Me.CuVentas1.Location = New System.Drawing.Point(23, 27)
		Me.CuVentas1.Name = "CuVentas1"
		Me.CuVentas1.Size = New System.Drawing.Size(738, 430)
		Me.CuVentas1.TabIndex = 9
		'
		'CuTurno1
		'
		Me.CuTurno1.Location = New System.Drawing.Point(23, 27)
		Me.CuTurno1.Name = "CuTurno1"
		Me.CuTurno1.Size = New System.Drawing.Size(738, 430)
		Me.CuTurno1.TabIndex = 8
		'
		'CuPuntoVenta1
		'
		Me.CuPuntoVenta1.Location = New System.Drawing.Point(23, 27)
		Me.CuPuntoVenta1.Name = "CuPuntoVenta1"
		Me.CuPuntoVenta1.Size = New System.Drawing.Size(738, 430)
		Me.CuPuntoVenta1.TabIndex = 7
		'
		'CuProveedor1
		'
		Me.CuProveedor1.Location = New System.Drawing.Point(23, 27)
		Me.CuProveedor1.Name = "CuProveedor1"
		Me.CuProveedor1.Size = New System.Drawing.Size(738, 430)
		Me.CuProveedor1.TabIndex = 6
		'
		'CuCrudSucursal1
		'
		Me.CuCrudSucursal1.Location = New System.Drawing.Point(23, 27)
		Me.CuCrudSucursal1.Name = "CuCrudSucursal1"
		Me.CuCrudSucursal1.Size = New System.Drawing.Size(738, 430)
		Me.CuCrudSucursal1.TabIndex = 5
		'
		'CuCrudCargos1
		'
		Me.CuCrudCargos1.Location = New System.Drawing.Point(23, 27)
		Me.CuCrudCargos1.Name = "CuCrudCargos1"
		Me.CuCrudCargos1.Size = New System.Drawing.Size(738, 430)
		Me.CuCrudCargos1.TabIndex = 4
		'
		'CuCategoria1
		'
		Me.CuCategoria1.Location = New System.Drawing.Point(23, 27)
		Me.CuCategoria1.Name = "CuCategoria1"
		Me.CuCategoria1.Size = New System.Drawing.Size(738, 430)
		Me.CuCategoria1.TabIndex = 3
		'
		'frmVentas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 463)
		Me.Controls.Add(Me.CuProveedorSucursal1)
		Me.Controls.Add(Me.CuProducto1)
		Me.Controls.Add(Me.CuCliente1)
		Me.Controls.Add(Me.CuEmpleado1)
		Me.Controls.Add(Me.CuVentas1)
		Me.Controls.Add(Me.CuTurno1)
		Me.Controls.Add(Me.CuPuntoVenta1)
		Me.Controls.Add(Me.CuProveedor1)
		Me.Controls.Add(Me.CuCrudSucursal1)
		Me.Controls.Add(Me.CuCrudCargos1)
		Me.Controls.Add(Me.CuCategoria1)
		Me.Controls.Add(Me.menuStrip1)
		Me.Name = "frmVentas"
		Me.Text = "Form1"
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents menuStrip1 As MenuStrip
	Private WithEvents cRUDsToolStripMenuItem As ToolStripMenuItem
	Private WithEvents proveedorToolStripMenuItem As ToolStripMenuItem
	Private WithEvents sucursalToolStripMenuItem As ToolStripMenuItem
	Private WithEvents cargoToolStripMenuItem As ToolStripMenuItem
	Private WithEvents turnoToolStripMenuItem As ToolStripMenuItem
	Private WithEvents empleadoToolStripMenuItem As ToolStripMenuItem
	Private WithEvents categoriaToolStripMenuItem As ToolStripMenuItem
	Private WithEvents clienteToolStripMenuItem As ToolStripMenuItem
	Private WithEvents productoToolStripMenuItem As ToolStripMenuItem
	Private WithEvents sucursalProveedorToolStripMenuItem As ToolStripMenuItem
	Private WithEvents ventasToolStripMenuItem As ToolStripMenuItem
	Private WithEvents nuevaVentaToolStripMenuItem As ToolStripMenuItem
	Private WithEvents listaVentasToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CuCategoria1 As cuCategoria
	Friend WithEvents CuCrudCargos1 As cuCrudCargos
	Friend WithEvents CuCrudSucursal1 As cuCrudSucursal
	Friend WithEvents CuProveedor1 As cuProveedor
	Friend WithEvents CuPuntoVenta1 As cuPuntoVenta
	Friend WithEvents CuTurno1 As cuTurno
	Friend WithEvents CuVentas1 As cuVentas
	Friend WithEvents CuEmpleado1 As cuEmpleado
	Friend WithEvents CuCliente1 As cuCliente
	Friend WithEvents CuProducto1 As cuProducto
	Friend WithEvents CuProveedorSucursal1 As cuProveedorSucursal
End Class
