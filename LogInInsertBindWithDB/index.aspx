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
                <h1>Category</h1>
                <div class="form-control">
                    <!--<asp:Label ID="lblPass" runat="server">Description :</asp:Label>
                    <asp:TextBox ID="txtCdesc" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>-->
                    <asp:Label ID="Label1" runat="server">Category :</asp:Label>
                    <asp:DropDownList ID="ddlCate" runat="server" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlCate_SelectedIndexChanged">
                        <asp:ListItem Value="0" Text="--Select Category--" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="other" Text="Other"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblUsrnm" runat="server">Category Name :</asp:Label>
                    <asp:TextBox ID="txtCname" runat="server"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="btn-primary" />
                </div>
                <div>
                    <asp:Label ID="lblConStat" runat="server" Text=""></asp:Label>
                </div>
            </div>
    </form>
</body>
</html>
