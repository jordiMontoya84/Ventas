<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuProducto
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
		Me.nudExistencia = New System.Windows.Forms.NumericUpDown()
		Me.nudCosto = New System.Windows.Forms.NumericUpDown()
		Me.cbProveedor = New System.Windows.Forms.ComboBox()
		Me.cbSucursal = New System.Windows.Forms.ComboBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.btnCrear = New System.Windows.Forms.Button()
		Me.tbDescripcion = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudCosto, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'nudExistencia
		'
		Me.nudExistencia.Location = New System.Drawing.Point(617, 160)
		Me.nudExistencia.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.nudExistencia.Name = "nudExistencia"
		Me.nudExistencia.Size = New System.Drawing.Size(100, 20)
		Me.nudExistencia.TabIndex = 48
		'
		'nudCosto
		'
		Me.nudCosto.Location = New System.Drawing.Point(617, 109)
		Me.nudCosto.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.nudCosto.Name = "nudCosto"
		Me.nudCosto.Size = New System.Drawing.Size(100, 20)
		Me.nudCosto.TabIndex = 47
		'
		'cbProveedor
		'
		Me.cbProveedor.FormattingEnabled = True
		Me.cbProveedor.Location = New System.Drawing.Point(617, 240)
		Me.cbProveedor.Name = "cbProveedor"
		Me.cbProveedor.Size = New System.Drawing.Size(100, 21)
		Me.cbProveedor.TabIndex = 46
		'
		'cbSucursal
		'
		Me.cbSucursal.FormattingEnabled = True
		Me.cbSucursal.Location = New System.Drawing.Point(617, 203)
		Me.cbSucursal.Name = "cbSucursal"
		Me.cbSucursal.Size = New System.Drawing.Size(100, 21)
		Me.cbSucursal.TabIndex = 45
		'
		'label5
		'
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label5.Location = New System.Drawing.Point(536, 238)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(81, 20)
		Me.label5.TabIndex = 44
		Me.label5.Text = "Proveedor"
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label4.Location = New System.Drawing.Point(546, 201)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(71, 20)
		Me.label4.TabIndex = 43
		Me.label4.Text = "Sucursal"
		'
		'label3
		'
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label3.Location = New System.Drawing.Point(536, 157)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(81, 20)
		Me.label3.TabIndex = 42
		Me.label3.Text = "Existencia"
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(560, 110)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(51, 20)
		Me.label2.TabIndex = 41
		Me.label2.Text = "Costo"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(596, 350)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 40
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.Location = New System.Drawing.Point(642, 293)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
		Me.btnActualizar.TabIndex = 39
		Me.btnActualizar.Text = "Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(550, 293)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 38
		Me.btnCrear.Text = "Crear"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'tbDescripcion
		'
		Me.tbDescripcion.Location = New System.Drawing.Point(617, 63)
		Me.tbDescripcion.Name = "tbDescripcion"
		Me.tbDescripcion.Size = New System.Drawing.Size(100, 20)
		Me.tbDescripcion.TabIndex = 37
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(525, 61)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(92, 20)
		Me.label1.TabIndex = 36
		Me.label1.Text = "Descripcion"
		'
		'dgvDatos
		'
		Me.dgvDatos.AllowUserToAddRows = False
		Me.dgvDatos.AllowUserToDeleteRows = False
		Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(21, 18)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.ReadOnly = True
		Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDatos.Size = New System.Drawing.Size(498, 395)
		Me.dgvDatos.TabIndex = 35
		'
		'cuProducto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.nudExistencia)
		Me.Controls.Add(Me.nudCosto)
		Me.Controls.Add(Me.cbProveedor)
		Me.Controls.Add(Me.cbSucursal)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.tbDescripcion)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "cuProducto"
		Me.Size = New System.Drawing.Size(738, 430)
		CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudCosto, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents nudExistencia As NumericUpDown
	Private WithEvents nudCosto As NumericUpDown
	Private WithEvents cbProveedor As ComboBox
	Private WithEvents cbSucursal As ComboBox
	Private WithEvents label5 As Label
	Private WithEvents label4 As Label
	Private WithEvents label3 As Label
	Private WithEvents label2 As Label
	Private WithEvents btnEliminar As Button
	Private WithEvents btnActualizar As Button
	Private WithEvents btnCrear As Button
	Private WithEvents tbDescripcion As TextBox
	Private WithEvents label1 As Label
	Private WithEvents dgvDatos As DataGridView
End Class
