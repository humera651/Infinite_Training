<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm_withDS.aspx.cs" Inherits="DataProject.DataForm_withDS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="custid" HeaderText="custid" SortExpression="custid" />
                    <asp:BoundField DataField="custname" HeaderText="custname" SortExpression="custname" />
                    <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                    <asp:BoundField DataField="caddress" HeaderText="caddress" SortExpression="caddress" />
                    <asp:BoundField DataField="cphone" HeaderText="cphone" SortExpression="cphone" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:infinitedbConnectionString %>" ProviderName="<%$ ConnectionStrings:infinitedbConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [customers]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
