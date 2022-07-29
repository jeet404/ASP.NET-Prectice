<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" EnableEventValidation="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resort Booking System</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>
        <h1>Classic Gir Resorts</h1>
    </header>
    <div class="container">
        <form id="form1" runat="server">
            <div class="form-body">
                <div class="form-control" style="text-align:center;">
                    <h2>Book Your Room</h2>
                    <hr />
                </div>
                <div class="form-control">
                    <asp:Label ID="lblfname" runat="server" Text="Full Name"></asp:Label>
                    <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                    <asp:Label ID="lblmno" runat="server" Text="Mobile No."></asp:Label>
                    <asp:TextBox ID="txtMno" runat="server"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblDoc" runat="server" Text="Upload Any Id Proof :"></asp:Label>
                    <asp:FileUpload ID="fuDoc" runat="server" />
                </div>
                <div class="form-control">
                    <asp:Label ID="Label1" runat="server" Text="Which Room do you want ?"></asp:Label>
                    <asp:DropDownList ID="ddlRooms" runat="server" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlRooms_SelectedIndexChanged">
                        <asp:ListItem Value="0" Text="--Select Room--"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-control">
                    <asp:Label ID="lblPSec" runat="server" Text="Price :"></asp:Label>
                    <div class="pr-cont">
                        <asp:Label ID="lblP" runat="server" Text="Price of 1 Person : "></asp:Label>
                        <asp:Label ID="lblOneP" runat="server" Text="0"></asp:Label>
                        <asp:TextBox ID="txtPerson" runat="server" TextMode="Number" AutoPostBack="true" OnTextChanged="txtPerson_TextChanged"></asp:TextBox>
                        <asp:Label ID="lblPTOT" runat="server" Text="0"></asp:Label>
                        <a></a>
                    </div>
                </div>
                <div class="form-control final">
                    <asp:Label ID="lbl1" runat="server" Text="Total Payable Amount"></asp:Label>
                    <hr /><br />
                    <asp:Label ID="lblRMT" runat="server" Text="0"></asp:Label>
                    <asp:Label ID="lbltex" runat="server" Text="+ 18% GST"></asp:Label>
                    <asp:Label ID="lblLine" runat="server" Text="----------------"></asp:Label>
                    <asp:Label ID="lblTOT" runat="server" Text="0"></asp:Label>
                </div>
                <div class="form-control btn-cont">
                    <asp:Button ID="btnCal" runat="server" Text="Book Now" OnClick="btnCal_Click" />
                </div>
                <div class="form-control">
                    <asp:Label ID="lblres" runat="server"></asp:Label>
                </div>
            </div>
            <div class="data-cont">
                <asp:GridView ID="gvBooking" AutoGenerateColumns="false" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <Columns>
                        <asp:BoundField HeaderText="Booking No." DataField="Id" />
                        <asp:BoundField HeaderText="Name" DataField="b_name" />
                        <asp:BoundField HeaderText="Mobile No." DataField="b_mobile" />
                        <asp:BoundField HeaderText="Room Type" DataField="b_roomtype" />
                        <asp:BoundField HeaderText="Persons" DataField="b_totalperson" />
                        <asp:BoundField HeaderText="Amount(With GST)" DataField="b_totalbill" />
                        <asp:ImageField HeaderText="ID Proof" DataImageUrlField="b_doc" ControlStyle-Width="100px"></asp:ImageField>
                    </Columns>
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>

        </form>
    </div>
</body>
</html>
