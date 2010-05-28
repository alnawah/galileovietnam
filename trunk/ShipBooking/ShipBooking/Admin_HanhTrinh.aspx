<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_HanhTrinh.aspx.cs" Inherits="ShipBooking.Admin_HanhTrinh" MasterPageFile="~/Admin_Master.Master" %>
<%@ Register TagPrefix="ucAdmin_Hanhtrinh" TagName="Admin_HanhTrinh" Src="~/Controls/AdminHanhTrinhControl.ascx"%>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="Admin_HanhTrinhContent" runat="server">
    <ucAdmin_Hanhtrinh:Admin_HanhTrinh ID="Admin_HanhTrinhControl" runat="server"/>
</asp:Content>
