using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNGANHANG
{
    public partial class FrmMoTaiKhoanKH : Form
    {
        String maChiNhanh = "";
        public FrmMoTaiKhoanKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_NGANHANG);

        }

        private void FrmMoTaiKhoanKH_Load(object sender, EventArgs e)
        {
            DS_NGANHANG.EnforceConstraints = false;
            // 
            this.chiNhanhTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.chiNhanhTableAdapter.Fill(DS_NGANHANG.ChiNhanh);
            // TODO: This line of code loads data into the 'dS_NGANHANG.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.khachHangTableAdapter.Fill(this.DS_NGANHANG.KhachHang);
            // TODO: This line of code loads data into the 'dS_NGANHANG.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.taiKhoanTableAdapter.Fill(this.DS_NGANHANG.TaiKhoan);

            cbbChiNhanh.DataSource = Program.bds_LisSubscriber.DataSource;  // đưa bds_dsPhanManh vào combobox
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
            Program.serverName = cbbChiNhanh.Text;
            maChiNhanh = DS_NGANHANG.ChiNhanh.Rows[0][0].ToString().Trim();
            // phân quyền
            if (Program.groupNV == "NGANHANG")
            {
                cbbChiNhanh.Enabled = true;
                btnThem.Enabled = false;
                txtCMND.Enabled = txtSoTK.Enabled = txtSoDu.Enabled = false;
            }
            else
            {
                cbbChiNhanh.Enabled = false;
                btnThem.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
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
                this.khachHangTableAdapter.Fill(this.DS_NGANHANG.KhachHang);
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.taiKhoanTableAdapter.Fill(this.DS_NGANHANG.TaiKhoan);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Regex.IsMatch(txtSoTK.Text.Trim(), "[0-9]{9}"))
            {
                MessageBox.Show("Số tài khoản không hợp lệ! \nSố tài khoản có 9 số!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTK.Focus();
                return;
            }

            if (!Regex.IsMatch(txtCMND.Text.Trim(), "[0-9]{10}"))
            {
                MessageBox.Show("Số CMND không được để trống và có 10 số!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCMND.Focus();
                return;
            }

            else if (txtSoDu.Text.Trim() == "")
            {
                MessageBox.Show("Số dư không được để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDu.Focus();
                return;
            }
            try
            {
                if (Int32.Parse(txtSoDu.Text.Replace(".","").Trim()) < 0)
                {
                    MessageBox.Show("Số dư >= 0 ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số dư không hợp lệ!, số dư >= 0!\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //
            String SoTK, CMND, NgayMo;
            int SoDu;
            SoTK = txtSoTK.Text.Trim();
            CMND = txtCMND.Text.Trim();
            SoDu = Int32.Parse(txtSoDu.Text.Replace(".","").Trim());
            String sql = "EXEC sp_MO_TAI_KHOAN_KH " + "'" + SoTK + "'," + " '" + CMND + "', " + SoDu;

            if (Program.ExecuteSqlNonQuery(sql) == 0)
            {
                MessageBox.Show("Thêm tài khoản khách hàng thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND.Text = "";
                txtSoTK.Text = "";
                txtSoDu.Text = "";
                this.taiKhoanTableAdapter.Fill(this.DS_NGANHANG.TaiKhoan);
                return;
            }
            else
            {
                MessageBox.Show("Thêm tài khoản khách hàng không thành công!\n Hãy xem lại Số tài khoản và CMND khách hàng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.chiNhanhTableAdapter.Fill(DS_NGANHANG.ChiNhanh);
            this.khachHangTableAdapter.Fill(this.DS_NGANHANG.KhachHang);
            this.taiKhoanTableAdapter.Fill(this.DS_NGANHANG.TaiKhoan);
        }
    }
}
