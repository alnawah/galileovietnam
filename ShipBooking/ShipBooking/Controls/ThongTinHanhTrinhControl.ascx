<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongTinHanhTrinhControl.ascx.cs" Inherits="ShipBooking.Controls.ThongTinHanhTrinhControl" %>

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
</script><style type="text/css">
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
    .style2
    {
        width: 181px;
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
    #imgCalendar2
    {
        height: 16px;
    }
    </style>
<p>
    <br />
</p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Tìm kiếm hành trình</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td>
                                                &nbsp;</td>
                    <td class="style2">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="25px" 
                            RepeatDirection="Horizontal" Width="199px">
                            <asp:ListItem Value="MotLuot">Một lượt</asp:ListItem>
                            <asp:ListItem Value="KhuHoi">Khứ hồi</asp:ListItem>
                        </asp:RadioButtonList>
                        </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                                                Từ:</td>
                    <td class="style2">
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true">
                        </asp:DropDownList>
                        </td>
                    <td>
                        Ngày khởi hành:</td>
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
                    </td>
                </tr>
                <tr>
                    <td>
                        Đến:</td>
                    <td class="style2">
                        
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true">
                        </asp:DropDownList>
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
                </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" Width="100px" />
</p>

<center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3">
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="NoiDi" HeaderText="Nơi khởi hành" />
            <asp:BoundField DataField="NoiDen" HeaderText="Nơi đến" />
            <asp:BoundField DataField="MaSoTau" HeaderText="Chuyến tàu" />
            <asp:BoundField DataField="SoGhe" HeaderText="Số ghế còn trống" />
            <asp:BoundField DataField="GioKhoiHanh" HeaderText="Giờ khởi hành" />
            <asp:BoundField DataField="GioDen" HeaderText="Giờ đến" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <br />
</center>