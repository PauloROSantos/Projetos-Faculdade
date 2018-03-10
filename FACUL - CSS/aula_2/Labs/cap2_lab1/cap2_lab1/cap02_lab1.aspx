<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cap02_lab1.aspx.cs" Inherits="cap2_lab1.cap02_lab1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Utilizando Seletores</title>
    <link rel="stylesheet" type="text/css" href="css/estilo_lab2.css" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
</head>
<body>
    <main role="main" class="fundo">
        <header class="topo">
            <div class="grid_12">
            <a href="#"><img src="images/bg-logo.png" alt="" /></a>

            <nav>
                <ul class="menu">
                    <li class="current"><a href="#">Home</a></li>
                    <li class="current"><a href="#">Historia</a></li>
                    <li class="current"><a href="#">Noticias</a></li>
                    <li class="current"><a href="#">Serviços</a></li>
                    <li class="current"><a href="#">Portfolio</a></li>
                    <li class="current"><a href="#">Fale Conosco</a></li>
                </ul>
            </nav>

            </div>
        </header>
    </main>
    <div>
        <form runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn-success"/>
            </form>
    </div>

</body>
</html>
