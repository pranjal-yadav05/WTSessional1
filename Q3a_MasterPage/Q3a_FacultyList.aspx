<%@ Page Title="Faculty List" Language="C#"
MasterPageFile="~/Q3a_MasterPage/Site.master" AutoEventWireup="true"
CodeFile="Q3a_FacultyList.aspx.cs" Inherits="Q3a_FacultyList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <asp:Label ID="lblDept" runat="server" Font-Bold="true" />
  <br />
  <asp:ListBox ID="lstFaculty" runat="server" Width="200px" />
</asp:Content>
