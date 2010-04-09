<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftMenuControl.ascx.cs" Inherits="ProductTest.LeftMenuControl" %>
<asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" 
    DataSourceID="SiteMapDataSource1" DynamicHorizontalOffset="2" 
    Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" 
    StaticSubMenuIndent="10px" onmenuitemclick="Menu1_MenuItemClick">
    <StaticSelectedStyle BackColor="#1C5E55" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
    <DynamicMenuStyle BackColor="#E3EAEB" />
    <DynamicSelectedStyle BackColor="#1C5E55" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#666666" ForeColor="White" />
</asp:Menu>

