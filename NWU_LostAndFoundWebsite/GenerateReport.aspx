<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateReport.aspx.cs" Inherits="NWU_LostAndFoundWebsite.GenerateReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #CCCCCC; font-family: Arial, Helvetica, sans-serif; font-size: small;">
            <strong style="font-family: Arial, Helvetica, sans-serif; color: #3366CC"><span class="auto-style1" style="color: #0066CC; font-family: Arial, Helvetica, sans-serif">North West University Lost and Found Website</span></strong><br />
            <br />
            Please note that this site can only be accessed by admin ONLY<br />
            <br />
            Email:<br />
            <asp:TextBox ID="txtAdminEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAdminEmail" ErrorMessage="Incorrect Format!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True" ForeColor="#CC3399"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="txtAdminPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblincorrectEmail" runat="server"></asp:Label>
            <br />
        </div>
        <p style="background-color: #CCCCCC">
            <asp:Button ID="btnAdminUser" runat="server" OnClick="btnAdminUser_Click" Text="Login as Admin" Font-Bold="True" Font-Names="Arial Narrow" />
        </p>
    </form>
</body>
</html>
