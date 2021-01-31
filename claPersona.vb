Imports Microsoft.Win32

Public Class claPersona

    Inherits claPadre

    Public Function devSociosPorApellidoNombre(ByRef ARdataSet As DataSet, ByVal arApellido As String, ByVal arNombre As String) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select soc.nro_socio, soc.apellido, soc.nombre, soc.nro_documento from Socios soc where soc.apellido like '%" & arApellido & "%' and soc.nombre like '%" & arNombre & "%' order by soc.apellido asc"

        intRetorno = Me.RecuperarDataSet(ARdataSet, strSql, "socios")

        Return intRetorno

    End Function

    Public Function devSocios(ByRef arDataSet As DataSet, ByVal arNroSocio As String) As Integer


        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select soc.nro_socio, soc.apellido, concat(rtrim(soc.apellido), ' ', ltrim(soc.nombre)) as 'apeynom', soc.nombre, soc.nro_documento, soc.fecha_nacimiento, soc.sexo, soc.parentesco, soc.plan_os from Socios soc where soc.nro_socio = '" & arNroSocio & "'"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "socios")

        Return intRetorno

    End Function

    Public Function devSocioPorNroSocioPlan(ByRef arDataSet As DataSet, ByVal arNroSocio As String) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select soc.nro_socio, concat(rtrim(soc.apellido), ' ', ltrim(soc.nombre)) as 'apeynom', soc.nro_documento, soc.plan_os, soc.parentesco, soc.estado, tra.nro_tramite, tra.estado from Socios soc, Tramites_cambio_plan tra where soc.nro_socio = tra.nro_socio and tra.estado = 'PEN' and soc.estado = 'ACT' and soc.parentesco = 'TIT' and soc.nro_socio = '" & arNroSocio & "'"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "socios")

        Return intRetorno

    End Function

    Public Function devSociosCompletos(ByRef arDataSet As DataSet, ByVal arNroSocio As String) As Integer

        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select * from Socios soc where soc.nro_socio = '" & arNroSocio & "'"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "socios")

        Return intRetorno

    End Function

    Public Function devFamiliaresSocio(ByRef arDataSet As DataSet, ByVal arNroSocioTitular As String) As Integer


        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select soc.nro_socio, soc.apellido, soc.nombre, soc.parentesco from Socios soc where soc.nro_socio_titular = '" & arNroSocioTitular & "' and soc.parentesco <> 'TIT'"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "familiares")

        Return intRetorno

    End Function

    Public Function devSociosTitulares(ByRef arDataSet As DataSet, ByVal arNroSocio As String) As Integer


        Dim strSql As String
        Dim intRetorno As Integer

        strSql = "select soc.nro_socio, soc.apellido, concat(rtrim(soc.apellido), ' ', ltrim(soc.nombre)) as 'apeynom', soc.nombre, soc.nro_documento, soc.fecha_nacimiento, soc.sexo, soc.parentesco, soc.plan_os from Socios soc where soc.nro_socio = '" & arNroSocio & "' and soc.parentesco = 'TIT'"

        intRetorno = Me.RecuperarDataSet(arDataSet, strSql, "socios")

        Return intRetorno

    End Function

End Class
