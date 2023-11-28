<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuEmpleado
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
		Me.cbTurno = New System.Windows.Forms.ComboBox()
		Me.cbCargo = New System.Windows.Forms.ComboBox()
		Me.cbSucursal = New System.Windows.Forms.ComboBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tbContra = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tbCorreo = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tbRfc = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.tbTel = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbApMat = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbApPat = New System.Windows.Forms.TextBox()
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
		'cbTurno
		'
		Me.cbTurno.FormattingEnabled = True
		Me.cbTurno.Location = New System.Drawing.Point(608, 296)
		Me.cbTurno.Name = "cbTurno"
		Me.cbTurno.Size = New System.Drawing.Size(113, 21)
		Me.cbTurno.TabIndex = 67
		'
		'cbCargo
		'
		Me.cbCargo.FormattingEnabled = True
		Me.cbCargo.Location = New System.Drawing.Point(608, 269)
		Me.cbCargo.Name = "cbCargo"
		Me.cbCargo.Size = New System.Drawing.Size(113, 21)
		Me.cbCargo.TabIndex = 66
		'
		'cbSucursal
		'
		Me.cbSucursal.FormattingEnabled = True
		Me.cbSucursal.Location = New System.Drawing.Point(608, 239)
		Me.cbSucursal.Name = "cbSucursal"
		Me.cbSucursal.Size = New System.Drawing.Size(113, 21)
		Me.cbSucursal.TabIndex = 65
		'
		'label9
		'
		Me.label9.AutoSize = True
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label9.Location = New System.Drawing.Point(556, 293)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(50, 20)
		Me.label9.TabIndex = 64
		Me.label9.Text = "Turno"
		'
		'label10
		'
		Me.label10.AutoSize = True
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label10.Location = New System.Drawing.Point(554, 269)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(52, 20)
		Me.label10.TabIndex = 63
		Me.label10.Text = "Cargo"
		'
		'label5
		'
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label5.Location = New System.Drawing.Point(537, 241)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(71, 20)
		Me.label5.TabIndex = 62
		Me.label5.Text = "Sucursal"
		'
		'tbContra
		'
		Me.tbContra.Location = New System.Drawing.Point(608, 215)
		Me.tbContra.Name = "tbContra"
		Me.tbContra.Size = New System.Drawing.Size(100, 20)
		Me.tbContra.TabIndex = 61
		Me.tbContra.UseSystemPasswordChar = True
		'
		'label6
		'
		Me.label6.AutoSize = True
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label6.Location = New System.Drawing.Point(520, 215)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(92, 20)
		Me.label6.TabIndex = 60
		Me.label6.Text = "Contraseña"
		'
		'tbCorreo
		'
		Me.tbCorreo.Location = New System.Drawing.Point(608, 189)
		Me.tbCorreo.Name = "tbCorreo"
		Me.tbCorreo.Size = New System.Drawing.Size(100, 20)
		Me.tbCorreo.TabIndex = 59
		'
		'label7
		'
		Me.label7.AutoSize = True
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label7.Location = New System.Drawing.Point(551, 189)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(57, 20)
		Me.label7.TabIndex = 58
		Me.label7.Text = "Correo"
		'
		'tbRfc
		'
		Me.tbRfc.Location = New System.Drawing.Point(608, 163)
		Me.tbRfc.Name = "tbRfc"
		Me.tbRfc.Size = New System.Drawing.Size(100, 20)
		Me.tbRfc.TabIndex = 57
		'
		'label8
		'
		Me.label8.AutoSize = True
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label8.Location = New System.Drawing.Point(556, 163)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(42, 20)
		Me.label8.TabIndex = 56
		Me.label8.Text = "RFC"
		'
		'tbTel
		'
		Me.tbTel.Location = New System.Drawing.Point(608, 137)
		Me.tbTel.Name = "tbTel"
		Me.tbTel.Size = New System.Drawing.Size(100, 20)
		Me.tbTel.TabIndex = 55
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label4.Location = New System.Drawing.Point(537, 137)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(71, 20)
		Me.label4.TabIndex = 54
		Me.label4.Text = "Telefono"
		'
		'tbApMat
		'
		Me.tbApMat.Location = New System.Drawing.Point(608, 111)
		Me.tbApMat.Name = "tbApMat"
		Me.tbApMat.Size = New System.Drawing.Size(100, 20)
		Me.tbApMat.TabIndex = 53
		'
		'label3
		'
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label3.Location = New System.Drawing.Point(520, 111)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(88, 20)
		Me.label3.TabIndex = 52
		Me.label3.Text = "ApMaterno"
		'
		'tbApPat
		'
		Me.tbApPat.Location = New System.Drawing.Point(608, 85)
		Me.tbApPat.Name = "tbApPat"
		Me.tbApPat.Size = New System.Drawing.Size(100, 20)
		Me.tbApPat.TabIndex = 51
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(515, 83)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(93, 20)
		Me.label2.TabIndex = 50
		Me.label2.Text = "Ap. Paterno"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(590, 390)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 49
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.Location = New System.Drawing.Point(646, 361)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
		Me.btnActualizar.TabIndex = 48
		Me.btnActualizar.Text = "Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(544, 361)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 47
		Me.btnCrear.Text = "Crear"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'tbNombre
		'
		Me.tbNombre.Location = New System.Drawing.Point(608, 59)
		Me.tbNombre.Name = "tbNombre"
		Me.tbNombre.Size = New System.Drawing.Size(100, 20)
		Me.tbNombre.TabIndex = 46
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(537, 59)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(73, 20)
		Me.label1.TabIndex = 45
		Me.label1.Text = "Nombres"
		'
		'dgvDatos
		'
		Me.dgvDatos.AllowUserToAddRows = False
		Me.dgvDatos.AllowUserToDeleteRows = False
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(17, 18)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.ReadOnly = True
		Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDatos.Size = New System.Drawing.Size(498, 395)
		Me.dgvDatos.TabIndex = 44
		'
		'cuEmpleado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.cbTurno)
		Me.Controls.Add(Me.cbCargo)
		Me.Controls.Add(Me.cbSucursal)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.tbContra)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.tbCorreo)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.tbRfc)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.tbTel)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbApMat)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.tbApPat)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.tbNombre)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "cuEmpleado"
		Me.Size = New System.Drawing.Size(738, 430)
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents cbTurno As ComboBox
	Private WithEvents cbCargo As ComboBox
	Private WithEvents cbSucursal As ComboBox
	Private WithEvents label9 As Label
	Private WithEvents label10 As Label
	Private WithEvents label5 As Label
	Private WithEvents tbContra As TextBox
	Private WithEvents label6 As Label
	Private WithEvents tbCorreo As TextBox
	Private WithEvents label7 As Label
	Private WithEvents tbRfc As TextBox
	Private WithEvents label8 As Label
	Private WithEvents tbTel As TextBox
	Private WithEvents label4 As Label
	Private WithEvents tbApMat As TextBox
	Private WithEvents label3 As Label
	Private WithEvents tbApPat As TextBox
	Private WithEvents label2 As Label
	Private WithEvents btnEliminar As Button
	Private WithEvents btnActualizar As Button
	Private WithEvents btnCrear As Button
	Private WithEvents tbNombre As TextBox
	Private WithEvents label1 As Label
	Private WithEvents dgvDatos As DataGridView
End Class
