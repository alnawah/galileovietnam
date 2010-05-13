<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_ThanhPho.aspx.cs" Inherits="ShipBooking.Admin_ThanhPho" MasterPageFile="~/Admin_Master.Master" %>
<%@ Register TagPrefix="ucAdminThanhPho" TagName="Admin_Tp" Src="~/Controls/Admin_ThanhPhoControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="Admin_ThanhPho" runat="server">
    <ucAdminThanhPho:Admin_Tp ID="Admin_TPControl" runat="server" />
</asp:Content>