<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dispData.aspx.cs" Inherits="dispData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome || Display</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-body">
                <h1>Category</h1>
                <div class="form-control">
                    <asp:Label ID="lblUsrnm" runat="server">Category :</asp:Label>
                    <asp:DropDownList ID="ddlCate" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCate_SelectedIndexChanged" AppendDataBoundItems="true">
                        <asp:ListItem Value="0" Text="--Select Category--"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblPass" runat="server">Description :</asp:Label>
                    <asp:TextBox ID="txtCdesc" runat="server" Rows="5" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lblConStat" runat="server" Text=""></asp:Label>
                </div>
            </div>
    </form>
</body>
</html>
