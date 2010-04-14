<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatVe_Step2.aspx.cs" Inherits="ShipBooking.DatVe_Step2" MasterPageFile="~/MyMaster.Master"%>
<%@ Register TagPrefix="ucDatve_Step2" TagName="booking_step2" Src="~/Controls/DatVe_Step2.ascx"  %>
<asp:Content runat="server" ID="step2" ContentPlaceHolderID="contentplaceCenter">
    <ucDatve_Step2:booking_step2 ID="buoc2" runat="server" />
</asp:Content>