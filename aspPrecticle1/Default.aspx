<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Regestration Form</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="main">
        <form id="form1" runat="server">
            <h1>Regestration Form</h1>
            <asp:Label ID="lbl1" runat="server">Full Name :</asp:Label>
            <asp:TextBox ID="TextFname" runat="server" CssClass="txtbox"></asp:TextBox>
            <asp:Label ID="Label1" runat="server">Email Id :</asp:Label>
            <asp:TextBox ID="TextEmail" runat="server" TextMode="Email" CssClass="txtbox"></asp:TextBox>
            <asp:Label ID="Label2" runat="server">Mobile No :</asp:Label>
            <asp:TextBox ID="TextMobile" runat="server" CssClass="txtbox"></asp:TextBox>
            <asp:Label ID="Label3" runat="server">Password :</asp:Label>
            <asp:TextBox ID="TextPass" runat="server" TextMode="Password" CssClass="txtbox"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn" OnClick="btnSave_Click" />
            <a href="dispData.aspx" class="btn" target="_blank" style="text-decoration-line:none;margin-top:5px;">Show Data</a>
        </form>
    </div>
    <footer>
        <h5>
            <asp:Label ID="lbl_stat" runat="server"></asp:Label>
        </h5>
        <h5>
            <asp:Label ID="lbl_opr" runat="server"></asp:Label>
        </h5>
    </footer>
</body>
</html>
