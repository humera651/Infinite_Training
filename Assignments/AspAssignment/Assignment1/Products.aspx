<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Assignment1.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProductsDetails" runat="server" AutoPostBack="true"
            OnSelectedIndexChanged="ddlProductsDetails_SelectedIndexChanged">
            <asp:ListItem Text="Select" Value="0"></asp:ListItem>
            <asp:ListItem Text="Laptop" Value="50000"></asp:ListItem>
            <asp:ListItem Text="Mobile" Value="25000"></asp:ListItem>
            <asp:ListItem Text="Tablet" Value="30000"></asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <asp:Image ID="imgProduct" runat="server" Width="400px" Height="300px" />
        <br /><br />
        <asp:Button ID="btnPrice" runat="server" Text="Show Price" OnClick="btnPrice_Click" />
        <br /><br />
        <asp:Label ID="lblPrice" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
