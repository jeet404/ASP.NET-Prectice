<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Classic Gir</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>
        <h1>Classic Gir Resorts</h1>
    </header>
    <div class="container">
        <form id="form1" runat="server">
            <div class="form-control">
                <asp:Label ID="lblName" runat="server" Text="Full Name :"></asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="Label1" runat="server" Text="Which Room do you want ?"></asp:Label>
                <asp:DropDownList ID="ddlRooms" runat="server" AutoPostBack="true">
                    <asp:ListItem Value="0" Text="--Select Room--"></asp:ListItem>
                    <asp:ListItem Value="S" Text="Silver"></asp:ListItem>
                    <asp:ListItem Value="G" Text="Gold"></asp:ListItem>
                    <asp:ListItem Value="P" Text="Platinum"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-control">
                <asp:Label ID="lblPSec" runat="server" Text="Price :"></asp:Label>
                <div class="pr-cont">
                    <asp:Label ID="lblP" runat="server" Text="Price of 1 Person : "></asp:Label>
                    <asp:Label ID="lblOneP" runat="server" Text="0"></asp:Label>
                    <asp:TextBox ID="txtPerson" runat="server" Text="2" TextMode="Number"></asp:TextBox>
                    <a></a>
                </div>
            </div>
            <div class="form-control final">
                <asp:Label ID="lbl1" runat="server" Text="Total Payable Amount"></asp:Label>
                <hr /><br />
                <asp:Label ID="lblRMT" runat="server" Text="0"></asp:Label>
                <asp:Label ID="lbltex" runat="server" Text="18%"></asp:Label>
                <asp:Label ID="lblLine" runat="server" Text="----------------"></asp:Label>
                <asp:Label ID="lblTOT" runat="server" Text="0"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
