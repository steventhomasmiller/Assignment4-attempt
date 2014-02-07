<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <h1>Register</h1>
    <div>
    <table>

        <tr>
            <td>Enter First Name:</td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
         <tr>
            <td>Enter Last Name:</td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            <td></td>
             </tr>
              <tr>
            <td>Enter Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtEmail" runat="server" ErrorMessage="I beg of you, enter an email."></asp:RequiredFieldValidator>
                  </td>
        </tr>
         <tr>
            <td>Enter Donation Amount:</td>
            <td>
                <asp:TextBox ID="txtDonation" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        
         <tr>
            <td>Enter Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" TextMode="Password"  runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please, enter a password!"></asp:RequiredFieldValidator></td>
        </tr>
         <tr>
            <td>Confirm Password:</td>
            <td>
                <asp:TextBox ID="txtConfirm" TextMode="Password" runat="server"></asp:TextBox></td>
            <td>
                 <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="These passwords, sadly, do not match." ControlToValidate="txtConfirm" ControlToCompare="txtPassword"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="These passwords, sadly, do not match."></asp:RequiredFieldValidator>
               
             
             </td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit!!" OnClick="btnSubmit_Click" />
            </td>
            <td>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
            <td>
                
            </td>
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
