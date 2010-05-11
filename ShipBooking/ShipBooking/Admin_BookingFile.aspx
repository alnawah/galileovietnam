<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_BookingFile.aspx.cs" Inherits="ShipBooking.Admin_BookingFile" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucAdminBF" TagName="AdminBD" Src="~/Controls/AdminBookingFileControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="Admin_Bookingfile" runat="server">
    <ucAdminBF:AdminBD ID="AdminBookingFile" runat="server" />
</asp:Content>