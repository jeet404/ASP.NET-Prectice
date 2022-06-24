<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Pizza Plaza</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous" />
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <nav class="navbar bg-light">
        <div class="container-fluid d-flex justify-content-center">
            <h1 class="navbar-brand text-center">Pizza Plaza</>
        </div>
    </nav>
    <div class="main">
        <form id="form1" runat="server" class="mt-5 p-3 rounded col-md-4">
            <div class="mb-2">
                <asp:Label ID="lblSize" runat="server" Text="Choose Pizza Size :" CssClass="form-label col-md-6 fs-3"></asp:Label>
                <div class="form-control fs-5 d-flex justify-content-evenly">
                    <asp:CheckBox ID="SS" runat="server" Text="Small" AutoPostBack="true" OnCheckedChanged="SS_CheckedChanged" />
                    <asp:CheckBox ID="MS" runat="server" Text="Medium" AutoPostBack="true" OnCheckedChanged="MS_CheckedChanged" />
                    <asp:CheckBox ID="LS" runat="server" Text="Large" AutoPostBack="true" OnCheckedChanged="LS_CheckedChanged" />
                </div>
            </div>
            <div class="mb-2">
                <asp:Label ID="lblItm" runat="server" Text="Choose Pizza Item :" CssClass="form-label col-md-6 fs-3"></asp:Label><br />
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="item_1" runat="server" CssClass="fs-5" Text="Margarita" AutoPostBack="true" OnCheckedChanged="item_1_CheckedChanged" />
                    <asp:TextBox ID="qty_1" runat="server" CssClass="fs-5 form-text" TextMode="Number" AutoPostBack="true" OnTextChanged="qty_1_TextChanged"></asp:TextBox>
                    <asp:Label ID="p1" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="item_2" runat="server" CssClass="fs-5" Text="Hot & Spicy" AutoPostBack="true" OnCheckedChanged="item_2_CheckedChanged" />
                    <asp:TextBox ID="qty_2" runat="server" CssClass="fs-5 form-text" TextMode="Number" AutoPostBack="true" OnTextChanged="qty_2_TextChanged"></asp:TextBox>
                    <asp:Label ID="p2" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="item_3" runat="server" CssClass="fs-5" Text="Pelas Pasto" AutoPostBack="true" OnCheckedChanged="item_3_CheckedChanged" />
                    <asp:TextBox ID="qty_3" runat="server" CssClass="fs-5 form-text" TextMode="Number" AutoPostBack="true" OnTextChanged="qty_3_TextChanged"></asp:TextBox>
                    <asp:Label ID="p3" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="item_4" runat="server" CssClass="fs-5" Text="Seven Cheese" AutoPostBack="true" OnCheckedChanged="item_4_CheckedChanged" />
                    <asp:TextBox ID="qty_4" runat="server" CssClass="fs-5 form-text" TextMode="Number" AutoPostBack="true" OnTextChanged="qty_4_TextChanged"></asp:TextBox>
                    <asp:Label ID="p4" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
            </div>
            <div class="mb-2">
                <asp:Label ID="lblpar" runat="server" Text="Check If You Want Parcel :" CssClass="form-label col-md-6 fs-3"></asp:Label><br />
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="chkParcel" runat="server" Text="With Parcel" CssClass="fs-5" AutoPostBack="true" OnCheckedChanged="chkParcel_CheckedChanged" />
                    <asp:Label ID="lblParcel" runat="server" CssClass="fs-5">40<span class="fs-5">Rs.</span></asp:Label>
                </div>
            </div>
            <div class="mb-2">
                <asp:Label ID="lblFnl" runat="server" Text="Estimate :" CssClass="form-label col-md-6 fs-3"></asp:Label><br />
            </div>
            <div class="form-control d-flex flex-row align-items-start flex-column fs-5">
                <div class="d-flex justify-content-between col-md-12">
                    <asp:Label ID="lblPTotal" runat="server" Text="Total Price (Only Pizza)"></asp:Label>
                    <asp:Label ID="amtPT" runat="server">0</asp:Label>
                </div>
                <div class="d-flex justify-content-between col-md-12">
                    <asp:Label ID="lblWP" runat="server" Text="With Parcel"></asp:Label>
                    <asp:Label ID="amtPC" runat="server">0</asp:Label>
                </div>
                <hr />
                <div class="d-flex justify-content-between col-md-12">
                    <asp:Label ID="lblFTotal" runat="server" Text="Total Amount :"></asp:Label>
                    <asp:Label ID="amtFTOT" runat="server">0</asp:Label> 
                </div>
                <hr />
                <asp:Button ID="btnCal" runat="server" Text="Calculate" CssClass="btn btn-primary fs-5" OnClick="btnCal_Click" />
            </div>
        </form>
    </div>
    <!-- Script -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2"
        crossorigin="anonymous"></script>
</body>

</html>