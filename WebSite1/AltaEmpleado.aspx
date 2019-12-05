<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaEmpleado.aspx.cs" Inherits="AltaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Alta de Empleado"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Matricula:"></asp:Label>
        <asp:TextBox ID="txtMatricula" runat="server" Width="247px"></asp:TextBox>
        <br />
        <asp:Label ID="lbDireccion" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" Width="254px"></asp:TextBox>
        <br />
        <asp:Label ID="lbTelefono" runat="server" Text="Puesto:"></asp:Label>
        <asp:TextBox ID="txtPuesto" runat="server" Width="266px"></asp:TextBox>
        <br />
        <asp:Label ID="lbTelefono0" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server" Width="243px"></asp:TextBox>
        <br />
        <asp:Label ID="lbTelefono1" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server" Width="245px"></asp:TextBox>
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