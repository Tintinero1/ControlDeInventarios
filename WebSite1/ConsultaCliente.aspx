<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsultaCliente.aspx.cs" Inherits="ConsultaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <asp:Label ID="lbNombre" runat="server" Text="Nombre del Cliente: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnConsultaCliente" runat="server" Text="Consulta" Width="305px" OnClick="btnConsultaCliente_Click" />
    </div>
    
</asp:Content>