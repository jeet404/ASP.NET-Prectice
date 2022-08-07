<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewAp.aspx.cs" Inherits="ViewAp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Appointment</title>
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
            <h1>View Your Appointment</h1>
            <div>
                <asp:Label ID="lbl1" runat="server" Text="Appointment Id : "></asp:Label>
                <asp:TextBox ID="txtApId" runat="server" OnTextChanged="txtApId_TextChanged" AutoPostBack="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lbl2" runat="server" Text="Select Date of Birth : "></asp:Label>
                <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnView" runat="server" Text="View" OnClick="btnView_Click" />
            </div>
            <div>
                <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>
