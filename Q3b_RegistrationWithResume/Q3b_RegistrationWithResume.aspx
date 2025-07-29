<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Q3b_RegistrationWithResume.aspx.cs"
Inherits="Q3b_RegistrationWithResume" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Q3b Registration with Resume Upload</title>
  </head>
  <body>
    <form id="form1" runat="server" enctype="multipart/form-data">
      Name: <asp:TextBox ID="txtName" runat="server" /><br />
      Enrollment No: <asp:TextBox ID="txtEnroll" runat="server" /><br />
      Contact No: <asp:TextBox ID="txtContact" runat="server" /><br />
      Email: <asp:TextBox ID="txtEmail" runat="server" /><br />
      Resume (PDF, &lt;10KB):
      <asp:FileUpload ID="fuResume" runat="server" /><br />
      <asp:Button
        ID="btnRegister"
        runat="server"
        Text="Register"
        OnClick="btnRegister_Click" /><br /><br />
      <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
    </form>
  </body>
</html>
