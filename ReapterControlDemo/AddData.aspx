<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddData.aspx.cs" Inherits="AddData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Data</title>
    <style>
        .main-cont{
            display:flex;
            justify-content:center;
            margin-top:26px;
        }
        div{
            display:flex;
            justify-content:space-between;
            margin-bottom:6px;
        }
    </style>
</head>
<body>
    <div class="main-cont">
        <form id="form1" runat="server">
            <h2>Add Data Here</h2>
            <div>
                <asp:Label ID="lbl1" runat="server" Text="Name : "></asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="City : "></asp:Label>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Age : "></asp:Label>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Choose Document : "></asp:Label>
                <asp:FileUpload ID="fuDoc" runat="server" />
            </div>
            <div>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnDisp" runat="server" Text="View Data" OnClick="btnDisp_Click" />
            </div>
        </form>
    </div>
</body>
</html>
