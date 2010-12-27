<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainFormControl.ascx.cs" Inherits="PFM.Controls.MainFormControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<link rel="stylesheet" href="../App_Themes/Standard/Standard.css" type="text/css" />



<input id="Text1" type="text" />

<ajaxtoolkit:ToolkitScriptManager ID="ToolkitScriptManager2" runat="server"/>


    
<ajaxtoolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
    Width="300px" Height="200px">
    <ajaxtoolkit:TabPanel runat="server" HeaderText="Thu" ID="TabPanel1">
        <ContentTemplate>
            <center>
                <table class="table_control">
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label5" runat="server" Text="Tên khoản:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label6" runat="server" Text="Ngày chi:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNgayThu" runat="server" Width="79px" MaxLength="1" style="text-align:justify" ValidationGroup="MKE" />
                            <asp:ImageButton ID="imgCalendarNgayThu" runat="server" ImageUrl="~/Images/CalendarIcon.png" CausesValidation="False" />
                            <ajaxtoolkit:maskededitextender ID="MaskedEditExtenderNgayThu" runat="server"
                                TargetControlID="txtNgayThu"
                                Mask="99/99/9999"
                                MaskType="Date"
                                DisplayMoney="Left"
                                AcceptNegative="Left"
                                ErrorTooltipEnabled="True" CultureAMPMPlaceholder="" 
                                CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                                CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" />
                            <ajaxtoolkit:maskededitvalidator ID="MaskedEditValidatorNgayThu" runat="server"
                                ControlExtender="MaskedEditExtenderNgayThu"
                                ControlToValidate="txtNgayThu"
                                EmptyValueMessage="Date is required"
                                InvalidValueMessage="Date is invalid"
                                Display="Dynamic"
                                TooltipMessage="Input a date"
                                EmptyValueBlurredText="*"
                                InvalidValueBlurredMessage="*"
                                ValidationGroup="MKE" ErrorMessage="MaskedEditValidatorNgayThu" />
                            <ajaxtoolkit:calendarextender ID="CalendarExtenderNgayThu" runat="server" 
                                TargetControlID="txtNgayThu" PopupButtonID="imgCalendarNgayThu" Enabled="True" />
                        </td>
                    </tr>
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label7" runat="server" Text="Số tiền:"></asp:Label>
                        </td>
                        <td style="margin-left: 80px">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label8" runat="server" Text="Ghi chú:"></asp:Label>
                        </td>
                        <td style="margin-left: 80px">
                            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Height="90px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </center>
        </ContentTemplate>
    </ajaxtoolkit:TabPanel>
    <ajaxtoolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="Chi">
        <ContentTemplate>
            <center>
                <table class="table_control">
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label1" runat="server" Text="Tên khoản:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtKhoanChi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label2" runat="server" Text="Ngày chi:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNgayChi" runat="server" Width="79px" MaxLength="1" style="text-align:justify" ValidationGroup="MKE" />
                            <asp:ImageButton ID="imgCalendarNgayChi" runat="server" ImageUrl="~/Images/CalendarIcon.png" CausesValidation="False" />
                            <ajaxtoolkit:maskededitextender ID="MaskedEditExtenderNgayChi" runat="server"
                                TargetControlID="txtNgayChi"
                                Mask="99/99/9999"
                                MaskType="Date"
                                DisplayMoney="Left"
                                AcceptNegative="Left"
                                ErrorTooltipEnabled="True" CultureAMPMPlaceholder="" 
                                CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                                CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                                CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" />
                            <ajaxtoolkit:maskededitvalidator ID="MaskedEditValidatorNgayChi" runat="server"
                                ControlExtender="MaskedEditExtenderNgayChi"
                                ControlToValidate="txtNgayChi"
                                EmptyValueMessage="Date is required"
                                InvalidValueMessage="Date is invalid"
                                Display="Dynamic"
                                TooltipMessage="Input a date"
                                EmptyValueBlurredText="*"
                                InvalidValueBlurredMessage="*"
                                ValidationGroup="MKE" ErrorMessage="MaskedEditValidatorNgayChi" />
                            <ajaxtoolkit:calendarextender ID="CalendarExtenderNgayChi" runat="server" 
                                TargetControlID="txtNgayChi" PopupButtonID="imgCalendarNgayChi" Enabled="True" />
                        </td>
                    </tr>
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label3" runat="server" Text="Số tiền:"></asp:Label>
                        </td>
                        <td style="margin-left: 80px">
                            <asp:TextBox ID="txtSoTienChi" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="col_label">
                            <asp:Label ID="Label4" runat="server" Text="Ghi chú:"></asp:Label>
                        </td>
                        <td style="margin-left: 80px">
                            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="90px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </center>
        </ContentTemplate>
    </ajaxtoolkit:TabPanel>
</ajaxtoolkit:TabContainer>
<ajaxtoolkit:DropShadowExtender ID="TabContainer1_DropShadowExtender" 
    runat="server" Enabled="True" TargetControlID="TabContainer1">
</ajaxtoolkit:DropShadowExtender>