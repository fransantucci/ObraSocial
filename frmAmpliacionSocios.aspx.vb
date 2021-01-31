Public Class frmAmpliacionSocios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim strSocio As String                  'string donde se guarda el numero del socio
        Dim objSocios As New claPersona         'objeto creado para recuperar socios
        Dim dtsDataSet As New DataSet           'dataset
        Dim intRetorno As Integer               'entero que devuelve la cantidad de elementos recuperados en la consulta sql
        Dim objFamiliares As New claPersona     'objeto creado para recuperar los familiares del socio titular (si es titular y tiene familiares afiliados)
        Dim dtsDataSet2 As New DataSet          'dataset
        Dim intRetorno2 As Integer              'entero que devuelve la cantidad de elementos recuperados en la consulta sql
        Dim strSocioTitular As String           'string donde se guarda el numero de socio si el socio es titular para poder recuperar sus familiares

        strSocio = Request.QueryString("nro_socio")

        intRetorno = objSocios.devSocios(dtsDataSet, strSocio)

        txtApellido.Text = dtsDataSet.Tables("socios").Rows(0).Item("apellido")
        txtNroSocio.Text = dtsDataSet.Tables("socios").Rows(0).Item("nro_socio")
        txtNombre.Text = dtsDataSet.Tables("socios").Rows(0).Item("nombre")
        txtFecNac.Text = dtsDataSet.Tables("socios").Rows(0).Item("fecha_nacimiento")
        txtNroDocumento.Text = dtsDataSet.Tables("socios").Rows(0).Item("nro_documento")
        txtParentesco.Text = dtsDataSet.Tables("socios").Rows(0).Item("parentesco")
        txtPlan.Text = dtsDataSet.Tables("socios").Rows(0).Item("plan_os")
        txtSexo.Text = dtsDataSet.Tables("socios").Rows(0).Item("sexo")

        txtApellido.ReadOnly = True
        txtNroSocio.ReadOnly = True
        txtNombre.ReadOnly = True
        txtFecNac.ReadOnly = True
        txtNroDocumento.ReadOnly = True
        txtParentesco.ReadOnly = True
        txtPlan.ReadOnly = True
        txtSexo.ReadOnly = True

        strSocioTitular = dtsDataSet.Tables("socios").Rows(0).Item("nro_socio")

        If dtsDataSet.Tables("socios").Rows(0).Item("parentesco") = "TIT" Then
            panelDatosFamiliares.Visible = True
            intRetorno2 = objFamiliares.devFamiliaresSocio(dtsDataSet2, strSocioTitular)
            If intRetorno2 > 1 Then
                Me.gvwDatosFamiliares.Visible = True
                Me.gvwDatosFamiliares.DataSource = dtsDataSet2.Tables("familiares")
                Me.gvwDatosFamiliares.DataBind()
            Else
                lblSinFamiliares.Visible = True
                lblSinFamiliares.Text = "El asociado " & dtsDataSet.Tables("socios").Rows(0).Item("apellido") & ", " & dtsDataSet.Tables("socios").Rows(0).Item("nombre") & "no cuenta con familiares afiliados al mismo plan."
            End If
        End If

    End Sub

End Class