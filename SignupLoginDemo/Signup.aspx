<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <style>
        body{
            display:flex;
            justify-content:center;
        }
        form{
            display:flex;
            flex-direction:column;
            justify-content:center;
        }
        .form-body{
            background-color:coral;
            border:1px solid black;
            border-radius:16px;
            padding:16px;
            margin-top:20px;
            display:flex;
            flex-direction:column;
            align-items:center;
            align-self:center;
            font-size:1.2em;
            margin-bottom:20px;
            width:300px;
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
        <div class="form-body">
            <h2>Sign Up</h2>
            <div>
                <asp:Label ID="lblFname" runat="server" Text="First Name : "></asp:Label>
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblLname" runat="server" Text="Last Name : "></asp:Label>
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblUname" runat="server" Text="Username : "></asp:Label>
                <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblPass" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblMobile" runat="server" Text="Mobile No : "></asp:Label>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblDob" runat="server" Text="Date of Birth : "></asp:Label>
                <asp:TextBox ID="txtDob" TextMode="Date" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnIn" runat="server" Text="Signup" OnClick="btnIn_Click" CssClass="btn-primary" />
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn-primary" />
            </div>
        </div>
    </form>
</body>
</html>
