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
                        <asp:RadioButtonList ID="rblLoaiHanhTrinh" runat="server" Height="22px" 
                            RepeatDirection="Horizontal" Width="364px" 
                            onselectedindexchanged="rblLoaiHanhTrinh_SelectedIndexChanged" AutoPostBack="true">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                                                Từ</td>
                    <td>
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                        </asp:DropDownList>
                        &nbsp;<span class="step1_warning">(*)</span>&nbsp;&nbsp;&nbsp;&nbsp; Đến&nbsp;
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="false" onselectedindexchanged="ddlNoiDen_SelectedIndexChanged">
                        </asp:DropDownList>
                        &nbsp;<span class="step1_warning">(*)</span></td>
                </tr>
                <tr>
                    <td>
                        Ngày đi</td>
                    <td>
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
                    &nbsp;(dd/mm/yyyy) &nbsp;
                        <asp:DropDownList ID="ddlThoiGian" runat="server" Height="21px" Width="136px">
                        </asp:DropDownList>
                    &nbsp;<span class="step1_warning">(*)</span></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNgayVe" runat="server" Text="Ngày về" Visible="False"></asp:Label>
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
                        &nbsp;<asp:Label ID="lblDateFormat" runat="server" Text="(dd/mm/yyyy)" 
                            Visible="False"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox ID="chkOpen" runat="server" Text="Open" Visible="False" />
                    </td>
                </tr>
                <tr>
                    <td>
                                                Loại vé</td>
                    <td>
                        <asp:DropDownList ID="ddlLoaiVe" runat="server" Height="22px" Width="160px">
                        </asp:DropDownList>
                    &nbsp;<span class="step1_warning">(*)
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ErrorMessage="RequiredFieldValidator" ControlToValidate="ddlLoaiVe"
                        Text="Bạn phải chọn loại vé"></asp:RequiredFieldValidator>
                        </span></td>
                </tr>
                <tr>
                    <td>
                        Số ghế</td>
                    <td>
                        <asp:RadioButtonList ID="rdbSoGhe" runat="server" RepeatColumns="5" 
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
    <asp:Button ID="Button1" runat="server" Text="Tiếp tục" 
        onclick="Button1_Click1" />
</p>


