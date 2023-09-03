<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportItem.aspx.cs" Inherits="NWU_LostAndFoundWebsite.ReportItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please add the description of the item<br />
            <asp:TextBox ID="txtItemDescription" runat="server" Height="268px" Width="749px"></asp:TextBox>
            <br />
            Category of the Item&nbsp;
            <asp:DropDownList ID="DropDownListCategory" runat="server">
            </asp:DropDownList>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownListCategory" ErrorMessage="Required!"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            Upload picture of item<br />
            <asp:FileUpload ID="FileUploadPicture" runat="server" Width="806px" />
        </div>
    </form>
</body>
</html>
