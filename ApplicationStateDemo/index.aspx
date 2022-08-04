<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Application State Demo</title>
</head>
<body>
    <div style="display:flex;justify-content:center">
        <form id="form1" runat="server">
            <h1>Refresh Page For Result</h1>
            <br /><br />
            <div style="border:1px solid black;padding:16px;">
                <asp:Label ID="lblCount" runat="server" Text="Count : "></asp:Label>
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
