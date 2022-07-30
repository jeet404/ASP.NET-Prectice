<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editDeleteData.aspx.cs" Inherits="editDeleteData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="display:flex;justify-content:center;margin-top:26px;">
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="lblRid" runat="server" Text="Room Id"></asp:Label>
                <asp:TextBox ID="txtRid" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            </div>
            <br />
            <div>
                <asp:Label ID="lblRname" runat="server" Text="Room Type : "></asp:Label>
                <br />
                <asp:TextBox ID="txtRname" runat="server"></asp:TextBox>
            </div>
            <br /><br />
            <div>
                <asp:Label ID="lblRprice" runat="server" Text="Room Price (per person) : "></asp:Label>
                <br />
                <asp:TextBox ID="txtRprice" runat="server"></asp:TextBox>
            </div>
            <br /><br />
            <div>
                <asp:Button ID="btnEdit" runat="server" Text="Update" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>
        </form>
    </div>
</body>
</html>
