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
        ImageUrl="~/Images/thong_tin_nguoi_nhan_ve.png" Width="600px" />
    <br />
</p>
<center>
    
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

<p style="text-align: center">
    <asp:LinkButton ID="LinkButton1" runat="server" 
        PostBackUrl="~/ThemHanhKhach.aspx" Visible="False">Thêm hoặc sửa danh sách khách</asp:LinkButton>
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
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Điện thoại</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="txtDienThoaiNguoiNhan" runat="server" Width="163px"></asp:TextBox>
                        &nbsp;<span class="warning_text">(*)</span>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Email</td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:TextBox ID="txtEmailNguoiNhan" runat="server" Width="279px"></asp:TextBox>
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







