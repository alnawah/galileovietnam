<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatVeReviewControl.ascx.cs" Inherits="ShipBooking.Controls.DatVeReviewControl" %>
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
        width: 600px;
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
        width: 98px;
        text-align: left;
    }
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/text_banvetau.png" Width="600px" />
</p>
<center>
    <table class="tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="table_header_style">
                Thông tin đặt chỗ</td>
        </tr>
        <tr>
            <td class="table_contain_style">
                <table class="tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="ThongTinDatCho_Title_1">
                            Từ:</td>
                        <td class="ThongTinDatCho_Detail">
                            <asp:Label ID="lblNoiDi1" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                        </td>
                        <td class="style1">
                            Đến:</td>
                        <td>
                            <asp:Label ID="lblNoiDen1" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="ThongTinDatCho_Title_1">
                            Ngày khởi hành:</td>
                        <td class="ThongTinDatCho_Detail">
                            <asp:Label ID="lblNgayDi" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                        </td>
                        <td class="style1">
                            Ngày về:</td>
                        <td>
                            <asp:Label ID="lblNgayVe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="ThongTinDatCho_Title_1">
                            Giờ khởi hành:</td>
                        <td class="ThongTinDatCho_Detail">
                            <asp:Label ID="lblGioKhoiHanh" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                        </td>
                        <td class="style1">
                            Giờ đến:</td>
                        <td>
                            <asp:Label ID="lblGioDen" runat="server" Font-Bold="True" 
                                ForeColor="#0000CC"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="ThongTinDatCho_Title_1">
                            Loại vé:</td>
                        <td class="ThongTinDatCho_Detail">
                            <asp:Label ID="lblLoaiVe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                        </td>
                        <td class="style1">
                            Loại hành trình:</td>
                        <td>
                            <asp:Label ID="lblLoaiHanhTrinh" runat="server" Font-Bold="True" 
                                ForeColor="#0000CC"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="ThongTinDatCho_Title_1">
                            Số ghế:</td>
                        <td class="ThongTinDatCho_Detail">
                            <asp:Label ID="lblSoGhe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                            <asp:Label ID="lblThoiGian" runat="server" Font-Bold="True" ForeColor="#0000CC" 
                                Visible="False"></asp:Label>
                        </td>
                        <td class="style1">
                            Giá vé:</td>
                        <td>
                            <asp:Label ID="lblGiaVN" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                            &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#990033" 
                                Text=" (VNĐ)"></asp:Label>
                        </td>
                    </tr>
                    </table>
                </td>
        </tr>
    </table>
</center>
<p style="text-align: center">
    &nbsp;</p>

<center>
    <asp:GridView ID="grvHanhKhach" runat="server" Width="800px" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Height="71px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="stt" HeaderText="STT" />
            <asp:BoundField DataField="TenKhach" HeaderText="Tên khách" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
            <asp:BoundField DataField="LoaiQuocTich" HeaderText="VN/Nước ngoài" />
            <asp:BoundField DataField="LoaiTuoi" HeaderText="Tuổi" />
            <asp:BoundField DataField="GiaVe" HeaderText="Giá vé" />
        </Columns>
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</center>
<br />
<table class="tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Thông tin để giao vé</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Tên người nhận vé:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblTenNguoiNhan" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Địa chỉ:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblDiaChiNguoiNhan" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Tỉnh/Thành phố:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblThanhPho" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Số điện thoại:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblSoDienThoai" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Email:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblEmail" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Các yêu cầu khác (nếu có):</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblYeuCauKhac" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Thời gian giao vé:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblThoiGianGiaoVe" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Thanh toán:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblThanhToan" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
            </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="Button1" runat="server" Text="Hiệu chỉnh" Width="90px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Hoàn tất" 
        Width="90px" />
</p>

