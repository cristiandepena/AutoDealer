<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rVehiculos.aspx.cs" Inherits="AutoRent.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1 style="text-align:center">Busqueda de Vehiculos</h1>
    <form id="form1" runat="server">
        <label>Condicion:</label><asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />

        <label>Marca</label>
        &nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <br />
        <label>Modelo </label>
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <br />
        <label>Transmision</label>
        <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
        <br />
        <label>Tipo de traccion</label>
        <asp:DropDownList ID="DropDownList5" runat="server"></asp:DropDownList>
        <br />
        <label>Tipo de vehiculo</label>
        <asp:DropDownList ID="DropDownList6" runat="server"></asp:DropDownList>
        <br />
        <label>Año de fabricacion</label>
        <asp:DropDownList ID="DropDownList7" runat="server"></asp:DropDownList>
        <br />
        <label>Tipo de combustible</label>
        <asp:DropDownList ID="DropDownList8" runat="server"></asp:DropDownList>
        <br />
        <label>Color</label>
        <asp:DropDownList ID="DropDownList9" runat="server"></asp:DropDownList>

        &nbsp;<div>
        </div>
    </form>
</body>
</html>
