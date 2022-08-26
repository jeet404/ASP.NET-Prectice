<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        *{
            margin:0;
            padding:0;
            box-sizing:border-box;
        }
        body{
            display:flex;
            justify-content:center;
            align-items:center;
            height:90vh;
            width:100%;
            background:#151515;
        }
        form{
            padding:16px;
            width:250px;
            height:auto;
            background-color:whitesmoke;
            font-family:cursive;
            border-radius:14px;
            box-shadow:0px 0px 55px 1px cyan;
        }
        form input[type=text],
        form input[type=password]{
            font-family:cursive;
            font-size:1em;
            border-top-right-radius:16px;
            border:0px;
            box-shadow:0px 0px 55px 1px cyan;
        }
        form input[type=text]:focus,
        form input[type=password]:focus{
            box-shadow:0px 0px 20px 6px cyan;
        }
        form input[type=submit]{
            width:30%;
            padding:4px;
            font-family:cursive;
            font-size:1em;
            background-color:transparent;
            border:0px;
            border-bottom-left-radius:10px;
            border-top-right-radius:10px;
            box-shadow:0px 0px 55px 1px cyan;
        }
        form input[type=submit]:hover{
            box-shadow:0px 0px 20px 6px cyan;
        }
        div{
            display:flex;
            flex-direction:column;
            justify-content:space-between;
        }
    </style>
</head>
<body>
        <form id="form1" runat="server">
            <h1>Login</h1>
            <br /><br />
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
</body>
</html>
