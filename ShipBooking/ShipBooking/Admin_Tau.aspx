<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Tau.aspx.cs" Inherits="ShipBooking.Admin_Tau" MasterPageFile="~/Admin_Master.Master" %>
<%@ Register TagPrefix="ucAdminTauControl" TagName="AdminTauControl" Src="~/Controls/AdminTauControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="admin_tauthuy" runat="server">
    <ucAdminTauControl:AdminTauControl ID="AdminTau" runat="server" />
</asp:Content>