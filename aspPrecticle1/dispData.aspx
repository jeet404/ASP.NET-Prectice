<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dispData.aspx.cs" Inherits="dispData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inserted Data</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="False" CellPadding="3" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />  
             <columns>  
                 <asp:TemplateField HeaderText="Id">  
                     <ItemTemplate>  
                         <asp:Label ID="Lblid" runat="server" Text='<%#Bind("Id") %>'></asp:Label>  
                     </ItemTemplate>  
                 </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Full Name">  
                     <ItemTemplate>  
                         <asp:Label ID="Lblname" runat="server" Text='<%#Bind("fullname") %>'></asp:Label>  
                     </ItemTemplate>  
                 </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Email">  
                     <ItemTemplate>  
                         <asp:Label ID="Lblemail" runat="server" Text='<%#Bind("email") %>'></asp:Label>  
                     </ItemTemplate>  
                 </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Mobile No">  
                     <ItemTemplate>  
                         <asp:Label ID="Lblmno" runat="server" Text='<%#Bind("mobileno") %>'></asp:Label>  
                     </ItemTemplate>  
                 </asp:TemplateField>  
                 <asp:TemplateField HeaderText="Password">  
                     <ItemTemplate>  
                         <asp:Label ID="Lblpass" runat="server" Text='<%#Bind("password") %>'></asp:Label>  
                     </ItemTemplate>  
                 </asp:TemplateField>  
             </columns>  
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
    </form>
    <footer>
        <h5>
            <asp:Label ID="lbl_stat" runat="server"></asp:Label>
        </h5>
    </footer>
</body>
</html>
