<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rColor.aspx.cs" Inherits="Auto.ControlPanel.rColor" MasterPageFile="~/Master.Master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>Id</th>
                <td>

                    <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

                </td>
            </tr>
            <tr>
                <th>Color</th>
                <td>

                    <asp:TextBox ID="tbColor" runat="server"></asp:TextBox>
                    

                </td>

            </tr>

        </table>
        
    </div>
        <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
        <hr />
        <asp:Button ID="btnNuevo" class="btn btn-success" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
        <asp:Button ID="btnCancelar" class="btn btn-info" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        <asp:Button ID="btnRegistrar" class="btn btn-success" runat="server" Text="Guardar" OnClick="btnRegistrar_Click" />
        <asp:Button ID="btnModificar" class="btn btn-success" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
        <asp:Button ID="btnEliminar" class="btn btn-danger" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    </form>
</asp:Content>