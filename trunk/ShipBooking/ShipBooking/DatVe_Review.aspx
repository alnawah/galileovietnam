<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatVe_Review.aspx.cs" Inherits="ShipBooking.DatVe_Review" MasterPageFile="~/MyMaster.Master"%>
<%@ Register TagPrefix="ucDatVe_Review" TagName="DatVe_Review" Src="~/Controls/DatVeReviewControl.ascx"%>
<asp:Content ID="datve_review" ContentPlaceHolderID="contentplaceCenter" runat="server">
    <ucDatVe_Review:DatVe_Review ID="datve_hoantat" runat="server" />
</asp:Content>
