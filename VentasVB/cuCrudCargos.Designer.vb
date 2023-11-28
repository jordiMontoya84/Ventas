<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuCrudCargos
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
		Me.nudSueldo = New System.Windows.Forms.NumericUpDown()
		Me.label2 = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.btnCrear = New System.Windows.Forms.Button()
		Me.tbDescripcion = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		CType(Me.nudSueldo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'nudSueldo
		'
		Me.nudSueldo.Location = New System.Drawing.Point(620, 140)
		Me.nudSueldo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.nudSueldo.Name = "nudSueldo"
		Me.nudSueldo.Size = New System.Drawing.Size(100, 20)
		Me.nudSueldo.TabIndex = 33
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(557, 140)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(59, 20)
		Me.label2.TabIndex = 32
		Me.label2.Text = "Sueldo"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(599, 291)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 31
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = True
		'
		'btnActualizar
		'
		Me.btnActualizar.Location = New System.Drawing.Point(645, 234)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
		Me.btnActualizar.TabIndex = 30
		Me.btnActualizar.Text = "Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = True
		'
		'btnCrear
		'
		Me.btnCrear.Location = New System.Drawing.Point(553, 234)
		Me.btnCrear.Name = "btnCrear"
		Me.btnCrear.Size = New System.Drawing.Size(75, 23)
		Me.btnCrear.TabIndex = 29
		Me.btnCrear.Text = "Crear"
		Me.btnCrear.UseVisualStyleBackColor = True
		'
		'tbDescripcion
		'
		Me.tbDescripcion.Location = New System.Drawing.Point(620, 98)
		Me.tbDescripcion.Name = "tbDescripcion"
		Me.tbDescripcion.Size = New System.Drawing.Size(100, 20)
		Me.tbDescripcion.TabIndex = 28
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(522, 96)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(92, 20)
		Me.label1.TabIndex = 27
		Me.label1.Text = "Descripcion"
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
		Me.dgvDatos.TabIndex = 26
		'
		'cuCrudCargos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.nudSueldo)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnCrear)
		Me.Controls.Add(Me.tbDescripcion)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "cuCrudCargos"
		Me.Size = New System.Drawing.Size(738, 430)
		CType(Me.nudSueldo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents nudSueldo As NumericUpDown
	Private WithEvents label2 As Label
	Private WithEvents btnEliminar As Button
	Private WithEvents btnActualizar As Button
	Private WithEvents btnCrear As Button
	Private WithEvents tbDescripcion As TextBox
	Private WithEvents label1 As Label
	Private WithEvents dgvDatos As DataGridView
End Class
