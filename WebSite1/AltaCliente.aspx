<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaCliente.aspx.cs" Inherits="AltaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <asp:Label ID="lbNombre" runat="server" Text="Nombre del Cliente: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbDireccion" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbTelefono" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnAltaCliente" runat="server" Text="Alta" Width="305px" OnClick="btnAltaCliente_Click" />
    </div>
    
</asp:Content>