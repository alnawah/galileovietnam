<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KetThucBooking.aspx.cs" Inherits="ShipBooking.KetThucBooking" MasterPageFile="~/MyMaster.Master" %>

<asp:Content ID="finish" ContentPlaceHolderID="contentplaceCenter" runat="server">

    <p>
        &nbsp;<table class="finish_booking">
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
        Chúc mừng bạn đã hoàn tất việc đặt chỗ.<br />
                    Mã số Booking File của bạn là:&nbsp;
                    <asp:Label ID="lblMaBF" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    <br />
                    Chúng tôi sẽ thông báo cho bạn kết quả đặt chỗ trong thời gian ngắn nhất.<br />
        Mọi thông tin xin liên hệ với chúng tôi qua địa chỉ email: quangminh_1203@yahoo.com<br />
        Hoặc số điện thoại 0975750080<br />
        Xin chân thành cảm bạn đã sử dụng dịch vụ của chúng tôi.<br />
        <b>Galileo Vietnam</b></td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .finish_booking
        {
            width: 100%;
        }
        .style1
        {
            width: 202px;
        }
    </style>

</asp:Content>
