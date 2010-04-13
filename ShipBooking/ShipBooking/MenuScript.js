/***********************************************
*Nguyen Quang Minh
***********************************************/
var mnuThoiCuoc = new Array()
mnuThoiCuoc[0] = '<div><a href="/News/Hinh-su/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;H&#236;nh s&#7921;</a></div>'
mnuThoiCuoc[1] = '<div><a href="/News/Thuong-truong/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;Th&#432;&#417;ng tr&#432;&#7901;ng</a></span></div>'
mnuThoiCuoc[2] = '<div><a href="/News/Du-hoc/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;Du h&#7885;c</a></div>'

var mnuTamTinh = new Array()
mnuTamTinh[0] = '<div><a href="/News/Chang-nang/Loi-yeu/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;L&#7901;i y&#234;u</a></span></div>';
mnuTamTinh[1] = '<div><a href="/News/Chang-nang/Go-roi/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;G&#7905; r&#7889;i</a></div>';

var mnuLamDep = new Array()
mnuLamDep[0] = '<div><a href="/News/Thoi-trang/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;Th&#7901;i trang</a></span></div>';
mnuLamDep[1] = '<div><a href="/News/Tu-van/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;T&#432; v&#7845;n</a></div>';

var mnuHauTruong = new Array()
mnuHauTruong[0] = '<div><a href="/News/Hoa-hau/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;Hoa h&#7853;u</a></span></div>';

var mnuTheThao = new Array()
mnuTheThao[0] = '<div><a href="/News/Clip/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;Clip</a></span></div>';

/*				



var mnuGiaiTri=new Array()
mnuGiaiTri[0]='<a href="/News/Choi-gi/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;Ch&#417;i g&#236;</a></span>'
mnuGiaiTri[1]='<a href="/News/An-dau/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;&#258;n &#273;&#226;u</a>'
mnuGiaiTri[2]='<a href="/News/Truyen-hay/"><img border=0 src="/Images/Menu/Bullet.gif">&nbsp;&nbsp;&nbsp;Truy&#7879;n hay</a>'
*/

var menuwidth='165px' //default menu width
var menubgcolor='#0E3288'  //menu bgcolor
var disappeardelay=150  //menu disappear speed onMouseout (in miliseconds)
var hidemenu_onclick="yes" //hide menu when user clicks within menu?

/////No further editting needed

var ie4=document.all
var ns6=document.getElementById&&!document.all

if (ie4||ns6)
document.write('<div id="dropmenudiv" style="visibility:hidden;position:absolute;z-index:9999;opacity:0.8;filter:alpha(opacity=80);width:' + menuwidth + ';background-color:' + menubgcolor + '" onMouseover="clearhidemenu()" onMouseout="dynamichide(event)"></div>')

function getposOffset(what, offsettype){
var totaloffset=(offsettype=="left")? what.offsetLeft : what.offsetTop;
var parentEl=what.offsetParent;
while (parentEl!=null){
totaloffset=(offsettype=="left")? totaloffset+parentEl.offsetLeft : totaloffset+parentEl.offsetTop;
parentEl=parentEl.offsetParent;
}
return totaloffset;
}


function showhide(obj, e, visible, hidden, menuwidth){
if (ie4||ns6)
dropmenuobj.style.left=dropmenuobj.style.top="-500px"
if (menuwidth!=""){
dropmenuobj.widthobj=dropmenuobj.style
dropmenuobj.widthobj.width=menuwidth
}
if (e.type=="click" && obj.visibility==hidden || e.type=="mouseover")
obj.visibility=visible
else if (e.type=="click")
obj.visibility=hidden
}

function iecompattest(){
return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body
}

function clearbrowseredge(obj, whichedge){
var edgeoffset=0
if (whichedge=="rightedge"){
var windowedge=ie4 && !window.opera? iecompattest().scrollLeft+iecompattest().clientWidth-15 : window.pageXOffset+window.innerWidth-15
dropmenuobj.contentmeasure=dropmenuobj.offsetWidth
if (windowedge-dropmenuobj.x < dropmenuobj.contentmeasure)
edgeoffset=dropmenuobj.contentmeasure-obj.offsetWidth
}
else{
var topedge=ie4 && !window.opera? iecompattest().scrollTop : window.pageYOffset
var windowedge=ie4 && !window.opera? iecompattest().scrollTop+iecompattest().clientHeight-15 : window.pageYOffset+window.innerHeight-18
dropmenuobj.contentmeasure=dropmenuobj.offsetHeight
if (windowedge-dropmenuobj.y < dropmenuobj.contentmeasure){ //move up?
edgeoffset=dropmenuobj.contentmeasure+obj.offsetHeight
if ((dropmenuobj.y-topedge)<dropmenuobj.contentmeasure) //up no good either?
edgeoffset=dropmenuobj.y+obj.offsetHeight-topedge
}
}
return edgeoffset
}

function populatemenu(what){
if (ie4||ns6)
dropmenuobj.innerHTML=what.join("")
}


function dropdownmenu(obj, e, menucontents, menuwidth){
displayovermenu(obj);
if (window.event) event.cancelBubble=true
else if (e.stopPropagation) e.stopPropagation()
clearhidemenu()
dropmenuobj=document.getElementById? document.getElementById("dropmenudiv") : dropmenudiv
populatemenu(menucontents)

if (ie4||ns6){
showhide(dropmenuobj.style, e, "visible", "hidden", menuwidth)
dropmenuobj.x=getposOffset(obj, "left")
dropmenuobj.y=getposOffset(obj, "top")
dropmenuobj.style.left=dropmenuobj.x-clearbrowseredge(obj, "rightedge")+"px"
dropmenuobj.style.top=dropmenuobj.y-clearbrowseredge(obj, "bottomedge")+obj.offsetHeight+"px"
}

return clickreturnvalue()
}

function clickreturnvalue(){
if (ie4||ns6) return false
else return true
}

function contains_ns6(a, b) {
while (b.parentNode)
if ((b = b.parentNode) == a)
return true;
return false;
}

function dynamichide(e){
if (ie4&&!dropmenuobj.contains(e.toElement))
delayhidemenu()
else if (ns6&&e.currentTarget!= e.relatedTarget&& !contains_ns6(e.currentTarget, e.relatedTarget))
delayhidemenu()
}

function hidemenu(e){
if (typeof dropmenuobj!="undefined"){
if (ie4||ns6)
dropmenuobj.style.visibility="hidden"
}
displaydefaultmenu();
}

function delayhidemenu(){
if (ie4||ns6)
delayhide=setTimeout("hidemenu()",disappeardelay)
}

function clearhidemenu(){
if (typeof delayhide!="undefined")
clearTimeout(delayhide)
}

if (hidemenu_onclick=="yes")
document.onclick=hidemenu

function displayovermenu(obj){
	if (Right(Left(obj.src,obj.src.length-4),2)!='-m') obj.src = Left(obj.src,obj.src.length-4) + '-m' + Right(obj.src,4);
}

function displaydefaultmenu(){
	gmobj("imgThoiCuoc").src = "/Images/Thoi-cuoc.gif";
	gmobj("imgHauTruong").src = "/Images/Hau-truong.gif";
	gmobj("imgTheThao").src = "/Images/The-thao.gif";
	gmobj("imgTamTinh").src = "/Images/Tam-tinh.gif";
	gmobj("imgHinhSu").src = "/Images/Hinh-su.gif";
	gmobj("imgChoiBlog").src = "/Images/Choi-blog.gif";
	gmobj("imgDanChoi").src = "/Images/Dan-choi.gif";
	gmobj("imgLamDep").src = "/Images/Lam-dep.gif";
	gmobj("imgTracNghiem").src = "/Images/Trac-nghiem.gif";
	gmobj("imgTroChoi").src = "/Images/Tro-choi.gif";
	gmobj("imgBuonChuyen").src = "/Images/Buon-chuyen.gif";
	gmobj("imgThoitrang").src = "/Images/Thoi-trang.gif";
	gmobj("imgAnh").src = "/Images/Anh.gif";
	gmobj("imgDungCuoi").src = "/Images/Dung-cuoi.gif";
}

