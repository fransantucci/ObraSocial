Imports System.Data.SqlClient
Imports Microsoft.Ajax.Utilities

Public Class claPadre

    Dim objConexion As SqlConnection
    Dim objTransaccion As SqlTransaction
    Private Function ConectarBD(ByRef objConexion As SqlConnection) As Integer

        Dim strConexion As String

        strConexion = "Data Source=localhost\sqlexpress;Initial Catalog=TP_Final_LaboIV;Integrated Security=True"

        objConexion.ConnectionString = strConexion
        objConexion.Open()

        Return 1

    End Function

    Public Function RecuperarDataSet(ByRef dtsDatos As DataSet, ByVal strSqltext As String, ByVal strTabla As String) As Integer

        Dim intRetorno As Integer
        Dim objConexion As SqlConnection

        objConexion = New SqlConnection
        Me.ConectarBD(objConexion)

        Dim objCommand As New SqlCommand(strSqltext, objConexion)
        Dim objAdapter As New SqlDataAdapter
        objAdapter.SelectCommand = objCommand
        intRetorno = objAdapter.Fill(dtsDatos, strTabla)
        objConexion.Close()
        objConexion = Nothing

        Return intRetorno

    End Function

    Public Function Ejecutar(ByVal strSqlText As String) As Integer

        Dim intRetorno As Integer

        If objConexion Is Nothing Then
            objConexion = New SqlConnection
            Me.ConectarBD(objConexion)
        End If

        Dim objCommand As New SqlCommand(strSqlText, objConexion)
        objCommand.Transaction = objTransaccion
        intRetorno = objCommand.ExecuteNonQuery()

        Return intRetorno

    End Function

    'las funciones de commit y rollback estan comentadas porque no fueron utilizadas
    'Public Function IniciarTransaccion() As Integer

    '    If objConexion Is Nothing Then
    '        objConexion = New SqlConnection
    '        Me.ConectarBD(objConexion)
    '    End If

    '    objTransaccion = objConexion.BeginTransaction()
    '    Return 1

    'End Function

    'Public Function FinTransaccion() As Integer

    '    objTransaccion.Commit()
    '    objConexion.Close()
    '    objConexion = Nothing
    '    Return 1

    'End Function

    'Public Function FinTransaccionRollback() As Integer

    '    objTransaccion.Rollback()
    '    objConexion.Close()
    '    objConexion = Nothing
    '    Return 1

    'End Function

End Class
