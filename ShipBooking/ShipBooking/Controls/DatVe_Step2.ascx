<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatVe_Step2.ascx.cs" Inherits="ShipBooking.Controls.DatVe_Step2" %>

<style type="text/css">
    .tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 800px;
        height: auto;
    }
    .tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        border-style: none;
        width: 600px;
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
    .warning_text
    {
        color: #FF0000;
    }
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/thong_tin_nguoi_nhan_ve.png" Width="600px" />
    <br />
</p>
<p style="text-align: center">
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
                    <td class="ThongTinDatCho_Title_2">
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
                    <td class="ThongTinDatCho_Title_2">
                        Ngày về:</td>
                    <td>
                        <asp:Label ID="lblNgayVe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Thời gian</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblThoiGian" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="ThongTinDatCho_Title_2">
                        Loại hành trình:</td>
                    <td>
                        <asp:Label ID="lblLoaiHanhTrinh" runat="server" Font-Bold="True" 
                            ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Loại vé:</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:Label ID="lblLoaiVe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                    <td class="ThongTinDatCho_Title_2">
                        Số ghế:</td>
                    <td>
                        <asp:Label ID="lblSoGhe" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        &nbsp;</td>
                    <td class="ThongTinDatCho_Detail">
                        &nbsp;</td>
                    <td class="ThongTinDatCho_Title_2">
                        Giá vé:</td>
                    <td>
                        <asp:Label ID="lblGiaVN" runat="server" Font-Bold="True" ForeColor="#0000CC"></asp:Label>
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#990033" 
                            Text=" (VNĐ)"></asp:Label>
                    </td>
                </tr>
            </table>
            </td>
    </tr>
</table>
</p>
<p style="text-align: center">
    &nbsp;</p>

<center>
    <asp:GridView ID="grvHanhKhach" runat="server" Width="800px" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Height="71px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="Stt" HeaderText="STT" />
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

<p style="text-align: center">
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/ThemHanhKhach.aspx">Thêm hoặc sửa danh sách khách</asp:LinkButton>
</p>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
</p>
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
                        Tên người nhận vé</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="txtTenNguoiNhan" runat="server" Width="279px"></asp:TextBox>
                        &nbsp;<span class="warning_text">(*)
                        </span>
                        </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Địa chỉ</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="txtDiaChiNguoiNhan" runat="server" Width="279px" Height="100px" 
                            TextMode="MultiLine"></asp:TextBox>
                    &nbsp;<span class="warning_text">(*)
                        </span>
                        </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Tỉnh/Thành phố</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:DropDownList ID="ddlThanhPho" runat="server" Height="22px" Width="166px">
                        </asp:DropDownList>
                    &nbsp;<span class="warning_text">(*)</span></td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Điện thoại</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="txtDienThoaiNguoiNhan" runat="server" Width="163px"></asp:TextBox>&nbsp;<span class="warning_text">(*)</span>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Email</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="txtEmailNguoiNhan" runat="server" Width="279px"></asp:TextBox>&nbsp;<span class="warning_text">(*)</span>
                        </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Các yêu cầu khác (nếu có)</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="txtYeuCauKhac" runat="server" Width="279px" Height="100px" 
                            TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Thời gian giao vé</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:DropDownList ID="ddlThoiGianGiaoVe" runat="server" Width="162px">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            </td>
    </tr>
</table>



<br />
<table class="tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Hình thức thanh toán</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Detail">
                        <asp:RadioButtonList ID="rblHinhThucThanhToan" runat="server">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<br />
<div style="text-align: center">
    <asp:Button ID="Button1" runat="server" Text="Tiếp tục" 
        onclick="Button1_Click" />
</div>
<p>
    &nbsp;</p>







