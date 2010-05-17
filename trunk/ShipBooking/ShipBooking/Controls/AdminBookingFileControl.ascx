<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminBookingFileControl.ascx.cs" Inherits="ShipBooking.Controls.AdminBookingFileControl" %>
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
        width: 478px;
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
        width: 103px;
    }
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="55px" 
        ImageUrl="~/Images/quan_ly_booking.png" Width="362px" />
</p>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
</p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Tìm kiếm Booking file</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="style1">
                        Tìm kiếm theo:</td>
                    <td>
                        <asp:RadioButtonList ID="rblTieuChiTimKiem" runat="server" Height="22px" 
                            RepeatDirection="Horizontal" Width="357px" AutoPostBack="true" 
                            onselectedindexchanged="rblTieuChiTimKiem_SelectedIndexChanged">
                            <asp:ListItem Value="MaBF">Mã booking file</asp:ListItem>
                            <asp:ListItem Value="TenKhach">Tên khách</asp:ListItem>
                            <asp:ListItem Value="AllBooking">Tất cả các Booking</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                                                Từ khóa:</td>
                    <td>
                        &nbsp;<asp:TextBox ID="txtKeyword" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                                                Từ ngày:</td>
                    <td>
                        <asp:TextBox ID="txtNgay1" runat="server"></asp:TextBox>
                        <img id="imgCalendar1" src="~/Images/CalendarIcon.png" alt="" runat="server" 
                            onclick="displayCalendar1()" height="16" />
                        <div id="datePicker1">
                            <asp:Calendar id="calStartDate" Runat="server" 
                                BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" 
                                DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                                ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" 
                                onselectionchanged="calEventDate_SelectionChanged" >
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
                        <asp:Label ID="lblDateFormat" runat="server" Text="(mm/dd/yyyy)" 
                            Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Đến ngày:</td>
                    <td>
                        <asp:TextBox ID="txtNgay2" runat="server"></asp:TextBox>
                        <img id="imgCalendar2" src="~/Images/CalendarIcon.png" alt="" runat="server" 
                            onclick="displayCalendar2()" height="16"/>
                        <div id="datePicker2">
                            <asp:Calendar id="calEndDate" Runat="server" BackColor="#FFFFCC" 
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
                        <asp:Label ID="lblDateFormat0" runat="server" Text="(mm/dd/yyyy)" 
                            Visible="False"></asp:Label>
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" Text="Quay lại" 
        Width="97px" />
&nbsp;&nbsp;
    <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" Width="97px" 
        onclick="btnSearch_Click" />
</p>
<p style="text-align: center">
    <asp:Label ID="lblResult" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
</p>

<center>
    <asp:GridView ID="grwResult" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" Width="800px" onrowdeleting="grwResult_RowDeleting"
        EmptyDataText="Chưa có dữ liệu nào" AllowPaging="True" 
        onpageindexchanging="grwResult_PageIndexChanging" 
        onselectedindexchanged="grwResult_SelectedIndexChanged">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <Columns>
            <asp:BoundField DataField="MaBF" HeaderText="Booking ID" />
            <asp:BoundField DataField="Ten" HeaderText="Khách" />
            <asp:BoundField DataField="NoiDi" HeaderText="Nơi đi" />
            <asp:BoundField DataField="NoiDen" HeaderText="Nơi đến" />
            <asp:BoundField DataField="NgayDi" HeaderText="Ngày đi" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="NgayVe" HeaderText="Ngày về" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                DeleteText="Hủy Booking" />
            <asp:CommandField ButtonType="Button" SelectText="Chi tiết" 
                ShowSelectButton="True" />
        </Columns>
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    </asp:GridView>
    <br />
</center>




