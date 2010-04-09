<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsingCalControl.aspx.cs" Inherits="UsingSkin_Css.UsingCalControl" %>
<%@ Register TagPrefix="main" TagName="cal" Src="~/Control/Calculator.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sử dụng Webcontrol</title>
    <style type="text/css">
        html{background-color:#e5e5e5}
        .divmain{background-color:White; margin:15px; padding:15px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="divmain">
            <main:cal runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
