<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
     <div style="display:flex;justify-content:center;margin-top:26px;">
        <form id="form2" runat="server">
            <div>
                <h1 style="text-align:center"><asp:Label ID="lblMsg" runat="server" Text="Registration"></asp:Label></h1>
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
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblfname" runat="server" Text="Full Name : "></asp:Label>
                <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblmno" runat="server" Text="Mobile No : "></asp:Label>
                <asp:TextBox ID="txtmno" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="btnRegi" runat="server" Text="SignUp" OnClick="btnRegi_Click" />
            </div>
            <br />
            <div>
                <asp:Button ID="btnMove" runat="server" Text="Already User" OnClick="btnMove_Click" />
            </div>
        </form>
    </div>
</body>
</html>
