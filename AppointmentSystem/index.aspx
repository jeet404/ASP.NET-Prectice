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
            <asp:Repeater ID="rprData" runat="server">
                <HeaderTemplate>
                    <h1>Welcome <asp:Label ID="lblUserDisp" runat="server"></asp:Label></h1>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="inner-cont" id="printarea">
                        <div>
                            Appointment Id :
                            <asp:Label ID="lblApNo" runat="server" Text='<%# Eval("ap_id")%>'></asp:Label>
                        </div>
                        <div>
                            Name :
                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("ap_name") %>'></asp:Label>
                        </div>
                        <div>
                            Email : 
                            <asp:Label ID="lblMobile" runat="server" Text='<%# Eval("ap_email") %>'></asp:Label>
                        </div> 
                        <div>
                            Mobile No :
                            <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("ap_mobile") %>'></asp:Label>
                        </div>
                        <div>
                            Gender :
                            <asp:Label ID="lblGen" runat="server" Text='<%# Eval("ap_gender") %>'></asp:Label>
                        </div>
                        <div>
                            Date of Birth : 
                            <asp:Label ID="lblDob" runat="server" Text='<%# DateTime.Parse(Eval("ap_dob").ToString()).ToShortDateString() %>'></asp:Label>
                        </div>
                        <div>
                            Expert Name : 
                            <asp:Label ID="lblApType" runat="server" Text='<%# Eval("ap_expert") %>'></asp:Label>
                        </div>
                        <div>
                            Your Appointment Date : 
                            <asp:Label ID="lblSlotDt" runat="server" Text='<%# DateTime.Parse(Eval("ap_slot").ToString()).ToShortDateString() %>'></asp:Label>
                        </div>
                        <div>
                            Your Appointment Time :
                            <asp:Label ID="lblSlotTm" runat="server" Text='<%# DateTime.Parse(Eval("ap_slot").ToString()).ToShortTimeString() %>'></asp:Label>
                        </div>
                    </div>
                    <br />
                </ItemTemplate>
                <FooterTemplate>
                </FooterTemplate>
            </asp:Repeater>
            <div>
                <input type="button" onclick="PrintDiv()" value="Print" id="btnprint" />
                <asp:Button ID="btnExit" runat="server" Text="Exit" OnClick="btnExit_Click" />
            </div>
        </form>
    </div>
</body>
</html>
