Public Class frmTramites
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim objPersona As New claTramites        'objeto utilizado para la actualizacion de los datos
        Dim dtsDataSet As New DataSet           'dataset
        Dim dtsTramite As New dtsTablaTramite   'dataset tramite 
        Dim dtrTramiteRow As dtsTablaTramite.Tramites_cambio_planRow    'filas del dataset tramite
        Dim intRetorno As Integer

        If ddlPlanNuevo.Text <> "Seleccione" Then

            dtrTramiteRow = dtsTramite.Tramites_cambio_plan.NewRow

            dtrTramiteRow.nro_tramite = 0
            dtrTramiteRow.nro_socio = Session("nro_socio")
            dtrTramiteRow.plan_actual = Session("plan_actual")
            dtrTramiteRow.plan_nuevo = ddlPlanNuevo.Text
            dtrTramiteRow.estado = "PEN"
            dtrTramiteRow.fecha_resolucion = "01/01/2000"
            dtrTramiteRow.usuario_ult_modif = Session("user")

            dtsTramite.Tramites_cambio_plan.AddTramites_cambio_planRow(dtrTramiteRow)

            intRetorno = objPersona.actualizarCambios(dtsTramite)
            Me.panelAmpliaInfo.Visible = False
            Me.panelGrabExitosa.Visible = True
            Me.MPE.Show()
        End If

    End Sub

    Private Sub wucControlUsuario_EncontroSocio() Handles wucControlUsuario.EncontroSocio
        btnEnviar.Visible = True
        ddlPlanNuevo.Visible = True
        ddlPlanNuevo.Items.Clear()
        Select Case Session("plan_actual")
            Case "1000"
                ddlPlanNuevo.Items.Add("Seleccione")
                ddlPlanNuevo.Items.Add("2000")
                ddlPlanNuevo.Items.Add("3000")
                ddlPlanNuevo.Items.Add("5000")
            Case "2000"
                ddlPlanNuevo.Items.Add("Seleccione")
                ddlPlanNuevo.Items.Add("1000")
                ddlPlanNuevo.Items.Add("3000")
                ddlPlanNuevo.Items.Add("5000")
            Case "3000"
                ddlPlanNuevo.Items.Add("Seleccione")
                ddlPlanNuevo.Items.Add("1000")
                ddlPlanNuevo.Items.Add("2000")
                ddlPlanNuevo.Items.Add("5000")
            Case "5000"
                ddlPlanNuevo.Items.Add("Seleccione")
                ddlPlanNuevo.Items.Add("1000")
                ddlPlanNuevo.Items.Add("2000")
                ddlPlanNuevo.Items.Add("3000")
        End Select
    End Sub

    Private Sub btnAmpliar_Click(sender As Object, e As EventArgs) Handles btnAmpliar.Click

        Dim objSocio As New claPersona      'objeto utilizado para la recuperacion de los datos mostrados en el popup de ampliacion
        Dim dtsDataSet As New DataSet       'dataset donde vienen los datos de sql
        Dim intRetorno As Integer           'entero que devuelve la cantidad de datos que recuperó de sql

        intRetorno = objSocio.devSociosCompletos(dtsDataSet, Session("nro_socio"))

        If intRetorno > 0 Then
            lblApellido.Text = "Apellido: " & dtsDataSet.Tables("socios").Rows(0).Item("apellido").ToString.Trim
            lblDireccion.Text = "Dirección: " & dtsDataSet.Tables("Socios").Rows(0).Item("direccion")
            lblDNI.Text = "DNI: " & dtsDataSet.Tables("Socios").Rows(0).Item("nro_documento")
            lblFechaNac.Text = "Fecha de nacimiento: " & dtsDataSet.Tables("socios").Rows(0).Item("fecha_nacimiento")
            lblNombre.Text = "Nombre: " & dtsDataSet.Tables("Socios").Rows(0).Item("nombre").ToString.Trim
            lblParentesco.Text = "Parentesco: " & dtsDataSet.Tables("Socios").Rows(0).Item("parentesco")
            lblPlan.Text = "Plan OS: " & dtsDataSet.Tables("Socios").Rows(0).Item("plan_os")
            lblTelefono.Text = "Telefono: " & dtsDataSet.Tables("Socios").Rows(0).Item("telefonos")
            Me.MPE.Show()
            Me.panelAmpliaInfo.Visible = True
            Me.panelGrabExitosa.Visible = False
        End If

    End Sub

End Class