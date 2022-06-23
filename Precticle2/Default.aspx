<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title>Login Page</title>
        <link href="style.css" rel="stylesheet" type="text/css" />
    </head>

    <body>
        <form id="form1" runat="server">
            <div class="form-body">
                <h1>Login</h1>
                <div class="form-control">
                    <asp:Label ID="lblUsrnm" runat="server">Username :</asp:Label>
                    <asp:TextBox ID="txtUsrnm" runat="server"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblPass" runat="server">Password :</asp:Label>
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-primary"
                        OnClick="btnLogin_Click" />
                </div>
            </div>
        </form>
    </body>

    </html>