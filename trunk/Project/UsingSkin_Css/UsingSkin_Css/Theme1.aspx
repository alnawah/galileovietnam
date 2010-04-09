<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Theme1.aspx.cs" Inherits="UsingSkin_Css.Theme1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >


<!-- 
Make sure the bat images are in the same directory/folder as the page using the 
script. If not, you will have to alter all referencces to them in the script.
-->


<!-- Use this as your body tag. Add own bg and link colours etc. -->
<body onBlur="if (!Netscape6) pre_load()">



<!-- Paste script in head -->

<script language="JavaScript">
<!--  Bats script by Kurt Grigg - http://www.btinternet.com/~kurt.grigg/javascript

var num=7; //Number of bats

//Nothing needs altering past here....................
/*
Script disabled for Netscape 6 
due to ugly scrollbar activety 
*/

var Netscape6=false;
if (navigator.appName == "Netscape" && parseFloat(navigator.appVersion) >= 5) 
Netscape6=true;

if (!Netscape6){
var pics=new Array("bat2.gif","bat3.gif","bat2.gif","bat1.gif");
var load=new Array();

function pre_load(){
for(i=0; i < pics.length; i++){
 load[i]=new Image();
 load[i].src=pics[i];
 }
}
pre_load();

var n4=(document.layers);
var o6=(navigator.appName.indexOf("Opera") != -1)?true:false;
var ie=(document.all);
var y=0;
var x=0;
var yb=0;
var xb=0;
var s0=0;
var s1=0.5;
var s2=1;
var cnt=new Array(0,1,2)
var mix=new Array();
for (i=0; i < num; i++)
mix[i]=cnt[Math.floor(Math.random()*cnt.length)];
var del=0.1;
var y1=new Array();
var x1=new Array();
var y2=new Array();
var x2=new Array();
for (i=0; i < num; i++){
y1[i]=0;
x1[i]=0;
y2[i]=0;
x2[i]=0;
}
if (n4){
window.captureEvents(Event.MOUSEMOVE);
function mouse1(e){
 y = e.pageY-window.pageYOffset;
 x = e.pageX; 
 }
window.onMouseMove=mouse1;                               
}
if (ie||o6){
 function mouse2(){
 y = (ie)?event.clientY:event.clientY-window.pageYOffset;
 x = event.clientX;
 } 
document.onmousemove=mouse2;
}
if (n4){
 for (i=0; i < num; i++)
 document.write("<LAYER NAME='bats"+i+"' LEFT=0 TOP=-50><img name='temp"+i+"' src="+pics[0]+"></LAYER>");
}
if (ie){
document.write('<div id="con" style="position:absolute;top:-50px;left:0px"><div style="position:relative">');
 for (i=0; i < num; i++){
 document.write('<img id="bats'+i+'" src="'+pics[0]+'" style="position:absolute;top:0px;left:0px">');
 }
 document.write('</div></div>');
}
if (o6){
 for (i=0; i < num; i++)
 document.write("<div id='bats"+i+"' style='position:absolute;top:-50px;left:0px'><img name='temp"+i+"' src="+pics[0]+"></div>");
}

function swirl(){
if (ie) con.style.top=document.body.scrollTop;
sy=(!ie)?window.pageYOffset:0;
yb=(ie)?window.document.body.offsetHeight/3:window.innerHeight/3;
xb=(ie)?window.document.body.offsetWidth/7:window.innerWidth/7;
for (i=0; i < num; i++){
 var t=(n4)?document.layers["bats"+i]:document.getElementById("bats"+i).style;
 t.top = y1[i]+yb*Math.sin(((s0)+i*3.7)/4)*Math.cos((s0+i*35)/20)+sy;
 t.left =x1[i]+xb*Math.cos(((s0)+i*3.7)/4)*Math.cos((s0+i*35)/62);
 }
s0+=s1;
}

function animate(){
var i_or_o=(ie)?"bats":"temp";
for (i=0; i < num; i++){
 if (mix[i] == pics.length) mix[i]=0;
 if (n4) document.layers['bats'+i].document.images['temp'+i].src=pics[mix[i]];
 else document.images[i_or_o+i].src=pics[mix[i]];
 mix[i]+=s2;
}
swirl();
}

function follow(){
y1[0]=Math.round(y2[0]+=((y)-y2[0])*del);
x1[0]=Math.round(x2[0]+=((x)-x2[0])*del);
for (i=1; i < num; i++){
y1[i]=Math.round(y2[i]+=(y1[i-1]-y2[i])*del);
x1[i]=Math.round(x2[i]+=(x1[i-1]-x2[i])*del);
}
animate();
setTimeout('follow()',20);
}

function startit(){
setTimeout('follow()',1000);
}
window.onload=startit;
}
//-->
</script>

<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1
        {
            height: 404px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 114px" class="content">
    
        <table align="center" style="width: 30%">
            <tr>
                <td style="width: 137px">
                    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="219px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="219px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Đăng nhập" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Hủy bỏ" Width="100px" 
                        onclick="Button2_Click" />
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    <div class="content">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Thông tin người dùng" 
        Height="119px" style="text-align: left" Width="362px">
        <table style="width: 100%; height: 96px;">
            <tr>
                <td style="width: 91px">
                    <asp:Label ID="Label3" runat="server" Text="Họ và tên"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" style="text-align: left" 
                        Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" style="text-align: left" 
                        Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">
                    <asp:Label ID="Label5" runat="server" Text="Địa chỉ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" GroupingText="Công ty" Height="84px" 
        style="text-align: left" Width="362px">
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Galileo Việt Nam" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="IFI Solution" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="HPC Hà Nội" />
    </asp:Panel>
    <br />
    </div>
    </form>
</body>
</html>
