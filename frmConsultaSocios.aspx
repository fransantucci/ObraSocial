<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="frmConsultaSocios.aspx.vb" Inherits="TP_Final_Labo_IV.frmConsultaSocios" %>
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
            width: 100px;
            background-color: #248f6b;
            color: #70dbb8;
            border-color: #70dbb8;
            cursor: pointer;
        }

        .boton:hover {
            background-color: #70dbb8;
            color: #248f6b;
            border-color: #248f6b;
            transform: scale(1.01, 1.01);
            transition: 0.24s;
        }

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container p-4">
        <div class="row p-2 justify-content-center">
            <div class="col-sm-10 col-lg-8 p-4 m-2 box">
                <asp:TextBox ID="txtApellido" runat="server" placeholder="Apellido socio" class="text p-2"></asp:TextBox>
                <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre socio" class="text p-2"></asp:TextBox>
                <asp:Button ID="btnBuscarSocio" runat="server" Text="Buscar" class="btn boton p-2"/>
            </div>
        </div>
    </div>

    <div class="container p-4">
        <div class="row p-2 justify-content-center">
            <div class="col-sm-10 col-lg-8">
                <asp:Panel ID="panelGridSocios" runat="server" Visible="false">
                    <asp:GridView ID="gvwSocios" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#33CC99" headerstyle-forecolor="#0f3d2d" CssClass="table table-bordered text-light" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            <asp:HyperLinkField DataNavigateUrlFields="nro_socio" DataNavigateUrlFormatString="/frmAmpliacionSocios.aspx?nro_socio={0}" DataTextField="apellido" HeaderText="Apellido" ControlStyle-CssClass="text-light" HeaderStyle-Font-Bold="true" HeaderStyle-Font-Underline="true" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" HeaderStyle-Font-Bold="true" />
                            <asp:BoundField DataField="nro_documento" HeaderText="Nro. Documento" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true"/>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </div>
        </div>
    </div>

</asp:Content>
