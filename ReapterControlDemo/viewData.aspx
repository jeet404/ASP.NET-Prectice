<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewData.aspx.cs" Inherits="viewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data On Reapter</title>
    <style>
        .main-cont{
            display:flex;
            justify-content:center;
            margin-top:26px;
        }
        div{
            display:flex;
            justify-content:space-between;
            margin-bottom:6px;
        }
    </style>
</head>
<body>
        <form id="form1" runat="server">
            <div class="main-cont">
                <h1>Here is User's Data</h1>
                <br />
            </div>
            <div class="main-cont">
                <asp:Repeater ID="rprData" runat="server">
                    <HeaderTemplate>
                       <table cellspacing="0" rules="all" border="1">
                            <tr>
                                <th scope="col" style="width: 80px">
                                    Name
                                </th>
                                <th scope="col" style="width: 120px">
                                    City
                                </th>
                                <th scope="col" style="width: 100px">
                                    Age
                                </th>
                                <th scope="col" style="width: 100px">
                                    Doc
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr style="background-color:cyan;">
                            <td>
                                <asp:Label ID="lblCustomerId" runat="server" Text='<%# Eval("u_name") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblContactName" runat="server" Text='<%# Eval("u_city") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("u_age") %>' />
                            </td>
                            <td>
                                <img alt="..." src='uploads/<%#Eval("u_doc") %>' height="50px" width="50px" />
                            </td>
                       </tr>
                    </ItemTemplate>
                    <SeparatorTemplate>  
                        <tr>  
                            <td>  
                                <hr />  
                            </td>  
                            <td>  
                                <hr />  
                            </td>  
                            <td>  
                                <hr />  
                            </td>
                            <td>  
                                <hr />  
                            </td>  
                        </tr>  
                    </SeparatorTemplate> 
                    <AlternatingItemTemplate>  
                       <tr style="background-color:yellow;">
                            <td>
                                <asp:Label ID="lblCustomerId" runat="server" Text='<%# Eval("u_name") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblContactName" runat="server" Text='<%# Eval("u_city") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("u_age") %>' />
                            </td>
                            <td>
                                <img alt="..." src='uploads/<%#Eval("u_doc") %>' height="50px" width="50px" />
                            </td>
                       </tr> 
                    </AlternatingItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </form>
</body>
</html>
