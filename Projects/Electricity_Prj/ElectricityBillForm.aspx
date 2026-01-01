<%@ Page Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="ElectricityBillForm.aspx.cs" Inherits="Electricity_Prj.ElectricityBillForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div class="form-container">
        <div class="form-ebox">
            <h3>Add Electricity Bill</h3>
            Number of Bills:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtCount" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Number of Bills cannot be blank" ControlToValidate="txtCount" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCount" ValidationExpression="^\d+$" ErrorMessage="Number of Bills must be numeric" ForeColor="Red" ValidationGroup="elecbill">*</asp:RegularExpressionValidator>
<br/><br/>
Consumer Number:&nbsp;&nbsp;
<asp:TextBox ID="txtNo" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Consumer Number cannot be blank" ControlToValidate="txtNo" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<br/><br/>
Consumer Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtName" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Consumer Name cannot be blank" ControlToValidate="txtName" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtName" ValidationExpression="^[A-Za-z ]{3,}$" ErrorMessage="Consumer Name must contain only letters and minimum 3 characters" ForeColor="Red" ValidationGroup="elecbill">*</asp:RegularExpressionValidator>
<br/><br/>
Units Consumed:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtUnits" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Units Consumed cannot be blank" ControlToValidate="txtUnits" ForeColor="Red" ValidationGroup="elecbill" >*</asp:RequiredFieldValidator>
<br/><br/>
<asp:Button ID="btnAdd" runat="server" Text="Add Bill" CssClass="action-btn" OnClick="btnAdd_Click" ValidationGroup="elecbill" />
            <br />
            <br/>

<asp:Label ID="lblOutput" runat="server" /><br/>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="elecbill" />
</div>
<div class="form-ebox">
            <h3>View Last Bills</h3>
Last N Bills to Retrieve:
<asp:TextBox ID="txtLast" runat="server" />
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter Last N Bills to Retrieve" ControlToValidate="txtLast" ForeColor="Red" ValidationGroup="elecbilllast" >*</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtLast" ValidationExpression="^\d+$" ErrorMessage="Last N Bills must be numeric" ForeColor="Red" ValidationGroup="elecbilllast">*</asp:RegularExpressionValidator>
<br/><br/>
<asp:Button ID="btnShow" runat="server" Text="Show Bills" CssClass="action-btn" OnClick="btnShow_Click" ValidationGroup="elecbilllast"/>
            <br />
            <br/>
<asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="elecbilllast" />

<asp:GridView ID="gvBills" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" >
    <AlternatingRowStyle BackColor="#F7F7F7" />
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <SortedAscendingCellStyle BackColor="#F4F4FD" />
    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
    <SortedDescendingCellStyle BackColor="#D8D8F0" />
    <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
        </div>
            </div>
</asp:Content>