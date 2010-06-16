<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminBookingFileControl.ascx.cs" Inherits="ShipBooking.Controls.AdminBookingFileControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
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
                            RepeatDirection="Horizontal" Width="283px" AutoPostBack="true" 
                            onselectedindexchanged="rblTieuChiTimKiem_SelectedIndexChanged">
                            <asp:ListItem Value="MaBF">Mã booking file</asp:ListItem>
                            <asp:ListItem Value="TenKhach">Tên khách</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                                                Từ khóa:</td>
                    <td>
                        <asp:TextBox ID="txtKeyword" runat="server" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <ajaxToolkit:ToolkitScriptManager runat="server" ID="ScriptManager1"  EnableScriptGlobalization="true" EnableScriptLocalization="true" />
                    <td class="style1">
                                                Từ ngày:</td>
                    <td>
                        <asp:TextBox ID="txtNgay1" runat="server" Width="79px"></asp:TextBox>
                        <asp:ImageButton ID="btnImgCal1" runat="server" ImageUrl="~/Images/CalendarIcon.png" CausesValidation="false" />
                         <ajaxtoolkit:maskededitextender ID="MaskedEditExtender1" runat="server"
                            TargetControlID="txtNgay1"
                            Mask="99/99/9999"
                            MessageValidatorTip="true"
                            OnFocusCssClass="MaskedEditFocus"
                            OnInvalidCssClass="MaskedEditError"
                            MaskType="Date"
                            DisplayMoney="Left"
                            AcceptNegative="Left"
                            ErrorTooltipEnabled="True" />
                        <ajaxtoolkit:maskededitvalidator ID="MaskedEditValidator1" runat="server"
                            ControlExtender="MaskedEditExtender1"
                            ControlToValidate="txtNgay1"
                            EmptyValueMessage="Date is required"
                            InvalidValueMessage="Date is invalid"
                            Display="Dynamic"
                            TooltipMessage="Input a date"
                            EmptyValueBlurredText="*"
                            InvalidValueBlurredMessage="*"
                            ValidationGroup="MKE" />
                         <ajaxtoolkit:calendarextender ID="CalendarExtender1" runat="server" 
                            TargetControlID="txtNgay1" PopupButtonID="btnImgCal1" />
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Đến ngày:</td>
                    <td>
                        <asp:TextBox ID="txtNgay2" runat="server" Width="79px"></asp:TextBox>
                        <asp:ImageButton ID="btnImgCal2" runat="server" ImageUrl="~/Images/CalendarIcon.png" CausesValidation="false" />
                         <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender2" runat="server"
                            TargetControlID="txtNgay2"
                            Mask="99/99/9999"
                            MessageValidatorTip="true"
                            OnFocusCssClass="MaskedEditFocus"
                            OnInvalidCssClass="MaskedEditError"
                            MaskType="Date"
                            DisplayMoney="Left"
                            AcceptNegative="Left"
                            ErrorTooltipEnabled="True" />
                        <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator2" runat="server"
                            ControlExtender="MaskedEditExtender2"
                            ControlToValidate="txtNgay2"
                            EmptyValueMessage="Date is required"
                            InvalidValueMessage="Date is invalid"
                            Display="Dynamic"
                            TooltipMessage="Input a date"
                            EmptyValueBlurredText="*"
                            InvalidValueBlurredMessage="*"
                            ValidationGroup="MKE" />
                         <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtNgay2" PopupButtonID="btnImgCal2" />
                    </td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" Text="Quay lại" 
        Width="97px" Height="28px" Visible="false" />
&nbsp;&nbsp;
    <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" Width="97px" 
        onclick="btnSearch_Click" Height="28px" />
&nbsp;&nbsp;
    <asp:Button ID="btnAllBooking" runat="server" Text="Tất cả các Booking" 
        Width="128px" Height="28px" onclick="btnAllBooking_Click" />
</p>
<p style="text-align: center">
    <asp:Label ID="lblResult" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
</p>

<center>
    <asp:GridView ID="grwResult" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" Width="800px" onrowdeleting="grwResult_RowDeleting"
        EmptyDataText="Chưa có dữ liệu nào"
        onpageindexchanging="grwResult_PageIndexChanging" 
        onselectedindexchanged="grwResult_SelectedIndexChanged" PageSize="100">
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
                DeleteText="Hủy Booking" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
            <asp:CommandField ButtonType="Button" SelectText="Chi tiết" 
                ShowSelectButton="True" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    </asp:GridView>
    <asp:GridView ID="grwResultAllBF" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" Width="800px" EmptyDataText="Chưa có dữ liệu nào"
        PageSize="100" onrowdeleting="grwResultAllBF_RowDeleting" 
        onselectedindexchanged="grwResultAllBF_SelectedIndexChanged">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <Columns>
            <asp:BoundField DataField="MaBF" HeaderText="Booking ID" />
            <asp:BoundField DataField="NoiDi" HeaderText="Nơi đi" />
            <asp:BoundField DataField="NoiDen" HeaderText="Nơi đến" />
            <asp:BoundField DataField="NgayDi" HeaderText="Ngày đi" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="NgayVe" HeaderText="Ngày về" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                DeleteText="Hủy Booking" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
            <asp:CommandField ButtonType="Button" SelectText="Chi tiết" 
                ShowSelectButton="True" >
                <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    </asp:GridView>
    <br />
</center>




    
    




