Public Class Main
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("tipeuser") = "ME" Then
            lkbtnCambioPlan.Visible = False
            lkbtnCambioPlan.Enabled = False
        End If
    End Sub

    Private Sub lkbtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles lkbtnCerrarSesion.Click
        FormsAuthentication.SignOut()
        Session.Clear()
        Session.Abandon()
        Response.Redirect(FormsAuthentication.LoginUrl)
    End Sub
End Class