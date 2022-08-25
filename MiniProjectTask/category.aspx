<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="category.aspx.cs" Inherits="category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <h1>Category</h1>
        <hr />
        <div class="row">
            <div class="form-style">
                <div class="form-control">
                    <asp:Label ID="lblcname" runat="server" Text="Category Name : "></asp:Label>
                    <asp:TextBox ID="txtCateName" runat="server"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                </div>
                <div class="form-control">
                    <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>
                </div>
            </div>
        </div>
        <div class="row">
            <asp:GridView ID="gvCategory" runat="server" PageSize="5" DataKeyNames="c_id" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="false" Width="300px" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvCategory_PageIndexChanging" OnRowCancelingEdit="gvCategory_RowCancelingEdit" OnRowDeleting="gvCategory_RowDeleting" OnRowEditing="gvCategory_RowEditing" OnRowUpdating="gvCategory_RowUpdating">
                <Columns>
                    <asp:BoundField HeaderText="Category Name" DataField="c_name" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>