<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminTauControl.ascx.cs" Inherits="ShipBooking.Controls.AdminTauControl" %>
<style type="text/css">


    .tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 800px;
        height: auto;
    }
    .table_header_style
    {
        color: #FFFFFF;
        font-weight: bold;
        font-family: Arial, Helvetica, sans-serif;
    }
    .table_contain_style
    {
        border: 1px solid #006699;
        text-align: center;
    }
    .tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        width: 781px;
        height: auto;
    }
    .ThongTinDatCho_Title_1
    {
        width: 100px;
        text-align: right;
    }
    .ThongTinDatCho_Detail
    {
        width: 200px;
        text-align: left;
    }
    .style2
    {
        width: 249px;
        text-align: right;
    }
    .style3
    {
        width: 398px;
        text-align: left;
    }
</style>
<p style="text-align: center">
    <asp:Image ID="Image1" runat="server" Height="55px" 
        ImageUrl="~/Images/quan_ly_tau_thuy.png" Width="362px" />
</p>
<p style="text-align: center">
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
</p>
<table class="tblThongTinDatCho_Summary_Style" align="center">
    <tr>
        <td bgcolor="#006699" class="table_header_style">
            Thông tin tàu thủy</td>
    </tr>
    <tr>
        <td class="table_contain_style">
            <table class="tblThongTinDatCho_Detail_Style">
                <tr>
                    <td class="style2">
                        Mã số tàu: </td>
                    <td class="style3">
                        <asp:TextBox ID="txtMaSoTau" runat="server"></asp:TextBox>
                    </td>
                    <td class="ThongTinDatCho_Detail">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                        Tên tàu: </td>
                    <td class="style3" align="right">
                        <asp:TextBox ID="txtTenTau" runat="server"></asp:TextBox>
                    </td>
                    <td class="ThongTinDatCho_Detail" align="right">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                        Số ghế: </td>
                    <td class="style3" align="right">
                        <asp:TextBox ID="txtSoGhe" runat="server"></asp:TextBox>
                    </td>
                    <td class="ThongTinDatCho_Detail" align="right">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                        Thông tin khác: </td>
                    <td class="style3" align="right">
                        <asp:TextBox ID="txtThongTinKhac" runat="server" Height="62px" Width="337px" 
                            TextMode="MultiLine" Font-Names="Arial" Wrap="False"></asp:TextBox>
                    </td>
                    <td class="ThongTinDatCho_Detail" align="right">
                        &nbsp;</td>
                </tr>
                </table>
            </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="btnNew" runat="server" onclick="btnNew_Click" Text="Thêm mới" 
        Width="79px" />
&nbsp;&nbsp;
    <asp:Button ID="btnEdit" runat="server" Text="Sửa" 
        Width="79px" onclick="btnEdit_Click" />
&nbsp;&nbsp;
    <asp:Button ID="btnSave" runat="server" Text="Lưu" Width="79px" 
        onclick="btnSave_Click" />
</p>

<center>
    <asp:GridView ID="grvTau" runat="server" AutoGenerateColumns="False" 
        EmptyDataText="Chưa có dữ liệu nào" AllowPaging="True"
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" Width="800px" 
        onselectedindexchanged="grvTau_SelectedIndexChanged" 
        onpageindexchanged="grvTau_PageIndexChanged" 
        onpageindexchanging="grvTau_PageIndexChanging" 
        onrowdeleted="grvTau_RowDeleted" onrowdeleting="grvTau_RowDeleting">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <RowStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundField DataField="MaSoTau" HeaderText="Mã số tàu" />
            <asp:BoundField DataField="Ten" HeaderText="Tên tàu" />
            <asp:BoundField DataField="SoGhe" HeaderText="Số ghế" />
            <asp:BoundField DataField="ThongTin" HeaderText="Thông tin khác" />
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
        </Columns>
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</center>
    
<p>
    &nbsp;</p>




