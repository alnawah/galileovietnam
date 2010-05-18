<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinHanhTrinh.aspx.cs" Inherits="ShipBooking.ThongTinHanhTrinh" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucThongTinHanhTrinh" TagName="TTHanhTrinh" Src="~/Controls/ThongTinHanhTrinhControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="ThongTinHanhTrinh" runat="server">
    <ucThongTinHanhTrinh:TTHanhTrinh ID="HanhTrinhInfo" runat="server" />
</asp:Content>