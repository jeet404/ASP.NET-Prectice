<%@ Page Language="C#" AutoEventWireup="true" CodeFile="protectedPage.aspx.cs" Inherits="protectedPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Protected Page</title>
</head>
<body>
    <div style="display:flex;justify-content:center;margin-top:26px;">
        <form id="form1" runat="server">
            <div>
                <h1><asp:Label ID="lbldisp" runat="server" Text="This is Protected Page."></asp:Label></h1>
            </div>
            <div>
                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            </div>
        </form>
    </div>
</body>
</html>
