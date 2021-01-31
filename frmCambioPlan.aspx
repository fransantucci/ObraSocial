<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="frmCambioPlan.aspx.vb" Inherits="TP_Final_Labo_IV.frmCambioPlan" %>

<%@ Register Src="~/wucControlUsuario.ascx" TagPrefix="uc1" TagName="wucControlUsuario" %>

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
        }

        .boton:hover {
            background-color: #70dbb8;
            color: #248f6b;
            border-color: #248f6b;
            transform: scale(1.01, 1.01);
            transition: 0.24s;
        }

    </style>

    <script>
        function jf_marca(ar_chek) {
            var row = ar_chek.parentNode.parentNode.parentNode;

            if (ar_chek.checked) {

                row.style.backgroundColor = "#238e6b";
            }
            else {
                row.style.backgroundColor = "#0f3d2d";
            }
        }

    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container p-4">
        <div class="row p-2 justify-content-center">
            <div class="col-sm-10 col-lg-8">
                <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                <asp:GridView ID="gvwTramites" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#33CC99" HeaderStyle-ForeColor="#0f3d2d" CssClass="table table-bordered text-light" AllowPaging="True" AllowSorting="True">
                    <Columns>
                        <asp:TemplateField HeaderText="Confirmar">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkSeleccionar" runat="server" CssClass="form-check" onclick="jf_marca(this)" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="nro_tramite" HeaderText="Nro. de Tramite"></asp:BoundField>
                        <asp:BoundField DataField="apeynom" HeaderText="Apellido y nombre" HeaderStyle-Font-Bold="true" />
                        <asp:BoundField DataField="plan_actual" HeaderText="Plan actual" HeaderStyle-Font-Bold="true" />
                        <asp:BoundField DataField="plan_nuevo" HeaderText="Plan nuevo" HeaderStyle-Font-Bold="true" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" HeaderStyle-Font-Bold="true" />
                    </Columns>
                </asp:GridView>
                <asp:Button ID="btnGuardar" runat="server" CssClass="btn boton" Text="Aplicar Cambios" />
            </div>
        </div>
    </div>

</asp:Content>
