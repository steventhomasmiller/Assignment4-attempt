<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
   <table>
        
       <tr>
        <td>Username:</td>
        <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
        <td>Password</td>
        <td><asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
             <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
        <td><asp:Label ID="lblError" runat="server" Text="Fill it out, if you would be so kind."></asp:Label></td>
            </tr>
        
     </table>
        
        <asp:LinkButton ID="lkbtnRegister" runat="server" PostBackUrl="Registration.aspx">Register</asp:LinkButton>


    </div>
    </form>
</body>
</html>
