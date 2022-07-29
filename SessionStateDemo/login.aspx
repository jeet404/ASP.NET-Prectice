<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <div style="display:flex;justify-content:center;margin-top:26px;">
        <form id="form1" runat="server">
            <div>
                <h1><asp:Label ID="lblMsg" runat="server" Text="Enter Valid Password for Login"></asp:Label></h1>
                <br />
                <asp:Label ID="lblErr" runat="server"></asp:Label>
            </div>
            <br />
            <br />
            <div>
                <asp:Label ID="lbluname" runat="server" Text="Username : "></asp:Label>
                <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblpass" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
        </form>
    </div>
</body>
</html>
