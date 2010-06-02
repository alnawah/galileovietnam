<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XemLichChuyen.aspx.cs" Inherits="ShipBooking.XemLichChuyen" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucXemLichChuyen" TagName="XemLichChuyen" Src="~/Controls/XemLichChuyenControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="XemLichChuyenContent" runat="server">
    <ucXemLichChuyen:XemLichChuyen ID="XemLichChuyenControl" runat="server" />
</asp:Content>