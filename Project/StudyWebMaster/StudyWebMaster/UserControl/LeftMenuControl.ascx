<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftMenuControl.ascx.cs" Inherits="StudyWebMaster.LeftMenuControl" %>
<asp:Menu ID="mnuLeft" runat="server" BackColor="#FFFBD6" 
    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
    ForeColor="#990000"
    StaticSubMenuIndent="10px" onmenuitemclick="mnuLeft_MenuItemClick">
    <StaticSelectedStyle BackColor="#FFCC66" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
    <DynamicMenuStyle BackColor="#FFFBD6" />
    <DynamicSelectedStyle BackColor="#FFCC66" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
</asp:Menu>


