Imports Microsoft.Win32

Public Class claTramites

    Inherits claPadre

    Public Function devTramites(ByRef arDataSet As DataSet) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select concat(rtrim(soc.apellido), ', ', ltrim(soc.nombre)), tra.plan_actual, tra.plan_nuevo, tra.estado, tra.fecha_resolucion from Tramites_cambio_plan tra, Socios soc where soc.nro_socio = tra.nro_socio and (tra.estado = 'PEN' or tra.fecha_resolucion > dateadd(day, -35, getdate()))"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "tramites")

        Return intRetorno

    End Function

    Public Function actualizarCambios(ByRef arDataSet As dtsTablaTramite) As Integer

        Dim strSql As String
        Dim intRetorno As Integer
        Dim dtrTramiteRow As dtsTablaTramite.Tramites_cambio_planRow

        dtrTramiteRow = arDataSet.Tramites_cambio_plan.Rows(0)

        strSql = "insert into Tramites_cambio_plan values ('" & dtrTramiteRow.nro_socio & "', '" & dtrTramiteRow.plan_actual & "', '" & dtrTramiteRow.plan_nuevo & "', 'PEN', getdate(), '" & dtrTramiteRow.usuario_ult_modif & "')"

        intRetorno = Me.Ejecutar(strSql)

        Return intRetorno

    End Function

    'el 35 en esta funcion significa que devuelve los tramites con menos de 35 dias desde la resolucion y los pendientes
    Public Function devTramites35(ByRef ARdataSet As DataSet) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select concat(rtrim(soc.apellido), ', ', ltrim(soc.nombre)) as 'apeynom', tra.nro_tramite, tra.plan_actual, tra.plan_nuevo, tra.estado, tra.fecha_resolucion from Tramites_cambio_plan tra, Socios soc where soc.nro_socio = tra.nro_socio and (tra.estado = 'PEN' or tra.fecha_resolucion > dateadd(day, -35, getdate()))"


        intRetorno = Me.RecuperarDataSet(ARdataSet, strSql, "tramites")


        Return intRetorno

    End Function

    Public Function actualizarTramites(ByVal arListTramites As ListItemCollection) As Integer
        Dim strSql As String
        Dim strSeparador As String = ""
        Dim strVector As String = "'"
        Dim intResultado As Integer
        Dim strUser As String

        strUser = HttpContext.Current.Session("user")

        For Each list In arListTramites

            strVector += strSeparador + list.ToString.Trim
            strSeparador = "','"

        Next

        strVector += "'"

        strSql = "UPDATE tramites_cambio_plan SET tramites_cambio_plan.estado = 'APL', usuario_ult_modif='" & strUser.Trim & "' where tramites_cambio_plan.nro_tramite in (" & strVector & ")"

        intResultado = Me.Ejecutar(strSql)

        strSql = "update socios set socios.plan_os = tramites_cambio_plan.plan_nuevo from socios,tramites_cambio_plan where socios.nro_socio_titular = tramites_cambio_plan.nro_socio and tramites_cambio_plan.nro_tramite in (" & strVector & ")"

        intResultado = Me.Ejecutar(strSql)

        Return 1

    End Function

    Public Function devTramitesPENPorSocio(ByRef arDataSet As DataSet, ByVal arNroSocio As String) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select tra.nro_socio, tra.estado from tramites_cambio_plan tra where tra.estado = 'PEN' and tra.nro_socio = '" & arNroSocio & "'"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "tramites")

        Return intRetorno

    End Function

End Class
