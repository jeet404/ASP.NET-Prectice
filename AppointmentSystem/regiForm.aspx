<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regiForm.aspx.cs" Inherits="regiForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Appointment</title>
    <style>
        div{
            margin-bottom:16px;
            display:flex;
            justify-content:space-between;
        }
    </style>
</head>
<body>
     <div style="display:flex;justify-content:center;">
        <form id="form1" runat="server">
                <h2>Registration Form</h2>
                <div>
                    <asp:Label ID="lbl1" runat="server" Text="Full Name : "></asp:Label>
                    <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lbl2" runat="server" Text="Email : "></asp:Label>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lbl4" runat="server" Text="Mobile No : "></asp:Label>
                    <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lbl7" runat="server" Text="Gender : "></asp:Label>
                    <asp:RadioButton ID="rdoM" runat="server" Text="Male" GroupName="gen" />
                    <asp:RadioButton ID="rdoF" runat="server" Text="Female" GroupName="gen" />
                    <asp:RadioButton ID="rdoO" runat="server" Text="Other" GroupName="gen" />
                </div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Date of Birth : "></asp:Label>
                    <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lbl8" runat="server" Text="Choose Category : "></asp:Label>
                    <asp:DropDownList ID="ddlChoice" runat="server" AutoPostBack="true" AppendDataBoundItems="true">
                        <asp:ListItem Text="--Select Category--" Value="0"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <asp:Label ID="lbl9" runat="server" Text="Choose Date : "></asp:Label>
                    <asp:TextBox ID="txtSlot" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnRegi" runat="server" Text="Done" OnClick="btnRegi_Click" />
                    <br /><br />
                    <asp:Button ID="btnLogin" runat="server" Text="View Appointment" OnClick="btnLogin_Click" />
                </div>
                <div>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </div>
        </form>
    </div>
</body>
</html>
