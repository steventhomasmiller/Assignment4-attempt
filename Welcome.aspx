<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblHello" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="gvVehicle" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
