<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Upload Demo</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Upload File For Image</h1>
        <div>
            <asp:FileUpload ID="fuImg" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        </div>
        <div>
            <asp:Label ID="lblImgName" runat="server"></asp:Label>
        </div>
        <div class="contOfImg">
            <asp:Image ID="imgSec" runat="server" />
        </div>
    </form>
</body>
</html>
