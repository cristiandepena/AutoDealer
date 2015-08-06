<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rTransmision.aspx.cs" Inherits="AutoRent.rTransmision" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" MasterPageFile="~/Master.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form  id="form1" runat="server">
    <fieldset>

        <div>
            <span>Descripcion:
                <asp:TextBox runat="server" ID="tbDescripcion" meta:resourcekey="tbDescripcionResource1"></asp:TextBox></span>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbDescripcion" ErrorMessage="El campo no puede estar vacio..." ForeColor="Red" meta:resourcekey="RequiredFieldValidator1Resource1">*</asp:RequiredFieldValidator>
            <br />
            <asp:Button runat="server" Text="Guardar" ID="btnGuardar" OnClick="Unnamed2_Click" meta:resourcekey="btnGuardarResource1" />

        </div>

    </fieldset>
        </form>
</asp:Content>
