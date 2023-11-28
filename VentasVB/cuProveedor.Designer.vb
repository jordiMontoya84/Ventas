<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuProveedor
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
		Me.tbCuenta = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbTelefono = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbCorreo = New System.Windows.Forms.TextBox()
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
		'tbCuenta
		'
		Me.tbCuenta.Location = New System.Drawing.Point(616, 232)
		Me.tbCuenta.Name = "tbCuenta"
		Me.tbCuenta.Size = New System.Drawing.Size(100, 20)
		Me.tbCuenta.TabIndex = 29
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label4.Location = New System.Drawing.Point(545, 232)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(61, 20)
		Me.label4.TabIndex = 28
		Me.label4.Text = "Cuenta"
		'
		'tbTelefono
		'
		Me.tbTelefono.Location = New System.Drawing.Point(616, 188)
		Me.tbTelefono.Name = "tbTelefono"
		Me.tbTelefono.Size = New System.Drawing.Size(100, 20)
		Me.tbTelefono.TabIndex = 27
		'
		'label3
		'
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label3.Location = New System.Drawing.Point(545, 188)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(71, 20)
		Me.label3.TabIndex = 26
		Me.label3.Text = "Telefono"
		'
		'tbCorreo
		'
		Me.tbCorreo.Location = New System.Drawing.Point(616, 141)
		Me.tbCorreo.Name = "tbCorreo"
		Me.tbCorreo.Size = New System.Drawing.Size(100, 20)
		Me.tbCorreo.TabIndex = 25
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(545, 141)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(57, 20)
		Me.label2.TabIndex = 24
		Me.label2.Text = "Correo"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(595, 332)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 23
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.Location = New System.Drawing.Point(641, 275)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
		Me.btnActualizar.TabIndex = 22
		Me.btnActualizar.Text = "Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(549, 275)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 21
		Me.btnCrear.Text = "Crear"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'tbNombre
		'
		Me.tbNombre.Location = New System.Drawing.Point(616, 94)
		Me.tbNombre.Name = "tbNombre"
		Me.tbNombre.Size = New System.Drawing.Size(100, 20)
		Me.tbNombre.TabIndex = 20
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(545, 94)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(65, 20)
		Me.label1.TabIndex = 19
		Me.label1.Text = "Nombre"
		'
		'dgvDatos
		'
		Me.dgvDatos.AllowUserToAddRows = False
		Me.dgvDatos.AllowUserToDeleteRows = False
		Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(22, 18)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.ReadOnly = True
		Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDatos.Size = New System.Drawing.Size(498, 395)
		Me.dgvDatos.TabIndex = 18
		'
		'cuProveedor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.tbCuenta)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbTelefono)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.tbCorreo)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.tbNombre)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "cuProveedor"
		Me.Size = New System.Drawing.Size(738, 430)
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents tbCuenta As TextBox
	Private WithEvents label4 As Label
	Private WithEvents tbTelefono As TextBox
	Private WithEvents label3 As Label
	Private WithEvents tbCorreo As TextBox
	Private WithEvents label2 As Label
	Private WithEvents btnEliminar As Button
	Private WithEvents btnActualizar As Button
	Private WithEvents btnCrear As Button
	Private WithEvents tbNombre As TextBox
	Private WithEvents label1 As Label
	Private WithEvents dgvDatos As DataGridView
End Class
