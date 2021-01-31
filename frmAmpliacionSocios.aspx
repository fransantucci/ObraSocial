<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="frmAmpliacionSocios.aspx.vb" Inherits="TP_Final_Labo_IV.frmAmpliacionSocios" %>
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
        <div class="row p-2 text-light justify-content-center">
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblNroSocio" runat="server" Text="Nro. Socio"></asp:Label>
                <asp:TextBox ID="txtNroSocio" runat="server" class="text p-2"></asp:TextBox>
            </div>
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server" class="text p-2"></asp:TextBox>
            </div>
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" class="text p-2"></asp:TextBox>
            </div>
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblNroDocumento" runat="server" Text="Nro. Documento"></asp:Label>
                <asp:TextBox ID="txtNroDocumento" runat="server" class="text p-2"></asp:TextBox>
            </div>
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblFecNac" runat="server" Text="Fecha de nacimiento"></asp:Label>
                <asp:TextBox ID="txtFecNac" runat="server" class="text p-2"></asp:TextBox>
            </div>
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
                <asp:TextBox ID="txtSexo" runat="server" class="text p-2"></asp:TextBox>
            </div>
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblParentesco" runat="server" Text="Parentesco"></asp:Label>
                <asp:TextBox ID="txtParentesco" runat="server" class="text p-2"></asp:TextBox>
            </div>
            <div class="col-sm-10 col-lg-8 m-2 box">
                <asp:Label ID="lblPlan" runat="server" Text="Plan"></asp:Label>
                <asp:TextBox ID="txtPlan" runat="server" class="text p-2"></asp:TextBox>
            </div>
        </div>
        <div class="container p-4">
            <div class="row p-2 justify-content-center">
                <div class="col-sm-10 col-lg-8">
                    <asp:Panel ID="panelDatosFamiliares" runat="server">
                        <asp:GridView ID="gvwDatosFamiliares" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#33CC99" headerstyle-forecolor="#0f3d2d" CssClass="table table-bordered text-light" AllowPaging="True" AllowSorting="True" Visible="false">
                            <Columns>
                                <asp:BoundField DataField="nro_socio" HeaderText="Nro. Socio" />
                                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="parentesco" HeaderText="Parentesco" />
                            </Columns>
                        </asp:GridView>
                        <asp:Label ID="lblSinFamiliares" runat="server" Text="" Visible="false" CssClass="text-warning"></asp:Label>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>
          
</asp:Content>
