<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaintainDetails.aspx.cs" Inherits="NWU_LostAndFoundWebsite.MaintainDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            height: 435px;
            width: 896px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #CCCCCC; font-family: Arial, Helvetica, sans-serif; font-size: small;" class="auto-style2">
            <strong style="font-family: Arial, Helvetica, sans-serif; color: #3366CC"><span class="auto-style1" style="color: #0066CC; font-family: Arial, Helvetica, sans-serif">North West University Lost and Found Website<br />
            </span></strong>&nbsp;<br />
            <br />
&nbsp; Current Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Current Surname:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSurname" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;
            <br />
&nbsp; New Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; New Contact:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp; &nbsp;
            <br />
&nbsp; New Password:&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Height="29px" Text="Update" Width="124px" Font-Bold="True" Font-Names="Arial Narrow" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnDelete" runat="server" Height="30px" Text="Delete Account" Width="124px" Font-Bold="True" Font-Names="Arial Narrow" />
            &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnExit" runat="server" Height="29px" Text="Exit" Width="106px" Font-Bold="True" Font-Names="Arial Narrow" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
