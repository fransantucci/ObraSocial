Public Class frmConsultaSocios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscarSocio_Click(sender As Object, e As EventArgs) Handles btnBuscarSocio.Click

        Dim objSocio As New claPersona  'objeto creado para recuperar socios de sql
        Dim dtsDataSet As New DataSet   'dataset
        Dim intRetorno As Integer       'entero que devuelve la cantidad de elementos recuperados en la consulta sql

        intRetorno = objSocio.devSociosPorApellidoNombre(dtsDataSet, txtApellido.Text.Trim, txtNombre.Text.Trim)

        If intRetorno > 0 Then
            panelGridSocios.Visible = True
            Me.gvwSocios.DataSource = dtsDataSet.Tables("socios")
            Me.gvwSocios.DataBind()
        End If

    End Sub
End Class