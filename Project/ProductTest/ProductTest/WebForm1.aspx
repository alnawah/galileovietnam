<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Galileo hiển thị giá riêng của TG</title>
    
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 314px;
        }
        .style3
        {
            font-size: medium;
        }
        .style5
        {
            font-family: Arial, Helvetica, sans-serif;
            color: #002A54;
            font-size: small;
        }
        .style6
        {
            color: #002A54;
            font-size: small;
        }
        .style7
        {
            font-size: small;
        }
        .style8
        {
            font-size: small;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
    
</head>
<body style="font-family: 'Times New Roman', Times, serif">
    <table class="style1">
        <tr>
            <td class="style2">
                <b style="mso-bidi-font-weight:normal">
                <span style="font-size:14.0pt;mso-bidi-font-size:12.0pt;font-family:&quot;Arial&quot;,&quot;sans-serif&quot;;
mso-fareast-font-family:&quot;Times New Roman&quot;;color:#002A54;mso-ansi-language:EN-US;
mso-fareast-language:AR-SA;mso-bidi-language:AR-SA">NEWS RELEASE</span></b></td>
            <td style="text-align: right">
                <img src="images/galileo_logo.jpg" alt="logo"/>
            </td>
        </tr>
    </table>
    <p style="text-align: center">
        <b style="mso-bidi-font-weight:normal">
        <span style="mso-bidi-font-size: 12.0pt; font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Times New Roman&quot;; color: #002A54; mso-ansi-language: EN-US; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA; text-align: center;" 
            class="style3">
        Galileo hiển thị giá riêng và bổ sung chức năng tính giá TG tự động dành cho các 
        đại lý</span></b></p>
    <p>
        <b style="mso-bidi-font-weight:normal"><i style="mso-bidi-font-style:normal">
        <span style="mso-bidi-font-size: 12.0pt; font-family: &quot;Arial&quot;,&quot;sans-serif&quot;; mso-fareast-font-family: &quot;Times New Roman&quot;; color: #002A54; mso-ansi-language: EN-US; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA; text-align: left;" 
            class="style7">
        Kể từ ngày 1.4.2010, toàn bộ giá bảng giá riêng của TG - Thai Airways đã được 
        hiển thị trên hệ thống phân phối toàn cầu Galileo.
        <span style="mso-spacerun:yes">&nbsp;</span>Để thuận tiện cho các đại lý sử dụng hệ 
        thống Galileo, Galileo Vietnam đã bổ sung chức<span style="mso-spacerun:yes">&nbsp;
        </span>năng tính giá, xuất vé của Thai Airways áp dụng riêng cho các giá TG tại 
        thị trường Vietnam. Với chức năng này, việc tính giá, xuất vé của TG trên 
        Galileo sẽ trở nên thuận tiện nhất so với các GDS khác.</span></i></b></p>
    <p class="style5" 
        style="mso-bidi-font-size: 12.0pt; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: AR-SA; mso-bidi-language: AR-SA">
        Khi sử dụng câu lệnh FD<span style="mso-spacerun:yes">&nbsp; </span>để tra giá, giá 
        hiển thị trên hệ thống hiện tại là giá Gross. Để biết được giá Pax hoặc giá 
        Agent, đại lý có thể sử dụng thêm một số bước tính toán nữa hoặc sử dụng chức 
        năng tính giá TG tự động áp dụng riêng cho các giá của TG tại thị trường Việt 
        Nam.</p>
    <p class="MsoNormal">
        <span class="style9">
        <b style="mso-bidi-font-weight:
normal"><i style="mso-bidi-font-style:normal"><u>
        <span style="mso-bidi-font-size:12.0pt;line-height:150%;mso-bidi-font-family:Arial;
color:#002A54" class="style7">Quy trình sử dụng như sau:</span></u></i></b></p>
    <p class="MsoNormal">
        <b style="mso-bidi-font-weight:normal">
        <span style="mso-bidi-font-size:
12.0pt;mso-bidi-font-family:Arial;color:#002A54" class="style7">I. Để tra giá giữa 1 cặp thành phố, 
        dùng lệnh FD<o:p></o:p></span></b></p>
    <p class="style6" 
        style="mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &gt;FD 
        DEP ARR/TG*RP9 cho giá Net Pax, &gt;FD DEP ARR/TG*RP12 cho giá Net Agent<o:p>&nbsp;</o:p></p>
    <p class="style6" 
        style="mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial;">
        Ví dụ: tra giá Net Pax từ SGN đi FRA làm như sau:<o:p></o:p></p>
    <p class="style6" 
        style="mso-bidi-font-size: 12.0pt; mso-bidi-font-family: Arial;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &gt;FDSGNFRA/TG*RP9<o:p></o:p></p>
    <p class="MsoNormal">
        </span>
        <b style="mso-bidi-font-weight:normal">
        <span style="mso-bidi-font-size:
12.0pt;mso-bidi-font-family:Arial;color:#002A54" class="style7"><span class="style9">II. Để quote giá khi đã có booking:</span><o:p></o:p></span></b></p>
    <u>
    <span style="mso-bidi-font-size:12.0pt;mso-fareast-font-family:&quot;Times New Roman&quot;;color:#002A54;mso-ansi-language:EN-US;
mso-fareast-language:AR-SA;mso-bidi-language:AR-SA" class="style8">Bước 1</span></u><span style="mso-bidi-font-size:12.0pt;mso-fareast-font-family:&quot;Times New Roman&quot;;color:#002A54;mso-ansi-language:EN-US;
mso-fareast-language:AR-SA;mso-bidi-language:AR-SA" class="style8">: click chuột vào biểu tượng của 
    Thai Airways. Chương trình sẽ tính giá cho booking và trả lời khi tính xong</span>
    </body>
</html>
