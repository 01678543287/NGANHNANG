using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNGANHANG
{
    public partial class FrmKhachHang : Form
    {
        private int vitri = 0;
        private String maCN = "";
        private String type;
        private Int32 tonTai;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;
 
            this.chiNhanhTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.chiNhanhTableAdapter.Fill(this.nGANHANGDataSet.ChiNhanh);          
            this.khachHangTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet.TaiKhoan);

            cbbChiNhanh.DataSource = Program.bds_LisSubscriber.DataSource;  // đưa bds_dsPhanManh vào combobox
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
            Program.serverName = cbbChiNhanh.Text;
            maCN = nGANHANGDataSet.ChiNhanh.Rows[0][0].ToString().Trim();
            if (Program.groupNV == "NGANHANG")
            {
                cbbChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = groupBox1.Enabled = groupBox1.Visible = false;
            }
            else
            {
                cbbChiNhanh.Enabled = btnPhucHoi.Enabled = groupBox1.Enabled = groupBox1.Visible = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            }

        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if (cbbChiNhanh.SelectedIndex != Program.CBBSelectedIndexChiNhanh)
            {
                Program.TestLogin = Program.remoteLogin;
                Program.TestPassword = Program.remotePassword;
            }
            else
            {
                Program.TestLogin = Program.loginDN;
                Program.TestPassword = Program.passwordDN;
            }

            if (Program.connection() == 0)
            {
                MessageBox.Show("Lỗi Kết nối tới chi nhánh!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                this.khachHangTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet.TaiKhoan);
                
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = khachHangBindingSource.Position;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            khachHangBindingSource.AddNew();
            txtCN.Text = maCN;
            dtNgayCap.EditValue = "";
            cbbPhai.SelectedIndex = 0;


            txtCMND.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnRefresh.Enabled = false;
            btnPhucHoi.Enabled = true;
            gcKH.Enabled = false;
            type = "ThemData";
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = khachHangBindingSource.Position;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnRefresh.Enabled = false;
            btnPhucHoi.Enabled = true;
            gcKH.Enabled = false;
            txtCMND.Enabled = false;
            dtNgayCap.Focus();
            dtNgayCap.SelectedText = dtNgayCap.Text;
            
            type = "SuaData";
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String CMND = "";
            if (taiKhoanBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng này do khách hàng đã có tài khoản", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    CMND = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString();
                    khachHangBindingSource.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.StrConn;
                    this.khachHangTableAdapter.Update(this.nGANHANGDataSet.KhachHang);
                    type = "XoaData";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
                    khachHangBindingSource.Position = khachHangBindingSource.Find("CMND", CMND);
                    return;
                }
                
            }
            if (khachHangBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khachHangBindingSource.CancelEdit();
            if (btnThem.Enabled == false) khachHangBindingSource.Position = vitri;
            gcKH.Enabled = true;
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnRefresh.Enabled =  true;
            btnPhucHoi.Enabled = false;
            try
            {
                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
                return;
            }
            else if (Regex.IsMatch(txtCMND.Text.Trim(), "[0-9]{10}$") == false)
            {
                MessageBox.Show("CMND phải là chữ số!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
                return;
            }
            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ của khách hàng không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHo.Focus();
                return;
            }
            else if (Regex.IsMatch(txtHo.Text.Trim(), "[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ]{1,40}$") == false)
            {
                MessageBox.Show("Họ của khách hàng chỉ chứa chữ cái và không quá 40 kí tự!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHo.Focus();
                return;
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên của khách hàng không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (Regex.IsMatch(txtTen.Text.Trim(), "[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ]{1,10}$") == false)
            {
                MessageBox.Show("Tên của khách hàng chỉ chứa chữ cái và không quá 10 kí tự!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (cbbPhai.SelectedIndex < 0)
            {
                MessageBox.Show("Giới tính của khách hàng không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (dtNgayCap.SelectedText.Trim().Equals(""))
            {
                MessageBox.Show("Ngày cấp CMND của khách hàng không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNgayCap.Focus();
                return;
            }
            else if (DateTime.Compare(DateTime.Now.Date, dtNgayCap.DateTime.Date) < 0)
            {
                MessageBox.Show("Ngày cấp CMND không được lớn hơn ngày hiện tại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtNgayCap.Focus();
                return;
            }
            else if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại của khách hàng không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            else if (Regex.IsMatch(txtSDT.Text.Trim(), "0[0-9]{9}$") == false)
            {
                MessageBox.Show("Số điện thoại của khách hàng không đúng định dạng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ của khách hàng không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            try
            {
                Program.conn.Close();
                SqlDataReader reader;
                String strSql = "EXEC [sp_CheckKhachHang] " + "'" + txtCMND.Text.Trim() + "'";
                reader = Program.ExecuteSqlReader(strSql);
                reader.Read();
                tonTai = reader.GetInt32(0);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (tonTai == 1 && type.Equals("ThemData"))
            {
                MessageBox.Show("CMND đã tồn tại!", "", MessageBoxButtons.OK);
            }
            else if (tonTai == 1 && type.Equals("SuaData"))
            {
                try
                {
                    khachHangBindingSource.EndEdit();
                    khachHangBindingSource.ResetCurrentItem();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.StrConn;
                    this.khachHangTableAdapter.Update(this.nGANHANGDataSet.KhachHang);
                    MessageBox.Show("Sửa khách hàng thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else if (tonTai == 0 && type.Equals("ThemData"))
            {
                try
                {
                    khachHangBindingSource.EndEdit();
                    khachHangBindingSource.ResetCurrentItem();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.StrConn;
                    this.khachHangTableAdapter.Update(this.nGANHANGDataSet.KhachHang);
                    MessageBox.Show("Thêm khách hàng thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Thêm khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            gcKH.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnRefresh.Enabled =  true;
            btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
        }


    }
}
