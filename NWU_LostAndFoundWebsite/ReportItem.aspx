<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportItem.aspx.cs" Inherits="NWU_LostAndFoundWebsite.ReportItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif; font-size: small; background-color: #CCCCCC;">
            Please add the description of the item<br />
            <asp:TextBox ID="txtItemDescription" runat="server" Height="268px" Width="749px"></asp:TextBox>
            <br />
            Category of the Item&nbsp;
            <asp:DropDownList ID="DropDownListCategory" runat="server" OnSelectedIndexChanged="DropDownListCategory_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownListCategory" ErrorMessage="Required!" SetFocusOnError="True" ForeColor="#CC3399"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="..."></asp:Label>
            <br />
            <br />
            Upload picture of item<br />
            <asp:FileUpload ID="FileUploadPicture" runat="server" Width="806px" />
            <br />
            <br />
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" Width="141px" />
        </div>
    </form>
</body>
</html>
