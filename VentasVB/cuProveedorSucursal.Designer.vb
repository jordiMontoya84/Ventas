<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuProveedorSucursal
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
		Me.cbProveedor = New System.Windows.Forms.ComboBox()
		Me.cbSucursal = New System.Windows.Forms.ComboBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.btnCrear = New System.Windows.Forms.Button()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cbProveedor
		'
		Me.cbProveedor.FormattingEnabled = True
		Me.cbProveedor.Location = New System.Drawing.Point(617, 172)
		Me.cbProveedor.Name = "cbProveedor"
		Me.cbProveedor.Size = New System.Drawing.Size(100, 21)
		Me.cbProveedor.TabIndex = 54
		'
		'cbSucursal
		'
		Me.cbSucursal.FormattingEnabled = True
		Me.cbSucursal.Location = New System.Drawing.Point(617, 135)
		Me.cbSucursal.Name = "cbSucursal"
		Me.cbSucursal.Size = New System.Drawing.Size(100, 21)
		Me.cbSucursal.TabIndex = 53
		'
		'label5
		'
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label5.Location = New System.Drawing.Point(536, 170)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(81, 20)
		Me.label5.TabIndex = 52
		Me.label5.Text = "Proveedor"
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label4.Location = New System.Drawing.Point(546, 133)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(71, 20)
		Me.label4.TabIndex = 51
		Me.label4.Text = "Sucursal"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(596, 282)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 50
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.Location = New System.Drawing.Point(642, 225)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
		Me.btnActualizar.TabIndex = 49
		Me.btnActualizar.Text = "Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(550, 225)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 48
		Me.btnCrear.Text = "Crear"
		Me.btnCrear.UseVisualStyleBackColor = True
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
		Me.dgvDatos.TabIndex = 47
		'
		'cuProveedorSucursal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.cbProveedor)
		Me.Controls.Add(Me.cbSucursal)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "cuProveedorSucursal"
		Me.Size = New System.Drawing.Size(738, 430)
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents cbProveedor As ComboBox
	Private WithEvents cbSucursal As ComboBox
	Private WithEvents label5 As Label
	Private WithEvents label4 As Label
	Private WithEvents btnEliminar As Button
	Private WithEvents btnActualizar As Button
	Private WithEvents btnCrear As Button
	Private WithEvents dgvDatos As DataGridView
End Class
