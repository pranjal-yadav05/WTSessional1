<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Q3b_ShopPurchase.aspx.cs" Inherits="Q3b_ShopPurchase" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Q3b Shop Purchase</title>
  </head>
  <body>
    <form id="form1" runat="server">
      <asp:CheckBoxList
        ID="cblItems"
        runat="server"
        AutoPostBack="true"
        OnSelectedIndexChanged="cblItems_SelectedIndexChanged" />
      <br />
      Total Price: <asp:TextBox ID="txtTotal" runat="server" ReadOnly="true" />
      <br />
      <asp:Button
        ID="btnPurchase"
        runat="server"
        Text="Purchase"
        OnClick="btnPurchase_Click" />
      <br /><br />
      <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
    </form>
  </body>
</html>
