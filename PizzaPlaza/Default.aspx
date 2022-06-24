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
                    <asp:CheckBox ID="SS" runat="server" Text="Small" />
                    <asp:CheckBox ID="MS" runat="server" Text="Medium" />
                    <asp:CheckBox ID="LS" runat="server" Text="Large" />
                </div>
            </div>
            <div class="mb-2">
                <asp:Label ID="lblItm" runat="server" Text="Choose Pizza Item :" CssClass="form-label col-md-6 fs-3"></asp:Label><br />
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="chkMgrt" runat="server" CssClass="fs-5" Text="Margarita" />
                    <asp:TextBox ID="txtnumOfMgrt" runat="server" CssClass="fs-5 form-text" TextMode="Number"></asp:TextBox>
                    <asp:Label ID="lblpriceM" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="chkHas" runat="server" CssClass="fs-5" Text="Hot & Spicy" />
                    <asp:TextBox ID="txtnumOfHas" runat="server" CssClass="fs-5 form-text" TextMode="Number"></asp:TextBox>
                    <asp:Label ID="lblpriceH" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="chkPsp" runat="server" CssClass="fs-5" Text="Pelas Pasto" />
                    <asp:TextBox ID="txtnumOfpsp" runat="server" CssClass="fs-5 form-text" TextMode="Number"></asp:TextBox>
                    <asp:Label ID="lblpriceP" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="chkSc" runat="server" CssClass="fs-5" Text="Seven Cheese" />
                    <asp:TextBox ID="txtnumOfSc" runat="server" CssClass="fs-5 form-text" TextMode="Number"></asp:TextBox>
                    <asp:Label ID="lblpriceS" runat="server" CssClass="fs-5">0<span class="fs-5">Rs.</span></asp:Label>
                </div>
            </div>
            <div class="mb-2">
                <asp:Label ID="lblpar" runat="server" Text="Check If You Want Parcel :" CssClass="form-label col-md-6 fs-3"></asp:Label><br />
                <div class="form-control col-md-12 d-flex flex-row align-items-center justify-content-between">
                    <asp:CheckBox ID="chkParcel" runat="server" Text="With Parcel" CssClass="fs-5" />
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
            </div>
        </form>
    </div>
    <!-- Script -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2"
        crossorigin="anonymous"></script>
</body>

</html>