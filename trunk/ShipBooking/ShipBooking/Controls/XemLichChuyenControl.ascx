<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="XemLichChuyenControl.ascx.cs" Inherits="ShipBooking.Controls.XemLichChuyenControl" %>
<style type="text/css">

    .step1_tblThongTinDatCho_Summary_Style
    {
        margin: auto;
        border: 1px solid #006699;
        width: 800px;
        height: auto;
    }
    .step1_table_header_style
    {
        color: #FFFFFF;
        font-weight: bold;
        font-family: Arial, Helvetica, sans-serif;
    }
    .step1_table_contain_style
    {
        border: 1px solid #006699;
    }
    .step1_tblThongTinDatCho_Detail_Style
    {
        margin: auto;
        border-style: none;
        width: 475px;
        height: auto;
    }
             .style3
             {
                 text-align: right;
                 width: 51px;
             }
             .style2
    {
        width: 181px;
    }
    
             .style4
             {
                 text-align: right;
                 width: 109px;
             }
        
    #datePicker1
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    #imgCalendar2
    {
        height: 16px;
    }
             #datePicker2
    {
        display:none;
        position:absolute;
        border:solid 2px black;
        background-color:white;
    }
    </style>
<center>
    <br />
    <asp:Image ID="Image1" runat="server" Height="59px" 
        ImageUrl="~/Images/xem_lich_chuyen.png" Width="380px" />
    <br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <table class="step1_tblThongTinDatCho_Summary_Style">
        <tr>
            <td bgcolor="#006699" class="step1_table_header_style">
                Chọn hành trình</td>
        </tr>
        <tr>
            <td class="step1_table_contain_style">
                <table class="step1_tblThongTinDatCho_Detail_Style">
                    <tr>
                        <td class="style3">
                                                    &nbsp;</td>
                        <td class="style2">
                            &nbsp;</td>
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                                                    Từ:</td>
                        <td class="style2">
                            <asp:DropDownList ID="ddlNoiDi" runat="server" Height="22px" Width="160px" 
                                AutoPostBack="true" onselectedindexchanged="ddlNoiDi_SelectedIndexChanged">
                            </asp:DropDownList>
                            </td>
                        <td class="style4">
                            Đến:</td>
                        <td>
                            
                            <asp:DropDownList ID="ddlNoiDen" runat="server" Height="22px" Width="160px" >
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            &nbsp;</td>
                        <td class="style2">
                            
                            &nbsp;</td>
                        <td class="style4">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    </table>
                </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnSearch" runat="server" Text="Xem" Width="97px" />
    <br />
</center>