<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AutoDealer.ControlPanel.Login" MasterPageFile="~/ControlPanel/Master.Master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="form-group">
        <label>Nombre de Usuario</label>
        <asp:TextBox ID="tbUsuario" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbUsuario" ErrorMessage="Este campo no puede estar vacio.." ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
        <div class="form-group">
            <label>Contraseña</label>
            <asp:TextBox ID="tbContrasena" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo no puede estar vacio.." ForeColor="Red" ControlToValidate="tbContrasena"></asp:RequiredFieldValidator>
            
        </div>
        <a href="../rCuenta.aspx">Registrarme!</a>
        <asp:CheckBox ID="Persist" runat="server" Checked="True" Text="Recordarme"/>
        <asp:Button ID="btnAceptar" class="btn btn-success" runat="server" Text="Iniciar Sesion" OnClick="btnAceptar_Click" />
        <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
    </form>
</asp:Content>