<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatVeControl.ascx.cs" Inherits="ShipBooking.Controls.DatVeControl" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style4
    {
    }
    .style14
    {
        width: 176px;
    }
    .style15
    {
        width: 63px;
    }
    .style16
    {
        width: 198px;
    }
    .style17
    {
        width: 167px;
    }
    .style18
    {
        width: 92px;
    }
    .style20
    {
        width: 86px;
    }
    .style23
    {
        width: 178px;
    }
    .style24
    {
        width: 179px;
    }
    .style25
    {
        width: 117px;
    }
    .style28
    {
    }
    .style30
    {
        width: 77px;
    }
    .style31
    {
        width: 267px;
    }
</style>
<table class="style1">
    <tr>
        <td class="style23">
        </td>
        <td class="style20">
        </td>
        <td class="style4" colspan="6">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem Value="KhuHoi">Khứ hồi</asp:ListItem>
                <asp:ListItem Value="MotLuot">Một lượt</asp:ListItem>
                <asp:ListItem Value="NhieuLuot">Nhiều lượt</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td class="style23">
            &nbsp;</td>
        <td class="style20">
            Từ</td>
        <td class="style14">
            <asp:DropDownList ID="DropDownList1" runat="server" Width="220px">
            </asp:DropDownList>
        </td>
        <td class="style15">
            (*)</td>
        <td class="style18">
            Đến</td>
        <td class="style17">
            <asp:DropDownList ID="DropDownList2" runat="server" Width="220px">
            </asp:DropDownList>
        </td>
        <td class="style16">
            (*)</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style23">
            &nbsp;</td>
        <td class="style20">
            Ngày đi</td>
        <td class="style14">
            <asp:TextBox ID="TextBox1" runat="server" Width="220px"></asp:TextBox>
        </td>
        <td class="style15">
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </td>
        <td class="style18">
            (mm/dd/yyyy)</td>
        <td class="style17">
            <asp:DropDownList ID="DropDownList4" runat="server" Width="126px" Height="17px">
            </asp:DropDownList>
        </td>
        <td class="style16">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style23">
            &nbsp;</td>
        <td class="style20">
            Ngày về</td>
        <td class="style14">
            <asp:TextBox ID="TextBox2" runat="server" Width="220px"></asp:TextBox>
        </td>
        <td class="style15">
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </td>
        <td class="style18">
            (mm/dd/yyyy)</td>
        <td class="style17">
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </td>
        <td class="style16">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style23">
            &nbsp;</td>
        <td class="style20">
            Loại vé</td>
        <td class="style14">
            <asp:DropDownList ID="DropDownList3" runat="server" Width="220px">
            </asp:DropDownList>
        </td>
        <td class="style15">
            (*)</td>
        <td class="style18">
            &nbsp;</td>
        <td class="style17">
            &nbsp;</td>
        <td class="style16">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

<p>
    &nbsp;</p>
<table class="style1">
    <tr>
        <td class="style24">
            &nbsp;</td>
        <td class="style25">
            Họ và tên</td>
        <td class="style31">
            <asp:TextBox ID="TextBox3" runat="server" Width="266px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style24">
            &nbsp;</td>
        <td class="style25">
            Địa chỉ</td>
        <td colspan="3">
            <asp:TextBox ID="TextBox4" runat="server" Height="122px" Width="266px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style24">
            &nbsp;</td>
        <td class="style25">
            Quốc tịch</td>
        <td class="style31">
            <asp:DropDownList ID="DropDownList5" runat="server" Height="16px" Width="200px">
            </asp:DropDownList>
        </td>
        <td class="style30">
            Độ tuổi</td>
        <td>
            <asp:DropDownList ID="DropDownList6" runat="server" Height="16px" Width="200px">
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style24">
            &nbsp;</td>
        <td class="style25">
            Số điện thoại</td>
        <td class="style31">
            <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
        </td>
        <td class="style30">
            Số nội bộ</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Height="22px" Width="200px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style24">
            &nbsp;</td>
        <td class="style25">
            Email</td>
        <td class="style28" colspan="2">
            <asp:TextBox ID="TextBox7" runat="server" Height="22px" Width="344px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
<table class="style1">
    <tr>
        <td>
            <asp:Button ID="Button3" runat="server" style="text-align: center" 
                Text="Button" />
        </td>
    </tr>
</table>


