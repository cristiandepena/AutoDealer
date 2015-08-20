<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rModelo.aspx.cs" Inherits="AutoDealer.ControlPanel.rModelo" MasterPageFile="~/ControlPanel/Master.Master" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>Id</th>
                <td>

                    <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" Text="Buscar"/>

                </td>
            </tr>
            <tr>
                <th>Marca</th>
                <td>
                    <asp:DropDownList ID="ddlMarca" runat="server">
                    </asp:DropDownList>
                    <asp:Label ID="lbModelo" runat="server" Text="Modelo"></asp:Label>
                    <asp:TextBox ID="tbModelo" runat="server"></asp:TextBox>
                </td>

            </tr>

        </table>
        
    </div>
        <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
        <hr />
        <asp:Button ID="btnNuevo" class="btn btn-success" runat="server" Text="Nuevo" />
        <asp:Button ID="btnCancelar" class="btn btn-info" runat="server" Text="Cancelar" />
        <asp:Button ID="btnRegistrar" class="btn btn-success" runat="server" Text="Guardar" />
        <asp:Button ID="btnModificar" class="btn btn-success" runat="server" Text="Modificar"/>
        <asp:Button ID="btnEliminar" class="btn btn-danger" runat="server" Text="Eliminar" />   
    </form>
</asp:Content>