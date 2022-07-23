<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log in</title>
    <style>
        body{
            display:flex;
            justify-content:center;
        }
        form{
            background-color:coral;
            border:1px solid black;
            border-radius:16px;
            padding:16px;
            margin-top:20px;
            display:flex;
            height:200px;
            flex-direction:column;
            align-items:center;
            font-size:1.2em;
        }
        h2{
            background-color:white;
            border-radius:16px;
            padding:10px;
            margin:6px;
        }
        form input{
            margin-bottom:10px;
        }
        .btn-primary{
            font-size:1.1em;
            padding:6px;
            border-radius:16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Login</h2>
        <div>
            <asp:Label ID="lblUname" runat="server" Text="Username : "></asp:Label>
            <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblPass" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnIn" runat="server" Text="Login" OnClick="btnIn_Click" CssClass="btn-primary" />
            <br />
        </div>
        <div>
            <asp:Label ID="lblres" runat="server"></asp:Label>
            <asp:LinkButton ID="linkBack" Text="Back" runat="server" PostBackUrl="~/Signup.aspx"></asp:LinkButton>
        </div>
    </form>
</body>
</html>
