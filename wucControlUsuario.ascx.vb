Public Class wucControlUsuario
    Inherits System.Web.UI.UserControl
    Public Event EncontroSocio()    'evento que significa que encontró un socio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub txtNroSocio_TextChanged(sender As Object, e As EventArgs) Handles txtNroSocio.TextChanged

        Dim objSocioCambioPlan As New claPersona
        Dim dtsDataSet As New DataSet
        Dim intRetorno As Integer

        intRetorno = objSocioCambioPlan.devSocios(dtsDataSet, txtNroSocio.Text.Trim)

        If intRetorno = 1 Then
            txtApeyNom.Text = dtsDataSet.Tables("socios").Rows(0).Item("apeynom")
            Session("nro_socio") = dtsDataSet.Tables("socios").Rows(0).Item("nro_socio")
            Session("plan_actual") = dtsDataSet.Tables("socios").Rows(0).Item("plan_os")
            txtDNI.Visible = False
            txtPlanOS.Visible = False
            txtParentesco.Visible = False
            lblSocioNoPermitido.Visible = False
            txtDNI.Text = String.Empty
            txtParentesco.Text = String.Empty
            txtPlanOS.Text = String.Empty
        Else
            txtApeyNom.Text = String.Empty
            txtDNI.Visible = False
            txtPlanOS.Visible = False
            txtParentesco.Visible = False
            lblSocioNoPermitido.Visible = False
            txtDNI.Text = String.Empty
            txtParentesco.Text = String.Empty
            txtPlanOS.Text = String.Empty
        End If

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click

        Dim objPersona As New claPersona
        Dim dtsDataSet As New DataSet
        Dim intRetorno As Integer

        intRetorno = objPersona.devSocioPorNroSocioPlan(dtsDataSet, txtNroSocio.Text.Trim)

        If intRetorno = 0 Then

            dtsDataSet = New DataSet
            intRetorno = objPersona.devSociosTitulares(dtsDataSet, txtNroSocio.Text.Trim)
            If intRetorno = 1 Then
                txtDNI.Text = dtsDataSet.Tables("socios").Rows(0).Item("nro_documento")
                txtPlanOS.Text = dtsDataSet.Tables("socios").Rows(0).Item("plan_os")
                txtParentesco.Text = dtsDataSet.Tables("socios").Rows(0).Item("parentesco")
                RaiseEvent EncontroSocio()
                txtDNI.Visible = True
                txtPlanOS.Visible = True
                txtParentesco.Visible = True
                lblSocioNoPermitido.Visible = False
            Else
                lblSocioNoPermitido.Visible = True
                lblSocioNoPermitido.CssClass = "text-warning"
                lblSocioNoPermitido.Text = "¡Atención! Esta transacción solo se puede realizar en socios activos, titulares y que no tienen cambios de planes pendientes."
            End If
        Else
            lblSocioNoPermitido.Visible = True
            lblSocioNoPermitido.CssClass = "text-warning"
            lblSocioNoPermitido.Text = "¡Atención! Esta transacción solo se puede realizar en socios activos, titulares y que no tienen cambios de planes pendientes."
        End If

    End Sub

End Class