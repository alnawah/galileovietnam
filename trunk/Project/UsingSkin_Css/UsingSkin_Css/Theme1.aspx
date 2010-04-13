<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Theme1.aspx.cs" Inherits="UsingSkin_Css.Theme1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1
        {
            height: 404px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 114px" class="content">
    
        <table align="center" style="width: 30%">
            <tr>
                <td style="width: 137px">
                    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="219px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="219px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Đăng nhập" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Hủy bỏ" Width="100px" 
                        onclick="Button2_Click" />
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    <div class="content">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Thông tin người dùng" 
        Height="119px" style="text-align: left" Width="362px">
        <table style="width: 100%; height: 96px;">
            <tr>
                <td style="width: 91px">
                    <asp:Label ID="Label3" runat="server" Text="Họ và tên"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" style="text-align: left" 
                        Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" style="text-align: left" 
                        Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <asp:Label ID="Label5" runat="server" Text="Địa chỉ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" GroupingText="Công ty" Height="84px" 
        style="text-align: left" Width="362px">
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Galileo Việt Nam" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="IFI Solution" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="HPC Hà Nội" />
    </asp:Panel>
    <br />
    </div>
    </form>
</body>
</html>
