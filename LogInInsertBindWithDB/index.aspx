<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome || Admin</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="form-body">
                <h1>Add Category</h1>
                <div class="form-control">
                    <asp:Label ID="lblUsrnm" runat="server">Category Name :</asp:Label>
                    <asp:TextBox ID="txtCname" runat="server"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblPass" runat="server">Description :</asp:Label>
                    <asp:TextBox ID="txtCdesc" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Button ID="btnLogin" runat="server" Text="Add" CssClass="btn-primary" OnClick="btnLogin_Click" />
                </div>
                <div>
                    <asp:Label ID="lblConStat" runat="server" Text=""></asp:Label>
                </div>
            </div>
    </form>
</body>
</html>
