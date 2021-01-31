Public Class frmCambioPlan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("tipeuser") <> "SU" Then
            Response.Redirect("frmNoPermission.aspx")
        End If
        If Not Page.IsPostBack Then
            cargarTramites()
        End If

    End Sub

    Private Sub cargarTramites()

        Dim objTramites As New claTramites   'objeto creado para recuperar los tramites
        Dim dtsDataSet As New DataSet       'dataset
        Dim intRetorno As Integer           'entero que devuelve la cantidad de elementos recuperados en la consulta sql

        intRetorno = objTramites.devTramites35(dtsDataSet)

        If intRetorno > 0 Then
            Me.gvwTramites.DataSource = dtsDataSet.Tables("tramites")
            Me.gvwTramites.DataBind()
            lblTitle.Visible = True
            lblTitle.Text = "Trámites"
        Else
            lblTitle.Text = "No hay trámites esperando aprobación o aplicados en los últimos 35 días"
            lblTitle.CssClass = "alert-danger"
            lblTitle.Visible = True
        End If

    End Sub

    Private Sub gvwTramites_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles gvwTramites.RowDataBound

        Dim strEstado As String         'string donde se guarda el estado del tramite
        Dim chkSeleccionar As CheckBox  'checkbox utilizado para seleccionar los cambios que se quieren efectuar

        If e.Row.RowType = DataControlRowType.DataRow Then
            strEstado = e.Row.Cells(5).Text
            If strEstado = "APL" Then
                e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml("#1e7a5b")
                chkSeleccionar = e.Row.FindControl("chkSeleccionar")
                chkSeleccionar.Visible = False
            End If

        End If
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim objTramites As New claTramites
        Dim licLista As New ListItemCollection
        Dim strEstado As String
        Dim chkSeleccionar As CheckBox
        Dim intCantFilas As Integer
        Dim intN As Integer

        intCantFilas = Me.gvwTramites.Rows.Count

        For intN = 0 To intCantFilas - 1
            strEstado = Me.gvwTramites.Rows(intN).Cells(5).Text
            If strEstado = "PEN" Then
                chkSeleccionar = gvwTramites.Rows(intN).FindControl("chkSeleccionar")
                If chkSeleccionar.Checked Then
                    licLista.Add(New ListItem(Me.gvwTramites.Rows(intN).Cells(1).Text))
                End If
            End If
        Next

        If licLista.Count > 0 Then
            objTramites.actualizarTramites(licLista)
            cargarTramites()
        End If

    End Sub
End Class