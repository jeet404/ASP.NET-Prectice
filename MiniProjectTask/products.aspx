<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="products.aspx.cs" Inherits="products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <h1>Products</h1>
        <hr />
        <div class="row">
            <div class="form-style-product">
                <div class="form-control">
                    <asp:Label ID="lblcname" runat="server" Text="Product Name : "></asp:Label>
                    <asp:TextBox ID="txtPname" runat="server"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblCat" runat="server" Text="Category : "></asp:Label>
                    <asp:DropDownList ID="ddlCat" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlCat_SelectedIndexChanged">
                        <asp:ListItem Text="--Select Category--" Value="0"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-control">
                    <asp:Label ID="Label1" runat="server" Text="Brand : "></asp:Label>
                    <asp:DropDownList ID="ddlBrand" runat="server">
                        <asp:ListItem Text="--Select Brand--" Value="0"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblspec" runat="server" Text="Specification : "></asp:Label>
                    <asp:TextBox ID="txtSpec" runat="server" Rows="3" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblprice" runat="server" Text="Price : "></asp:Label>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
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
            <asp:GridView ID="gvProducts" runat="server" PageSize="5" DataKeyNames="p_id" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="false" Width="700px" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvProducts_PageIndexChanging" OnRowCancelingEdit="gvProducts_RowCancelingEdit" OnRowDeleting="gvProducts_RowDeleting" OnRowEditing="gvProducts_RowEditing" OnRowUpdating="gvProducts_RowUpdating">
                <Columns>
                    <asp:BoundField HeaderText="Product Name" DataField="p_name" />
                    <asp:BoundField HeaderText="Specifications" DataField="p_spec" />
                    <asp:BoundField HeaderText="Brand" DataField="p_brand" />
                    <asp:BoundField HeaderText="Category" DataField="p_cate" />
                    <asp:BoundField HeaderText="Price" DataField="p_price" />
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

