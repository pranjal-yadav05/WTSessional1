<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Q2a_ImageMap.aspx.cs"
Inherits="Q2a_ImageMap" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Q2a ImageMap Hotspot Example</title>
  </head>
  <body>
    <form id="form1" runat="server">
      <asp:ImageMap
        ID="ImageMap1"
        runat="server"
        ImageUrl="~/sun_mountain_river.jpg"
        OnClick="ImageMap1_Click">
        <asp:CircleHotSpot X="50" Y="50" Radius="30" PostBackValue="Sun" />
        <asp:RectangleHotSpot
          Left="120"
          Top="40"
          Right="200"
          Bottom="100"
          PostBackValue="Mountain" />
        <asp:PolygonHotSpot
          Coordinates="220,150,260,180,300,170,280,140"
          PostBackValue="River" />
      </asp:ImageMap>
      <br />
      <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
    </form>
  </body>
</html>
