<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImagenesDePerros.aspx.cs" Inherits="Perros_API.ImagenesDePerros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Imagenes Aleatorias de Perros</title>
</head>
<body>
    <form id="form1" runat="server" style="text-align: center; margin-top: 50px;">
        <h1>--Imagenes aleatorias de Perros--</h1>
        <asp:Image ID="imgPerro" runat="server" Width="300px" Height="300px" />
        <br /><br />
        <asp:Button ID="btnObtenerImagen" runat="server" Text="Obtener Imagen" OnClick="btnObtenerImagen_Click" />
    </form>
</body>
</html>
