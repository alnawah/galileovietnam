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
    .banner_menu_style
    {
        background-image: url('../../../../Images/menu_bar.gif');
        height: 21px;
        color: #FFFFCC;
        font-weight: normal;
        font-family: Arial;
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
    <tr>
        <td class="banner_menu_style" colspan="2" height="21px">
		   &nbsp;&nbsp;
		   <asp:LinkButton ID="LinkButton1" PostBackUrl="~/Default.aspx" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Trang chủ </asp:LinkButton>|
           <asp:LinkButton ID="LinkButton2" PostBackUrl="~/DatVe.aspx" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Đặt vé </asp:LinkButton>|
           <asp:LinkButton ID="LinkButton3" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Tình trạng chỗ </asp:LinkButton>|
           <asp:LinkButton ID="LinkButton4" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Liên kết</asp:LinkButton>
		</td>
    </tr>
</table>
