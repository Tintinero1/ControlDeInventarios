<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsultaAlmacenes.aspx.cs" Inherits="ConsultaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Consulta de Almacenes"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Nombre del Almacen:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Estatus"></asp:Label>
        <asp:DropDownList ID="DDLClientes" runat="server" Width="347px">
            <asp:ListItem>Inactivo</asp:ListItem>
            <asp:ListItem>Activo</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnConsultaCliente" runat="server" Text="Consulta" Width="305px" OnClick="btnConsultaCliente_Click" />
    </div>
    
</asp:Content>