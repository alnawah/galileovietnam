<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Functions.aspx.cs" Inherits="ShipBooking.Admin_Functions" MasterPageFile="~/Admin_Master.Master" %>

<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="Admin_Functions" runat="server">

    <p style="text-align: center">
        <br />
        &nbsp;&nbsp;
        </p>
    <p style="text-align: center">
        <asp:ImageButton ID="imgbtnQLBooking" runat="server" 
            ImageUrl="~/Images/admin_quan_ly_booking.png" style="text-align: center" 
            Width="500px" onclick="imgbtnQLBooking_Click"/>
    </p>
    <p style="text-align: center">
        <asp:ImageButton ID="imgbtnQLHanhtrinh" runat="server" 
            ImageUrl="~/Images/admin_quan_ly_hanhtrinh.png" style="text-align: center" 
            Width="500px" onclick="imgbtnQLHanhtrinh_Click"/>
    </p>
    <p style="text-align: center">
        &nbsp;</p>
    <p style="text-align: center">
        &nbsp;</p>
    
</asp:Content>
