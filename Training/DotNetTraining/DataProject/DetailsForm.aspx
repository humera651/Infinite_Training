<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsForm.aspx.cs" Inherits="DataProject.DetailsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="custid">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="custid" HeaderText="custid" SortExpression="custid" />
                    <asp:BoundField DataField="custname" HeaderText="custname" SortExpression="custname" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infinitedbConnectionString2 %>" ProviderName="<%$ ConnectionStrings:infinitedbConnectionString2.ProviderName %>" SelectCommand="SELECT [custid], [custname] FROM [customers]"></asp:SqlDataSource>
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:infinitedbConnectionString2 %>" SelectCommand="SELECT * FROM [customers] WHERE ([custid] = @custid)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="custid" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="custid" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="custid" HeaderText="custid" SortExpression="custid" />
                    <asp:BoundField DataField="custname" HeaderText="custname" SortExpression="custname" />
                    <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                    <asp:BoundField DataField="caddress" HeaderText="caddress" SortExpression="caddress" />
                    <asp:BoundField DataField="cphone" HeaderText="cphone" SortExpression="cphone" />
                </Fields>
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
