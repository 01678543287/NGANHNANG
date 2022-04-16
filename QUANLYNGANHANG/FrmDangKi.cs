using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QUANLYNGANHANG
{
    public partial class FrmDangKi : Form
    {
        public FrmDangKi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDangKi_Load(object sender, EventArgs e)
        {
            if (Program.groupNV == "NGANHANG") txt_Nhom.Text = "NGANHANG";
            else txt_Nhom.Text = "CHINHANH";
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            String MaNhanVien = txt_MaNhanVien.Text.Trim(), nhom = txt_Nhom.Text.Trim(),
                taiKhoan = txtTaiKhoan.Text.Trim(), matKhau = txtMatKhau.Text.Trim();

            if (MaNhanVien == "")
            {
                MessageBox.Show("Mã số Nhân viên không được để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNhanVien.Focus();
                return;
            }
            if (taiKhoan == "")
            {
                MessageBox.Show("Tài khoản không được để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            if (matKhau == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            Program.TestLogin = Program.loginDN;
            Program.TestPassword = Program.passwordDN;
            //Program.connection();

            Program.conn.Close();
            SqlCommand cmd = new SqlCommand("SP_TAOLOGIN", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@LGNAME", SqlDbType.VarChar).Value = taiKhoan;
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = matKhau;
            cmd.Parameters.Add("@USERNAME ", SqlDbType.VarChar).Value = MaNhanVien;
            cmd.Parameters.Add("@ROLE ", SqlDbType.VarChar).Value = nhom;
            cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection.Output;

            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                cmd.ExecuteNonQuery();
                Program.conn.Close();
                if ((int)cmd.Parameters["@ret"].Value == -1)
                {
                    MessageBox.Show("Mã Nhân viên không tồn tại!");
                    txt_MaNhanVien.Focus();
                    return;
                }
                MessageBox.Show("Tạo tài khoản thành công!");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txt_MaNhanVien.Text = "";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Program.conn.Close();
                int ret = (int)cmd.Parameters["@ret"].Value;
                if (ret == 1)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                }
                else if (ret == 2)
                {
                    MessageBox.Show("Nhân viên đã có tài khoản!");
                }
                return;
            }
        }
    }
}
