<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestSkinToTheme.aspx.cs" Inherits="StudyWebMaster.TestSkinToTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="">
    <h1>Registration Form</h1>
        <asp:Label ID="lblFirstName" runat="server" Text="Fisrt name:" AssociatedControlID="txtFirstName"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblLastName" runat="server" Text="Last name:" AssociatedControlID="txtLastName"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br /><br />
        
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button"/>
        
    </div>
    </form>
</body>
</html>
