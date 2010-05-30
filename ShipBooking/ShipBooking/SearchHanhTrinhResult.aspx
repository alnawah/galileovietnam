<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchHanhTrinhResult.aspx.cs" Inherits="ShipBooking.SearchHanhTrinhResult" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucSearchHanhTrinhResult" TagName="SearchHanhTrinh" Src="~/Controls/SearchHanhTrinhResultControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="SearchHanhTrinhResult" runat="server">
    <ucSearchHanhTrinhResult:SearchHanhTrinh ID="Search" runat="server" />
</asp:Content>
