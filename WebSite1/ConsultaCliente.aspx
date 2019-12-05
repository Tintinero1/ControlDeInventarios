<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsultaCliente.aspx.cs" Inherits="ConsultaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Consulta de Clientes"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Label ID="lbIdCliente" runat="server" Text="Codigo del Cliente: "></asp:Label>
        <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Nombre del Cliente: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre del Cliente: "></asp:Label>
        <asp:DropDownList ID="DDLClientes" runat="server">
            <asp:ListItem>Inactivo</asp:ListItem>
            <asp:ListItem>Activo</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnConsultaCliente" runat="server" Text="Consulta" Width="305px" OnClick="btnConsultaCliente_Click" />
    </div>
    
</asp:Content>