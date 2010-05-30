<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookingSep1.aspx.cs" Inherits="ShipBooking.BookingSep1" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucBookingStep1" TagName="BookingStep1Control" Src="~/Controls/BookingStep1Control.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="BookingStep1" runat="server">
    <ucBookingStep1:BookingStep1Control ID="BS1Control" runat="server" />
</asp:Content>