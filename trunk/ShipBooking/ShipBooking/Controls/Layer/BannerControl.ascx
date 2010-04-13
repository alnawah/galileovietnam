<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BannerControl.ascx.cs" Inherits="ShipBooking.Controls.Layer.BannerControl" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
<table class="style1">
    <tr>
        <td>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/banner.png" Width="800px" />
        </td>
        <td></td>
    </tr>
    <tr>
        <td colspan="2" 
            style="text-align: center; font-weight: 700; background-color: #3399FF;">Trang chủ | Đặt chỗ | Liên hệ | Trợ giúp</td>
    </tr>
</table>
