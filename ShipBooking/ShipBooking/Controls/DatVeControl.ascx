<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatVeControl.ascx.cs" Inherits="ShipBooking.Controls.DatVeControl" %>
<script type="text/javascript">
    function displayCalendar1()
    {
        var datePicker = document.getElementById('datePicker1');
        datePicker.style.display = 'block';
    }
    
    function displayCalendar2()
    {
        var datePicker = document.getElementById('datePicker2');
        datePicker.style.display = 'block';
    }
</script>

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
    .style1
    {
    }
    .style2
    {
        width: 181px;
    }
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/thong_tin_tinh_trang_chuyen.png" Width="621px" />
</p>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
</p>
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
                    <td class="style2">
                        <asp:RadioButtonList ID="rblLoaiHanhTrinh" runat="server" Height="16px" 
                            RepeatDirection="Horizontal" Width="208px" 
                            onselectedindexchanged="rblLoaiHanhTrinh_SelectedIndexChanged" 
                            AutoPostBack="true">
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:DropDownList ID="ddlThoiGian" runat="server" Height="21px" Width="136px" Visible="false">
                        </asp:DropDownList>
                        <asp:CheckBox ID="chkOpen" runat="server" Text="Open" Visible="False" />
                    </td>
                </tr>
                <tr>
                    <td>
                                                Từ</td>
                    <td class="style2">
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                        </asp:DropDownList>
                        </td>
                    <td>
                        Đến: </td>
                    <td>
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDen_SelectedIndexChanged">
                        </asp:DropDownList>
                        </td>
                </tr>
                <tr>
                    <td>
                        Ngày đi</td>
                    <td class="style2">
                        <asp:TextBox ID="txtNgayDi" runat="server" Width="138px"></asp:TextBox>
                        <img id="imgCalendar1" src="~/Images/CalendarIcon.png" alt="" runat="server" 
                            onclick="displayCalendar1()" height="16" />
                        <div id="datePicker1">
                            <asp:Calendar id="calEventDate" 
                                OnSelectionChanged="calEventDate_SelectionChanged" Runat="server" 
                                BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" 
                                DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                                ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" >
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                                    ForeColor="#FFFFCC" />
                            </asp:Calendar>
                        </div>
                    </td>
                    <td>
                        <asp:Label ID="lblNgayVe" runat="server" Visible="false" Text="Ngày về:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgayVe" runat="server" Width="138px" Visible="False"></asp:TextBox>
                        <img id="imgCalendar2" src="~/Images/CalendarIcon.png" alt="" runat="server" 
                            onclick="displayCalendar2()" height="16" visible="False"/>
                        <div id="datePicker2">
                            <asp:Calendar id="Calendar1" Runat="server" BackColor="#FFFFCC" 
                                BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                                Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
                                ShowGridLines="True" Width="220px" 
                                onselectionchanged="Calendar1_SelectionChanged" >
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                                    ForeColor="#FFFFCC" />
                            </asp:Calendar>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        Giờ khởi hành:</td>
                    <td class="style2">
                        <asp:Label ID="lblGioKhoiHanh" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                    <td>
                        Giờ đến:&nbsp;</td>
                    <td>
                        <asp:Label ID="lblGioDen" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Loại vé</td>
                    <td class="style2">
                        <asp:DropDownList ID="ddlLoaiVe" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true" onselectedindexchanged="ddlLoaiVe_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td colspan="2">
                        Số vé hiện có:
                        <asp:Label ID="lblSoLuongVe" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    &nbsp;&nbsp;&nbsp; Giá vé:
                        <asp:Label ID="lblGiaVe" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Số ghế</td>
                    <td class="style1" colspan="3">
                        <asp:RadioButtonList ID="rdbSoGhe" runat="server" RepeatColumns="12" 
                            RepeatDirection="Horizontal">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<br />

<br />
<p style="text-align: center">
    <asp:Button ID="btnContinue" runat="server" Text="Tiếp tục" 
        onclick="btnContinue_Click" />
</p>


