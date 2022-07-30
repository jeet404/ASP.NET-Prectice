﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
</head>
<body>
    <div style="display:flex;justify-content:center;margin-top:26px;">
        <form id="form1" runat="server">
            <div>
                <h1><asp:Label ID="lblDisp" runat="server" Text="Welcome "></asp:Label>
                <asp:Label ID="lblUname" runat="server"></asp:Label></h1>
                <br />
                <asp:Label ID="lblSid" runat="server"></asp:Label>
            </div>
            <br />
            <div>
                <asp:Button ID="btnProtPage" runat="server" Text="Protected Page" OnClick="btnProtPage_Click" />
                <br /><br />
                <asp:Button ID="btnShow" runat="server" Text="Session Id" OnClick="btnShow_Click" />
                <br /><br />
                <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            </div>
        </form>
    </div>
</body>
</html>
