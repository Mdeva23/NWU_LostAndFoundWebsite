<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaintainDetails.aspx.cs" Inherits="NWU_LostAndFoundWebsite.MaintainDetails" %>

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
        <div style="height: 412px; width: 896px; background-color: #CCCCCC">
            <strong style="font-family: Arial, Helvetica, sans-serif; color: #3366CC"><span class="auto-style1" style="color: #0066CC; font-family: Arial, Helvetica, sans-serif">North West University Lost and Found Website<br />
            </span></strong>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp; Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
&nbsp; Surname:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
&nbsp; Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
&nbsp; Contact:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
            <br />
&nbsp; Password:
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="39px" Text="Update" Width="101px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Height="39px" Text="Delete Account" Width="124px" />
            &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="39px" Text="Exit" Width="101px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
