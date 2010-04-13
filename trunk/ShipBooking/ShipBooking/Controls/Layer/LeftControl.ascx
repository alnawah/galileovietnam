<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftControl.ascx.cs" Inherits="ShipBooking.Controls.Layer.LeftControl" %>
<asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" 
    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
    ForeColor="#990000" StaticSubMenuIndent="10px">
    <StaticSelectedStyle BackColor="#FFCC66" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
    <DynamicMenuStyle BackColor="#FFFBD6" />
    <DynamicSelectedStyle BackColor="#FFCC66" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
    <Items>
        <asp:MenuItem Text="Trang chu" Value="Trang chủ"></asp:MenuItem>
        <asp:MenuItem Text="Dat cho" Value="Đặt chỗ">
            <asp:MenuItem Text="Dat cho dung" Value="Đặt chỗ đứng"></asp:MenuItem>
            <asp:MenuItem Text="Dat cho ngoi" Value="Đặt chỗ ngồi"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="Lien he" Value="Liên hệ"></asp:MenuItem>
        <asp:MenuItem Text="Tro giup" Value="Trợ giúp"></asp:MenuItem>
    </Items>
</asp:Menu>
