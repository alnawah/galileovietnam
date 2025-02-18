﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminDetailBookingControl.ascx.cs" Inherits="ShipBooking.Controls.AdminDetailBookingControl" %>
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
        width: 478px;
        height: auto;
    }
    .style1
    {
        width: 103px;
    }
    
    #datePicker1
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    #datePicker2
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    </style>
 <center>
    <p style="text-align: center">
        <asp:Image ID="Image1" runat="server" Height="55px" 
            ImageUrl="~/Images/quan_ly_booking.png" Width="362px" />
    </p>
    
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Chi tiết Booking</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style1">
                            Booking ID:</td>
                        <td>
                            <asp:Label ID="lblBookingID" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                        <td>
                            Loại chuyến:</td>
                        <td>
                            <asp:Label ID="lblLoaiChuyen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                                                    Nơi đi:</td>
                        <td>
                            <asp:Label ID="lblNoiDi" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                        <td>
                            Nơi đến:</td>
                        <td>
                            <asp:Label ID="lblNoiDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Ngày khởi hành:</td>
                        <td>
                            <asp:Label ID="lblNgayDi" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblNgayVeText" runat="server" Text="Ngày về:" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblNgayVe" runat="server" Font-Bold="True" ForeColor="Blue" 
                                Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Giờ khởi hành:</td>
                        <td>
                            <asp:Label ID="lblGioKhoiHanh" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                        <td>
                            Giờ đến:</td>
                        <td>
                            <asp:Label ID="lblGioDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Loại vé:</td>
                        <td>
                            <asp:Label ID="lblLoaiVe" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                        <td>
                            Số ghế:</td>
                        <td>
                            <asp:Label ID="lblSoGhe" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            Giá tiền:</td>
                        <td>
                            <asp:Label ID="lblGiaTien" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        &nbsp;<asp:Label ID="lblDonViTien" runat="server" Font-Bold="True" 
                                ForeColor="Maroon" Text=" (VNĐ)"></asp:Label>
                        </td>
                    </tr>
                    </table>
                </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="grvHanhKhach" runat="server" Width="800px" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Height="71px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="MaHK" HeaderText="Mã khách" >
                <ItemStyle Width="100px" HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Ten" HeaderText="Tên khách" >
                <ItemStyle Width="300px" />
            </asp:BoundField>
            <asp:BoundField DataField="DoTuoi" HeaderText="Độ tuổi" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="GiaTien" HeaderText="Giá vé" >
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
        </Columns>
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <br />
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Thông tin người nhận vé</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style1">
                            Mã người nhận:</td>
                        <td style="margin-left: 40px">
                            <asp:Label ID="lblMaNN" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                                                    Họ tên:</td>
                        <td>
                            <asp:Label ID="lblTenNN" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Địa chỉ:</td>
                        <td>
                            <asp:Label ID="lblDiaChiNN" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Số điện thoại:</td>
                        <td>
                            <asp:Label ID="lblSoDienThoaiNN" runat="server" Font-Bold="True" 
                                ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Email:</td>
                        <td>
                            <asp:Label ID="lblEmailNN" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Yêu cầu khác:</td>
                        <td>
                            <asp:Label ID="lblYeuCauKhac" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                        </td>
                    </tr>
                    </table>
                </td>
        </tr>
    </table>

    <p style="text-align: center">
        <asp:Button ID="btnBack" runat="server" Text="Quay lại" 
            onclick="btnBack_Click" Height="26px" />
    </p>
</center>