<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rCuenta.aspx.cs" Inherits="Auto.rCuenta" MasterPageFile="~/Master.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
     <table>
         <tr>
            <th>Nombre de Usuario</th>
            <td>
                <asp:TextBox ID="tbNombreUsuario" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Contraseña</th>
            <td>
                <asp:TextBox ID="tbContrasena" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Confirmar Contraseña</th>
            <td>
                <asp:TextBox ID="tbConfirmacion" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Nombre</th>
            <td>
                <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Apellido</th>
            <td>
                <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Fecha Nacimiento</th>
            <td>
                <label>Año</label>    
                <asp:DropDownList ID="ddlAnio" runat="server">
                </asp:DropDownList>
                <label>Mes</label>    
                <asp:DropDownList ID="ddlMes" runat="server">
                </asp:DropDownList>
                <label>Dia</label>    
                <asp:DropDownList ID="ddlDia" runat="server">
                </asp:DropDownList>
            </td>
         </tr>
         <tr>
            <th>Cedula</th>
            <td>
                <asp:TextBox ID="tbCedula" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Telefono</th>
            <td>
                <asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Ciudad</th>
            <td>
                <asp:DropDownList ID="ddlCiudad" runat="server">
                </asp:DropDownList>
            </td>
         </tr>
         <tr>
            <th>Direccion</th>
            <td>
                <asp:TextBox ID="tbDireccion" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <th>Correo</th>
            <td>
                <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
            </td>
         </tr>

     </table>
    </div>
    </form>
</asp:Content>
