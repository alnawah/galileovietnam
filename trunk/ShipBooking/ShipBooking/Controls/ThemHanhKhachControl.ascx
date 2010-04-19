<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThemHanhKhachControl.ascx.cs" Inherits="ShipBooking.Controls.ThemHanhKhachControl" %>
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
    <asp:Button ID="btnThemKhach" runat="server" Text="Thêm mới" />
</p>

<center>
    <asp:GridView ID="grvHanhKhach" runat="server" Width="800px" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Height="71px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="Stt" HeaderText="STT" />
            <asp:BoundField DataField="TenKhach" HeaderText="Tên khách" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
            <asp:BoundField DataField="LoaiQuocTich" HeaderText="VN/Nước ngoài" />
            <asp:BoundField DataField="LoaiTuoi" HeaderText="Tuổi" />
            <asp:BoundField DataField="GiaVe" HeaderText="Giá vé" />
        </Columns>
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</center>

<p style="text-align: center">
    <asp:Button ID="btnHoanTat" runat="server" Text="Hoàn tất" 
        onclick="btnHoanTat_Click" />
</p>
