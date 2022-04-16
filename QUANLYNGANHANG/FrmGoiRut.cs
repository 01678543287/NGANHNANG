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

namespace QUANLYNGANHANG
{
    

    public partial class FrmGoiRut : Form
    {
        String type = "";
        public FrmGoiRut()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void FrmGoiRut_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.StrConn;
           
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.StrConn;
            
            if (Program.groupNV == "NGANHANG")
            {
                btnGoi.Enabled = btnRut.Enabled = btnHuy.Enabled = groupBox.Enabled =  false;
                btnThoat.Enabled = true;
            }
            else
            {
                groupBox.Enabled =  false;
                btnGoi.Enabled = btnRut.Enabled = btnHuy.Enabled = btnThoat.Enabled = true;
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox.Enabled =  btnHuy.Enabled = false;
            btnGoi.Enabled = btnRut.Enabled = btnThoat.Enabled = true;
            txtSoTK.Text = "";
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtSoDu.Text = "";
            txtTienGD.Text = "";
        }

        private void btnRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThoat.Enabled = btnRut.Enabled = btnGoi.Enabled = false;
            groupBox.Enabled =  btnHuy.Enabled = true;
            type = "RT";
        }

        private void btnGoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThoat.Enabled = btnRut.Enabled = btnGoi.Enabled = false;
            groupBox.Enabled =  btnHuy.Enabled = true;
            type = "GT";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtSoTK.Text.Trim() == "")
            {
                MessageBox.Show("Số TK không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTK.Focus();
                return;
            }
            else if (txtTienGD.Text.Trim() == "")
            {
                MessageBox.Show("Tiền GD không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienGD.Focus();
                return;
            }
            else if (errorProvider1.GetError(txtSoTK) != "") MessageBox.Show(errorProvider1.GetError(txtSoTK), "ERROR");
            else if (errorProvider1.GetError(txtTienGD) != "") MessageBox.Show(errorProvider1.GetError(txtTienGD), "ERROR");
            else if (MessageBox.Show("Bạn muốn thực hiện giao dịch?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            
                {
                try
                {
                    Program.conn.Close();
                    String strSql = "EXEC [dbo].[SP_GOIRUT]" + "N'" + txtSoTK.Text.ToString().Trim() + "'," + "N'" + type + "'," + "'" + Convert.ToDouble(txtTienGD.Text.ToString()) + "'," + "N'" + Program.MaNV.ToString().Trim() + "'";
                    Program.ExecuteSqlNonQuery(strSql);
                    MessageBox.Show("Giao dịch thành công", "Thông Báo");

                    txtSoTK.Text = "";
                    txtHoTen.Text = "";
                    txtCMND.Text = "";
                    txtSoDu.Text = "";
                    txtTienGD.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSoTK_Leave(object sender, EventArgs e)
        {
            String hoTen = "";
            String CMND = "";
            Double soDu = 0;
            int check;
            if (string.IsNullOrEmpty(txtSoTK.Text))
            {
                txtHoTen.Text = hoTen;
                txtCMND.Text = CMND;
                txtSoDu.Text = soDu.ToString("#,###");
                return;
            }
            else
            {
                try
                {
                    Program.conn.Close();
                    SqlDataReader reader;
                    String strSql = "EXEC [dbo].[SP.LayKhachHang]" + "'" + txtSoTK.Text.ToString().Trim() + "'";
                    reader = Program.ExecuteSqlReader(strSql);
                    reader.Read();
                    check = reader.GetInt32(0);
                    if (check == 1 && type.Equals("RT"))
                    {
                        hoTen = reader.GetString(1);
                        CMND = reader.GetString(2);
                        soDu = Convert.ToDouble(reader.GetDecimal(3));
                        if (!string.IsNullOrEmpty(txtTienGD.Text))
                            if (soDu < Convert.ToDouble(txtTienGD.Text))
                                errorProvider1.SetError(txtTienGD, "Số dư không đủ");
                    }
                    else if (check == 1 && type.Equals("GT"))
                    {
                        hoTen = reader.GetString(1);
                        CMND = reader.GetString(2);
                        soDu = Convert.ToDouble(reader.GetDecimal(3));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtHoTen.Text = hoTen;
                txtSoDu.Text = soDu.ToString("#,###");
                txtCMND.Text = CMND;
            }
         }

        private void txtSoTK_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoTK.Text)) {
                errorProvider1.SetError(txtSoTK, "Số tài khoản không được để trống");
            }
            else if (string.IsNullOrEmpty(txtHoTen.Text)){
                errorProvider1.SetError(txtSoTK, "Số tài khoản không tồn tại");
            }
            else
            {
                errorProvider1.SetError(txtSoTK, null);
            }
        }

        private void txtSoTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienGD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienGD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTienGD.Text)) return;
            else
            {
                double temp = Convert.ToDouble(txtTienGD.Text);
                if (string.IsNullOrEmpty(txtTienGD.Text))
                {
                    errorProvider1.SetError(txtTienGD, "Số tiền GD phải từ 100.000 vnđ tở lên");
                }
            }
        }

        private void txtTienGD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSoDu.Text) && !string.IsNullOrEmpty(txtTienGD.Text) && Convert.ToDouble(txtTienGD.Text) > 0)
                {
                    txtTienGD.Text = Convert.ToDouble(txtTienGD.Text).ToString("#,###");
                    txtTienGD.Focus();
                    txtTienGD.SelectionStart = txtTienGD.Text.Length;
                    if (Convert.ToDouble(txtTienGD.Text) < 100000) errorProvider1.SetError(txtTienGD, "Số tiền phải từ 100.000 vnđ tở lên");
                    else if (Convert.ToDouble(txtTienGD.Text) >= 100000) errorProvider1.SetError(txtTienGD, null);
                    return;
                }
                else if (string.IsNullOrEmpty(txtTienGD.Text) || Convert.ToDouble(txtTienGD.Text).Equals(0)) return;
                else 
                {
                    double tempSoTien = Convert.ToDouble(txtTienGD.Text);
                    double tempSoDu = Convert.ToDouble(txtSoDu.Text);
                    txtTienGD.Text = tempSoTien.ToString("#,###");
                    txtTienGD.Focus();
                    txtTienGD.SelectionStart = txtTienGD.Text.Length;
                    if (tempSoTien < 100000) errorProvider1.SetError(txtTienGD, "Số tiền phải từ 100.000 vnđ tở lên");
                    else if (tempSoTien > tempSoDu && type.Equals("RT")) errorProvider1.SetError(txtTienGD, "Số dư không đủ");
                    else if (tempSoTien >= 100000 && tempSoTien <= tempSoDu) errorProvider1.SetError(txtTienGD, null);
                    else if (tempSoTien >= 100000 && type.Equals("GT")) errorProvider1.SetError(txtTienGD, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void txtTienGD_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
