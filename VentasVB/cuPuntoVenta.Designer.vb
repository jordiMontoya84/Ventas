<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuPuntoVenta
	Inherits System.Windows.Forms.UserControl

	'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
		Me.pArticulo = New System.Windows.Forms.Panel()
		Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tbCodigo = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.pNota = New System.Windows.Forms.Panel()
		Me.cbCliente = New System.Windows.Forms.ComboBox()
		Me.btnPagar = New System.Windows.Forms.Button()
		Me.tbImporte = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.dgvArticulos = New System.Windows.Forms.DataGridView()
		Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.pArticulo.SuspendLayout()
		CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pNota.SuspendLayout()
		CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pArticulo
		'
		Me.pArticulo.Controls.Add(Me.nudCantidad)
		Me.pArticulo.Controls.Add(Me.label2)
		Me.pArticulo.Controls.Add(Me.tbCodigo)
		Me.pArticulo.Controls.Add(Me.label1)
		Me.pArticulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.pArticulo.Location = New System.Drawing.Point(0, 0)
		Me.pArticulo.Name = "pArticulo"
		Me.pArticulo.Size = New System.Drawing.Size(522, 61)
		Me.pArticulo.TabIndex = 22
		'
		'nudCantidad
		'
		Me.nudCantidad.Location = New System.Drawing.Point(389, 19)
		Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudCantidad.Name = "nudCantidad"
		Me.nudCantidad.Size = New System.Drawing.Size(44, 20)
		Me.nudCantidad.TabIndex = 18
		Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(309, 20)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(73, 20)
		Me.label2.TabIndex = 17
		Me.label2.Text = "Cantidad"
		'
		'tbCodigo
		'
		Me.tbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbCodigo.Location = New System.Drawing.Point(126, 18)
		Me.tbCodigo.Name = "tbCodigo"
		Me.tbCodigo.Size = New System.Drawing.Size(158, 22)
		Me.tbCodigo.TabIndex = 16
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(61, 18)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(59, 20)
		Me.label1.TabIndex = 15
		Me.label1.Text = "Codigo"
		'
		'pNota
		'
		Me.pNota.Controls.Add(Me.cbCliente)
		Me.pNota.Controls.Add(Me.btnPagar)
		Me.pNota.Controls.Add(Me.tbImporte)
		Me.pNota.Controls.Add(Me.label8)
		Me.pNota.Controls.Add(Me.label4)
		Me.pNota.Dock = System.Windows.Forms.DockStyle.Right
		Me.pNota.Location = New System.Drawing.Point(522, 0)
		Me.pNota.Name = "pNota"
		Me.pNota.Size = New System.Drawing.Size(216, 430)
		Me.pNota.TabIndex = 21
		'
		'cbCliente
		'
		Me.cbCliente.FormattingEnabled = True
		Me.cbCliente.Location = New System.Drawing.Point(56, 135)
		Me.cbCliente.Name = "cbCliente"
		Me.cbCliente.Size = New System.Drawing.Size(121, 21)
		Me.cbCliente.TabIndex = 23
		'
		'btnPagar
		'
		Me.btnPagar.Location = New System.Drawing.Point(76, 232)
		Me.btnPagar.Name = "btnPagar"
		Me.btnPagar.Size = New System.Drawing.Size(81, 42)
		Me.btnPagar.TabIndex = 22
		Me.btnPagar.Text = "Pagar"
		Me.btnPagar.UseVisualStyleBackColor = True
		'
		'tbImporte
		'
		Me.tbImporte.Enabled = False
		Me.tbImporte.Location = New System.Drawing.Point(56, 172)
		Me.tbImporte.Name = "tbImporte"
		Me.tbImporte.Size = New System.Drawing.Size(82, 20)
		Me.tbImporte.TabIndex = 11
		Me.tbImporte.Text = "0"
		'
		'label8
		'
		Me.label8.AutoSize = True
		Me.label8.Location = New System.Drawing.Point(19, 172)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(31, 13)
		Me.label8.TabIndex = 10
		Me.label8.Text = "Total"
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(11, 135)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(39, 13)
		Me.label4.TabIndex = 1
		Me.label4.Text = "Cliente"
		'
		'dgvArticulos
		'
		Me.dgvArticulos.AllowUserToAddRows = False
		Me.dgvArticulos.AllowUserToDeleteRows = False
		Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Costo, Me.Cantidad, Me.Eliminar})
		Me.dgvArticulos.Location = New System.Drawing.Point(3, 67)
		Me.dgvArticulos.MultiSelect = False
		Me.dgvArticulos.Name = "dgvArticulos"
		Me.dgvArticulos.ReadOnly = True
		Me.dgvArticulos.RowHeadersWidth = 51
		Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvArticulos.Size = New System.Drawing.Size(513, 337)
		Me.dgvArticulos.TabIndex = 20
		'
		'Codigo
		'
		Me.Codigo.FillWeight = 30.0!
		Me.Codigo.HeaderText = "Codigo"
		Me.Codigo.MinimumWidth = 6
		Me.Codigo.Name = "Codigo"
		Me.Codigo.ReadOnly = True
		'
		'Descripcion
		'
		Me.Descripcion.FillWeight = 111.9289!
		Me.Descripcion.HeaderText = "Descripcion"
		Me.Descripcion.MinimumWidth = 6
		Me.Descripcion.Name = "Descripcion"
		Me.Descripcion.ReadOnly = True
		'
		'Costo
		'
		Me.Costo.FillWeight = 25.0!
		Me.Costo.HeaderText = "Costo"
		Me.Costo.MinimumWidth = 6
		Me.Costo.Name = "Costo"
		Me.Costo.ReadOnly = True
		'
		'Cantidad
		'
		Me.Cantidad.FillWeight = 30.0!
		Me.Cantidad.HeaderText = "Cantidad"
		Me.Cantidad.Name = "Cantidad"
		Me.Cantidad.ReadOnly = True
		'
		'Eliminar
		'
		Me.Eliminar.FillWeight = 25.0!
		Me.Eliminar.HeaderText = "Eliminar"
		Me.Eliminar.MinimumWidth = 6
		Me.Eliminar.Name = "Eliminar"
		Me.Eliminar.ReadOnly = True
		Me.Eliminar.Text = "Eliminar"
		Me.Eliminar.UseColumnTextForButtonValue = True
		'
		'cuPuntoVenta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.pArticulo)
		Me.Controls.Add(Me.pNota)
		Me.Controls.Add(Me.dgvArticulos)
		Me.Name = "cuPuntoVenta"
		Me.Size = New System.Drawing.Size(738, 430)
		Me.pArticulo.ResumeLayout(False)
		Me.pArticulo.PerformLayout()
		CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pNota.ResumeLayout(False)
		Me.pNota.PerformLayout()
		CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents pArticulo As Panel
	Private WithEvents nudCantidad As NumericUpDown
	Private WithEvents label2 As Label
	Private WithEvents tbCodigo As TextBox
	Private WithEvents label1 As Label
	Private WithEvents pNota As Panel
	Private WithEvents cbCliente As ComboBox
	Private WithEvents btnPagar As Button
	Private WithEvents tbImporte As TextBox
	Private WithEvents label8 As Label
	Private WithEvents label4 As Label
	Private WithEvents dgvArticulos As DataGridView
	Private WithEvents Codigo As DataGridViewTextBoxColumn
	Private WithEvents Descripcion As DataGridViewTextBoxColumn
	Private WithEvents Costo As DataGridViewTextBoxColumn
	Private WithEvents Cantidad As DataGridViewTextBoxColumn
	Private WithEvents Eliminar As DataGridViewButtonColumn
End Class
