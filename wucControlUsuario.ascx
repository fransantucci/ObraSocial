<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="wucControlUsuario.ascx.vb" Inherits="TP_Final_Labo_IV.wucControlUsuario" %>


<div class="row p-2 justify-content-center">
    <div class="col-sm-10 col-md-8 col-lg-4 box">
        <div class="py-2">
            <asp:TextBox ID="txtNroSocio" runat="server" class="form-control text" placeholder="Número Socio" AutoPostBack="true"></asp:TextBox>
        </div>
        <div class="py-2">
            <asp:TextBox ID="txtApeyNom" runat="server" class="form-control text" placeholder="Apellido y nombre"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="txtDNI" runat="server" class="form-control text" placeholder="DNI" Visible="false"></asp:TextBox>
        </div>
        <div class="py-2">
            <asp:TextBox ID="txtPlanOS" runat="server" class="form-control text" placeholder="Plan OS" Visible="false"></asp:TextBox>
        </div>
        <div class="py-2">
            <asp:TextBox ID="txtParentesco" runat="server" class="form-control text" placeholder="Parentesco" Visible="false"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblSocioNoPermitido" runat="server" Text="" Visible="false"></asp:Label>
        </div>
        <div class="row p-2 justify-content-center">
            <asp:Button ID="btnRecuperar" runat="server" Text="Recuperar" class="boton py-2" />
        </div>
    </div>
</div>
     
