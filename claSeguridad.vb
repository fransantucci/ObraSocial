Public Class claSeguridad

    Inherits claPadre

    Public Function devUserPass(ByRef arDataSet, ByVal arUser) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select usu.usuario, usu.clave, usu.tipo_usuario from Usuarios usu where usu.usuario = '" & arUser & "'"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "usuarios")

        Return intRetorno

    End Function

End Class
