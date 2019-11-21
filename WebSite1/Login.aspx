<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Login
        <br /><br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" Height="25px" Width="128px" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
