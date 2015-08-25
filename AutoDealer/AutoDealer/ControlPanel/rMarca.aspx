<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rMarca.aspx.cs" Inherits="AutoDealer.ControlPanel.rMarca" MasterPageFile="~/ControlPanel/Master.Master" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>Id</th>
                <td>

                    <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>

                </td>
            </tr>
            <tr>
                <th>Marca</th>
                <td>
                    <asp:TextBox ID="tbDescripcion" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tbModelo" runat="server"></asp:TextBox>
                    <asp:Button ID="btnAgregar" class="btn btn-success" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />

                </td>

            </tr>

            <tr>
                <th>Modelos</th>
                
                <td>
                    <asp:GridView ID="gvModelos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>

        </table>
        
    </div>
        <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
        <hr />
        <asp:Button ID="btnNuevo" class="btn btn-success" runat="server" Text="Nuevo" />
        <asp:Button ID="btnCancelar" class="btn btn-info" runat="server" Text="Cancelar" />
        <asp:Button ID="btnRegistrar" class="btn btn-success" runat="server" Text="Guardar" OnClick="btnRegistrar_Click"/>
        <asp:Button ID="btnModificar" class="btn btn-success" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>
        <asp:Button ID="btnEliminar" class="btn btn-danger" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>    
    </form>
</asp:Content>