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
    
    .style2
    {
        width: 153px;
    }
    .style3
    {
        width: 100px;
        text-align: right;
    }
    .style4
    {
        width: 85px;
        text-align: right;
    }
    
    .style5
    {
        text-align: right;
    }
    
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/thong_tin_khach.png" Width="380px" />
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
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
</p>
<asp:Panel ID="Panel1" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 1</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td style="text-align: right">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen1" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            Độ tuổi:</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi1" runat="server" Height="22px" Width="160px" >
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel2" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 2</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen2" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi2" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel3" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 3</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen3" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi3" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel4" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 4</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen4" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi4" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel5" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số&nbsp; 5</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen5" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi5" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel6" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 6</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen6" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi6" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel7" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 7</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen7" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi7" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel8" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 8</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen8" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi8" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<asp:Panel ID="Panel9" runat="server" Visible="False">
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin về hành khách số 9</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style5">
                            Họ và tên:</td>
                        <td>
                            <asp:TextBox ID="txtHoTen9" runat="server" Width="250px"></asp:TextBox>
                            &nbsp;<span class="step1_warning">(*) </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Độ tuổi</td>
                        <td>
                            <asp:DropDownList ID="ddlDoTuoi9" runat="server" Height="22px" Width="160px">
                                <asp:ListItem Value="NguoiLon">Người lớn</asp:ListItem>
                                <asp:ListItem Value="TreSoSinh">Trẻ sơ sinh</asp:ListItem>
                                <asp:ListItem Value="TreEm">Trẻ em</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<p style="text-align: center">
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="text-align: center" Text="Tiếp tục" />
</p>
<p style="text-align: center">
    &nbsp;</p>


