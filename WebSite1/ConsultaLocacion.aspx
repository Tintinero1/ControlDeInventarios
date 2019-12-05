﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsultaLocacion.aspx.cs" Inherits="ConsultaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <asp:Label ID="lbNombre" runat="server" Text="Nombre Locacion:"></asp:Label>
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
        <asp:Button ID="btnConsultaLocacion" runat="server" Text="Consulta" Width="305px" OnClick="btnConsultaLocacion_Click" />
    </div>
    
</asp:Content>