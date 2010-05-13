<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Admin_ThanhPhoControl.ascx.cs" Inherits="ShipBooking.Controls.Admin_ThanhPhoControl" %>
<style type="text/css">
    .style1
    {
        width: 34%;
    }
</style>
<p style="text-align: center">
    &nbsp;</p>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
</p>

<center>
    <table class="style1">
        <tr>
            <td>
                Mã thành phố (tỉnh)</td>
            <td>
                <asp:TextBox ID="txtMaTP" runat="server" Width="166px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Tên thành phố (tỉnh)</td>
            <td>
                <asp:TextBox ID="txtTenTP" runat="server" Width="166px"></asp:TextBox>
            </td>
        </tr>
    </table>
</center>

<p style="text-align: center">
    <asp:Button ID="btnNew" runat="server" Text="Thêm" Width="79px" 
        onclick="btnNew_Click"/>
    &nbsp;&nbsp;
    <asp:Button ID="btnEdit" runat="server" Text="Sửa" Width="79px" 
        onclick="btnEdit_Click" />
    &nbsp;&nbsp;
    <asp:Button ID="btnSave" runat="server" Text="Lưu" Width="79px" 
        onclick="btnSave_Click" />
</p>

<center>
    <asp:GridView ID="grvThanhPho" runat="server" AutoGenerateColumns="False" 
        EmptyDataText="Chưa có dữ liệu nào" AllowPaging="True"
        BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" Width="478px" 
        onpageindexchanging="grvThanhPho_PageIndexChanging" 
        onrowdeleting="grvThanhPho_RowDeleting" 
        onselectedindexchanged="grvThanhPho_SelectedIndexChanged">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <Columns>
            <asp:BoundField DataField="MaThanhPho" HeaderText="Mã thành phố" />
            <asp:BoundField DataField="Ten" HeaderText="Tên thành phố" />
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
        </Columns>
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    </asp:GridView>
    <br />
</center>
