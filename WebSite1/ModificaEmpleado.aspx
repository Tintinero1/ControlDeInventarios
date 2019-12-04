<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaEmpleado.aspx.cs" Inherits="ConsultaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <asp:Label ID="lbIdCliente" runat="server" Text="Matricula:"></asp:Label>
        <asp:TextBox ID="txtMatricula" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbNombre0" runat="server" Text="Puesto:"></asp:Label>
        <asp:TextBox ID="txtPuesto" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbNombre1" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbNombre2" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Estatus:"></asp:Label>
        <asp:DropDownList ID="DDLClientes" runat="server">
            <asp:ListItem>Inactivo</asp:ListItem>
            <asp:ListItem>Activo</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView ID="gvEmpleados" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnModificaEmpleado" runat="server" Text="Modificar" Width="305px" OnClick="btnModificaEmpleado_Click" />
    </div>
    
</asp:Content>