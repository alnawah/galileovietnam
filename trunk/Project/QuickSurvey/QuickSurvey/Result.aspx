<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        int nKq_KhuyenMai_DuLich = getNumberKhuyenMai("KhuyenMai_Dulich");
        int nKq_KhuyenMai_QuaTang = getNumberKhuyenMai("KhuyenMai_QuaTang");
        int nKq_KhuyenMai_DiemTichLuy = getNumberKhuyenMai("KhuyenMai_TangDiem");
        int nKq_KhuyenMai_KhongQuanTam = getNumberKhuyenMai("KhuyenMai_KhongQuanTam");
        int nKq_KhuyenMai_YKienKhac = getNumberKhuyenMai("KhuyenMai_YKienKhac");

        int nKq_SinhHoat_DaNgoai = getNumberSinhHoat("SinhHoat_DaNgoai");
        int nKq_SinhHoat_TheThao = getNumberSinhHoat("SinhHoat_TheThao");
        int nKq_SinhHoat_TuTap = getNumberSinhHoat("SinhHoat_TuTap");
        int nKq_SinhHoat_HoiThao = getNumberSinhHoat("SinhHoat_HoiThao");
        int nKq_SinhHoat_YKienKhac = getNumberSinhHoat("SinhHoat_YKienKhac");

        int nKq_HoiThao_TamLy = getNumberHoiThao("HoiThao_TamLy");
        int nKq_HoiThao_SucKhoe = getNumberHoiThao("HoiThao_SucKhoe");
        int nKq_HoiThao_CongViec = getNumberHoiThao("HoiThao_NgheNghiep");
        int nKq_HoiThao_YKienKhac = getNumberHoiThao("HoiThao_YKienKhac");

        int nKq_ThoiGian_3thang = getNumberThoiGianToChuc("ThoiGian_BaThang");
        int nKq_ThoiGian_6thang = getNumberThoiGianToChuc("ThoiGian_SauThang");
        int nKq_ThoiGian_DeuDan = getNumberThoiGianToChuc("ThoiGian_DeuDan");
        int nKq_ThoiGian_YKienKhac = getNumberThoiGianToChuc("ThoiGian_YKienKhac");

        Label1.Text = nKq_KhuyenMai_DuLich.ToString() + " kết quả";
        Label2.Text = nKq_KhuyenMai_QuaTang.ToString() + " kết quả";
        Label3.Text = nKq_KhuyenMai_DiemTichLuy.ToString() + " kết quả";
        Label4.Text = nKq_KhuyenMai_KhongQuanTam.ToString() + " kết quả";
        Label5.Text = nKq_KhuyenMai_YKienKhac.ToString() + " kết quả";

        Label6.Text = nKq_SinhHoat_DaNgoai.ToString() + " kết quả";
        Label7.Text = nKq_SinhHoat_TheThao.ToString() + " kết quả";
        Label8.Text = nKq_SinhHoat_TuTap.ToString() + " kết quả";
        Label9.Text = nKq_SinhHoat_HoiThao.ToString() + " kết quả";
        Label10.Text = nKq_SinhHoat_YKienKhac.ToString() + " kết quả";

        Label11.Text = nKq_HoiThao_TamLy.ToString() + " kết quả";
        Label12.Text = nKq_HoiThao_SucKhoe.ToString() + " kết quả";
        Label13.Text = nKq_HoiThao_CongViec.ToString() + " kết quả";
        Label14.Text = nKq_HoiThao_YKienKhac.ToString() + " kết quả";

        Label15.Text = nKq_ThoiGian_3thang.ToString() + " kết quả";
        Label16.Text = nKq_ThoiGian_6thang.ToString() + " kết quả";
        Label17.Text = nKq_ThoiGian_DeuDan.ToString() + " kết quả";
        Label18.Text = nKq_ThoiGian_YKienKhac.ToString() + " kết quả";
    }

    protected int getNumberKhuyenMai(string strField)
    {
        int nNumberChecked = 0;
        bool result = false;
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
        System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(strConn);
        try
        {
            cnn.Open();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = cnn;
            if (strField == "KhuyenMai_YKienKhac")
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblKhuyenMai WHERE " + strField + " <> ''";
            }
            else
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblKhuyenMai WHERE " + strField + " = 'TRUE'";
            }
            cmd.CommandType = System.Data.CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            System.Data.DataTable dtb = ds.Tables[0];
            
            nNumberChecked = dtb.Rows.Count;
            cnn.Close();
        }
        catch (Exception ex)
        {
            string Error = ex.Message;
        }
        return nNumberChecked;
    }

    protected int getNumberSinhHoat(string strField)
    {
        int nNumberChecked = 0;
        bool result = false;
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
        System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(strConn);
        try
        {
            cnn.Open();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = cnn;
            if (strField == "SinhHoat_YKienKhac")
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblLoaiHinhSinhHoat WHERE " + strField + " <> ''";
            }
            else
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblLoaiHinhSinhHoat WHERE " + strField + " = 'TRUE'";
            }
            cmd.CommandType = System.Data.CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            System.Data.DataTable dtb = ds.Tables[0];

            nNumberChecked = dtb.Rows.Count;
            cnn.Close();
        }
        catch (Exception ex)
        {
            string Error = ex.Message;
        }
        return nNumberChecked;
    }

    protected int getNumberHoiThao(string strField)
    {
        int nNumberChecked = 0;
        bool result = false;
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
        System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(strConn);
        try
        {
            cnn.Open();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = cnn;
            if (strField == "HoiThao_YKienKhac")
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblHoiThao WHERE " + strField + " <> ''";
            }
            else
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblHoiThao WHERE " + strField + " = 'TRUE'";
            }
            cmd.CommandType = System.Data.CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            System.Data.DataTable dtb = ds.Tables[0];

            nNumberChecked = dtb.Rows.Count;
            cnn.Close();
        }
        catch (Exception ex)
        {
            string Error = ex.Message;
        }
        return nNumberChecked;
    }

    protected int getNumberThoiGianToChuc(string strField)
    {
        int nNumberChecked = 0;
        bool result = false;
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
        System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(strConn);
        try
        {
            cnn.Open();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = cnn;
            if (strField == "ThoiGian_YKienKhac")
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblThoiGianToChuc WHERE " + strField + " <> ''";
            }
            {
                cmd.CommandText = "SELECT " + strField + " FROM tblThoiGianToChuc WHERE " + strField + " = 'TRUE'";
            }
            cmd.CommandType = System.Data.CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            System.Data.DataTable dtb = ds.Tables[0];

            nNumberChecked = dtb.Rows.Count;
            cnn.Close();
        }
        catch (Exception ex)
        {
            string Error = ex.Message;
        }
        return nNumberChecked;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int nKq_KhuyenMai_DuLich        = getNumberKhuyenMai("KhuyenMai_Dulich");
        int nKq_KhuyenMai_QuaTang       = getNumberKhuyenMai("KhuyenMai_QuaTang");
        int nKq_KhuyenMai_DiemTichLuy   = getNumberKhuyenMai("KhuyenMai_TangDiem");
        int nKq_KhuyenMai_KhongQuanTam  = getNumberKhuyenMai("KhuyenMai_KhongQuanTam");
        int nKq_KhuyenMai_YKienKhac     = getNumberKhuyenMai("KhuyenMai_YKienKhac");

        int nKq_SinhHoat_DaNgoai        = getNumberSinhHoat("SinhHoat_DaNgoai");
        int nKq_SinhHoat_TheThao        = getNumberSinhHoat("SinhHoat_TheThao");
        int nKq_SinhHoat_TuTap          = getNumberSinhHoat("SinhHoat_TuTap");
        int nKq_SinhHoat_HoiThao        = getNumberSinhHoat("SinhHoat_HoiThao");
        int nKq_SinhHoat_YKienKhac      = getNumberSinhHoat("SinhHoat_YKienKhac");

        int nKq_HoiThao_TamLy           = getNumberHoiThao("HoiThao_TamLy");
        int nKq_HoiThao_SucKhoe         = getNumberHoiThao("HoiThao_SucKhoe");
        int nKq_HoiThao_CongViec        = getNumberHoiThao("HoiThao_NgheNghiep");
        int nKq_HoiThao_YKienKhac       = getNumberHoiThao("HoiThao_YKienKhac");

        int nKq_ThoiGian_3thang         = getNumberThoiGianToChuc("ThoiGian_BaThang");
        int nKq_ThoiGian_6thang         = getNumberThoiGianToChuc("ThoiGian_SauThang");
        int nKq_ThoiGian_DeuDan         = getNumberThoiGianToChuc("ThoiGian_DeuDan");
        int nKq_ThoiGian_YKienKhac      = getNumberThoiGianToChuc("ThoiGian_YKienKhac");

        Label1.Text = nKq_KhuyenMai_DuLich.ToString() + " kết quả";
        Label2.Text = nKq_KhuyenMai_QuaTang.ToString() + " kết quả";
        Label3.Text = nKq_KhuyenMai_DiemTichLuy.ToString() + " kết quả";
        Label4.Text = nKq_KhuyenMai_KhongQuanTam.ToString() + " kết quả";
        Label5.Text = nKq_KhuyenMai_YKienKhac.ToString() + " kết quả";

        Label6.Text  = nKq_SinhHoat_DaNgoai.ToString() + " kết quả";
        Label7.Text  = nKq_SinhHoat_TheThao.ToString() + " kết quả";
        Label8.Text  = nKq_SinhHoat_TuTap.ToString() + " kết quả";
        Label9.Text  = nKq_SinhHoat_HoiThao.ToString() + " kết quả";
        Label10.Text = nKq_SinhHoat_YKienKhac.ToString() + " kết quả";

        Label11.Text = nKq_HoiThao_TamLy.ToString() + " kết quả";
        Label12.Text = nKq_HoiThao_SucKhoe.ToString() + " kết quả";
        Label13.Text = nKq_HoiThao_CongViec.ToString() + " kết quả";
        Label14.Text = nKq_HoiThao_YKienKhac.ToString() + " kết quả";

        Label15.Text = nKq_ThoiGian_3thang.ToString() + " kết quả";
        Label16.Text = nKq_ThoiGian_6thang.ToString() + " kết quả";
        Label17.Text = nKq_ThoiGian_DeuDan.ToString() + " kết quả";
        Label18.Text = nKq_ThoiGian_YKienKhac.ToString() + " kết quả";
        
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <span lang="en-us" style="font-size: x-large"><strong>Kết quả bình chọn</strong></span>
    </div>
    <br /><br />
    <div>
    <center>
        <table style="width: 60%; " bgcolor="#FFFFCC" border="1px">
            <tr align="left">
                <td colspan="2">
                    <span lang="en-us" style="color: #0000FF"><strong>1. Hình thức khuyến khích của G Corner đối với hội 
                    viên:</strong></span></td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Du lịch/nghỉ dưỡng</span></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Quà tặng vật phẩm/ thẻ mua hàng/ phiếu tặng quà</span></td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Tặng điểm tích lũy hội viên</span></td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Không quan tâm</span></td>
                <td>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Ý kiến khác</span></td>
                <td>
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
        </table> 
    </center>
    </div>
    <br />
    <div>
    <center>
        <table style="width: 60%" bgcolor="#FFFFCC" border="1">
            <tr align="left">
                <td colspan="2">
                    <span lang="en-us" style="color: #0000FF"><strong>2. Loại hình sinh hoạt của G Corner</strong></span></td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Hoạt động dã ngoại/ term building</span></td>
                <td>
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Hoạt động thể thao/ vui chơi/ giải trí</span></td>
                <td>
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Các hoạt động sinh hoạt tụ tập nhóm theo chủ đề</span></td>
                <td>
                    <asp:Label ID="Label8" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Các chương trình hội thảo, tư vấn và nâng cao kỹ năng nghề nghiệp</span></td>
                <td>
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Ý kiến khác</span></td>
                <td>
                    <asp:Label ID="Label10" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </center>
    </div>
    <br />
    <div>
    <center>
        <table style="width: 60%" bgcolor="#FFFFCC" border="1">
            <tr align="left">
                <td colspan="2">
                    <span lang="en-us" style="color: #0000FF"><strong>3. Hội thảo chuyên đề:</strong></span></td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Các chủ đề tâm lý, tình cảm, gia đình</span></td>
                <td>
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Các chủ đề chăm sóc sức khỏe, làm đẹp, kỹ năng sống</span></td>
                <td>
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Các chủ đề công việc, nâng cao kỹ năng nghề nghiệp</span></td>
                <td>
                    <asp:Label ID="Label13" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Các chủ đề khác</span></td>
                <td>
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </center>
    </div>
    <br />
    <div>
    <center>
        
        <table style="width: 60%" bgcolor="#FFFFCC" border="1">
            <tr align="left">
                <td colspan="2">
                    <span lang="en-us" style="color: #0000FF"><strong>4. Thời gian tổ chức:</strong></span></td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">3 tháng/lần và kéo dài 1 buổi/sự kiện</span></td>
                <td>
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">6 tháng/ 1 lần và kéo dài 1 buổi/ sự kiện</span></td>
                <td>
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Đều đặn hàng tháng</span></td>
                <td>
                    <asp:Label ID="Label17" runat="server"></asp:Label>
                </td>
            </tr>
            <tr align="left">
                <td style="width: 488px">
                    <span lang="en-us">Ý kiến khác</span></td>
                <td>
                    <asp:Label ID="Label18" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        
    </center>
    </div>
    
    <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" Width="124px" />
    </p>
    </form>
</body>
</html>
