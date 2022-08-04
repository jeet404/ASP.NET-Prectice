<%@ Page Language="C#" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
</head>
<body>
    <div style="display:flex;justify-content:center;">
        <form id="form1" runat="server">
            <div>
                <h1><asp:Label ID="lblMsg" runat="server"></asp:Label></h1>
            </div>
            <br />
            <div>
                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            </div>
        </form>
    </div>
</body>
</html>
