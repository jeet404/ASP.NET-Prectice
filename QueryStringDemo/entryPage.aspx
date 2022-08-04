<%@ Page Language="C#" AutoEventWireup="true" CodeFile="entryPage.aspx.cs" Inherits="entryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Entry Page</title>
</head>
<body>
    <div style="display:flex;justify-content:center;">
        <form id="form1" runat="server">
            <h1>Query String Demo</h1>
            <br />
            <div>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
            <br />
            <div>
                <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
