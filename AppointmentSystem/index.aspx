<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <style>
        div{
            margin-bottom:16px;
            display:flex;
            justify-content:space-between;
        }
        .main-cont{
            display:flex;
            justify-content:center;
            margin-top:20px;
        }
        .inner-cont{
            border:1px solid black;
            padding:16px; 
            margin-top:20px;
            display:flex;
            flex-direction:column;
            width:300px;
        }
    </style>
    <script>
        function PrintDiv() {
            var divToPrint = document.getElementById('printarea');
            var popupWin = window.open('','width=300,height=400,location=no,left=200px');
            popupWin.document.open();
            popupWin.document.write('<html><body onload="window.print()">' + divToPrint.innerHTML + '</html>');
            popupWin.document.close();
        }
    </script>
</head>
<body>
    <div class="main-cont">
        <form id="form1" runat="server">
            <h1>Welcome <asp:Label ID="lblUserDisp" runat="server"></asp:Label></h1>
            <div class="inner-cont" id="printarea">
                <div>
                    <asp:Label ID="lblApNo" runat="server" Text="Appointment Id : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblName" runat="server" Text="Name : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblMobile" runat="server" Text="Email : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblEmail" runat="server" Text="Mobile No : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblGen" runat="server" Text="Gender : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblDob" runat="server" Text="Date of Birth : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblApType" runat="server" Text="Expert Name : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblSlotDt" runat="server" Text="Your Appointment Date : "></asp:Label>
                </div>
                <div>
                    <asp:Label ID="lblSlotTm" runat="server" Text="Your Appointment Time : "></asp:Label>
                </div>
            </div>
            <br />
            <div>
                <input type="button" onclick="PrintDiv()" value="Print" id="btnprint" />
                <asp:Button ID="btnExit" runat="server" Text="Exit" OnClick="btnExit_Click" />
            </div>
        </form>
    </div>
</body>
</html>
