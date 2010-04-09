<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LeisureDemo._Default" EnableTheming="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Galileo Leisure Demo</title>
    <link href="App_Themes/simple/LandingPage.css" rel="stylesheet" type="text/css">
    <style type="text/css">
        .LandingPage
        {
            height: 513px;
            width: 809px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="LandingPage">
            <asp:Label ID="Label1" runat="server" 
            style="font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #99CCFF" 
            Text="Please select the country where your agency located"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="326px" 
                style="text-align: left">
            </asp:DropDownList>
        </div>  
    </div>
    <br />
    <img src="images/mb.jpg" width="30" height="27" align="absmiddle">
<span class="style32">
    <span class="style34">
        <a href="GCornerRegisterationForm.doc" onMouseOver="return escape('Bạn tải mẫu đăng ký thành viên này. Sau khi điền đủ thông tin xin email về địa chỉ apus@galileovietnam.com')">
        &nbsp;&#272;&#259;ng k&yacute; thành vi&ecirc;n</a>
    </span>
</span>
    <p>
<span class="style32">
    <span class="style34">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </span>
</span>
    </p>
    </form>
</body>
</html>
