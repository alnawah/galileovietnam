<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongTinKhachControl.ascx.cs" Inherits="ShipBooking.Controls.ThongTinKhachControl" %>
<style type="text/css">


    .step1_tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 800px;
        height: auto;
    }
    .step1_table_header_style
    {
        color: #FFFFFF;
        font-weight: bold;
        font-family: Arial, Helvetica, sans-serif;
    }
    .step1_table_contain_style
    {
        border: 1px solid #006699;
    }
    .step1_tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        border-style: none;
        width: 600px;
        height: auto;
    }
    .step1_warning
    {
        color: #FF0000;
    }

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
    
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/text_banvetau.png" Width="600px" />
</p>
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
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
</p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Thông tin về hành khách</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td>
                        Họ và tên:</td>
                    <td>
                        <asp:TextBox ID="txtHoTen" runat="server" Width="250px"></asp:TextBox>
                    &nbsp;<span class="step1_warning">(*) </span>
                    </td>
                </tr>
                <tr>
                    <td>
                        Địa chỉ:</td>
                    <td>
                        <asp:TextBox ID="txtDiaChi" runat="server" Height="100px" TextMode="MultiLine" 
                            Width="250px"></asp:TextBox>
                        <span class="step1_warning">(*)
                        </span>
                    </td>
                </tr>
                <tr>
                    <td>
                        Quốc tịch:</td>
                    <td>
                        <asp:DropDownList ID="ddlQuocTich" runat="server" Height="22px" Width="160px">
                        </asp:DropDownList>
                    &nbsp;<span class="step1_warning">(*)
                        </span></td>
                </tr>
                <tr>
                    <td>
                        Độ tuổi</td>
                    <td>
                        <asp:DropDownList ID="ddlDoTuoi" runat="server" Height="22px" Width="160px">
                        </asp:DropDownList>
                    &nbsp;<span class="step1_warning">(*)
                        </span></td>
                </tr>
                <tr>
                    <td>
                        Số điện thoại:</td>
                    <td>
                        <asp:TextBox ID="txtSoDienThoai" runat="server" Width="138px"></asp:TextBox>
                        &nbsp;<span class="step1_warning">(*) 
                        </span>
                        </td>
                </tr>
                <tr>
                    <td>
                        Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                    &nbsp;<span class="step1_warning">(*) 
                        </span>
                    </td>
                </tr>
            </table>
            </td>
    </tr>
</table>

<p style="text-align: center">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="text-align: center" Text="Tiếp tục" />
</p>


