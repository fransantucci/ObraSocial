Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim intRetorno As Integer
        Dim objUsuario As New claSeguridad
        Dim dtsDataSet As New DataSet
        Dim strPassDB As String
        Dim strUser As String               'guarda el usuario que intenta loggearse
        Dim strTipoUsuario As String        'guarda el tipo de usuario (ME para mesa de entrada y SU para supervisor)

        strUser = txtUser.Text.Trim

        intRetorno = objUsuario.devUserPass(dtsDataSet, strUser)

        If intRetorno = 0 Then
            'login incorrecto
            lblError.Visible = True
            lblError.Text = "Atención, usuario y contraseña no coinciden."
            Return
        Else
            'login correcto
            strPassDB = dtsDataSet.Tables("usuarios").Rows(0).Item("clave").ToString.Trim
            strTipoUsuario = dtsDataSet.Tables("usuarios").Rows(0).Item("tipo_usuario")
            If Validar() = 1 Then

                If dtsDataSet.Tables("usuarios").Rows(0).Item("clave").ToString.Trim = txtPassword.Text.Trim And dtsDataSet.Tables("usuarios").Rows(0).Item("usuario").ToString.Trim = txtUser.Text.Trim Then

                    FormsAuthentication.RedirectFromLoginPage(Me.txtUser.Text.Trim, False)
                    strPassDB = dtsDataSet.Tables("usuarios").Rows(0).Item("clave")
                    strTipoUsuario = dtsDataSet.Tables("usuarios").Rows(0).Item("tipo_usuario")
                    'variable de sesion que guarda el usuario loggeado actualmente
                    Session("user") = strUser
                    'variable de sesion que guarda el tipo de usuario loggeado para saber que a cosas puede acceder y a cuales se le bloquea el acceso
                    Session("tipeuser") = strTipoUsuario
                    lblError.Visible = False
                Else
                    lblError.Visible = True
                    lblError.Text = "Atención, usuario y contraseña no coinciden."
                End If

            End If
        End If

    End Sub

    Private Function Validar() As Integer
        If txtUser.Text.Trim = String.Empty Then
            lblError.Visible = True
            lblError.Text = "Atención, el usuario no puede estar vacio."
            Return 0
        End If
        If txtPassword.Text.Trim = String.Empty Then
            lblError.Visible = True
            lblError.Text = "Atención, la contraseña no puede estar vacia."
            Return 0
        End If
        Return 1
    End Function
End Class