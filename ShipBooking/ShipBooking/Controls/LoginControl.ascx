<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="ShipBooking.Controls.LoginControl" %>
<style type="text/css">
    .login_style
    {
        border: 1px solid #0000FF;
        width: 300px;
    }
    .style1
    {
        color: #FFFFCC;
        font-weight: bold;
    }
    .style2
    {
        width: 146px;
    }
    .style3
    {
        width: 66px;
    }
</style>

<center>
    <br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <br />
<table class="login_style">
    <tr>
        <td bgcolor="Blue" class="style1" colspan="2">
            Đăng nhập</td>
    </tr>
    <tr>
        <td class="style3">
            User name</td>
        <td class="style2">
            <asp:TextBox ID="txtUserName" runat="server" Width="174px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Password</td>
        <td class="style2">
            <asp:TextBox ID="txtPassword" runat="server" Width="174px" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
</table>
</center>
<p style="text-align: center">
    <asp:Button ID="Button1" runat="server" Text="Login" Width="84px" 
        onclick="Button1_Click" Height="26px" />
</p>
<p style="text-align: center">
    &nbsp;</p>

    


