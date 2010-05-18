<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShipBooking._Default" MasterPageFile="~/MyMaster.Master" %>


<asp:Content ID="main" ContentPlaceHolderID="contentplaceCenter" runat="server">
    <table align="center">
        <tr>
            <td>
                <br />
                <br />
                <asp:ImageButton ID="imgbtnDatve" runat="server" ImageUrl="~/Images/dat_ve.png" 
                    Width="492px" Height="65px" style="text-align: center" 
                    onclick="Image3_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgbtnXemLichChuyen" runat="server" ImageUrl="~/Images/lich_chuyen.png" 
                    Width="492px" Height="65px" onclick="imgbtnXemLichChuyen_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgbtnTinhTrangCho" runat="server" ImageUrl="~/Images/tinh_trang_cho.png" 
                    Width="492px" Height="65px" style="text-align: center" 
                    onclick="imgbtnTinhTrangCho_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgbtnBangGiaVe" runat="server" ImageUrl="~/Images/bang_gia_ve.png" 
                    Width="492px" Height="65px" style="text-align: center" 
                    onclick="imgbtnBangGiaVe_Click" />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
