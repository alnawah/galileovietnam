<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestSkin.aspx.cs" Inherits="StudyWebMaster.TestSkin" Theme="simple" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Using theme</title>
</head>
<body style="background-color:#e5e5e5;">
    <form id="form1" runat="server">
    <div>
        <h3>Skin tới điều khiển được chỉ định</h3>
        <asp:TextBox ID="txtChiDinh" SkinID="txtChidinh" runat="server"></asp:TextBox>
        <h3>Skin mặc định cho điều khiển TextBox</h3>
        <asp:TextBox ID="txtMacDinh" runat="server"></asp:TextBox>
        <h3>Không áp dụng Skin mặc định</h3>
        <asp:TextBox ID="txtNone" runat="server" EnableTheming="false"></asp:TextBox>
        
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Double" 
            BorderWidth="1px" BorderColor="Red"></asp:TextBox>
    </div>
    </form>
</body>
</html>
