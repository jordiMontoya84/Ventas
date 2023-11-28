<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuCliente
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
		Me.cbSucursal = New System.Windows.Forms.ComboBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tbRegimen = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tbCfdi = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbRfc = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbCp = New System.Windows.Forms.TextBox()
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
		'cbSucursal
		'
		Me.cbSucursal.FormattingEnabled = True
		Me.cbSucursal.Location = New System.Drawing.Point(619, 261)
		Me.cbSucursal.Name = "cbSucursal"
		Me.cbSucursal.Size = New System.Drawing.Size(102, 21)
		Me.cbSucursal.TabIndex = 49
		'
		'label5
		'
		Me.label5.AutoSize = True
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label5.Location = New System.Drawing.Point(541, 263)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(71, 20)
		Me.label5.TabIndex = 48
		Me.label5.Text = "Sucursal"
		'
		'tbRegimen
		'
		Me.tbRegimen.Location = New System.Drawing.Point(612, 219)
		Me.tbRegimen.Name = "tbRegimen"
		Me.tbRegimen.Size = New System.Drawing.Size(100, 20)
		Me.tbRegimen.TabIndex = 47
		'
		'label6
		'
		Me.label6.AutoSize = True
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label6.Location = New System.Drawing.Point(541, 219)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(73, 20)
		Me.label6.TabIndex = 46
		Me.label6.Text = "Regimen"
		'
		'tbCfdi
		'
		Me.tbCfdi.Location = New System.Drawing.Point(612, 176)
		Me.tbCfdi.Name = "tbCfdi"
		Me.tbCfdi.Size = New System.Drawing.Size(100, 20)
		Me.tbCfdi.TabIndex = 45
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label4.Location = New System.Drawing.Point(555, 176)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(47, 20)
		Me.label4.TabIndex = 44
		Me.label4.Text = "CFDI"
		'
		'tbRfc
		'
		Me.tbRfc.Location = New System.Drawing.Point(612, 132)
		Me.tbRfc.Name = "tbRfc"
		Me.tbRfc.Size = New System.Drawing.Size(100, 20)
		Me.tbRfc.TabIndex = 43
		'
		'label3
		'
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label3.Location = New System.Drawing.Point(564, 132)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(42, 20)
		Me.label3.TabIndex = 42
		Me.label3.Text = "RFC"
		'
		'tbCp
		'
		Me.tbCp.Location = New System.Drawing.Point(612, 85)
		Me.tbCp.Name = "tbCp"
		Me.tbCp.Size = New System.Drawing.Size(100, 20)
		Me.tbCp.TabIndex = 41
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(572, 85)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(30, 20)
		Me.label2.TabIndex = 40
		Me.label2.Text = "CP"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(600, 384)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 39
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.Location = New System.Drawing.Point(646, 327)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
		Me.btnActualizar.TabIndex = 38
		Me.btnActualizar.Text = "Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(554, 327)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 37
		Me.btnCrear.Text = "Crear"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'tbNombre
		'
		Me.tbNombre.Location = New System.Drawing.Point(612, 38)
		Me.tbNombre.Name = "tbNombre"
		Me.tbNombre.Size = New System.Drawing.Size(100, 20)
		Me.tbNombre.TabIndex = 36
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(541, 38)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(65, 20)
		Me.label1.TabIndex = 35
		Me.label1.Text = "Nombre"
		'
		'dgvDatos
		'
		Me.dgvDatos.AllowUserToAddRows = False
		Me.dgvDatos.AllowUserToDeleteRows = False
		Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(18, 18)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.ReadOnly = True
		Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDatos.Size = New System.Drawing.Size(498, 395)
		Me.dgvDatos.TabIndex = 34
		'
		'cuCliente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.cbSucursal)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.tbRegimen)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.tbCfdi)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbRfc)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.tbCp)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.tbNombre)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "cuCliente"
		Me.Size = New System.Drawing.Size(738, 430)
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents cbSucursal As ComboBox
	Private WithEvents label5 As Label
	Private WithEvents tbRegimen As TextBox
	Private WithEvents label6 As Label
	Private WithEvents tbCfdi As TextBox
	Private WithEvents label4 As Label
	Private WithEvents tbRfc As TextBox
	Private WithEvents label3 As Label
	Private WithEvents tbCp As TextBox
	Private WithEvents label2 As Label
	Private WithEvents btnEliminar As Button
	Private WithEvents btnActualizar As Button
	Private WithEvents btnCrear As Button
	Private WithEvents tbNombre As TextBox
	Private WithEvents label1 As Label
	Private WithEvents dgvDatos As DataGridView
End Class
