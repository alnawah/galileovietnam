<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongTinHanhTrinhControl.ascx.cs" Inherits="ShipBooking.Controls.ThongTinHanhTrinhControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
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
        width: 475px;
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
             .style3
             {
                 text-align: right;
                 width: 51px;
             }
             .style4
             {
                 text-align: right;
                 width: 109px;
             }
    </style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/tim_kiem_hanh_trinh.png" Width="515px" />
</p>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
</p>
<table class="step1_tblThongTinDatCho_Summary_Style">
    <tr>
        <td bgcolor="#006699" class="step1_table_header_style">
            Thông tin tìm kiếm</td>
    </tr>
    <tr>
        <td class="step1_table_contain_style">
            <table class="step1_tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="style3">
                                                &nbsp;</td>
                    <td class="style2">
                        <asp:RadioButtonList ID="rblLoaiHanhTrinh" runat="server" Height="22px" 
                            Width="162px" AutoPostBack="true" 
                            onselectedindexchanged="rblLoaiHanhTrinh_SelectedIndexChanged">
                        </asp:RadioButtonList>
                        </td>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                                                Từ:</td>
                    <td class="style2">
                        <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="160px" 
                            AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                        </asp:DropDownList>
                        </td>
                    <ajaxToolkit:ToolkitScriptManager runat="server" ID="ScriptManager1"  EnableScriptGlobalization="true" EnableScriptLocalization="true" />
                    <td class="style4">
                        Ngày khởi hành:</td>
                    <td>
                        <asp:TextBox ID="txtNgayDi" runat="server" Width="79px" MaxLength="1" 
                            style="text-align:justify" ValidationGroup="MKE" />
                        <asp:ImageButton ID="imgCalendar1" runat="server" ImageUrl="~/Images/CalendarIcon.png" CausesValidation="False" />
                        <ajaxtoolkit:maskededitextender ID="MaskedEditExtender1" runat="server"
                            TargetControlID="txtNgayDi"
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
                            ControlToValidate="txtNgayDi"
                            EmptyValueMessage="Date is required"
                            InvalidValueMessage="Date is invalid"
                            Display="Dynamic"
                            TooltipMessage="Input a date"
                            EmptyValueBlurredText="*"
                            InvalidValueBlurredMessage="*"
                            ValidationGroup="MKE" />
                         <ajaxtoolkit:calendarextender ID="CalendarExtender1" runat="server" 
                            TargetControlID="txtNgayDi" PopupButtonID="imgCalendar1" />
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Đến:</td>
                    <td class="style2">
                        
                        <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="160px" >
                        </asp:DropDownList>
                    </td>
                    <td class="style4">
                        <asp:Label ID="lblNgayVe" runat="server" Visible="false" Text="Ngày về:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNgayVe" runat="server" Width="79px" MaxLength="1" 
                            style="text-align:justify" ValidationGroup="MKE" Visible="False" />
                        <asp:ImageButton ID="imgCalendar2" runat="server" 
                            ImageUrl="~/Images/CalendarIcon.png" CausesValidation="False" Visible="False" />
                        <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender2" runat="server"
                            TargetControlID="txtNgayVe"
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
                            ControlToValidate="txtNgayDi"
                            EmptyValueMessage="Date is required"
                            InvalidValueMessage="Date is invalid"
                            Display="Dynamic"
                            TooltipMessage="Input a date"
                            EmptyValueBlurredText="*"
                            InvalidValueBlurredMessage="*"
                            ValidationGroup="MKE" />
                         <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtNgayVe" PopupButtonID="imgCalendar2" />
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style2">
                        
                        &nbsp;</td>
                    <td class="style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" Width="100px" 
        onclick="btnSearch_Click" style="height: 26px" />
</p>
<p style="text-align: center">
    &nbsp;</p>

