<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatVeControl.ascx.cs" Inherits="ShipBooking.Controls.DatVeControl" %>

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

</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/text_banvetau.png" Width="600px" />
</p>
<p style="text-align: center">
    &nbsp;</p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Đặt chỗ vé tàu</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="22px" 
                            RepeatDirection="Horizontal" Width="364px">
                            <asp:ListItem Value="KhuHoi">Khứ hồi</asp:ListItem>
                            <asp:ListItem Value="MotLuot">Một lượt</asp:ListItem>
                            <asp:ListItem Value="NhieuLuot">Nhiều lượt</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Từ:</td>
                    <td>
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="160px">
                        </asp:DropDownList>
                        &nbsp;<span class="step1_warning">(*)</span>&nbsp;&nbsp;&nbsp;&nbsp;
                        Đến:
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="160px">
                        </asp:DropDownList>
                        &nbsp;<span class="step1_warning">(*)</span></td>
                </tr>
                <tr>
                    <td>
                        Ngày đi</td>
                    <td>
                        <asp:TextBox ID="txtNgayDi" runat="server" Width="138px"></asp:TextBox>
                        <asp:ImageButton ID="ImageButton1" runat="server" 
                            ImageUrl="~/Images/CalendarIcon.png" />
                    &nbsp;(dd/mm/yyyy) &nbsp;
                        <asp:DropDownList ID="ddlThoiGian" runat="server" Height="21px" Width="136px">
                        </asp:DropDownList>
                    &nbsp;<span class="step1_warning">(*)</span></td>
                </tr>
                <tr>
                    <td>
                        Ngày về</td>
                    <td>
                        <asp:TextBox ID="txtNgayVe" runat="server" Width="138px"></asp:TextBox>
                        <asp:ImageButton ID="ImageButton2" runat="server" 
                            ImageUrl="~/Images/CalendarIcon.png" />
                    &nbsp;(dd/mm/yyyy)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Open" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Loại vé:</td>
                    <td>
                        <asp:DropDownList ID="ddlLoaiVe" runat="server" Height="22px" Width="160px">
                        </asp:DropDownList>
                    &nbsp;<span class="step1_warning">(*)
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="ddlLoaiVe"
        Text="Bạn phải chọn loại vé"></asp:RequiredFieldValidator>
                        </span></td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<br />
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
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="txtHoTen"
        Text="Bạn phải nhập họ tên"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Địa chỉ:</td>
                    <td>
                        <asp:TextBox ID="txtDiaChi" runat="server" Height="100px" TextMode="MultiLine" 
                            Width="250px"></asp:TextBox>
                        <span class="step1_warning">(*)
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="txtDiaChi"
        Text="Bạn phải địa chỉ"></asp:RequiredFieldValidator>
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
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="ddlQuocTich"
        Text="Bạn phải chọn quốc tịch"></asp:RequiredFieldValidator>
                        </span></td>
                </tr>
                <tr>
                    <td>
                        Độ tuổi</td>
                    <td>
                        <asp:DropDownList ID="ddlDoTuoi" runat="server" Height="22px" Width="160px">
                        </asp:DropDownList>
                    &nbsp;<span class="step1_warning">(*)
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="ddlDoTuoi"
        Text="Bạn phải chọn độ tuổi"></asp:RequiredFieldValidator>
                        </span></td>
                </tr>
                <tr>
                    <td>
                        Số điện thoại:</td>
                    <td>
                        <asp:TextBox ID="txtSoDienThoai" runat="server" Width="138px"></asp:TextBox>
                        &nbsp;<span class="step1_warning">(*) 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="txtSoDienThoai"
        Text="Bạn phải nhập số điện thoại"></asp:RequiredFieldValidator>
                        </span>
                        </td>
                </tr>
                <tr>
                    <td>
                        Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                    &nbsp;<span class="step1_warning">(*) 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ErrorMessage="RequiredFieldValidator" ControlToValidate="txtEmail"
        Text="Bạn phải nhập email"></asp:RequiredFieldValidator>
                        </span>
                    </td>
                </tr>
            </table>
            </td>
    </tr>
</table>

<p style="text-align: center">
    <asp:Button ID="Button1" runat="server" Text="Tiếp tục" 
        onclick="Button1_Click1" />
</p>


