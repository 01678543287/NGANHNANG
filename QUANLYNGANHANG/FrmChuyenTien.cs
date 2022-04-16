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
    public partial class FrmChuyenTien : Form
    {
        public FrmChuyenTien()
        {
            InitializeComponent();
        }

        

        private void FrmChuyenTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            //this.GD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);

        }

        private void sOTK_CHUYENTextBox_Leave(object sender, EventArgs e)
        {
            String hoTen = "";
            Double soDu = 0;
            int check;
            if (string.IsNullOrEmpty(txt_STKChuyen.Text) || txt_STKChuyen.Text.Equals(txt_STKNhan.Text))
            {
                txt_HoTenNguoiChuyen.Text = hoTen;
                txt_SoDu.Text = soDu.ToString("#,###");
                return;
            }
            else
            {
                try
                {
                    Program.conn.Close();
                    SqlDataReader reader;
                    String strSql = "EXEC [dbo].[SP.LayThongTinKhachHang]" + "'" + txt_STKChuyen.Text.ToString().Trim() + "'";
                    reader = Program.ExecuteSqlReader(strSql);
                    reader.Read();
                    check = reader.GetInt32(0);
                    if (check == 1)
                    {
                        hoTen = reader.GetString(1);
                        soDu = Convert.ToDouble(reader.GetDecimal(2));
                        if (!string.IsNullOrEmpty(txt_SoTien.Text))
                            if (soDu < Convert.ToDouble(txt_SoTien.Text)) errorProvider.SetError(txt_SoTien, "Số dư không đủ");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_HoTenNguoiChuyen.Text = hoTen;
                txt_SoDu.Text = soDu.ToString("#,###");
            }
            
        }

        private void txt_STKChuyen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_STKChuyen.Text)) errorProvider.SetError(txt_STKChuyen, "Số tài khoản không được để trống");
            else if (txt_STKChuyen.Text.Equals(txt_STKNhan.Text))
            {
                errorProvider.SetError(txt_STKChuyen, "Số tài khoản chuyển trùng số tài khoản nhận");
            }
            else if(string.IsNullOrEmpty(txt_HoTenNguoiChuyen.Text)) errorProvider.SetError(txt_STKChuyen, "Số tài khoản không tồn tại");
            else
            {
                errorProvider.SetError(txt_STKChuyen, null);
            }
        }

        private void txt_STKNhan_Leave(object sender, EventArgs e)
        {
            String hoTen = "";
            int check;
            if (string.IsNullOrEmpty(txt_STKNhan.Text))
            {
                txt_HoTenNguoiNhan.Text = hoTen;
                return;
            }
            else
            {
                try
                {
                    Program.conn.Close();
                    SqlDataReader reader;
                    String strSql = "EXEC [dbo].[SP.LayThongTinKhachHang]" + "'" + txt_STKNhan.Text.ToString().Trim() + "'";
                    reader = Program.ExecuteSqlReader(strSql);
                    reader.Read();
                    check = reader.GetInt32(0);
                    if (check == 1)
                    {
                        hoTen = reader.GetString(1);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_HoTenNguoiNhan.Text = hoTen;
            }
            
        }

        private void txt_STKChuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_STKNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SoTien_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_STKNhan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_STKNhan.Text)) errorProvider.SetError(txt_STKNhan, "Số tài khoản không được để trống");
            else if (txt_STKNhan.Text.Equals(txt_STKChuyen.Text))
            {
                errorProvider.SetError(txt_STKNhan, "Số tài khoản nhận trùng với số tài khoản chuyển");
            }
            else if (string.IsNullOrEmpty(txt_HoTenNguoiNhan.Text)) errorProvider.SetError(txt_STKNhan,"Số tài khoản không tồn tại");
            else
            {
                errorProvider.SetError(txt_STKNhan, null);
            }
        }

        private void txt_SoTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ( string.IsNullOrEmpty(txt_SoDu.Text) && !string.IsNullOrEmpty(txt_SoTien.Text) && Convert.ToDouble(txt_SoTien.Text)>0)
                {
                     txt_SoTien.Text = Convert.ToDouble(txt_SoTien.Text).ToString("#,###");
                     txt_SoTien.Focus();
                     txt_SoTien.SelectionStart = txt_SoTien.Text.Length;
                     if (Convert.ToDouble(txt_SoTien.Text) < 100000) errorProvider.SetError(txt_SoTien, "Số tiền phải từ 100.000 vnđ tở lên");
                     else if(Convert.ToDouble(txt_SoTien.Text) >= 100000) errorProvider.SetError(txt_SoTien, null);
                    return;
                }
                else if (string.IsNullOrEmpty(txt_SoTien.Text) || Convert.ToDouble(txt_SoTien.Text).Equals(0)) return;
                else
                {
                    double tempSoTien = Convert.ToDouble(txt_SoTien.Text);
                    double tempSoDu = Convert.ToDouble(txt_SoDu.Text);
                    txt_SoTien.Text = tempSoTien.ToString("#,###");
                    txt_SoTien.Focus();
                    txt_SoTien.SelectionStart = txt_SoTien.Text.Length;
                    if (tempSoTien < 100000) errorProvider.SetError(txt_SoTien, "Số tiền phải từ 100.000 vnđ tở lên");
                    else if (tempSoTien > tempSoDu) errorProvider.SetError(txt_SoTien, "Số dư không đủ");
                    else if (tempSoTien >= 100000 && tempSoTien <= tempSoDu) errorProvider.SetError(txt_SoTien, null);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void txt_SoTien_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoTien.Text)) return;
            else
            {
                double temp = Convert.ToDouble(txt_SoTien.Text);
                if (string.IsNullOrEmpty(txt_SoTien.Text)) errorProvider.SetError(txt_SoTien, "Số tiền phải từ 100.000 vnđ");
            }
            
        }

        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            if (errorProvider.GetError(txt_STKChuyen) != "") MessageBox.Show(errorProvider.GetError(txt_STKChuyen), "ERROR");
            else if (errorProvider.GetError(txt_STKNhan) != "") MessageBox.Show(errorProvider.GetError(txt_STKNhan), "ERROR");
            else if (errorProvider.GetError(txt_SoTien) != "") MessageBox.Show(errorProvider.GetError(txt_SoTien), "ERROR");
            else if (txt_HoTenNguoiChuyen.Text.Equals(""))
            {
                MessageBox.Show("Số tài khoản chuyển không được để trống","ERROR");
                return;
            }
            else if (txt_HoTenNguoiNhan.Text.Equals(""))
            {
                MessageBox.Show("Số tài khoản nhận không được để trống", "ERROR");
                return;
            }
            else if (txt_SoTien.Text.Equals(""))
            {
                MessageBox.Show("Số tiền không được để trống", "ERROR");
                return;
            }
            else
            {
                try
                {
                    Program.conn.Close();
                    String strSql = "EXEC [dbo].[SP_CHUYENTIEN]" + "N'" + txt_STKChuyen.Text.ToString().Trim() + "'," + "N'" + txt_STKNhan.Text.ToString().Trim() + "'," + "'" + Convert.ToDouble(txt_SoTien.Text.ToString()) + "'," + "N'" + Program.MaNV.ToString().Trim() + "'";
                    Program.ExecuteSqlNonQuery(strSql);
                    MessageBox.Show("Chuyển tiền thành công","Thông Báo");

                    txt_STKChuyen.Text = "";
                    txt_STKNhan.Text = "";
                    txt_HoTenNguoiChuyen.Text = "";
                    txt_HoTenNguoiNhan.Text = "";
                    txt_SoDu.Text = "";
                    txt_SoTien.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
