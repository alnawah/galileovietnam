<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Functions.aspx.cs" Inherits="ShipBooking.Admin_Functions" MasterPageFile="~/Admin_Master.Master" %>

<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="Admin_Functions" runat="server">
    <br />
    <center>
        <asp:ImageButton ID="imgbtnQLBooking" runat="server" 
            ImageUrl="~/Images/quan_ly_booking_button.png" style="text-align: center" 
            Width="500px" onclick="imgbtnQLBooking_Click"/>
        <br />
        <asp:ImageButton ID="imgbtnQLHanhtrinh" runat="server" 
            ImageUrl="~/Images/quan_ly_hanh_trinh_button.png" style="text-align: center" 
            Width="500px" onclick="imgbtnQLHanhtrinh_Click"/>
        <br />
        <asp:ImageButton ID="imgbtnQLThanhPho" runat="server" 
            ImageUrl="~/Images/quan_ly_thanh_pho_button.png" style="text-align: center" 
            Width="500px" onclick="imgbtnQLThanhPho_Click" />
        <br />
        <asp:ImageButton ID="imgbtnQLTauThuy" runat="server" 
            ImageUrl="~/Images/quan_ly_tau_thuy_button.png" style="text-align: center" 
            Width="500px" onclick="imgbtnQLTauThuy_Click" />
    </center>
    <br />
</asp:Content>
