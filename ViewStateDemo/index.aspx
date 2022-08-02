<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="display:flex;justify-content:center;align-items:center">
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="txtCont" runat="server"></asp:TextBox>
                <asp:Button ID="btnDone" runat="server" Text="Clear & Submit" OnClick="btnDone_Click" />
                <asp:Button ID="btnRestore" runat="server" Text="Restore" OnClick="btnRestore_Click" />
            </div>
        </form>
    </div>
</body>
</html>
