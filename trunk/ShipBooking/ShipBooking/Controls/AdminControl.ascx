<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminControl.ascx.cs" Inherits="ShipBooking.Controls.AdminControl" %>
<style type="text/css">

    .tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 800px;
        height: auto;
    }
    .table_header_style
    {
        color: #FFFFFF;
        font-weight: bold;
        font-family: Arial, Helvetica, sans-serif;
    }
    .table_contain_style
    {
        border: 1px solid #006699;
    }
    .tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        border-style: none;
        width: 781px;
        height: auto;
    }
    .ThongTinDatCho_Title_1
    {
        width: 100px;
        text-align: left;
    }
    .ThongTinDatCho_Detail
    {
        width: 200px;
    }
    .ThongTinDatCho_Title_2
    {
        width: 170px;
        text-align: left;
    }
    .style1
    {
        width: 122px;
        text-align: left;
    }
    .ngay_style_column
    {
        width: 100px;
    }
    .style8
    {
        width: 72px;
    }
    .style9
    {
        width: 48px;
    }
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="55px" 
        ImageUrl="~/Images/admin.jpg" Width="362px" />
    </p>
<table class="tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Hành trình</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Từ:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="200px">
                        </asp:DropDownList>
                    </td>
                    <td class="style1">
                        Đến:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" Width="200px">
                        </asp:DropDownList>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p>
    &nbsp;</p>
<center>
<asp:Panel ID="Panel1" runat="server" Width="801px" Visible="true">
    <table class="tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="table_header_style">
                Cập nhật thông tin hành trình</td>
        </tr>
        <tr>
            <td class="table_contain_style">
                <table class="tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                        <td class="ngay_style_column">
                            Thứ Hai</td>
                        <td class="ngay_style_column">
                            Thứ Ba</td>
                        <td class="ngay_style_column">
                            Thứ Tư</td>
                        <td class="ngay_style_column">
                            Thứ Năm</td>
                        <td class="ngay_style_column">
                            Thứ Sáu</td>
                        <td class="ngay_style_column">
                            Thứ Bảy</td>
                        <td class="ngay_style_column">
                            Chủ Nhật</td>
                    </tr>
                    <tr>
                        <td class="ngay_style_column">
                            Có chuyến:</td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                    </tr>
                    <tr>
                        <td class="ngay_style_column">
                            Giá vé:</td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                    </tr>
                    <tr>
                        <td class="ngay_style_column">
                            Số hiệu tàu</td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                        </td>
                    </tr>
                    <tr>
                        <td class="ngay_style_column">
                        </td>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                        <td class="ngay_style_column">
                            &nbsp;</td>
                    </tr>
                    </table>
                </td>
        </tr>
    </table>
</asp:Panel>
</center>
<p>
    &nbsp;</p>

