<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Functions.aspx.cs" Inherits="ShipBooking.Admin_Functions" MasterPageFile="~/MyMaster.Master" %>

<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="Admin_Functions" runat="server">

    <p style="text-align: center">
        <br />
        <asp:Button ID="btnAdminBF" runat="server" Text="Quản lý thông tin đặt chỗ" 
            onclick="btnAdminBF_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="btnAdminSegment" runat="server" 
            Text="Quản lý thông tin hành trình" onclick="btnAdminSegment_Click" />
    </p>
    <p style="text-align: center">
        &nbsp;</p>

</asp:Content>
