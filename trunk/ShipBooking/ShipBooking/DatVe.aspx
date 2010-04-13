<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatVe.aspx.cs" Inherits="ShipBooking.DatVe" MasterPageFile="~/MyMaster.Master" %>
<%@ Register TagPrefix="ucDatve" TagName="DatVe" Src="~/Controls/DatVeControl.ascx" %>
<asp:Content ID="contenDatVe" ContentPlaceHolderID="contentplaceCenter" runat="server">
    <ucDatve:DatVe ID="main" runat="server" />
</asp:Content>