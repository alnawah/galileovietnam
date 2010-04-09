<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    public class DataConnection
    {
        #region "variable"
        private string strConnect;
        private System.Data.OleDb.OleDbConnection conn;
        private string strError = "";
        #endregion

        #region "Properties"
        public string Error
        {
            get { return strError; }
            set { strError = value; }
        }
        #endregion
        public DataConnection()
        {
            //
            // TODO: Add constructor logic here
            //
            strConnect = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
            conn = null;
        }
        public int ExecuteCommand(string strQuery)
        {
            System.Data.OleDb.OleDbCommand cmd;
            int result = 0;
            if (conn == null)
                conn = new System.Data.OleDb.OleDbConnection(strConnect);
            try
            {
                conn.Open();
                cmd = new System.Data.OleDb.OleDbCommand();
                // gán đối tượng connection vào property connection của command
                cmd.Connection = conn;
                // gán chuỗi command vào property commandtext của command
                cmd.CommandText = strQuery;
                // chọn loạt command
                cmd.CommandType = System.Data.CommandType.Text;
                // thực hiện command
                result = cmd.ExecuteNonQuery();
                // đóng connection sau khi chạy lệnh sql
                conn.Close();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }

            return result;
        }
    }

    protected bool checkGCornerID(string strId)
    {
        bool result = false;
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
        System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(strConn);
        try
        {
            cnn.Open();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT GId FROM tblMembers WHERE GId='" + strId + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            System.Data.DataTable dtb = ds.Tables[0];
            if (dtb.Rows.Count > 0)
            {
                result = true;
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            string Error = ex.Message;
        }
        return result;
    }

    protected bool checkCurrentGCornerID(string strId)
    {
        bool result = false;
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
        System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(strConn);
        try
        {
            cnn.Open();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT IDTruyCap FROM tblKhach WHERE IDTruyCap='" + strId + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            System.Data.DataTable dtb = ds.Tables[0];
            if (dtb.Rows.Count > 0)
            {
                result = true;
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            string Error = ex.Message;
        }
        return result;
    }

    protected bool checkCurrentIdNewMembers(string strId)
    {
        bool result = false;
        string strConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|QuickSurvey.mdb";
        System.Data.OleDb.OleDbConnection cnn = new System.Data.OleDb.OleDbConnection(strConn);
        try
        {
            cnn.Open();
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT IDTruyCap FROM tblNewMembers WHERE IDTruyCap='" + strId + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);
            System.Data.DataTable dtb = ds.Tables[0];
            if (dtb.Rows.Count > 0)
            {
                result = true;
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            string Error = ex.Message;
        }
        return result;
    }
    
    protected void reset()
    {
        txtHoten.Text = "";
        txtIdTruyCap.Text = "";
        //txtNgaySinh.Text = "";
        //txtPPC.Text = "";
        txtTenCongTy.Text = "";
        txtMobile.Text = "";
        txtEmail.Text = "";
        //txtSoThich.Text = "";

        txt_HoiThao_YKienKhac.Text = "";
        txt_KhuyenMai_YKienKhac.Text = "";
        txt_SinhHoat_YKienKhac.Text = "";
        txt_ThoiGian_YKienKhac.Text = "";
        txt_YKienRieng.Text = "";
    }

    protected void resetMaso()
    {
        lblMsg.Visible = true;
        lblSubmitSuccessMsg.Visible = false;
        lblMaSo.Visible = false;
        lkbDangKy.Visible = false;
        lblCauHoi7.ForeColor = System.Drawing.Color.Black;
        lblCauHoi2.ForeColor = System.Drawing.Color.Black;
        lblCauHoi3.ForeColor = System.Drawing.Color.Black;
        lblCauHoi4.ForeColor = System.Drawing.Color.Black;
    }
    
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        bool ok;
        
        resetMaso();
        if (txtHoten.Text == "")
        {
            lblMsg.Text = "Bạn hãy nhập họ tên mình";
            lblHoTenMsg.Visible = true;
            return;
        }
        else
        {
            lblHoTenMsg.Visible = false;
        }

        if (txtIdTruyCap.Text == "")
        {
            lblMsg.Text = "Bạn hãy nhập G Corner ID, nếu bạn chưa phải là hội viên G Corner, hãy đăng ký tại đây:";
            lblIDTruyCapMsg.Visible = true;
            lkbDangKy.Visible = true;
            return;
        }
        else
        {
            ok = checkGCornerID(txtIdTruyCap.Text.ToUpper().Trim());
            if (ok == false)
            {
                if (checkCurrentGCornerID(txtIdTruyCap.Text.ToUpper().Trim()) || checkCurrentIdNewMembers(txtIdTruyCap.Text.ToUpper().Trim()))
                {
                    lblIDTruyCapMsg.Text = "ID này đã tham gia bình chọn!";
                    lblIDTruyCapMsg.Visible = true;
                    return;
                }
                lblIDTruyCapMsg.Text = "Chú ý: Bạn chưa phải là thành viên của G Corner";
                lblIDTruyCapMsg.Visible = true;
            }
            else if (checkCurrentGCornerID(txtIdTruyCap.Text.ToUpper().Trim()) || checkCurrentIdNewMembers(txtIdTruyCap.Text.ToUpper().Trim()))
            {
                lblIDTruyCapMsg.Text = "ID này đã tham gia bình chọn!";
                lblIDTruyCapMsg.Visible = true;
                return;
            }
            else
            {
                lblIDTruyCapMsg.Visible = false;
            }
        }

        if (txtTenCongTy.Text == "")
        {
            lblMsg.Text = "Bạn hãy nhập tên công ty của mình";
            lblPCCMsg.Visible = true;
            return;
        }
        else
        {
            lblPCCMsg.Visible = false;
        }

        if (txtEmail.Text == "")
        {
            lblMsg.Text = "Bạn hãy nhập địa chỉ email";
            lblMsgEmail.Visible = true;
            return;
        }
        else
        {
            lblMsgEmail.Visible = false;
        }

        if (chk_KhuyenMai_Dulich.Checked == false
            && chk_KhuyenMai_QuaTang.Checked == false
            && chk_KhuyenMai_TangDiem.Checked == false
            && chk_KhuyenMai_KhongQuanTam.Checked == false
            && txt_KhuyenMai_YKienKhac.Text == "")
        {
            lblMsg.Text = "Bạn hãy chọn một hoặc nhiều hình thức khuyến khích của G Corner đối với hội viên?";
            lblCauHoi7.ForeColor = System.Drawing.Color.Red;
            return;
        }
        else
        {
            lblCauHoi1.ForeColor = System.Drawing.Color.Black;
        }

        if (chk_SinhHoat_DaNgoai.Checked == false
            && chk_SinhHoat_TheThao.Checked == false
            && chk_SinhHoat_TuTap.Checked == false
            && chk_SinhHoat_HoiThao.Checked == false
            && txt_SinhHoat_YKienKhac.Text == "")
        {
            lblMsg.Text = "Bạn hãy chọn một hoặc nhiều loại hình sinh hoạt của CLB G Corner!";
            lblCauHoi2.ForeColor = System.Drawing.Color.Red;
            return;
        }
        else
        {
            lblCauHoi2.ForeColor = System.Drawing.Color.Black;
        }

        if (chk_HoiThao_TamLy.Checked == false
            && chk_HoiThao_SucKhoe.Checked == false
            && chk_HoiThao_NgheNghiep.Checked == false
            && txt_HoiThao_YKienKhac.Text == "")
        {
            lblMsg.Text = "Bạn hãy chọn một hoặc nhiều loại chuyên đề dành cho hội viên!";
            lblCauHoi3.ForeColor = System.Drawing.Color.Red;
            return;
        }
        else
        {
            lblCauHoi3.ForeColor = System.Drawing.Color.Black;
        }

        if (chk_ThoiGian_BaThang.Checked == false
            && chk_ThoiGian_SauThang.Checked == false
            && chk_ThoiGian_DeuDan.Checked == false
            && txt_ThoiGian_YKienKhac.Text == "")
        {
            lblMsg.Text = "Bạn hãy chọn thời gian phù hợp để tổ chức các hoạt động!";
            lblCauHoi4.ForeColor = System.Drawing.Color.Red;
            return;
        }
        else
        {
            lblCauHoi4.ForeColor = System.Drawing.Color.Black;
        }

        if (txt_YKienRieng.Text.Length > 254)
        {
            lbInform.Text = "Bạn đã nhập nhiều hơn 255 ký tự, mời nhập lại hoặc gửi email cho chúng tôi.";
            lbInform.Visible = true;
            return;
        }

        DataConnection da = new DataConnection();
        int nGioiTinh = 0;
        if (RadioButtonList2.SelectedValue == "Nam")
        {
            nGioiTinh = 1;
        }
        else
        {
            nGioiTinh = 0;
        }
        int nMaSo = 0;
        Random rdm = new Random();
        nMaSo = rdm.Next(10000, 99999);
        string strInsert = "";
        if (ok == true)
        {
            strInsert = "INSERT INTO tblKhach(HoTen, IDTruyCap, NgaySinh, TenCty, SoThich, GioiTinh, PCC, Mobile, Email, MaSo) VALUES(";
            strInsert += "'" + txtHoten.Text + "',";
            strInsert += "'" + txtIdTruyCap.Text + "',";
            strInsert += "'" + txtNgaySinh.Text + "',";
            strInsert += "'" + txtTenCongTy.Text + "',";
            strInsert += "'" + txtSoThich.Text + "',";
            strInsert += nGioiTinh + ",";
            strInsert += "'" + txtPPC.Text + "',";
            strInsert += "'" + txtMobile.Text + "',";
            strInsert += "'" + txtEmail.Text + "',";
            strInsert += nMaSo;
            strInsert += ")";
        }
        else
        {
            strInsert = "INSERT INTO tblNewMembers(HoTen, IDTruyCap, NgaySinh, TenCty, SoThich, GioiTinh, PCC, Mobile, Email, MaSo) VALUES(";
            strInsert += "'" + txtHoten.Text + "',";
            strInsert += "'" + txtIdTruyCap.Text + "',";
            strInsert += "'" + txtNgaySinh.Text + "',";
            strInsert += "'" + txtTenCongTy.Text + "',";
            strInsert += "'" + txtSoThich.Text + "',";
            strInsert += nGioiTinh + ",";
            strInsert += "'" + txtPPC.Text + "',";
            strInsert += "'" + txtMobile.Text + "',";
            strInsert += "'" + txtEmail.Text + "',";
            strInsert += nMaSo;
            strInsert += ")";
        }

        // Thực thi câu lệnh insert
        if (da.ExecuteCommand(strInsert) > 0)
        {
            string strInsertKhuyenMai = "INSERT INTO tblKhuyenMai(IDTruyCap, KhuyenMai_Dulich, KhuyenMai_QuaTang, KhuyenMai_TangDiem, KhuyenMai_KhongQuanTam, KhuyenMai_YKienKhac) VALUES(";
            strInsertKhuyenMai += "'" + txtIdTruyCap.Text + "',";
            strInsertKhuyenMai += "'" + chk_KhuyenMai_Dulich.Checked.ToString() + "',";
            strInsertKhuyenMai += "'" + chk_KhuyenMai_QuaTang.Checked.ToString() + "',";
            strInsertKhuyenMai += "'" + chk_KhuyenMai_TangDiem.Checked.ToString() + "',";
            strInsertKhuyenMai += "'" + chk_KhuyenMai_KhongQuanTam.Checked.ToString() + "',";
            strInsertKhuyenMai += "'" + txt_KhuyenMai_YKienKhac.Text + "'";
            strInsertKhuyenMai += ")";

            string strInsertLoaiHinhSinhHoat = "INSERT INTO tblLoaiHinhSinhHoat(IDTruyCap, SinhHoat_DaNgoai, SinhHoat_TheThao, SinhHoat_TuTap, SinhHoat_HoiThao, SinhHoat_YKienKhac) VALUES(";
            strInsertLoaiHinhSinhHoat += "'" + txtIdTruyCap.Text + "',";
            strInsertLoaiHinhSinhHoat += "'" + chk_SinhHoat_DaNgoai.Checked.ToString() + "',";
            strInsertLoaiHinhSinhHoat += "'" + chk_SinhHoat_TheThao.Checked.ToString() + "',";
            strInsertLoaiHinhSinhHoat += "'" + chk_SinhHoat_TuTap.Checked.ToString() + "',";
            strInsertLoaiHinhSinhHoat += "'" + chk_SinhHoat_HoiThao.Checked.ToString() + "',";
            strInsertLoaiHinhSinhHoat += "'" + txt_SinhHoat_YKienKhac.Text + "'";
            strInsertLoaiHinhSinhHoat += ")";

            string strInsertHoiThao = "INSERT INTO tblHoiThao(IDTruyCap, HoiThao_TamLy, HoiThao_SucKhoe, HoiThao_NgheNghiep, HoiThao_YKienKhac) VALUES(";
            strInsertHoiThao += "'" + txtIdTruyCap.Text + "',";
            strInsertHoiThao += "'" + chk_HoiThao_TamLy.Checked.ToString() + "',";
            strInsertHoiThao += "'" + chk_HoiThao_SucKhoe.Checked.ToString() + "',";
            strInsertHoiThao += "'" + chk_HoiThao_NgheNghiep.Checked.ToString() + "',";
            strInsertHoiThao += "'" + txt_HoiThao_YKienKhac.Text + "'";
            strInsertHoiThao += ")";

            string strInsertThoiGianToChuc = "INSERT INTO tblThoiGianToChuc(IDTruyCap, ThoiGian_BaThang, ThoiGian_SauThang, ThoiGian_DeuDan, ThoiGian_YKienKhac) VALUES(";
            strInsertThoiGianToChuc += "'" + txtIdTruyCap.Text + "',";
            strInsertThoiGianToChuc += "'" + chk_ThoiGian_BaThang.Checked.ToString() + "',";
            strInsertThoiGianToChuc += "'" + chk_ThoiGian_SauThang.Checked.ToString() + "',";
            strInsertThoiGianToChuc += "'" + chk_ThoiGian_DeuDan.Checked.ToString() + "',";
            strInsertThoiGianToChuc += "'" + txt_ThoiGian_YKienKhac.Text + "'";
            strInsertThoiGianToChuc += ")";

            string strInsertYKien = "INSERT INTO tblYKien(IDTruyCap, YKienRieng) VALUES(";
            strInsertYKien += "'" + txtIdTruyCap.Text + "',";
            strInsertYKien += "'" + txt_YKienRieng.Text + "'";
            strInsertYKien += ")";

            if ((da.ExecuteCommand(strInsertKhuyenMai) > 0)
                && (da.ExecuteCommand(strInsertLoaiHinhSinhHoat) > 0)
                && (da.ExecuteCommand(strInsertHoiThao) > 0)
                && (da.ExecuteCommand(strInsertThoiGianToChuc) > 0)
                && (da.ExecuteCommand(strInsertYKien) > 0))
            {
                lbInform.Visible = true;
                lblSubmitSuccessMsg.Visible = true;
                lblMaSo.Text = nMaSo.ToString();
                lblMaSo.Visible = true;
                lblMsg.Visible = false;
		        lbInform.Visible = false;
                reset();
            }
            else
            {
                lbInform.Text = "Việc submit không thành công. Chi tiết: " + da.Error;
                lbInform.Visible = true;
                return;
            }
        }

        else
        {
            lbInform.Text = "Việc submit không thành công. Chi tiết: " + da.Error;
            lbInform.Visible = true;
        }
        //-------------------------------------------------------------------------------------------
        lblHoTenMsg.Visible = false;
        lblPCCMsg.Visible = false;
        lkbDangKy.Visible = false;
        if (ok == false)
        {
            lblIDTruyCapMsg.Visible = true;
        }
        else
        {
            lblIDTruyCapMsg.Visible = false; 
        }

        lblCauHoi7.ForeColor = System.Drawing.Color.Black;
        lblCauHoi2.ForeColor = System.Drawing.Color.Black;
        lblCauHoi3.ForeColor = System.Drawing.Color.Black;
        lblCauHoi4.ForeColor = System.Drawing.Color.Black;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>G Corner - Quick survey</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Panel ID="Panel1" runat="server"
            style="z-index: 1; width: 788px; height: 202px; position: absolute; top: 219px; left: 395px" >      
        <asp:Label ID="lblIDTruyCapMsg" runat="server" Text="*" ForeColor="Red" Visible="false" 
        style="z-index: 1; position: absolute; top: 45px; left: 310px; width: 489px;"></asp:Label>
        <asp:Table ID="Table1" runat="server" Width="776px" Height="189px" 
            style="margin-right: 5px">
            <asp:TableRow HorizontalAlign="Left">
                <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Họ tên"></asp:Label>
                </asp:TableCell>
                <asp:TableCell >
                <asp:TextBox ID="txtHoten" runat="server" Width="200px"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell Width="350px">
                <asp:Label ID="lblHoTenMsg" runat="server" Text="* " ForeColor="Red" Visible="false"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left">
                <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="G Corner ID"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="txtIdTruyCap" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left" Visible="false">
                <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Ngày sinh"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="txtNgaySinh" runat="server" ></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left" Visible="false">
                <asp:TableCell HorizontalAlign="Left">
                <asp:Label ID="Label6" runat="server" Text="Giới tính"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem Value="Nam">Nam</asp:ListItem>
                    <asp:ListItem Value="Nu">Nữ</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RadioButtonList ID="RadioButtonList1"
                    runat="server">
                </asp:RadioButtonList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left">
                <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Tên công ty / đại lý"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="txtTenCongTy" runat="server" Width="200px"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                <asp:Label ID="lblPCCMsg" runat="server" Text="*" ForeColor="Red" Visible="False"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left" Visible="false">
                <asp:TableCell>
                <asp:Label ID="Label7" runat="server" Text="PPC"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="txtPPC" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left" Visible="false">
                <asp:TableCell>
                <asp:Label ID="Label5" runat="server" Text="Sở thích"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="txtSoThich" runat="server" Width="250px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left">
                <asp:TableCell>
                <asp:Label ID="Label8" runat="server" Text="Mobile"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Left">
                <asp:TableCell>
                <asp:Label ID="Label9" runat="server" Text="Email"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                <asp:Label ID="lblMsgEmail" runat="server" Text="*" ForeColor="Red" Visible="False"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </asp:Panel>
    <asp:Panel ID="Panel5" runat="server" 
            style="z-index: 1; width: 702px; height: 111px; position: absolute; top: 1073px; left: 289px" 
            BorderStyle="Ridge">
        <asp:Table ID="Table9" runat="server" 
            
            
            style="z-index: 1; width: 675px; height: 25px; position: absolute; top: 79px; left: 12px">
            <asp:TableRow>
                <asp:TableCell>
                <asp:Label ID="Label13" runat="server" Text="Ý kiến khác: "> </asp:Label>
                </asp:TableCell>
                <asp:TableCell HorizontalAlign="Left">
                <asp:TextBox ID="txt_ThoiGian_YKienKhac" runat="server" Width="500px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Table ID="Table10" runat="server" 
            style="z-index: 1; width: 547px; height: 77px; position: absolute; top: 2px; left: 5px">
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_ThoiGian_BaThang" runat="server" Text="3 tháng/lần và kéo dài 1 buổi/sự kiện" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_ThoiGian_SauThang" runat="server" Text="6 tháng/lần và kéo dài 1 buổi/sự kiện" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_ThoiGian_DeuDan" runat="server" Text="Đều đặn hàng tháng" /></asp:TableCell></asp:TableRow>
        </asp:Table>
    </asp:Panel>
    
    <asp:Panel ID="Panel2" runat="server" BorderStyle="Ridge" 
            
            
            
            
            style="z-index: 1; width: 700px; height: 135px; position: absolute; top: 514px; left: 291px">
        <asp:Table ID="Table2" runat="server"  
            style="z-index: 1; width: 389px; height: 77px; position: absolute; top: 3px; left: 6px">
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_KhuyenMai_Dulich" runat="server" Text="Du lịch/nghỉ dưỡng" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_KhuyenMai_QuaTang" runat="server" Text="Quà tặng vật phẩm/thẻ mua hàng/phiếu tặng quà" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_KhuyenMai_TangDiem" runat="server" Text="Tặng điểm tích lũy hội viên" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_KhuyenMai_KhongQuanTam" runat="server" Text="Không quan tâm" /></asp:TableCell></asp:TableRow>
        </asp:Table>
        <asp:Table ID="Table3" runat="server" 
            
            style="z-index: 1; width: 658px; height: 25px; position: absolute; top: 103px; left: 13px">
            <asp:TableRow>
                <asp:TableCell>
                <asp:Label ID="Label10" runat="server" Text="Ý kiến khác: "> </asp:Label>
                </asp:TableCell>
                <asp:TableCell HorizontalAlign="Left">
                <asp:TextBox ID="txt_KhuyenMai_YKienKhac" runat="server" Width="500px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" 
        style="z-index: 1; width: 700px; height: 135px; position: absolute; top: 701px; left: 291px" 
        BorderStyle="Ridge">
        <asp:Table ID="Table4" runat="server" 
            style="z-index: 1; width: 653px; height: 77px; position: absolute; top: 2px; left: 5px">
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_SinhHoat_DaNgoai" runat="server" Text="Hoạt động dã ngoại/team building" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_SinhHoat_TheThao" runat="server" Text="Hoạt động thể thao/vui chơi/giải trí" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_SinhHoat_TuTap" runat="server" Text="Các hoạt động sinh hoạt tụ tập nhóm theo chủ đề (Pizza Day, BBQ Day, Swimming,...)" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_SinhHoat_HoiThao" runat="server" Text="Các chương trình hội thảo, tư vấn và nâng cao kỹ năng nghề nghiệp" /></asp:TableCell></asp:TableRow>
        </asp:Table>
        <asp:Table ID="Table5" runat="server" 
            style="z-index: 1; width: 677px; height: 25px; position: absolute; top: 103px; left: 10px">
            <asp:TableRow>
                <asp:TableCell>
                <asp:Label ID="Label11" runat="server" Text="Các chủ đề khác: "> </asp:Label>
                </asp:TableCell>
                <asp:TableCell HorizontalAlign="Left">
                <asp:TextBox ID="txt_SinhHoat_YKienKhac" runat="server" Width="500px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" 
        
            style="z-index: 1; width: 701px; height: 112px; position: absolute; top: 908px; left: 292px" 
            BorderStyle="Ridge">
        <asp:Table ID="Table6" runat="server" 
            style="z-index: 1; width: 547px; height: 77px; position: absolute; top: 2px; left: 5px">
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_HoiThao_TamLy" runat="server" Text="Các chủ đề tâm lý, tình cảm, gia đình" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_HoiThao_SucKhoe" runat="server" Text="Các chủ đề chăm sóc sức khỏe, làm đẹp, kỹ năng sống" /></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:CheckBox ID="chk_HoiThao_NgheNghiep" runat="server" Text="Các chủ đề công việc, nâng cao kỹ năng nghề nghiệp" /></asp:TableCell></asp:TableRow>
        </asp:Table>
        <asp:Table ID="Table7" runat="server" 
            style="z-index: 1; width: 668px; height: 25px; position: absolute; top: 79px; left: 12px">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label12" runat="server" Text="Ý kiến khác: "> </asp:Label>
                </asp:TableCell>
                <asp:TableCell HorizontalAlign="Left">
                    <asp:TextBox ID="txt_HoiThao_YKienKhac" runat="server" Width="500px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </asp:Panel>
    </div>
    <p style="text-align: left">
    <asp:Label ID="lblCauHoi1" runat="server" 
            Text="Thăm dò ý kiến hội viên về định hướng các hoạt động của G Corner 2010" 
            style="z-index: 1; position: absolute; top: 77px; left: 249px; width: 782px;" 
            Font-Bold="True" ForeColor="#333300" Font-Size="X-Large"></asp:Label>
    <asp:Label ID="lblCauHoi2" runat="server" 
            Text="2. Bạn quan tâm đến các loại hình sinh hoạt nào nhất của CLB G Corner?" 
            style="z-index: 1; position: absolute; top: 680px; left: 294px; width: 697px;" 
            Font-Bold="True" ForeColor="#333300"></asp:Label>
    <asp:Label ID="lblCauHoi4" runat="server" 
            Text="4. Theo bạn, thời gian tổ chức các hoạt động cho G Corner như thế nào là phù hợp?" 
            style="z-index: 1; position: absolute; top: 1051px; left: 294px; width: 697px;" 
            Font-Bold="True" ForeColor="#333300"></asp:Label>
    <asp:Label ID="lblCauHoi5" runat="server" 
            Text="5. Xin vui lòng cho biết một vài ý kiến của bạn về Câu lạc bộ G Corner? (Tối đa 250 ký tự)" 
            style="z-index: 1; position: absolute; top: 1213px; left: 294px; width: 803px;" 
            Font-Bold="True" ForeColor="#333300"></asp:Label>
    <asp:Label ID="lblCauHoi3" runat="server" 
        Text="3. Sắp tới, G Corner sẽ tổ chức hội thảo chuyên đề dành cho hội viên, bạn quan tâm đến nội dung   nào dưới đây?" 
        style="z-index: 1; position: absolute; top: 868px; left: 294px; width: 690px;" 
        Font-Bold="True" ForeColor="#333300"></asp:Label>
    <asp:Label ID="Label15" runat="server" 
            Text="Xin bạn cho biết một vài thông tin cá nhân:" 
            style="z-index: 1; position: absolute; top: 199px; left: 394px; width: 361px;" 
            Font-Bold="True" ForeColor="#333300"></asp:Label>
    <asp:Label ID="lbInform" runat="server" 
            style="z-index: 1; position: absolute; top: 1470px; left: 292px; width: 710px; height: 80px; font-weight: bold;"  ForeColor="#333300"></asp:Label>
    </p>
    <asp:TextBox ID="txt_YKienRieng" runat="server" 
        style="z-index: 1; position: absolute; top: 1235px; left: 292px; width: 707px; height: 87px" 
        TextMode="MultiLine"></asp:TextBox>
    <asp:Button ID="btnSubmit" runat="server" 
        style="z-index: 1; position: absolute; top: 1338px; left: 593px; width: 147px" 
        Text="Submit" onclick="btnSubmit_Click1" />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" 
        ImageUrl="G corner Logo.jpg" 
        
        
        
        style="position:absolute; left: 257px; top: 14px; width: 101px; height: auto;"/>
        <br />
        <br />
        <br />
    <p style="text-align: justify">
    <asp:Label ID="lblSubmitSuccessMsg" runat="server" 
            Text="Cám ơn bạn đã bình chọn! Mã số dự thưởng của bạn là:" 
            style="z-index: 1; position: absolute; top: 427px; left: 343px; width: 444px; right: 422px;" 
            Font-Bold="True" ForeColor="Lime" Font-Size="Large" Visible="False"></asp:Label>
    <asp:Label ID="lblMsg" runat="server" 
            style="z-index: 1; position: absolute; top: 468px; left: 295px; width: 577px;" 
            Font-Bold="False" ForeColor="Red">Đánh dấu vào những câu trả lời bạn tâm đắc 
        nhất.</asp:Label>
    <asp:Label ID="lblCauHoi7" runat="server" 
            Text="1. Bạn quan tâm tới hình thức khuyến khích nào của CLB G Corner đối với hội viên?" 
            style="z-index: 1; position: absolute; top: 492px; left: 295px; width: 697px;" 
            Font-Bold="True" ForeColor="#333300"></asp:Label>
    <asp:Label ID="lblCauHoi8" runat="server" 
            Text="Để có thể đáp ứng tốt hơn nhu cầu của các hội viên, ban điều hành câu lạc bộ G Corner rất mong muốn bạn dành ít phút cho ý kiến và trả lời một số câu hỏi dưới đây. Các ý kiến đóng góp của bạn sẽ giúp đỡ chúng tôi rất nhiều trong việc định hướng hoạt động của câu lạc bộ trong thời gian tới. Xin chân thành cảm ơn!" 
            style="z-index: 1; position: absolute; top: 123px; left: 268px; width: 697px; height: 78px;" 
            ForeColor="Black"></asp:Label>
    <asp:Label ID="lblMaSo" runat="server" 
            style="z-index: 1; position: absolute; top: 422px; left: 798px; width: 108px; height: 30px;" 
            ForeColor="Blue" Font-Size="X-Large" Visible="False"></asp:Label>
        <asp:LinkButton ID="lkbDangKy" runat="server" 
            PostBackUrl="http://www.galileo.com.vn/Gcorner/Gcorner.asp" Text="Đăng ký" Visible="false" 
            style="position:absolute; left: 871px; top: 468px; width: 86px;">Đăng ký</asp:LinkButton>
    </p>
    <asp:Image ID="Image2" runat="server" ImageUrl="gal_h_4pms_pos.jpg" 
        
        style=" position:absolute; left: 778px; top: 22px; width: 178px; height: 44px;" />
    <asp:Label ID="lbInform0" runat="server" 
            style="z-index: 1; position: absolute; top: 1398px; left: 298px; width: 710px; height: 80px; font-style: italic;" 
             ForeColor="#333300">Liên hệ với G Corner theo số điện 
    thoại 08.38274742 ext 18,19 (SGN) hoặc 04.35622433 ext 24,25 (HAN) để được hướng 
    dẫn chi tiết và giải đáp thắc mắc nếu có.</asp:Label>
    <p>
    <asp:Label ID="lblMsg0" runat="server" 
            Text="Lưu ý: Chỉ có thành viên của G Corner mới được tham gia dự thưởng." 
            style="z-index: 1; position: absolute; top: 1437px; left: 295px; width: 535px; font-weight: bold; font-style: italic;" 
            Font-Bold="False" ForeColor="Red"></asp:Label>
    </p>
    </form>
</body>
</html>
