<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClaimItem.aspx.cs" Inherits="NWU_LostAndFoundWebsite.ClaimItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            You are in the processing of claiming the item(s)
            <br />
            Please make sure you have claim the correct item(s)<br />
            <br />
            Details of Item:<br />
            <asp:ListBox ID="ListBoxClaimedItem" runat="server" Width="731px"></asp:ListBox>
&nbsp;<br />
            <br />
            Please enter when and where would you like to collect your item(s)<br />
            Location:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLocation" ErrorMessage="Required!"></asp:RequiredFieldValidator>
            <br />
            Time:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTime" ErrorMessage="Required!"></asp:RequiredFieldValidator>
            <br />
            Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTime" ErrorMessage="Required!"></asp:RequiredFieldValidator>
            <br />
            <br />
&nbsp;
            <asp:Button ID="btnAddToDatabase" runat="server" Text="Add to database" OnClick="btnAddToDatabase_Click1" />
            <br />
        </div>
    </form>
</body>
</html>
