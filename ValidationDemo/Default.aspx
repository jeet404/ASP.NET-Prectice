<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Demo</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-body">
                <h1>Login</h1>
                <div class="form-control">
                    <asp:Label ID="lblUsrnm" runat="server">Username :</asp:Label>
                    <asp:TextBox ID="txtUsrnm" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUname" runat="server" ControlToValidate="txtUsrnm" ErrorMessage="Not Filled!"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revUname" runat="server" ControlToValidate="txtUsrnm" ValidationExpression="^[A-Z0-9]{6}$" ErrorMessage="EX = KSC1203"></asp:RegularExpressionValidator>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblPass" runat="server">Password :</asp:Label>
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPass" runat="server" ControlToValidate="txtPass" ErrorMessage="Not Filled!"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPass" runat="server" ControlToValidate="txtPass" ValidationExpression="^[A-Za-z0-9]{8,16}$" ErrorMessage="Password Must be in between 8 to 16 charcters"></asp:RegularExpressionValidator>
                </div>
                <div class="form-control">
                    <asp:Label ID="Label2" runat="server">Mobile :</asp:Label>
                    <asp:TextBox ID="txtMob" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMob" runat="server" ControlToValidate="txtMob" ErrorMessage="Not Filled!"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revMob" runat="server" ControlToValidate="txtMob" ValidationExpression="^[0-9]{10}$" ErrorMessage="Must be in 10 Digit"></asp:RegularExpressionValidator>
                </div>
                <div class="form-control">
                    <asp:Label ID="Label1" runat="server">PIN-CODE :</asp:Label>
                    <asp:TextBox ID="txtPIN" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPin" runat="server" ControlToValidate="txtPIN" ErrorMessage="Not Filled!"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPin" runat="server" ControlToValidate="txtPIN" ValidationExpression="^[0-9]{6}$" ErrorMessage="PIN Must be in 6 charcters"></asp:RegularExpressionValidator>
                </div>
                <div class="form-control">
                    <asp:Label ID="Label3" runat="server">ZIP-CODE :</asp:Label>
                    <asp:TextBox ID="txtZIP" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvZip" runat="server" ControlToValidate="txtZIP" ErrorMessage="Not Filled!"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revZip" runat="server" ControlToValidate="txtZIP" ValidationExpression="^[A-Z0-9]{6.8}$" ErrorMessage="EX = "></asp:RegularExpressionValidator>
                </div>
                <div class="form-control range-cont">
                    <asp:Label ID="Label4" runat="server">Total Marks :</asp:Label>
                    <asp:TextBox ID="txtTotalM" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTotalM" runat="server" ControlToValidate="txtTotalM" ErrorMessage="Not Filled!"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revTotalM" runat="server" ControlToValidate="txtTotalM" ValidationExpression="^[0-9]{3}$" ErrorMessage="Enter Proper Total Marks!"></asp:RegularExpressionValidator>
                    <br />
                    <asp:Label ID="Label5" runat="server">Obtain Marks :</asp:Label>
                    <asp:TextBox ID="txtObtM" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvObtM" runat="server" ControlToValidate="txtTotalM" ErrorMessage="Not Filled!"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="compM" runat="server" ControlToValidate="txtObtM" ControlToCompare="txtTotalM" Operator="LessThan" Type="Integer" ErrorMessage="Value Must be Lower Than you Entered in Total Marks!"></asp:CompareValidator>
                </div>
                <div class="form-control">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn-primary" />
                </div>
            </div>
    </form>
</body>
</html>
