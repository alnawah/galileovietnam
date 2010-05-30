<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchHanhTrinhResultControl.ascx.cs" Inherits="ShipBooking.Controls.SearchHanhTrinhResultControl" %>
<style type="text/css">
    .style1
    {
        width: 40%;
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
</style>
<center>
    <br />
    <table class="style1">
        <tr>
            <td class="style2">
                Loại chuyến</td>
            <td class="style3">
                            <asp:Label ID="lblLoaiChuyen" runat="server" Font-Bold="True" 
                    ForeColor="Blue"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Nơi khởi hành:</td>
            <td class="style3">
                            <asp:Label ID="lblNoiDi" runat="server" Font-Bold="True" 
                    ForeColor="Blue"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Nơi đến:</td>
            <td class="style3">
                            <asp:Label ID="lblNoiDen" runat="server" Font-Bold="True" 
                    ForeColor="Blue"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Ngày khởi hành:</td>
            <td class="style3">
                            <asp:Label ID="lblNgayDi" runat="server" Font-Bold="True" 
                    ForeColor="Blue"></asp:Label>
                        </td>
        </tr>
        <tr>
            <td class="style2">
                Ngày về:</td>
            <td class="style3">
                            <asp:Label ID="lblNgayDen" runat="server" Font-Bold="True" 
                    ForeColor="Blue"></asp:Label>
            </td>
        </tr>
    </table>
</center>
<p>
    &nbsp;</p>

<center>
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
            <asp:BoundField DataField="MaHanhTrinh" HeaderText="Số hiệu chuyến" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="SoGhe" HeaderText="Số ghế còn trống" >
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
    <br />
</center>