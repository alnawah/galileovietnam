<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexPage.aspx.cs" Inherits="LeisureDemo.IndexPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

 <!--[if IE]><script>document.write('<base href="' + location.protocol + '//' + location.host + location.pathname.replace(/\/[^\/]*$/, '/safari/') + '"/>')</script><![endif]-->
    <base href="safari/">
    <script id="DC_baseScript">
        if(navigator.userAgent.indexOf('AppleWebKit/') == -1)
        {
            document.write('<base href="' + location.protocol + '//' + location.host + location.pathname.replace(/\/[^\/]*$/, '/safari/') + '"/>')
        }
    </script>
    <meta http-equiv="content-type" content="text/html; charset=utf-8">
    <link rel="stylesheet" href="main.css">
    <script type="text/javascript" src="../Parts/redirector.js"></script>
    <script type="text/javascript" src="Parts/parts.js" charset="utf-8"></script>
    <script type="text/javascript" src="main.js" charset="utf-8"></script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Galileo Leisure Demo</title>
</head>
<body onload="load();">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <div id="columnLayout">
        <div style="position: relative; display: table-cell; vertical-align: top; height: auto; width: 100%; "><div id="column">
                <div id="image">
                    <img id="DC_img">
     
                </div>
                <div id="text"></div>
            <asp:DropDownList ID="ddlCountry" runat="server" Height="16px" Width="196px">
            </asp:DropDownList>
                
            </div></div></div>
    <div id="columnLayout1">
        <div style="position: relative; display: table-cell; vertical-align: top; height: auto; width: 100%; "><div id="column1">
                <div id="text1"></div>
            </div></div></div>
    <div id="columnLayout2">
        <div style="position: relative; display: table-cell; vertical-align: top; height: auto; width: 100%; "><div id="column2">
                <div id="text3"></div>
            </div></div></div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </form>
</body>
</html>




