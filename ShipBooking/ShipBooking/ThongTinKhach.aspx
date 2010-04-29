<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinKhach.aspx.cs" Inherits="ShipBooking.ThongTinKhach" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucThongTinKhach" TagName="ThongTinKhachControl" Src="~/Controls/ThongTinKhachControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="ThongTinHanhKhach" runat="server">
    <ucThongTinKhach:ThongTinKhachControl ID="TTKhach" runat="server" />
</asp:Content>