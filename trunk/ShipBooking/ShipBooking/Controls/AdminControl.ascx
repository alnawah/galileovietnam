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
        text-align: center;
    }
    .tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        width: 781px;
        height: auto;
    }
    .ThongTinDatCho_Title_1
    {
        width: 100px;
        text-align: right;
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
    .ngay_style_column
    {
        width: 100px;
    }
    .style2
    {
        width: 65%;
    }
    .style3
    {
        width: 122px;
        text-align: left;
    }
    .style4
    {
        width: 95px;
        text-align: left;
    }
    .style5
    {
        text-align: right;
    }
    .style6
    {
        width: 239px;
    }
    .style7
    {
        width: 263px;
    }
    </style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="55px" 
        ImageUrl="~/Images/quan_ly_hanh_trinh.png" Width="402px" />
    </p>
<table class="tblThongTinDatCho_Summary_Style" align="center">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Hành trình</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Từ: </td>
                    <td class="style6">
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="200px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="style7">
                        Đến:&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="200px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDen_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnDanhSachTP" runat="server" Height="26px" 
                            Text="Danh sách thành phố" Width="139px" onclick="btnDanhSachTP_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        &nbsp;</td>
                    <td class="style6" align="right">
                        Có chuyến:</td>
                    <td class="style7">
                        <asp:RadioButtonList ID="rblTinhTrangChuyen" runat="server" 
                            RepeatDirection="Horizontal" AutoPostBack="true" 
                            onselectedindexchanged="rblTinhTrangChuyen_SelectedIndexChanged">
                            <asp:ListItem Value="Yes">Có</asp:ListItem>
                            <asp:ListItem Value="No">Không</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        &nbsp;</td>
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
        <tr align="center">
            <td class="table_contain_style" align="center">
                <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <table align="center" class="style2" style="border: 1px solid #006699">
                    <tr align="center">
                        <td align="left" 
                            style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                            Giá vé</td>
                    </tr>
                    <tr>
                        <td align="left" class="style5">
                            <br />
                            <table align="center" class="style2" style="border: 1px solid #006699">
                                <tr align="center">
                                    <td align="left" colspan="2" 
                                        style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                        Loại thường</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Người lớn:</td>
                                    <td style="text-align: left">
                                        <asp:TextBox ID="txtGiaVe1_NguoiLon" runat="server" Width="176px" 
                                            style="text-align: right"></asp:TextBox>
                                        &nbsp;(VNĐ)</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Trẻ em:</td>
                                    <td style="text-align: left">
                                        <asp:TextBox ID="txtGiaVe1_TreEm" runat="server" Width="176px" 
                                            style="text-align: right"></asp:TextBox>
                                        &nbsp;(VNĐ)</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Số lượng:</td>
                                    <td style="text-align: left">
                                        <asp:DropDownList ID="ddlSoLuongVe1" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table align="center" class="style2" style="border: 1px solid #006699">
                                <tr align="center">
                                    <td align="left" colspan="2" 
                                        style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                        Loại doanh nhân</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Người lớn:</td>
                                    <td style="text-align: left">
                                        <asp:TextBox ID="txtGiaVe2_NguoiLon" runat="server" Width="176px" 
                                            style="text-align: right"></asp:TextBox>
                                        &nbsp;(VNĐ)</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Trẻ em:</td>
                                    <td style="text-align: left">
                                        <asp:TextBox ID="txtGiaVe2_TreEm" runat="server" Width="176px" 
                                            style="text-align: right"></asp:TextBox>
                                        &nbsp;(VNĐ)</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Số lượng:</td>
                                    <td style="text-align: left">
                                        <asp:DropDownList ID="ddlSoLuongVe2" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table align="center" class="style2" style="border: 1px solid #006699">
                                <tr align="center">
                                    <td align="left" colspan="2" 
                                        style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                        Loại VIP</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Người lớn:</td>
                                    <td style="text-align: left">
                                        <asp:TextBox ID="txtGiaVe3_NguoiLon" runat="server" Width="176px" 
                                            style="text-align: right"></asp:TextBox>
                                        &nbsp;(VNĐ)</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Trẻ em:</td>
                                    <td style="text-align: left">
                                        <asp:TextBox ID="txtGiaVe3_TreEm" runat="server" Width="176px" 
                                            style="text-align: right"></asp:TextBox>
                                        &nbsp;(VNĐ)</td>
                                </tr>
                                <tr>
                                    <td align="left" class="style5">
                                        Số lượng:</td>
                                    <td style="text-align: left">
                                        <asp:DropDownList ID="ddlSoLuongVe3" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <table align="center" class="style2" style="border: 1px solid #006699">
                    <tr align="center">
                        <td align="left" colspan="3" 
                            style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                            Số hiệu chuyến tàu</td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Số hiệu tàu:
                        </td>
                        <td class="style3">
                            <asp:TextBox ID="txtSoHieuTau" runat="server" Width="140px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Height="26px" onclick="Button1_Click" 
                                Text="Xem thông tin tàu" Width="134px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Số ghế:</td>
                        <td class="style3">
                            <asp:DropDownList ID="ddlSoGhe" runat="server" Height="22px" Width="66px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlSoHieuTau" runat="server" AutoPostBack="true" 
                                Height="22px" onselectedindexchanged="ddlSoHieuTau_SelectedIndexChanged" 
                                Visible="False" Width="110px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="lblMsg2" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <asp:Panel ID="panelLichTrinh" runat="server" Visible="true">
                    <table ID="tblLichTrinh" border="1px" class="tblThongTinDatCho_Detail_Style" 
                        style="border: 1px solid #CCCCCC">
                        <tr>
                            <td class="ngay_style_column">
                                &nbsp;</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Hai</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Ba</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Tư</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Năm</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Sáu</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Bảy</td>
                            <td align="center" class="ngay_style_column">
                                Chủ Nhật</td>
                        </tr>
                        <tr>
                            <td class="ngay_style_column">
                                Có chuyến</td>
                            <td class="ngay_style_column">
                                <asp:CheckBox ID="chkThu2" runat="server" AutoPostBack="true" 
                                    oncheckedchanged="chkThu2_CheckedChanged" Text="Có" />
                            </td>
                            <td class="ngay_style_column">
                                <asp:CheckBox ID="chkThu3" runat="server" AutoPostBack="true" 
                                    oncheckedchanged="chkThu3_CheckedChanged" Text="Có" />
                            </td>
                            <td class="ngay_style_column">
                                <asp:CheckBox ID="chkThu4" runat="server" AutoPostBack="true" 
                                    oncheckedchanged="chkThu4_CheckedChanged" Text="Có" />
                            </td>
                            <td class="ngay_style_column">
                                <asp:CheckBox ID="chkThu5" runat="server" AutoPostBack="true" 
                                    oncheckedchanged="chkThu5_CheckedChanged" Text="Có" />
                            </td>
                            <td class="ngay_style_column">
                                <asp:CheckBox ID="chkThu6" runat="server" AutoPostBack="true" 
                                    oncheckedchanged="chkThu6_CheckedChanged" Text="Có" />
                            </td>
                            <td class="ngay_style_column">
                                <asp:CheckBox ID="chkThu7" runat="server" AutoPostBack="true" 
                                    oncheckedchanged="chkThu7_CheckedChanged" Text="Có" />
                            </td>
                            <td class="ngay_style_column">
                                <asp:CheckBox ID="chkCN" runat="server" AutoPostBack="true" 
                                    oncheckedchanged="chkCN_CheckedChanged" Text="Có" />
                            </td>
                        </tr>
                        <tr>
                            <td class="ngay_style_column">
                                Giờ khởi hành</td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioKhoiHanh_Thu2" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioKhoiHanh_Thu3" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioKhoiHanh_Thu4" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioKhoiHanh_Thu5" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioKhoiHanh_Thu6" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioKhoiHanh_Thu7" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioKhoiHanh_ChuNhat" runat="server" 
                                    style="text-align: center" Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="ngay_style_column">
                                Giờ đến</td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioDen_Thu2" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioDen_Thu3" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioDen_Thu4" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioDen_Thu5" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioDen_Thu6" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioDen_Thu7" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="txtGioDen_ChuNhat" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <br />
                </td>
        </tr>
    </table>
</asp:Panel>
</center>
<p style="text-align: center">
    <asp:Button ID="btnSave" runat="server" Text="Save" Width="60px" Height="26px" onclick="btnSave_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Height="26px" />
</p>


