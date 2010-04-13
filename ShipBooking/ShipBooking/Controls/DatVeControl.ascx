<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatVeControl.ascx.cs" Inherits="ShipBooking.Controls.DatVeControl" %>

<form name="BOOKINGFORM">
<table border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" valign="top">
            <table border="1" bordercolor="#3980f4" cellpadding="0" cellspacing="1" 
                width="94%">
                <tr>
                    <td bgcolor="#3980f4">
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td width="49%">
                                    <font face="Verdana, Arial, Helvetica, sans-serif"><b><font color="#ffffff">Giữ chỗ vé tàu</font></b></font></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center" valign="top">
                        <table border="0" cellpadding="1" cellspacing="2" width="93%">
                            <tr>
                                <td align="center" height="8" width="23%">
                                    <div align="right">
                                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Khứ hồi" />
                                    </div>
                                </td>
                                <td height="8" width="77%">
                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <td width="37%">
                                                <div align="right">
                                                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Một lượt" />
                                                </div>
                                            </td>
                                            <td width="63%">
                                                <div align="center">
                                                    <asp:RadioButton ID="RadioButton3" runat="server" Text="Khứ hồi" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td width="23%">
                                    <font>Từ:</font></td>
                                <td width="77%">
                                    <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="169px">
                                    </asp:DropDownList> 
                                    <font color="#ff0000">&nbsp;(*)</font>
                                    <font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Đến:&nbsp;&nbsp;&nbsp;&nbsp;</font>
                                     <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" Width="169px">
                                    </asp:DropDownList>
                                    <font color="#ff0000">&nbsp;(*)</font>
                                </td>
                            </tr>
                            <tr>
                                <td width="23%"><font>Ngày đi:</font></td>
                                <td width="77%">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/Images/CalendarIcon.png" />
                                    <font face="Arial, Helvetica, sans-serif" size="1">(mm/dd/yyyy) &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:DropDownList ID="DropDownList3" runat="server" Height="24px" Width="169px">
                                    </asp:DropDownList>
                                    <font color="#ff0000">&nbsp;(*)</font>
                                </td>
                            </tr>
                            <tr>
                                <td width="23%">
                                    <font>Ngày về:</font></td>
                                <td width="77%">
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    <asp:ImageButton ID="ImageButton2" runat="server" 
                                        ImageUrl="~/Images/CalendarIcon.png" />
                                    <font face="Arial, Helvetica, sans-serif" size="1">(mm/dd/yyyy) &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Open" />
                            </tr>
                            <tr>
                                <td width="23%">
                                    <font>Loại vé:</font></td>
                                <td width="77%">
                                    <asp:DropDownList ID="DropDownList4" runat="server" Height="22px" Width="169px">
                                    </asp:DropDownList> &nbsp;<font color="#ff0000">(*)</font>
                                </td>
                            </tr>
                            <tr>
                                <td width="23%">
                                    &nbsp;</td>
                                <td width="77%">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="center">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" valign="top">
            <table border="1" bordercolor="#3980f4" cellpadding="0" cellspacing="1" 
                width="94%">
                <tr>
                    <td bgcolor="#3980f4">
                        <font face="Verdana, Arial, Helvetica, sans-serif"><b><font color="#ffffff">
                        Thông tin về hành khách</font></b></font></td>
                </tr>
                <tr>
                    <td align="center">
                        <table border="0" cellpadding="1" cellspacing="1" width="93%">
                            <tr>
                                <td width="21%">
                                    <font>Họ và tên:</font></td>
                                <td width="79%">
                                    <asp:TextBox ID="TextBox3" runat="server" Width="345px"></asp:TextBox>
                                    &nbsp;<font color="#ff0000">(*)</font>
                                </td>
                            </tr>
                            <tr>
                                <td bordercolor="#3980F4" width="21%">
                                    <font>Địa chỉ:</font></td>
                                <td width="79%">
                                    <asp:TextBox ID="TextBox4" runat="server" Height="101px" TextMode="MultiLine" 
                                        Width="345px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td width="21%">
                                    <font>Quốc tịch:</font></td>
                                <td width="79%">
                                    <asp:DropDownList ID="DropDownList5" runat="server" Height="22px" Width="138px"></asp:DropDownList> 
                                    <font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Độ tuổi</font>: &nbsp;&nbsp;
                                    <asp:DropDownList ID="DropDownList6" runat="server" Height="22px" Width="138px"></asp:DropDownList> 
                                    <font color="#ff0000">(*)</font>
                                </td>
                            </tr>
                            <tr>
                                <td width="21%">
                                    <font>Số điện thoại:</font></td>
                                <td width="79%">
                                    <font>
                                    <asp:TextBox ID="TextBox8" runat="server" Width="133px"></asp:TextBox>
                                    &nbsp;&nbsp;&nbsp;Số nội bộ:&nbsp;</font>
                                    <asp:TextBox ID="TextBox6" runat="server" Width="133px"></asp:TextBox>
                                    <font color="#ff0000">(*)</font>
                                </td>
                            </tr>
                            <tr>
                                <td width="21%">
                                    <font>Email:</font></td>
                                <td width="79%">
                                    <asp:TextBox ID="TextBox7" runat="server" Width="345px"></asp:TextBox>
                                    <font color="#ff0000">(*)</font>
                                </td>
                            </tr>
                            <tr>
                                <td width="21%">
                                    &nbsp;</td>
                                <td width="79%">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td align="center">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center">
            <asp:Button ID="Button1" runat="server" Text="Tiếp tục" />
        </td>
    </tr>
    <tr>
        <td align="center">
            &nbsp;</td>
    </tr>
</table>
</form>
