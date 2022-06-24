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
                    <asp:Label ID="lblUsrnm" runat="server">Add City :</asp:Label>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Button ID="btnAddcity" runat="server" Text="Add City" CssClass="btn-primary" OnClick="btnAddcity_Click" />
                </div>
                <div class="form-control">
                    <asp:DropDownList ID="ddlCity" runat="server">
                        <asp:ListItem Value="non" Text="--Select City--"></asp:ListItem>
                        <asp:ListItem Value="Amreli" Text="Amreli"></asp:ListItem>
                        <asp:ListItem Value="Rajkot" Text="Rajkot"></asp:ListItem>
                        <asp:ListItem Value="Surat" Text="Surat"></asp:ListItem>
                        <asp:ListItem Value="Navsari" Text="Navsari"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-control">
                    <asp:Button ID="btnGetCity" runat="server" Text="Get City" CssClass="btn-primary" OnClick="btnGetCity_Click" />
                </div>
            </div>
        </form>
    </body>

    </html>
