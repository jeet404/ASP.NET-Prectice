<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        div{
            margin-bottom:16px;
            display:flex;
            justify-content:space-between;
        }
    </style>
</head>
<body>
    <div style="display:flex;justify-content:center;margin-top:26px;">
        <form id="form1" runat="server">
            <div>
                <h1>Login</h1>
                <br />
                <asp:Label ID="lblErr" runat="server"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lbluname" runat="server" Text="Email : "></asp:Label>
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblpass" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <br /><br />
                <asp:Button ID="btnRegi" runat="server" Text="New User" OnClick="btnRegi_Click" />
            </div>
        </form>
    </div>
</body>
</html>
