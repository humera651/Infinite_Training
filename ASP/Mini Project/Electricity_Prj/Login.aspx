<%@ Page Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Electricity_Prj.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="login-container">
        <div class="login-card">
            <h2>Admin Login</h2>
            <div class="input-row">
            <asp:TextBox ID="txtUser" runat="server" CssClass="input-box" Placeholder="Username" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username is required" ControlToValidate="txtUser" ForeColor="Red" ValidationGroup="login">*</asp:RequiredFieldValidator>
            </div>
                <br/><br/>
            <div class="input-row">
            <asp:TextBox ID="txtPass" runat="server" CssClass="input-box" TextMode="Password" Placeholder="Password" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="Password is required" ForeColor="Red" ValidationGroup="login">*</asp:RequiredFieldValidator>
            </div>
                <br/><br/>
            <asp:Button ID="btnLogin" runat="server" CssClass="login-btn" Text="Login" OnClick="btnLogin_Click" ValidationGroup="login" /><br/>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="login" />
        </div>
    </div>
</asp:Content>
