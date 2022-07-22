<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Demo</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-body">
            <h1>Insert Demo</h1>
            <div class="form-control">
                <asp:Label ID="Label3" runat="server">Name :</asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="Label1" runat="server">Mobile :</asp:Label>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="Label2" runat="server">Email :</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn-primary" />
            </div>
        </div>
    </form>
</body>
</html>
