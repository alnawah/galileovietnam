<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UsingSkin_Css._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:Button ID="btnTheme1" runat="server" Text="Theme 1" 
            onclick="btnTheme1_Click" />
        <br /><br />
        <asp:Button ID="btnTheme2" runat="server" Text="Theme 2" 
            onclick="btnTheme2_Click" />
    </div>
    </form>
</body>
</html>
