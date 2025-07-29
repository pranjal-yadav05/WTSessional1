<%@ Page Language="C#" AutoEventWireup="true"
CodeFile="Q2b_CustomCalendar.aspx.cs" Inherits="Q2b_CustomCalendar" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Q2b Custom Calendar</title>
  </head>
  <body>
    <form id="form1" runat="server">
      <asp:Calendar
        ID="Calendar1"
        runat="server"
        OnDayRender="Calendar1_DayRender"
        FirstDayOfWeek="Tuesday" />
      <br />
      <asp:Label ID="lblInfo" runat="server" Font-Bold="true" />
    </form>
  </body>
</html>
