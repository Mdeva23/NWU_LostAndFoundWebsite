<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateReport.aspx.cs" Inherits="NWU_LostAndFoundWebsite.GenerateReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please note that this site can only be accessed by admin ONLY<br />
            <br />
            Email:<br />
            <asp:TextBox ID="txtAdminEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAdminEmail" ErrorMessage="Incorrect Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="txtAdminPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdminPassword" ErrorMessage="Required!"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdminUser" runat="server" OnClick="btnAdminUser_Click" Text="Login as Admin" />
        </div>
    </form>
</body>
</html>
