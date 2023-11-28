<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuCrudSucursal
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
		Me.tbNumero = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tbCalle = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tbColonia = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tbCiudad = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbTelefono = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbEstado = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.btnCrear = New System.Windows.Forms.Button()
		Me.tbNombre = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tbNumero
		'
		Me.tbNumero.Location = New System.Drawing.Point(612, 295)
		Me.tbNumero.Name = "tbNumero"
		Me.tbNumero.Size = New System.Drawing.Size(100, 20)
		Me.tbNumero.TabIndex = 53
		'
		'label5
		'
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label5.Location = New System.Drawing.Point(541, 295)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(65, 20)
		Me.label5.TabIndex = 52
		Me.label5.Text = "Numero"
		'
		'tbCalle
		'
		Me.tbCalle.Location = New System.Drawing.Point(612, 251)
		Me.tbCalle.Name = "tbCalle"
		Me.tbCalle.Size = New System.Drawing.Size(100, 20)
		Me.tbCalle.TabIndex = 51
		'
		'label6
		'
		Me.label6.AutoSize = True
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label6.Location = New System.Drawing.Point(557, 251)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(44, 20)
		Me.label6.TabIndex = 50
		Me.label6.Text = "Calle"
		'
		'tbColonia
		'
		Me.tbColonia.Location = New System.Drawing.Point(612, 204)
		Me.tbColonia.Name = "tbColonia"
		Me.tbColonia.Size = New System.Drawing.Size(100, 20)
		Me.tbColonia.TabIndex = 49
		'
		'label7
		'
		Me.label7.AutoSize = True
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label7.Location = New System.Drawing.Point(541, 204)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(62, 20)
		Me.label7.TabIndex = 48
		Me.label7.Text = "Colonia"
		'
		'tbCiudad
		'
		Me.tbCiudad.Location = New System.Drawing.Point(612, 171)
		Me.tbCiudad.Name = "tbCiudad"
		Me.tbCiudad.Size = New System.Drawing.Size(100, 20)
		Me.tbCiudad.TabIndex = 47
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label4.Location = New System.Drawing.Point(541, 171)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(59, 20)
		Me.label4.TabIndex = 46
		Me.label4.Text = "Ciudad"
		'
		'tbTelefono
		'
		Me.tbTelefono.Location = New System.Drawing.Point(612, 87)
		Me.tbTelefono.Name = "tbTelefono"
		Me.tbTelefono.Size = New System.Drawing.Size(100, 20)
		Me.tbTelefono.TabIndex = 45
		'
		'label3
		'
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label3.Location = New System.Drawing.Point(541, 87)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(71, 20)
		Me.label3.TabIndex = 44
		Me.label3.Text = "Telefono"
		'
		'tbEstado
		'
		Me.tbEstado.Location = New System.Drawing.Point(612, 127)
		Me.tbEstado.Name = "tbEstado"
		Me.tbEstado.Size = New System.Drawing.Size(100, 20)
		Me.tbEstado.TabIndex = 43
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(541, 127)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(60, 20)
		Me.label2.TabIndex = 42
		Me.label2.Text = "Estado"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(600, 390)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 41
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.Location = New System.Drawing.Point(646, 333)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
		Me.btnActualizar.TabIndex = 40
		Me.btnActualizar.Text = "Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(554, 333)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 39
		Me.btnCrear.Text = "Crear"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'tbNombre
		'
		Me.tbNombre.Location = New System.Drawing.Point(612, 33)
		Me.tbNombre.Name = "tbNombre"
		Me.tbNombre.Size = New System.Drawing.Size(100, 20)
		Me.tbNombre.TabIndex = 38
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(541, 33)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(65, 20)
		Me.label1.TabIndex = 37
		Me.label1.Text = "Nombre"
		'
		'dgvDatos
		'
		Me.dgvDatos.AllowUserToAddRows = False
		Me.dgvDatos.AllowUserToDeleteRows = False
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(18, 18)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.ReadOnly = True
		Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDatos.Size = New System.Drawing.Size(498, 395)
		Me.dgvDatos.TabIndex = 36
		'
		'cuCrudSucursal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.tbNumero)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.tbCalle)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.tbColonia)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.tbCiudad)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbTelefono)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.tbEstado)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.tbNombre)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "cuCrudSucursal"
		Me.Size = New System.Drawing.Size(738, 430)
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents tbNumero As TextBox
	Private WithEvents label5 As Label
	Private WithEvents tbCalle As TextBox
	Private WithEvents label6 As Label
	Private WithEvents tbColonia As TextBox
	Private WithEvents label7 As Label
	Private WithEvents tbCiudad As TextBox
	Private WithEvents label4 As Label
	Private WithEvents tbTelefono As TextBox
	Private WithEvents label3 As Label
	Private WithEvents tbEstado As TextBox
	Private WithEvents label2 As Label
	Private WithEvents btnEliminar As Button
	Private WithEvents btnActualizar As Button
	Private WithEvents btnCrear As Button
	Private WithEvents tbNombre As TextBox
	Private WithEvents label1 As Label
	Private WithEvents dgvDatos As DataGridView
End Class
