<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingStep1Control.ascx.cs" Inherits="ShipBooking.Controls.BookingStep1Control" %>
<style type="text/css">


    .step1_tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 600px;
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
        width: 518px;
        height: auto;
    }
    .style2
    {
        border: 1px solid #0000FF;
        width: 600px;
    }
        
    #datePicker1
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    #imgCalendar2
    {
        width: 14px;
    }
    #datePicker2
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    .style4
    {
        width: 123px;
    }
    .style7
    {
        width: 119px;
    }
    .style8
    {
    }
    .style9
    {
        width: 155px;
    }
    .style12
    {
        width: 100px;
        text-align: right;
    }
    .style13
    {
        width: 100px;
        font-weight: bold;
        text-align: center;
    }
    .style14
    {
        font-weight: bold;
        text-align: center;
    }
    .style15
    {
        text-align: center;
    }
    .style16
    {
        width: 100px;
        text-align: center;
    }
    </style>
<p>
    &nbsp;</p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Tạo booking</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="style8">
                                                Loại hành trình:</td>
                    <td class="style7">
                        <asp:Label ID="lblLoaiHanhTrinh" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                        </td>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style8">
                                                Nơi khởi hành:</td>
                    <td class="style7">
                        <asp:Label ID="lblNoiDi" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    <td class="style4">
                        Nơi đến:</td>
                    <td>
                        <asp:Label ID="lblNoiDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td class="style8">
                        Ngày đi:</td>
                    <td class="style7">
                        <asp:Label ID="lblNgayKhoiHanh" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                    </td>
                    <td class="style4">
                        <asp:Label ID="lblNgayVe" runat="server" Visible="false" Text="Ngày về:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblNgayDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        Giờ khởi hành:</td>
                    <td class="style7">
                        <asp:Label ID="lblGioKhoiHanh" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                    <td class="style4">
                        Giờ đến:&nbsp;</td>
                    <td>
                        <asp:Label ID="lblGioDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style8">Số ghế:</td>
                    <td class="style1" colspan="3" style="margin-left: 40px">
                        <asp:RadioButtonList ID="rdbSoGhe" runat="server" RepeatColumns="12" 
                            RepeatDirection="Horizontal">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p>
    &nbsp;</p>
<table align="center" class="style2" style="border: 1px solid #006699">
    <tr bgcolor="#006699">
        <td style="text-align: center; font-weight: 700; color: #FFFFFF;" 
            class="style9">
            Loại vé</td>
        <td style="color: #FFFFFF; text-align: center;" class="style12">
            <b style="text-align: center">Số vé còn lại</b></td>
        <td style="color: #FFFFFF;" class="style16">
            <b style="text-align: center">Giá người lớn</b></td>
        <td style="color: #FFFFFF" class="style13">
            Giá trẻ em</td>
        <td style="color: #FFFFFF" class="style14">
            Số vé</td>
    </tr>
    <tr>
        <td align="left" class="style9">
            <asp:CheckBox ID="chkHangThuong" runat="server" Text="Hạng thường" 
                AutoPostBack="true" oncheckedchanged="chkHangThuong_CheckedChanged" />
        </td>
        <td class="style12">
        <asp:Label ID="lblSLVe1" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style12">
        <asp:Label ID="lblGiaNL1" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style12">
        <asp:Label ID="lblGiaTE1" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style15">
                    <asp:DropDownList ID="ddlSLVe1" runat="server" Enabled="False" Height="22px" 
                        Width="70px">
                    </asp:DropDownList>
        </td>
            </tr>
            <tr>
                <td align="left" class="style9">
                    <asp:CheckBox ID="chkHangDoanhNhan" runat="server" Text="Hạng doanh nhân" 
                        AutoPostBack="true" oncheckedchanged="chkHangDoanhNhan_CheckedChanged" />
                </td>
                <td class="style12">
        <asp:Label ID="lblSLVe2" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style12">
        <asp:Label ID="lblGiaNL2" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style12">
        <asp:Label ID="lblGiaTE2" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style15">
                    <asp:DropDownList ID="ddlSLVe2" runat="server" Enabled="False" Height="22px" 
                        Width="70px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="left" class="style9">
                    <asp:CheckBox ID="chkHangVIP" runat="server" Text="Hạng VIP" 
                        AutoPostBack="true" oncheckedchanged="chkHangVIP_CheckedChanged" />
                </td>
                <td class="style12">
        <asp:Label ID="lblSLVe3" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style12">
        <asp:Label ID="lblGiaNL3" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style12">
        <asp:Label ID="lblGiaTE3" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                </td>
                <td class="style15">
                    <asp:DropDownList ID="ddlSLVe3" runat="server" Enabled="False" Height="22px" 
                        Width="70px">
                    </asp:DropDownList>
                </td>
    </tr>
</table>
                            
<p style="text-align: center">
    <asp:Button ID="btnContinue" runat="server" Text="Tiếp tục" Width="84px" 
        onclick="btnContinue_Click" />
</p>

                            

