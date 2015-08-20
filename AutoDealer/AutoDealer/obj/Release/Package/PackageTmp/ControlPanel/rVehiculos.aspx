<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rVehiculos.aspx.cs" Inherits="AutoRent.WebForm1" MasterPageFile="~/Master.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Id</th>
                    <td>
                        <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    </td>
                </tr>
                <tr>
                    <th>Descripcion</th>
                    <td>
                        <asp:TextBox ID="tbDescripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Imagen</th>
                    <td>
                        <asp:FileUpload ID="fuImagen" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th>Color</th>
                    <td>
                        <asp:Label ID="lbPrimario" runat="server" Text="Primario"></asp:Label>
                        <asp:DropDownList ID="ddlColorPrimario" runat="server"></asp:DropDownList>
                        <asp:Label ID="lbSecundario" runat="server" Text="Secundario"></asp:Label>
                        <asp:DropDownList ID="ddlColorSecundario" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Marca</th>
                    <td>
                        <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
                        <asp:Label ID="Label1" runat="server" Text="Modelo"></asp:Label>
                        <asp:DropDownList ID="ddlModelo" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Tipo de Transmision</th>
                    <td>
                        <asp:DropDownList ID="ddlTipoTransmision" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Traccion</th>
                    <td>
                        <asp:DropDownList ID="ddlTraccion" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Tipo de vehiculo</th>
                    <td>
                        <asp:DropDownList ID="ddlTipoVehiculo" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Ano de fabricacion</th>
                    <td>
                        <asp:DropDownList ID="ddlAnioFabricacion" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th>Precio</th>
                    <td>
                        <asp:TextBox ID="tbPrecio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>Tipo de combustible</th>
                    <td>
                        <asp:DropDownList ID="ddlCombustible" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </table>
            <p>
                <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
            </p>
            <asp:Button ID="btnRegistrar" class="btn btn-success" runat="server" Text="Registrar Vehiculo" OnClick="btnRegistrar_Click" />
        </div>
    </form>
</asp:Content>
