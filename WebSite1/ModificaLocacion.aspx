<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaLocacion.aspx.cs" Inherits="ModificaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Modificacion de Locaciones"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lbIdCliente" runat="server" Text="ID Locacion:"></asp:Label>
        <asp:TextBox ID="txtIdAlmacen" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Nombre Locacion:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbActivo" runat="server" Text="Estatus: "></asp:Label>
        <asp:DropDownList ID="ddlEstatus" runat="server" Width="125px">
            <asp:ListItem>Inactivo</asp:ListItem>
            <asp:ListItem>Activo</asp:ListItem>
        </asp:DropDownList>

        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnModificaAlmacen" runat="server" Text="Modificar" Width="305px" OnClick="btnModificaAlmacen_Click" />
    </div>
    
</asp:Content>