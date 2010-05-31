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
    .style3
    {
        width: 100px;
        text-align: right;
    }
        
    .style2
    {
        width: 153px;
    }
    .style4
    {
        width: 85px;
        text-align: right;
    }
    
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/ket_thuc_booking.png" Width="413px" />
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
                    <td class="style3">
                        Loại hành trình:</td>
                    <td class="style2">
                        <asp:Label ID="lblLoaiHanhTrinh" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        Từ:</td>
                    <td class="style2">
                        <asp:Label ID="lblNoiDi" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="style4">
                        Đến:</td>
                    <td>
                        <asp:Label ID="lblNoiDen" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Ngày khởi hành:</td>
                    <td class="style2">
                        <asp:Label ID="lblNgayDi" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="style4">
                        <asp:Label ID="lblNgayVeLabel" runat="server" Text="Ngày về:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblNgayVe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Giờ khởi hành:</td>
                    <td class="style2">
                        <asp:Label ID="lblGioKhoiHanh" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="style4">
                        Giờ đến:</td>
                    <td>
                        <asp:Label ID="lblGioDen" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Hạng vé:</td>
                    <td class="style2">
                        <asp:Label ID="lblLoaiVe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="style4">
                        Số lượng vé:</td>
                    <td>
                        <asp:Label ID="lblSLVe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Số ghế:</td>
                    <td class="style2">
                        <asp:Label ID="lblSoGhe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="style4">
                        Tổng giá tiền:</td>
                    <td>
                        <asp:Label ID="lblTongGiaVe" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#CC0000" 
                            Text="VNĐ"></asp:Label>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<br />
<center>
    <asp:GridView ID="grvHanhKhach" runat="server" Width="800px" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Height="71px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="Stt" HeaderText="STT" >
                <ItemStyle Width="40px" />
            </asp:BoundField>
            <asp:BoundField DataField="TenKhach" HeaderText="Tên khách" >
                <ItemStyle Width="250px" />
            </asp:BoundField>
            <asp:BoundField DataField="LoaiTuoi" HeaderText="Tuổi" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="GiaVe" HeaderText="Giá vé" >
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
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

