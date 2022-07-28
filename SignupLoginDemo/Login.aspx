<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log in</title>
    <style>
        body{
            display:flex;
            justify-content:center;
        }
         form{
            display:flex;
            flex-direction:column;
            justify-content:center;
        }
        .form-body{
            background-color:coral;
            border:1px solid black;
            border-radius:16px;
            padding:16px;
            margin-top:20px;
            display:flex;
            flex-direction:column;
            align-items:center;
            align-self:center;
            font-size:1.2em;
            margin-bottom:20px;
            width:300px;
        }
        h2{
            background-color:white;
            border-radius:16px;
            padding:10px;
            margin:6px;
        }
        form input{
            margin-bottom:10px;
        }
        .btn-primary{
            font-size:1.1em;
            padding:6px;
            border-radius:16px;
        }
        .data-cont{
            display:flex;
            justify-content:center;
            align-items:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-body">
            <h2>Login</h2>
            <div>
                <asp:Label ID="lblUname" runat="server" Text="Username : "></asp:Label>
                <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblPass" runat="server" Text="Password : "></asp:Label>
                <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnIn" runat="server" Text="Login" OnClick="btnIn_Click" CssClass="btn-primary" />
                <br />
            </div>
            <div>
                <asp:Label ID="lblres" runat="server"></asp:Label>
                <asp:LinkButton ID="linkBack" Text="Back" runat="server" PostBackUrl="~/Signup.aspx"></asp:LinkButton>
            </div>
        </div>
        <div class="data-cont">
        <asp:GridView ID="gvDatas" AllowPaging="true" runat="server" PageSize="5" AllowSorting="True" CellPadding="4" AutoGenerateColumns="false" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvData_PageIndexChanging" OnRowCancelingEdit="gvDatas_RowCancelingEdit" OnRowDeleting="gvDatas_RowDeleting" DataKeyNames="Id" OnRowEditing="gvDatas_RowEditing" OnRowUpdating="gvDatas_RowUpdating">
            <Columns>
                <asp:BoundField HeaderText="No." DataField="Id" />
                <asp:BoundField HeaderText="First Name" DataField="u_fname" />
                <asp:BoundField HeaderText="Last Name" DataField="u_lname" />
                <asp:BoundField HeaderText="Username" DataField="u_username" />
                <asp:BoundField HeaderText="Password" DataField="u_password" />
                <asp:BoundField HeaderText="Mobile No." DataField="u_mobile" />
                <asp:BoundField HeaderText="Date of Birth" DataField="u_dob" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="true" />
            </Columns>
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
