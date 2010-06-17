<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchHanhTrinhResultControl.ascx.cs" Inherits="ShipBooking.Controls.SearchHanhTrinhResultControl" %>
<style type="text/css">
    .style1
    {
        width: 61%;
    }
    .style2
    {
        width: 153px;
        text-align: right;
    }
    .style3
    {
        text-align: left;
    }
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
        width: 475px;
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
        height: 16px;
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
        text-align: right;
        width: 67px;
    }
    .style5
    {
        text-align: left;
        width: 98px;
    }
    </style>
<center>
    <br />
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/ket_qua_tim_kiem_hanhtrinh.png" Width="398px" />
    <br />
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Hành trình</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
        <center>
            <table class="style1">
                <tr>
                    <td class="style2">
                        Loại chuyến:</td>
                    <td class="style5">
                                    <asp:Label ID="lblLoaiChuyen" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                    </td>
                    <td class="style4">
                                    &nbsp;</td>
                    <td class="style3">
                                    &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                        Nơi khởi hành:</td>
                    <td class="style5">
                                    <asp:Label ID="lblNoiDi" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                    </td>
                    <td class="style4">
                        Nơi đến:</td>
                    <td class="style3">
                                    <asp:Label ID="lblNoiDen" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        Ngày khởi hành:</td>
                    <td class="style5">
                                    <asp:Label ID="lblNgayDi" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                                </td>
                    <td class="style4">
                        <asp:Label ID="lblNgayVeLabel" runat="server" Text="Ngày về:"></asp:Label>
                                </td>
                    <td class="style3">
                                    <asp:Label ID="lblNgayVe" runat="server" Font-Bold="True" 
                            ForeColor="Blue"></asp:Label>
                                </td>
                </tr>
                </table>
        </center>
        </td>
    </tr>
</table>
</center>
<br />

<center>
    <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#00CC00"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="grvTinhTrangCho" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" Width="800px" 
        onselectedindexchanged="grvTinhTrangCho_SelectedIndexChanged">
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="TenTPDi" HeaderText="Nơi khởi hành" >
                <ItemStyle HorizontalAlign="Center" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="TenTPDen" HeaderText="Nơi đến" >
                <ItemStyle HorizontalAlign="Center" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="GioKhoiHanh" HeaderText="Giờ khởi hành" >
                <ItemStyle HorizontalAlign="Center" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="GioDen" HeaderText="Giờ đến" >
                <ItemStyle HorizontalAlign="Center" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="SoHieuChuyenTau" HeaderText="Số hiệu chuyến tàu" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="MaHanhTrinh" HeaderText="Mã hành trình" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:CommandField ButtonType="Button" SelectText="Đặt chỗ" 
                ShowSelectButton="True" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <br />
    <asp:Button ID="btnBack" runat="server" Text="Tìm kiếm lại" 
        onclick="btnBack_Click" Width="111px" Height="26px" />
    <br />
</center>
    
    <p>
        &nbsp;</p>

    
