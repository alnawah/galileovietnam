<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchHotelPriceControl.ascx.cs" Inherits="SearchHotelPrice.Controls.SearchHotelPriceControl" %>
<style type="text/css">
    .style1
    {
        width: 400px;
    }
    .style2
    {
        width: 120px;
    }
    .style3
    {
        width: 120px;
    }
</style>
<table class="style1">
    <tr>
        <td class="style2">
            Client ID</td>
        <td>
            <asp:TextBox ID="txtClientID" runat="server" Width="179px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Email Address</td>
        <td>
            <asp:TextBox ID="txtClientEmail" runat="server" Width="240px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Password</td>
        <td>
            <asp:TextBox ID="txtClientPassword" runat="server" TextMode="Password" 
                Width="179px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Language</td>
        <td>
            <asp:TextBox ID="txtClientLanguage" runat="server" Width="179px"></asp:TextBox>
        </td>
    </tr>
</table>
<p>
    &nbsp;</p>
<table class="style1">
    <tr>
        <td class="style3">
            City Code</td>
        <td>
            <asp:TextBox ID="txtDestinationCode" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Check in date</td>
        <td>
            <asp:TextBox ID="txtCheckInDate" runat="server"></asp:TextBox>
        &nbsp;(yyyy-mm-dd)</td>
    </tr>
    <tr>
        <td class="style3">
            Check out date</td>
        <td>
            <asp:TextBox ID="txtCheckOutDate" runat="server"></asp:TextBox>
        &nbsp;(yyyy-mm-dd)</td>
    </tr>
    <tr>
        <td class="style3">
            Room type</td>
        <td>
            <asp:TextBox ID="txtRoomType" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Number of room</td>
        <td>
            <asp:TextBox ID="txtNumOfRoom" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<p style="text-align: center">
    <asp:Button ID="btnSearch" runat="server" Text="Search" 
        onclick="btnSearch_Click" />
</p>
