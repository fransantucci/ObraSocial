<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="frmNoPermission.aspx.vb" Inherits="TP_Final_Labo_IV.frmNoPermission" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- este formulario es llamado si un usuario de mesa de entrada intenta forzar la url para entrar a paginas que no tiene permiso --%>

    <div class="row p-2 justify-content-center">
        <div class="col-sm-10 col-md-8 col-lg-4 box">
            <div class="py-2">
                <h1 class="alert-danger text-center p-2">¡Acceso denegado!</h1>
                <h4>Usted no tiene permiso para acceder a esta sección.</h4>
            </div>
        </div>
    </div>

</asp:Content>
