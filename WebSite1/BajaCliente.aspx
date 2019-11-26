<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BajaCliente.aspx.cs" Inherits="BajaCliente" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div style="margin-top:100px;">
        <asp:Button ID="btnAlta" runat="server" Text="Alta" />
        <asp:Button ID="btnModificacion" runat="server" Text="Modificacion" />
    </div>
    <div>
        <asp:Label ID="lbNombre" runat="server" Text="Nombre del Cliente: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:GridView ID="gvClientes" runat="server" AutoGenerateColumns="true"></asp:GridView>
        <asp:Table ID="Table1" runat="server"></asp:Table>
        <asp:ListView ID="ListViewClientes" runat="server">
        <ItemTemplate>
            <div>
                <div style="float:left; margin-right: 15px;">
                    <strong>Codigo : </strong>
                    <br />
                    <asp:Label runat="server" ID="lblId" Text='<%# Eval("id_cliente") %>'></asp:Label>
                </div>
                <div style="position: relative">
                    <strong>Nombre :</strong>
                    <br />
                    <asp:Label runat="server" ID="lblName" Text='<%# Eval("nombre") %>'></asp:Label>
                </div>

            </div>
        </ItemTemplate>
    

        </asp:ListView>
        <asp:Repeater ID="Repeater1" runat="server"></asp:Repeater>
    </div>
    <div>
        <asp:Button ID="btnBajaCliente" runat="server" Text="Button" Width="305px" OnClick="btnBajaCliente_Click" />
    </div>
    
</asp:Content>