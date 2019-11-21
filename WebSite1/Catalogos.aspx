<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Catalogos.aspx.cs" Inherits="Catalogos" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">

        <h1>Catalogos</h1>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="360px"></asp:DropDownList>
        <div style="text-align:center;">
            <asp:Button ID="btnAlta" runat="server" Text="Alta" Height="81px" Width="95px" style="margin-right:20px;" />
            <asp:Button ID="btnBaja" runat="server" Text="Baja" Height="81px" Width="95px" style="margin-right:20px;"/>
            <asp:Button ID="btnConsulta" runat="server" Text="Consulta" Height="81px" Width="95px" style="margin-right:20px;"/>
            <asp:Button ID="btnModificacion" runat="server" Text="Modificacion" Height="81px" Width="95px" style="margin-right:20px;"/>
        </div>
        <div style="margin-top:20px;">
            <asp:GridView ID="GridView1" runat="server" Width="1439px"></asp:GridView>
        </div>

</asp:Content>