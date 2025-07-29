<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Q3a_StudentRegistrationWithValidators.aspx.cs"
Inherits="Q3a_StudentRegistrationWithValidators" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Q3a Student Registration with Validators</title>
  </head>
  <body>
    <form id="form1" runat="server">
      Name: <asp:TextBox ID="txtName" runat="server" /><br />
      Email: <asp:TextBox ID="txtEmail" runat="server" />
      <asp:RegularExpressionValidator
        ID="revEmail"
        runat="server"
        ControlToValidate="txtEmail"
        ErrorMessage="Invalid Email"
        ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"
        ForeColor="Red" /><br />
      Password:
      <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" /><br />
      Confirm Password:
      <asp:TextBox ID="txtConfirmPwd" runat="server" TextMode="Password" />
      <asp:CompareValidator
        ID="cvPwd"
        runat="server"
        ControlToValidate="txtConfirmPwd"
        ControlToCompare="txtPwd"
        ErrorMessage="Passwords do not match"
        ForeColor="Red" /><br />
      Age: <asp:TextBox ID="txtAge" runat="server" />
      <asp:CustomValidator
        ID="custAge"
        runat="server"
        ControlToValidate="txtAge"
        OnServerValidate="custAge_ServerValidate"
        ErrorMessage="Age must be 18 or above"
        ForeColor="Red" /><br />
      <asp:Button
        ID="btnRegister"
        runat="server"
        Text="Register"
        OnClick="btnRegister_Click" /><br /><br />
      <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
    </form>
  </body>
</html>
