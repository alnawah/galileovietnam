<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SearchHotelPrice._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register TagPrefix="ucSearchHotelPrice" TagName="SearchHotelPrice" Src="~/Controls/SearchHotelPriceControl.ascx" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <ucSearchHotelPrice:SearchHotelPrice ID="SearchHotelPriceControl" runat="server" />
        </center>
        <asp:TreeView ID="treeViewRequest" runat="server" 
            DataSourceID="SearchHotelPrice_XmlDataSource" 
            onselectednodechanged="treeViewRequest_SelectedNodeChanged" >
        </asp:TreeView>
        <asp:XmlDataSource ID="SearchHotelPrice_XmlDataSource" runat="server" 
            DataFile="~/XMLFile1.xml"></asp:XmlDataSource>
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
