<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaCliente.aspx.cs" Inherits="ModificaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <asp:Label ID="lbIdCliente" runat="server" Text="Codigo del Cliente: "></asp:Label>
        <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Nombre del Cliente: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbDireccion" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbTelefono" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbActivo" runat="server" Text="Estatus: "></asp:Label>
        <asp:DropDownList ID="ddlEstatus" runat="server" Width="125px">
            <asp:ListItem>Inactivo</asp:ListItem>
            <asp:ListItem>Activo</asp:ListItem>
        </asp:DropDownList>

        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnModificaCliente" runat="server" Text="Button" Width="305px" OnClick="btnModificaCliente_Click" />
    </div>
    
</asp:Content>