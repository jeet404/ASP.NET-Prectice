<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SignUp</title>
    <style>
        div{
            margin-bottom:16px;
            display:flex;
            justify-content:space-between;
        }
    </style>
</head>
<body>
    <div style="display:flex;justify-content:center;">
        <form id="form1" runat="server">
            <h2>Sign Up</h2>
            <div>
                <asp:Label ID="lbl1" runat="server" Text="Full Name : "></asp:Label>
                <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lbl2" runat="server" Text="Email : "></asp:Label>
                <asp:TextBox ID="txtemail" runat="server" OnTextChanged="txtemail_TextChanged" AutoPostBack="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lbl3" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lbl4" runat="server" Text="Mobile No : "></asp:Label>
                <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnRegi" runat="server" Text="Signup" OnClick="btnRegi_Click" />
            </div>
            <div>
                <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
