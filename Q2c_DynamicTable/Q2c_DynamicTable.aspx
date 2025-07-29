<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Q2c_DynamicTable.aspx.cs" Inherits="Q2c_DynamicTable" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Q2c Dynamic Table Generator</title>
  </head>
  <body>
    <form id="form1" runat="server">
      Rows: <asp:DropDownList ID="ddlRows" runat="server" /> Columns:
      <asp:DropDownList ID="ddlCols" runat="server" />
      <br />
      Control Type:
      <asp:RadioButtonList ID="rblControlType" runat="server">
        <asp:ListItem>TextBox</asp:ListItem>
        <asp:ListItem>HyperLink</asp:ListItem>
        <asp:ListItem>LinkButton</asp:ListItem>
      </asp:RadioButtonList>
      <asp:Button
        ID="btnCreate"
        runat="server"
        Text="Create Table"
        OnClick="btnCreate_Click" />
      <br /><br />
      <asp:PlaceHolder ID="phTable" runat="server" />
    </form>
  </body>
</html>
