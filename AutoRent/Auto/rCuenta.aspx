<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rCuenta.aspx.cs" Inherits="Auto.rCuenta" MasterPageFile="~/Master.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
     <table>
         <tr>
            <th>Nombre de Usuario</th>
            <td>
                <asp:TextBox ID="tbNombreUsuario" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbNombreUsuario" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <th>Contraseña</th>
            <td>
                <asp:TextBox ID="tbContrasena" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbContrasena" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <th>Confirmar Contraseña</th>
            <td>
                <asp:TextBox ID="tbConfirmacion" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contrasenas no son iguales" ControlToCompare="tbContrasena" ControlToValidate="tbConfirmacion" ForeColor="Red"></asp:CompareValidator>
            </td>
         </tr>
         <tr>
            <th>Nombre</th>
            <td>
                <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbNombre" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <th>Apellido</th>
            <td>
                <asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tbApellido" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <th>Fecha Nacimiento</th>
            <td>
                <asp:TextBox ID="tbFechaNacimiento" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="tbFechaNacimiento" ErrorMessage="La fecha no es valida.. dd/mm/yyyy" ForeColor="Red" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <th>Cedula</th>
            <td>
                <asp:TextBox ID="tbCedula" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Cedula invalida" ControlToValidate="tbCedula" ForeColor="Red" ValidationExpression="^[0-9]{3}-?[0-9]{7}-?[0-9]{1}$"></asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <th>Telefono</th>
            <td>
                <asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Telefono invalido" ControlToValidate="tbTelefono" ValidationExpression="\d{3}-\d{3}-\d{4}" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <th>Ciudad</th>
            <td>
                <asp:DropDownList ID="ddlCiudad" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="ddlCiudad" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <th>Direccion</th>
            <td>
                <asp:TextBox ID="tbDireccion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="tbDireccion" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <th>Correo</th>
            <td>
                <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="tbCorreo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="tbCorreo" ErrorMessage="El correo es invalido..." ForeColor="Red" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>
            </td>
         </tr>
     </table>
        <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnAceptar" class="btn btn-success" runat="server" Text="Registrarme" OnClick="btnAceptar_Click" />
    </div>
    </form>
</asp:Content>
