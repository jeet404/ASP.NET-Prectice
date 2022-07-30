<%@ Page Language="C#" AutoEventWireup="true" CodeFile="roomsData.aspx.cs" Inherits="roomsData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Room Data</title>
</head>
<body>
    <div style="display:flex;justify-content:center;margin-top:26px;">
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="lblRname" runat="server" Text="Room Type : "></asp:Label>
                <br />
                <asp:TextBox ID="txtRname" runat="server"></asp:TextBox>
            </div>
            <br /><br />
            <div>
                <asp:Label ID="lblRprice" runat="server" Text="Room Price (/per person) : "></asp:Label>
                <br />
                <asp:TextBox ID="txtRprice" runat="server"></asp:TextBox>
            </div>
            <br /><br />
            <div>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <br /><br />
                <asp:Button ID="btnEdit" runat="server" Text="Edit Data" OnClick="btnEdit_Click" />
            </div>
        </form>
    </div>
</body>
</html>
