<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminHanhTrinhControl.ascx.cs" Inherits="ShipBooking.Controls.AdminHanhTrinhControl" %>
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
        text-align: center;
    }
    .tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        width: 781px;
        height: auto;
    }
    .ThongTinDatCho_Title_1
    {
        width: 100px;
        text-align: right;
    }
    .style6
    {
        width: 239px;
    }
    .style7
    {
        width: 263px;
    }
    .style4
    {
        text-align: left;
    }
    .style3
    {
        text-align: left;
    }
    </style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="55px" 
        ImageUrl="~/Images/quan_ly_hanh_trinh.png" Width="402px" 
        style="text-align: center" />
</p>
<table class="tblThongTinDatCho_Summary_Style" align="center">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Chặng</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Từ: </td>
                    <td class="style6">
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="200px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="style7">
                        Đến:&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="200px" 
                            AutoPostBack="true" 
                            onselectedindexchanged="ddlNoiDen_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnDanhSachTP" runat="server" Height="26px" 
                            Text="Danh sách thành phố" Width="155px" style="text-align: center" 
                            onclick="btnDanhSachTP_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        &nbsp;</td>
                    <td class="style6" align="right">
                        Có chuyến:</td>
                    <td class="style7">
                        <asp:RadioButtonList ID="rblTinhTrangChuyen" runat="server" 
                            RepeatDirection="Horizontal" AutoPostBack="true" 
                            onselectedindexchanged="rblTinhTrangChuyen_SelectedIndexChanged">
                            <asp:ListItem Value="Yes">Có</asp:ListItem>
                            <asp:ListItem Value="No">Không</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<center>
    <asp:Panel ID="Panel1" runat="server" Width="801px" Visible="true">
        <br />
        <table class="tblThongTinDatCho_Summary_Style">
            <tr>
                <td bgcolor="#006699" class="table_header_style">
                    Thông tin hành trình</td>
            </tr>
            <tr align="center">
                <td class="table_contain_style" align="center">
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <table align="center" class="style2" 
                        style="border: 1px solid #006699; width: 517px;">
                        <tr align="center">
                            <td align="left" colspan="3" 
                                style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                Thông tin chuyến tàu</td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Mã chuyến:</td>
                            <td class="style3" colspan="2">
                                <asp:TextBox ID="txtMaHanhTrinh" runat="server" Width="140px" 
                                    style="text-align: center"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Số hiệu chuyến tàu:</td>
                            <td class="style3" colspan="2">
                                <asp:TextBox ID="txtSoHieuTau" runat="server" style="text-align: center" 
                                    Width="140px"></asp:TextBox>
                                &nbsp;&nbsp;
                                <asp:Button ID="btnXemTTTau" runat="server" Height="26px" 
                                    onclick="btnXemTTTau_Click" Text="Xem thông tin tàu" Width="134px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Giờ khởi hành:</td>
                            <td class="style3" colspan="2">
                                <asp:DropDownList ID="ddlGioKhoiHanh" runat="server" Height="22px" Width="50px">
                                </asp:DropDownList>
                                &nbsp;giờ
                                <asp:DropDownList ID="ddlPhutKhoiHanh" runat="server" Height="22px" 
                                    Width="50px">
                                </asp:DropDownList>
                                &nbsp;phút</td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Giờ đến:</td>
                            <td class="style3">
                                <asp:DropDownList ID="ddlGioDen" runat="server" Height="22px" 
                                    Width="50px">
                                </asp:DropDownList>
                                &nbsp;giờ
                                <asp:DropDownList ID="ddlPhutDen" runat="server" Height="22px" Width="50px">
                                </asp:DropDownList>
                                &nbsp;phút</td>
                            <td style="text-align: left">
                                <asp:DropDownList ID="ddlNgayDen" runat="server" Height="22px" Width="140px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Ngày trong tuần:</td>
                            <td class="style3">
                                <asp:DropDownList ID="ddlNgayTrongTuan" runat="server" Height="22px" 
                                    Width="111px">
                                </asp:DropDownList>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Số ghế:</td>
                            <td class="style3">
                                <asp:DropDownList ID="ddlSoGhe" runat="server" Height="22px" Width="66px">
                                </asp:DropDownList>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table align="center" class="style2" 
                        style="border: 1px solid #006699; width: 779px;">
                        <tr align="center">
                            <td align="left" colspan="3" 
                                style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                Giá vé</td>
                        </tr>
                        <tr>
                            <td align="left" class="style5">
                                <table align="center" class="style2" style="border: 1px solid #006699">
                                    <tr align="center">
                                        <td align="left" colspan="2" 
                                            style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                            Loại thường</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Người lớn:</td>
                                        <td style="text-align: left">
                                            <asp:TextBox ID="txtGiaVe1_NguoiLon" runat="server" style="text-align: right" 
                                                Width="100px">0</asp:TextBox>
                                            &nbsp;(VNĐ)</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Trẻ em:</td>
                                        <td style="text-align: left">
                                            <asp:TextBox ID="txtGiaVe1_TreEm" runat="server" style="text-align: right" 
                                                Width="100px">0</asp:TextBox>
                                            &nbsp;(VNĐ)</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Số lượng:</td>
                                        <td style="text-align: left">
                                            <asp:DropDownList ID="ddlSoLuongVe1" runat="server" Height="22px" Width="60px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td align="left" class="style5">
                                <table align="center" class="style2" style="border: 1px solid #006699">
                                    <tr align="center">
                                        <td align="left" colspan="2" 
                                            style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                            Loại doanh nhân</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Người lớn:</td>
                                        <td style="text-align: left">
                                            <asp:TextBox ID="txtGiaVe2_NguoiLon" runat="server" style="text-align: right" 
                                                Width="100px">0</asp:TextBox>
                                            &nbsp;(VNĐ)</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Trẻ em:</td>
                                        <td style="text-align: left">
                                            <asp:TextBox ID="txtGiaVe2_TreEm" runat="server" style="text-align: right" 
                                                Width="100px">0</asp:TextBox>
                                            &nbsp;(VNĐ)</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Số lượng:</td>
                                        <td style="text-align: left">
                                            <asp:DropDownList ID="ddlSoLuongVe2" runat="server" Height="22px" Width="60px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td align="left" class="style5">
                                <table align="center" class="style2" style="border: 1px solid #006699">
                                    <tr align="center">
                                        <td align="left" colspan="2" 
                                            style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                                            Loại VIP</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Người lớn:</td>
                                        <td style="text-align: left">
                                            <asp:TextBox ID="txtGiaVe3_NguoiLon" runat="server" style="text-align: right" 
                                                Width="100px">0</asp:TextBox>
                                            &nbsp;(VNĐ)</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Trẻ em:</td>
                                        <td style="text-align: left">
                                            <asp:TextBox ID="txtGiaVe3_TreEm" runat="server" style="text-align: right" 
                                                Width="100px">0</asp:TextBox>
                                            &nbsp;(VNĐ)</td>
                                    </tr>
                                    <tr>
                                        <td align="left" class="style5">
                                            Số lượng:</td>
                                        <td style="text-align: left">
                                            <asp:DropDownList ID="ddlSoLuongVe3" runat="server" Height="22px" Width="60px">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" class="style5" colspan="3">
                                Giảm giá vé khứ hồi:
                                <asp:TextBox ID="txtGiamGiaVeKhuHoi" runat="server" Width="119px" 
                                    style="text-align: right">0</asp:TextBox>
                                &nbsp;(VNĐ)</td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="btnAdd" runat="server" Text="Thêm" Width="60px" 
                        onclick="btnAdd_Click" />
                    &nbsp;
                    <asp:Button ID="btnSaveHanhTrinh" runat="server" Text="Lưu" Width="60px" 
                        onclick="btnSaveHanhTrinh_Click" />
                    <br />
                    <br />
                    <asp:GridView ID="grwHanhTrinh" runat="server" AutoGenerateColumns="False"
                        EmptyDataText="Chưa có dữ liệu nào"
                        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" Width="779px" 
                        onpageindexchanged="grwHanhTrinh_PageIndexChanged" 
                        onpageindexchanging="grwHanhTrinh_PageIndexChanging" 
                        onrowdeleted="grwHanhTrinh_RowDeleted" 
                        onrowdeleting="grwHanhTrinh_RowDeleting" 
                        onselectedindexchanged="grwHanhTrinh_SelectedIndexChanged" PageSize="50">
                        <RowStyle ForeColor="#000066" />
                        <Columns>
                            <asp:BoundField HeaderText="Số hiệu chuyến" DataField="SoHieuChuyenTau" />
                            <asp:BoundField HeaderText="Giờ khởi hành" DataField="GioKhoiHanh" />
                            <asp:BoundField HeaderText="Giờ đến" DataField="GioDen" />
                            <asp:BoundField HeaderText="Tổng thời gian" DataField="TongThoiGian" />
                            <asp:BoundField HeaderText="Ngày trong tuần" DataField="NgayTrongTuan" />
                            <asp:CommandField ButtonType="Button" DeleteText="Xóa" ShowDeleteButton="True">
                                <ControlStyle Width="50px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:CommandField>
                            <asp:CommandField ButtonType="Button" SelectText="Chọn" ShowSelectButton="True">
                                <ControlStyle Width="50px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:CommandField>
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                    <br />
                    </td>
            </tr>
        </table>
    </asp:Panel>
</center>
<p style="text-align: center">
                    &nbsp;</p>
<p style="text-align: center">
    &nbsp;</p>
