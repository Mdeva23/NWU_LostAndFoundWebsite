<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newsFeed.aspx.cs" Inherits="NWU_LostAndFoundWebsite.newsFeed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtSearchForItem" runat="server" Width="518px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search For Item" />
        <br />
        <br />
        Lost Items<br />
        <asp:ListBox ID="ListBoxItems" runat="server" Height="295px" Width="789px"></asp:ListBox>
        <br />
&nbsp;<br />
        <asp:Button ID="btnClaim" runat="server" Text="Claim Item" Width="130px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReportItem" runat="server" Text="Report Lost Item" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLinkLogout" runat="server">Logout</asp:HyperLink>
    </form>
</body>
</html>
