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
        width: 489px;
        height: auto;
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
    .style12
    {
        width: 100px;
        text-align: right;
    }
    .style20
    {
    }
    .style21
    {
        width: 114px;
    }
    .style22
    {
        text-align: left;
        height: 23px;
    }
    .style28
    {
        width: 100px;
        text-align: right;
        height: 23px;
    }
    .style29
    {
        height: 23px;
    }
    .style30
    {
        width: 55px;
        text-align: right;
    }
    .style31
    {
    }
    .style32
    {
        width: 68px;
    }
    </style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/tao_booking_step.png" Width="312px" />
        <br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    </p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Tạo booking</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="style12">
                                                Loại hành trình:</td>
                    <td class="style20" colspan="3">
                        <asp:Label ID="lblLoaiHanhTrinh" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td class="style12">
                                                Nơi khởi hành:</td>
                    <td class="style32">
                        <asp:Label ID="lblNoiDi" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    <td class="style30">
                        Nơi đến:</td>
                    <td class="style21">
                        <asp:Label ID="lblNoiDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td class="style12">
                        Ngày đi:</td>
                    <td class="style32">
                        <asp:Label ID="lblNgayKhoiHanh" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                    </td>
                    <td class="style30">
                        <asp:Label ID="lblNgayVeLabel" runat="server" Text="Ngày về:"></asp:Label>
                    </td>
                    <td class="style21">
                        <asp:Label ID="lblNgayVe" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style12">
                        Giờ khởi hành:</td>
                    <td class="style32">
                        <asp:Label ID="lblGioKhoiHanh" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                    <td class="style30">
                        Giờ đến:</td>
                    <td class="style21">
                        <asp:Label ID="lblGioDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style12">
                        Hạng vé:</td>
                    <td class="style31" colspan="3">
                        <asp:DropDownList ID="ddlLoaiVe" runat="server" Height="22px" Width="159px" 
                            AutoPostBack="true" 
                            onselectedindexchanged="ddlLoaiVe_SelectedIndexChanged" 
                            style="margin-right: 0px">
                        </asp:DropDownList>
                    &nbsp;&nbsp; Giá:                         <asp:Label ID="lblGiaVe" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Số vé:</td>
                    <td class="style29" colspan="3">
                        <asp:DropDownList ID="ddlSLVe" runat="server" Height="22px" Width="75px">
                        </asp:DropDownList>
&nbsp;&nbsp; Số lượng còn:
                        <asp:Label ID="lblSoLuongVe" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style28">Số ghế:</td>
                    <td class="style22" colspan="3" style="margin-left: 40px">
                        <asp:RadioButtonList ID="rdbSoGhe" runat="server" RepeatColumns="12" 
                            RepeatDirection="Horizontal" Height="22px" style="text-align: left" 
                            Width="126px">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
                            
<p style="text-align: center">
    <asp:Button ID="btnContinue" runat="server" Text="Tiếp tục" Width="84px" 
        onclick="btnContinue_Click" />
</p>

                            

