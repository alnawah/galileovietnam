<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShipBooking.Login" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucDangNhap" TagName="login" Src="~/Controls/LoginControl.ascx" %>
<asp:Content ContentPlaceHolderID="contentplaceCenter" ID="LoginPage" runat="server">
    <ucDangNhap:login ID="LoginControl" runat="server" />
</asp:Content>
