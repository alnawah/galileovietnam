<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThemHanhKhach.aspx.cs" Inherits="ShipBooking.ThemHanhKhach" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucThemKhach" TagName="ThemHanhKhach" Src="~/Controls/ThemHanhKhachControl.ascx"%>

<asp:Content ID="ThemHanhKhach_Content" ContentPlaceHolderID="contentplaceCenter" runat ="server">
    <ucThemKhach:ThemHanhKhach ID="themkhach" runat="server" />
</asp:Content>