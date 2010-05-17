<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailBooking.aspx.cs" Inherits="ShipBooking.DetailBooking" MasterPageFile="~/Admin_Master.Master" %>
<%@ Register TagPrefix="ucDetailBooking" TagName="DetailBF" Src="~/Controls/AdminDetailBookingControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="Admin_Detail_Booking" runat="server">
    <ucDetailBooking:DetailBF ID="Admin_Detail_BF" runat="server" />
</asp:Content>