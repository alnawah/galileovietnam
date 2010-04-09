<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestDatabase._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Connect database - test</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div style="text-align: center">
            <span style="font-family: Verdana; font-size: large"><b>THÔNG TIN THÀNH VIÊN</b></span><br />
            <br />
        </div>
        <table align="center" style="width: 36%">
            <tr>
                <td style="width: 109px">
                    Họ và tên</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    Giới tính</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    Ngày sinh</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    Công ty</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    Địa chỉ</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    Số điện thoại</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 109px">
                    Email</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; height: 52px;" colspan="2">
                    <asp:Button ID="Button1" runat="server" style="text-align: center" Text="Lưu" 
        Width="109px" a/>
                </td>
            </tr>
        </table>
    
    </div>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" style="text-align: center" 
        Width="868px">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="HoTen" HeaderText="Họ tên">
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" />
            <asp:BoundField DataField="CongTy" HeaderText="Công ty">
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ">
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="SoDienThoai" HeaderText="Số điện thoại" />
            <asp:BoundField DataField="Email" HeaderText="Email">
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    </form>
</body>
</html>
