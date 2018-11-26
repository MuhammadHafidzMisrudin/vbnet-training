<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 174px">
            <asp:Login ID="Login1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" DestinationPageUrl="~/Welcome.aspx">
            </asp:Login>
            <br />
        </div>
    </form>
</body>
</html>
