<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DropDownList Demo</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-body">
            <h1>Select Your Location</h1>
            <div class="form-control">
                <asp:DropDownList ID="ddlCo" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCo_SelectedIndexChanged">
                    <asp:ListItem Value="0" Text="--Select Country--"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-control">
                <asp:DropDownList ID="ddlSt" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSt_SelectedIndexChanged">
                    <asp:ListItem Value="0" Text="--Select State--"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-control">
                <asp:DropDownList ID="ddlCt" runat="server">
                    <asp:ListItem Value="0" Text="--Select City--"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
    </form>
</body>
</html>
