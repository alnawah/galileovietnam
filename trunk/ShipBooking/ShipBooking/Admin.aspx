<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ShipBooking.Admin" MasterPageFile="~/Admin_Master.Master" %>
<%@ Register TagPrefix="ucAdmin" TagName="adminControl" Src="~/Controls/AdminControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID ="AdminPage" runat="server">
    <ucAdmin:adminControl ID="AdminControl" runat="server" />
</asp:Content>