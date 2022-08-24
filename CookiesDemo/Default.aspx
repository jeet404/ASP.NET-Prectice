<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="display:flex;justify-content:center;">
        <form id="form1" runat="server">
            <asp:Label ID="lbl1" runat="server" Text="Enter your Name :"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl2" runat="server" Text="Enter your Age :"></asp:Label>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSet" runat="server" Text="Set Cookie" OnClick="btnSet_Click" />
        </form>
    </div>
</body>
</html>
