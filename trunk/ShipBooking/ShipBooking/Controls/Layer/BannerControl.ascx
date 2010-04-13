<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BannerControl.ascx.cs" Inherits="ShipBooking.Controls.Layer.BannerControl" %>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 222px;
        height: 80px;
    }
    .style4
    {
        height: 80px;
    }
    .style5
    {
        background-image: url('../../../../Images/menu_bar.gif');
        height: 21px;
        color: #FFFFCC;
        font-weight: normal;
        font-family: Arial;
    }
    .style6
    {
        color: #FFFFCC;
    }
    .style7
    {
        color: #FFFFCC;
        font-weight: bold;
    }
    .style9
    {
        text-decoration: none;
    }
</style>
<table class="style1">
    <tr>
        <td class="style2">
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2" runat="server" Height="47px" 
                ImageUrl="~/Images/galileo_logo.jpg" Width="179px" />
        </td>
        <td class="style4">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/banner_blue.png" 
                Width="495px" Height="62px" style="margin-left: 50px" />
        </td>
    </tr>
    <tr>
        <td class="style5" colspan="2" height="21px">
		   &nbsp;&nbsp;
		   <asp:LinkButton ID="LinkButton1" PostBackUrl="~/Default.aspx" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Trang chủ | </asp:LinkButton>
           <asp:LinkButton ID="LinkButton2" PostBackUrl="~/DatVe.aspx" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Đặt vé | </asp:LinkButton>
           <asp:LinkButton ID="LinkButton3" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Tình trạng chỗ | </asp:LinkButton>
           <asp:LinkButton ID="LinkButton4" runat="server" Font-Underline="False" 
                Font-Bold="True" Font-Names="Arial" Font-Size="Small" ForeColor="#FFFFCC">Liên kết</asp:LinkButton>
		</td>
    </tr>
</table>
