<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.tbContraseña = New System.Windows.Forms.TextBox()
		Me.tbCorreo = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(199, 110)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(75, 23)
		Me.btnLogin.TabIndex = 9
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'tbContraseña
		'
		Me.tbContraseña.Location = New System.Drawing.Point(114, 75)
		Me.tbContraseña.Name = "tbContraseña"
		Me.tbContraseña.Size = New System.Drawing.Size(100, 20)
		Me.tbContraseña.TabIndex = 8
		Me.tbContraseña.UseSystemPasswordChar = True
		'
		'tbCorreo
		'
		Me.tbCorreo.Location = New System.Drawing.Point(114, 30)
		Me.tbCorreo.Name = "tbCorreo"
		Me.tbCorreo.Size = New System.Drawing.Size(160, 20)
		Me.tbCorreo.TabIndex = 7
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label2.Location = New System.Drawing.Point(15, 76)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(92, 20)
		Me.label2.TabIndex = 6
		Me.label2.Text = "Contraseña"
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(50, 31)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(57, 20)
		Me.label1.TabIndex = 5
		Me.label1.Text = "Correo"
		'
		'frmLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(288, 163)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.tbContraseña)
		Me.Controls.Add(Me.tbCorreo)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "frmLogin"
		Me.Text = "frmLogin"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents btnLogin As Button
	Private WithEvents tbContraseña As TextBox
	Private WithEvents tbCorreo As TextBox
	Private WithEvents label2 As Label
	Private WithEvents label1 As Label
End Class
