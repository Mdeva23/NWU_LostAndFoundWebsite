<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="NWU_LostAndFoundWebsite.Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewReport" runat="server" Height="285px" Width="865px">
            </asp:GridView>
            <br />
            Type of report:<asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderStyle="Solid">
                <asp:ListItem>View Detailed Report</asp:ListItem>
                <asp:ListItem>View Reported Items</asp:ListItem>
                <asp:ListItem>View Claimed Items</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Filter according Categoty(&quot;Cellphones&quot;,&quot;Student card&quot;,&quot;Keys&quot;and &quot;Others&quot;)<br />
            Enter the filter you want to apply:<br />
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFilterOrDisplay" runat="server" Text="Filter/Display Report" />
        </div>
    </form>
</body>
</html>
