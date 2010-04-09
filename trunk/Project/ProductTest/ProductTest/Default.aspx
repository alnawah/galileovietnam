<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductTest._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <span style="font-family: Verdana; font-weight: bold; font-size: x-large">Giới 
    thiệu</span><br />
    <span style="font-family: Verdana; font-size: large">Cập nhật thông tin giới 
    thiệu<br />
    </span><br />
    <table style="width: 46%; height: 316px" align="center">
        <tr>
            <td align="left" style="width: 80px; height: 11px">
                Tiêu đề</td>
            <td align="left" style="height: 11px">
                <asp:TextBox ID="TextBox1" runat="server" Width="456px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left" style="height: 68px; width: 80px">
                Tóm tắt</td>
            <td align="left" style="height: 68px">
                <asp:TextBox ID="TextBox2" runat="server" Height="93px" TextMode="MultiLine" 
                    Width="458px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left" style="width: 80px; height: 74px">
                Nội dung</td>
            <td align="left" style="height: 74px">
                <asp:TextBox ID="TextBox3" runat="server" Height="110px" TextMode="MultiLine" 
                    Width="458px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left" style="width: 80px; height: 8px">
                Vị trí</td>
            <td align="left" style="height: 8px">
                <asp:TextBox ID="txtViTri" runat="server" Width="315px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtViTri" 
                    ErrorMessage="Vị trí phải là kiểu số" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="Ghi" runat="server" Text="Ghi" Width="70px" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" style="text-align: center" 
                    Text="Bỏ qua" Width="70px" />
                                      <asp:Label ID="lblidintro" runat="server" Text="" Visible="false"></asp:Label>
            </td>
        </tr>
    </table>
    <asp:Panel ID="panelview" runat="server" Height="51px">
                       <tr>
                       <td align="left" style="padding-bottom:3px;"><asp:LinkButton ID="btnaddnew" runat="server" Text="Thêm mới" OnClick="btnaddnew_Click" />
                           <br />
                           <br />
                           </td>
                       </tr>

                       <tr>
                        <td valign="top" align="left">
                        </td>    
                      </tr>
                      <tr>
                       <td align="right" style="padding-top:3px;">
                        <asp:Label ID="lblthongbao" runat="server"></asp:Label>
                        <asp:LinkButton ID="lbncapnhatvitri" runat="server" Text="Cập nhật vị trí" OnClick="lbncapnhatvitri_Click" />
                       </td>
                      </tr>
                      
                      </asp:Panel>
    <br />
    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" 
        Width="1044px">
        <Columns>
            <asp:BoundColumn HeaderText="STT">
                <HeaderStyle Width="50px" />
            </asp:BoundColumn>
            <asp:BoundColumn DataField="sTitle" HeaderText="Tiêu đề">
                <HeaderStyle Width="600px" />
                <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                    Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Left" />
            </asp:BoundColumn>
            <asp:TemplateColumn HeaderText="Vị trí">
                <HeaderStyle Width="150px" />
                    <ItemTemplate>
                        <asp:TextBox ID="txtVitri" runat="server" Text='<%#Eval("iPosition") %>' Width="39px" />
                    </ItemTemplate>
            </asp:TemplateColumn>
            <asp:EditCommandColumn CancelText="Cancel" EditText="Edit" 
                HeaderText="Chỉnh sửa" UpdateText="Update"></asp:EditCommandColumn>
            <asp:ButtonColumn CommandName="Delete" HeaderText="Xóa" Text="Delete">
            </asp:ButtonColumn>
        </Columns>
    </asp:DataGrid>
    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="CompanyName" 
        DataValueField="pkCompanyID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [CompanyName], [pkCompanyID], [Address] FROM [Company]">
    </asp:SqlDataSource>
    </form>
</body>
</html>
