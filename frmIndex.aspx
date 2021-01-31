<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="frmIndex.aspx.vb" Inherits="TP_Final_Labo_IV.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main role="main" style="background-color: #0f3d2d">
        <div class="jumbotron" style="border-bottom: #33CC99 solid 1px; background-color: #0f3d2d">
            <div>
                <h1 class="display-3 text-center" style="color: #33CC99"><b>:: Obra social ::</b></h1>
            </div>
        </div>
        <div class="container p-4">
            <div class="row p-2 justify-content-center">
                <div class="col-xl-3 text-center text-light lead m-4 p-4" style="border: solid #33CC99; border-radius: 8px;">
                    <h2>Socios</h2>
                    <p>Puede consultar los socios haciendo click acá</p>
                    <p><a class="btn px-5" style="background-color: #33CC99; color: white" href="/frmConsultaSocios.aspx" role="button">Ver socios</a></p>
                </div>

                <div class="col-xl-3 text-center text-light lead m-4 p-4" style="border: solid #33CC99; border-radius: 8px;">
                    <h2>Trámites</h2>
                    <p>Para generar tramites de cambio de plan nuevos</p>
                    <p><a class="btn px-5" style="background-color: #33CC99; color: white" href="/frmTramites.aspx" role="button">Ir a tramites</a></p>
                </div>

                <div class="col-xl-3 text-center text-light lead m-4 p-4" style="border: solid #33CC99; border-radius: 8px;">
                    <h2>Cambio de plan</h2>
                    <p>Para aplicar los cambios a los tramites pendientes</p>
                    <p><a class="btn px-5" style="background-color: #33CC99; color: white" href="/frmCambioPlan.aspx" role="button">Cambiar de plan</a></p>
                </div>
            </div>
        </div>
    </main>

</asp:Content>
