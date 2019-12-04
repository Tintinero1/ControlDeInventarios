<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaAlmacen.aspx.cs" Inherits="AltaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <asp:Label ID="lbDireccion" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" Width="254px"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Estatus:"></asp:Label>
        <asp:DropDownList ID="DDLClientes" runat="server">
            <asp:ListItem>Inactivo</asp:ListItem>
            <asp:ListItem>Activo</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="btnAltaCliente" runat="server" Text="Alta" Width="305px" OnClick="btnAltaCliente_Click" />
    </div>
    
</asp:Content>