Public Class frmLogin
    Dim con As Conexion = New Conexion()
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If con.login(tbCorreo.Text, tbContraseña.Text) Then
            Dim menu As frmVentas = New frmVentas()
            menu.Show()
            Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectas")
        End If
    End Sub
End Class