<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BannerControl.ascx.cs" Inherits="ShipBooking.Controls.Layer.BannerControl" %>

<style type="text/css">
    .banner_style
    {
        width: 100%;
    }
    .banner_logo_style
    {
        width: 222px;
        height: 80px;
    }
    .banner_headpicture_style
    {
        height: 80px;
    }
</style>
<table class="banner_style">
    <tr>
        <td class="banner_logo_style">
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2" runat="server" Height="47px" 
                ImageUrl="~/Images/galileo_logo.jpg" Width="179px" />
        </td>
        <td class="banner_headpicture_style">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/banner_blue.png" 
                Width="495px" Height="62px" style="margin-left: 50px" />
        </td>
    </tr>
</table>
