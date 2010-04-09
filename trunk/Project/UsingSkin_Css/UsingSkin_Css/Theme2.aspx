<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Theme2.aspx.cs" Inherits="UsingSkin_Css.Theme2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" style="width: 43%">
            <tr>
                <td style="width: 131px">
                    <asp:Label ID="Label1" runat="server" Text="Họ tên"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="210px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 131px">
                    <asp:Label ID="Label2" runat="server" Text="Ngày sinh"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 131px">
                    <asp:Label ID="Label3" runat="server" Text="Quê quán"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="210px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 131px">
                    <asp:Label ID="Label4" runat="server" Text="Địa chỉ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="210px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 131px">
                    <asp:Label ID="Label5" runat="server" Text="Số điện thoại"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 131px">
                    <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="210px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
