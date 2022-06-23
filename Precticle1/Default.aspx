<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Information</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>User Information</h1>
        <div class="form-body">
            <div class="form-control">
                <asp:Label ID="lblFname" runat="server">First Name :</asp:Label>
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="lblLname" runat="server">Last Name :</asp:Label>
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="lblAge" runat="server">Age :</asp:Label>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="lblDob" runat="server">Date of Birth :</asp:Label>
                <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="lblAdd" runat="server">Address :</asp:Label>
                <asp:TextBox ID="txtAdd" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="form-control">
                <asp:Label ID="Label1" runat="server">City :</asp:Label>
                <asp:DropDownList ID="ddlCity" runat="server">
                    <asp:ListItem Value="0" Text="--Select City--"></asp:ListItem>
                    <asp:ListItem Value="Amreli" Text="Amreli"></asp:ListItem>
                    <asp:ListItem Value="Rajkot" Text="Rajkot"></asp:ListItem>
                    <asp:ListItem Value="Bhavnagar" Text="Bhavnagar"></asp:ListItem>
                    <asp:ListItem Value="Bhuj" Text="Bhuj"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-control">
                <asp:Label ID="lblEmail" runat="server">Email :</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div class="form-control form-gender">
                <asp:Label ID="lblGen" runat="server">Gender :</asp:Label>
                <asp:RadioButton ID="rdoM" runat="server" Text="Male" GroupName="gen" />
                <asp:RadioButton ID="rdoF" runat="server" Text="Female" GroupName="gen" />
            </div>
            <div class="form-control">
                <asp:Label ID="lblhobby" runat="server">Hobbies :</asp:Label>
                <div class="form-hobby">
                    <asp:CheckBox ID="chk1" runat="server" Text="Cricket" />
                    <asp:CheckBox ID="chk2" runat="server" Text="Football" />
                    <asp:CheckBox ID="chk3" runat="server" Text="Coding" /><br />
                    <asp:CheckBox ID="chk4" runat="server" Text="Dancing" />
                    <asp:CheckBox ID="chk5" runat="server" Text="Singing" />
                </div>
            </div>
            <div class="form-control">
                <asp:Button ID="btnDisp" runat="server" Text="Show" CssClass="btn-primary" OnClick="btnDisp_Click" />
            </div>
        </div>
    </form>
</body>
</html>
