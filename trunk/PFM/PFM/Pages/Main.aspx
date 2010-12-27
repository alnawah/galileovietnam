<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="PFM.Pages.Main" MasterPageFile="~/PFMMasterPage.Master" %>
<%@ Register TagPrefix="ucMainForm" TagName="mainForm" Src="~/Controls/MainFormControl.ascx" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolderCenter" ID="LoginPage" runat="server">
    <ucMainForm:mainForm ID="ucMainForm" runat="server" />
</asp:Content>
