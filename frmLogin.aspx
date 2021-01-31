<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmLogin.aspx.vb" Inherits="TP_Final_Labo_IV.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title>Login</title>

    <style>

        body {
            margin: 0;
            padding: 0;
            font-family: sans-serif;
            background: #33CC99;
        }

        .box {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%);
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

        #btnLogin {
            border-radius: 24px;
            background-color: #248f6b;
            color: #70dbb8;
            border-color: #70dbb8;
            cursor: pointer;
        }

        #btnLogin:hover {
            background-color: #70dbb8;
            color: #248f6b;
            border-color: #248f6b;
            transform: scale(1.01, 1.01);
            transition: 0.24s;
        }

    </style>

</head>
    <body>

        <div class="container p-4">
            <div class="row p-2 justify-content-center">
                <div class="col-sm-10 col-md-8 col-lg-4 box">
                    <form runat="server" class="form-singin p-2">
                        <h1 class="h1 mb-3 font-weight-normal text-light">Iniciar sesión</h1>
                        <div class="py-2">
                            <asp:label for="txtUser" runat="server" class="sr-only">Usuario</asp:label>
                            <asp:TextBox ID="txtUser" runat="server" class="form-control user text" placeholder="Usuario"></asp:TextBox>
                        </div>
                        <div class="py-2">
                            <asp:label for="txtPassword" runat="server" class="sr-only">Contraseña</asp:label>
                            <asp:TextBox ID="txtPassword" runat="server" class="form-control pass text" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="mb-3 p-2"> 
                            <asp:label ID="lblError" runat="server" class="text-danger" visible="false"></asp:label>
                        </div>
                        <asp:Button ID="btnLogin" runat="server" Text="Iniciar sesión" class="btn btn-lg btn-block" href="/frmIndex.aspx" /> 
                    </form>
                </div>
            </div>
        </div>

    </body>
</html>
