<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        div{
            display:flex;
            justify-content:space-between;
        }
    </style>
</head>
<body>
    <div style="display:flex;justify-content:center;margin-top:20px;">
        <form id="form1" runat="server">
            <h1>Login</h1>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Email : "></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <br /><br />
                <div>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </div>
        </form>
    </div>
</body>
</html>
