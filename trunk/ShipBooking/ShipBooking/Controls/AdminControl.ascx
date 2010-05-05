<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminControl.ascx.cs" Inherits="ShipBooking.Controls.AdminControl" %>
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
    .ThongTinDatCho_Detail
    {
        width: 200px;
    }
    .ThongTinDatCho_Title_2
    {
        width: 170px;
        text-align: left;
    }
    .style1
    {
        width: 122px;
        text-align: right;
    }
    .ngay_style_column
    {
        width: 100px;
    }
    .style2
    {
        width: 65%;
    }
    .style3
    {
        width: 122px;
    }
    .style4
    {
        width: 95px;
    }
    .style5
    {
        width: 96px;
        text-align: right;
    }
    </style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="55px" 
        ImageUrl="~/Images/admin.jpg" Width="362px" />
    </p>
<table class="tblThongTinDatCho_Summary_Style" align="center">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Hành trình</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        Từ: </td>
                    <td class="ThongTinDatCho_Detail">
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="200px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="style1">
                        Đến: </td>
                    <td>
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="200px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDen_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="ThongTinDatCho_Title_1">
                        &nbsp;</td>
                    <td class="ThongTinDatCho_Detail" align="right">
                        Có chuyến:</td>
                    <td class="style1">
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
<p>
    &nbsp;</p>
<center>
<asp:Panel ID="Panel1" runat="server" Width="801px" Visible="true">
    <table class="tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="table_header_style">
                Cập nhật thông tin hành trình</td>
        </tr>
        <tr align="center">
            <td class="table_contain_style" align="center">
                <br />
                <table class="style2" style="border: 1px solid #006699" align="center">
                    <tr align="center">
                        <td colspan="3" 
                            style="background-color: #006699; color: #FFFFFF; font-weight: bold;" 
                            align="left">Giá vé</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td align="left" class="style5">
                            Loại thường: </td>
                        <td>
                            <asp:TextBox ID="txtGiaVeThuong" runat="server" Width="176px"></asp:TextBox>
                            &nbsp;(VNĐ)</td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td align="left" class="style5">
                            Loại doanh nhân:</td>
                        <td>
                            <asp:TextBox ID="txtGiaVeDoanhNhan" runat="server" Width="176px"></asp:TextBox>
                            &nbsp;(VNĐ)</td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td align="left" class="style5">
                            Loại VIP:</td>
                        <td>
                            <asp:TextBox ID="txtGiaVeVIP" runat="server" Width="176px"></asp:TextBox>
                            &nbsp;(VNĐ)</td>
                    </tr>
                </table>
                <br />
                <table align="center" class="style2" style="border: 1px solid #006699">
                    <tr align="center">
                        <td align="left" colspan="4" 
                            style="background-color: #006699; color: #FFFFFF; font-weight: bold;">
                            Số hiệu chuyến tàu</td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Số hiệu tàu:
                        </td>
                        <td class="style3">
                            <asp:DropDownList ID="ddlSoHieuTau" runat="server" Height="22px" Width="110px" 
                                AutoPostBack="true" onselectedindexchanged="ddlSoHieuTau_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSoHieuTau" runat="server" Width="140px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Xem thông tin tàu" 
                                Width="134px" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Panel ID="panelLichTrinh" runat="server">
                    <table ID="tblLichTrinh" border="1px" class="tblThongTinDatCho_Detail_Style" 
                        style="border: 1px solid #CCCCCC">
                        <tr>
                            <td class="ngay_style_column">
                                &nbsp;</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Hai</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Ba</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Tư</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Năm</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Sáu</td>
                            <td align="center" class="ngay_style_column">
                                Thứ Bảy</td>
                            <td align="center" class="ngay_style_column">
                                Chủ Nhật</td>
                        </tr>
                        <tr>
                            <td class="ngay_style_column">
                                Giờ khởi hành</td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox3" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox4" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox5" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox6" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox7" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox8" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox9" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="ngay_style_column">
                                Giờ đến</td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox10" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox11" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox12" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox13" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox14" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox15" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                            <td class="ngay_style_column">
                                <asp:TextBox ID="TextBox16" runat="server" style="text-align: center" 
                                    Width="60px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <br />
                <br />
                </td>
        </tr>
    </table>
</asp:Panel>
</center>
<p style="text-align: center">
    <asp:Button ID="btnSave" runat="server" Text="Save" Width="60px" 
        onclick="btnSave_Click" />
&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
</p>

