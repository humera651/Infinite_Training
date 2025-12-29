<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm.aspx.cs" Inherits="ValidationsPrj.TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function IsNameValid(source, args) {
            var name = args.Value;
            if (name == "") {
            args.IsValid = false;
            alert("Empty Text, Enter Valid Data..");
        }
        else {
            if (name.length > 6) {
                args.IsValid = true;
                alert("Validation Suceeded");
            }
            else {
                args.IsValid = false;
                alert("Validation Failed...");
            }
        }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    Please Enter Your Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Name should be more than 6 characters" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="IsNameValid" ValidateEmptyText="True"></asp:CustomValidator>
    <br />
    <br />
    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    <br /><br />
    <asp:label ID="lblmsg" runat="server"></asp:label>
</div>
    </form>
</body>
</html>
