<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="frmTramites.aspx.vb" Inherits="TP_Final_Labo_IV.frmTramites" %>
<%@ Register Src="~/wucControlUsuario.ascx" TagPrefix="uc1" TagName="wucControlUsuario" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <style>

        body {
            margin: 0;
            padding: 0;
            font-family: sans-serif;
            background: #0f3d2d;
        }

        .box {
            text-align: center;
        }

        .text {
            border-radius: 24px;
            background-color: #c1efe0;
            color: #248f6b;
            border-color: #248f6b;
        }

        .text:focus {
              border-radius: 24px;
              background-color: #c1efe0;
              color: #248f6b;
              border-color: #248f6b;
              transform: scale(1.02,1)
        }

        .boton {
            border-radius: 24px;
            background-color: #248f6b;
            color: #70dbb8;
            border-color: #70dbb8;
            cursor: pointer;
            width: 200px;
            margin: 10px;
            padding: 4px;
            align-content: center;
            justify-self: center;
        }

        .boton:hover {
            background-color: #70dbb8;
            color: #248f6b;
            border-color: #248f6b;
            transform: scale(1.01, 1.01);
            transition: 0.24s;
        }

        .CajaPanelPopup {
            background-color: #efefef;
            filter: alpha(opacity=70);
            opacity: 0.7;
        }

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container p-4">
        <uc1:wucControlUsuario runat="server" id="wucControlUsuario" />
        <div class="row p-2 justify-content-center">
            <asp:Button ID="btnAmpliar" runat="server" Text="Ampliar info" class="boton py-2x" />
        </div>
        <div class="row p-2 justify-content-center">
            <asp:DropDownList ID="ddlPlanNuevo" runat="server" AutoPostBack="true" CssClass="boton" Visible="false"></asp:DropDownList>
        </div>
        <div class="row p-2 justify-content-center">
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" class="boton py-2x" Visible="false" />
        </div>
    </div>

    <asp:Label ID="lblPopUp" runat="server" Text=""></asp:Label>
    <cc1:ModalPopupExtender ID="MPE" runat="server" PopupControlID="panelMPE" TargetControlID="lblPopUp" BackgroundCssClass="CajaPanelPopup" CancelControlID="btnCerrar">
    </cc1:ModalPopupExtender>

    <asp:Panel ID="panelMPE" CssClass="alert-secondary CajaPanelPopup justify-content-center rounded" runat="server">

        <asp:Panel ID="panelGrabExitosa" runat="server" CssClass="justify-content-center m-2 p-2">
            <h4>Grabación exitosa</h4>
        </asp:Panel>

        <asp:Panel ID="panelAmpliaInfo" runat="server" CssClass="justify-content-center m-2 p-2">
            <div class="container">
                <div class="row">
                    <asp:Label ID="lblApellido" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="lblDNI" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="lblFechaNac" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="lblPlan" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="lblParentesco" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </asp:Panel>

        <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" CssClass="boton justify-content-center" />

    </asp:Panel>

</asp:Content>

    