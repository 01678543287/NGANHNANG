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
using System.Globalization;

namespace QUANLYNGANHANG
{
    public partial class FrmNhanVien : Form
    {
        private int vitri;
        private String maCN = "";
        private String type;

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private String sinhMaTuDong()
        {
            int coso = 0;
            if (bds_NhanVien.Count == 0 && maCN.Trim() == "BENTHANH")// nếu danh sách nhân viên rỗng
            {
                coso = 1;
            }
            else if (bds_NhanVien.Count == 0 && maCN.Trim() == "TANDINH")// nếu danh sách nhân viên rỗng
            {
                coso = 2;
            }
            else if (bds_NhanVien.Count == 1 && int.Parse(((DataRowView)bds_NhanVien[0])["MANV"].ToString().Substring(2, 3)) == 1 && maCN.Trim() == "BENTHANH") // nếu danh sách nhân viên có 1 nhân viên và mã người này là NV001
            {
                coso = 3;
            }
            else if (bds_NhanVien.Count == 1 && int.Parse(((DataRowView)bds_NhanVien[0])["MANV"].ToString().Substring(2, 3)) > 1 && maCN.Trim() == "BENTHANH") // nếu danh sách có 1 nhân viên mà mã người này khác NV001
            {
                coso = 1;
            }
            else if (bds_NhanVien.Count == 1 && int.Parse(((DataRowView)bds_NhanVien[0])["MANV"].ToString().Substring(2, 3)) == 2 && maCN.Trim() == "TANDINH") // nếu danh sách nhân viên có 1 nhân viên và mã người này là NV002
            {
                coso = 4;
            }
            else if (bds_NhanVien.Count == 1 && int.Parse(((DataRowView)bds_NhanVien[0])["MANV"].ToString().Trim().Substring(2, 3)) > 2 && maCN.Trim() == "TANDINH") // nếu danh sách có 1 nhân viên mà mã người này khác NV002
            {
                coso = 2;
            }
            else // nếu danh sách có hơn 1 nhân viên
            {
                for (int i = 0; i < bds_NhanVien.Count - 1; i++)
                {
                    if (int.Parse(((DataRowView)bds_NhanVien[i + 1])["MANV"].ToString().Substring(2)) - int.Parse(((DataRowView)bds_NhanVien[i])["MANV"].ToString().Substring(2)) > 2)
                    {
                        coso = int.Parse(((DataRowView)bds_NhanVien[i])["MANV"].ToString().Substring(2)) + 2;
                        break;
                    }
                    coso = int.Parse(((DataRowView)bds_NhanVien[bds_NhanVien.Count - 1])["MANV"].ToString().Substring(2)) + 2;
                }

            }
            if (coso < 10)
                return "NV00" + coso;
            else if (coso < 100)
                return "NV0" + coso;
            else
                return "NV" + coso;
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_NhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void loadComboBox()
        {
            cbb_ChiNhanh.DataSource = Program.bds_LisSubscriber;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
        }
        private void Refresh()
        {
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            this.danhSachNVTableAdapter.Fill(DS.SP_Laydanhsachnhanvien, cbb_ChiNhanh.SelectedValue.ToString().Trim());
            gc_NhanVien.DataSource = DS.SP_Laydanhsachnhanvien;
        }
        private void loadData()
        {
            try
            {
                DS.EnforceConstraints = false;

                //this.nhanVienTableAdapter.Connection.ConnectionString = Program.StrConn;
                /*Program.conn.Close();
                String sql = "EXEC SP_Laydanhsachnhanvien" + "'" + Program.serverName + "'";
                Program.myReader = Program.ExecuteSqlReader(sql);  // lấy thông tin nhân viên
                if (Program.myReader == null) return;
                while (Program.myReader.Read())
                {
                    Console.WriteLine("du lieu: "+ Program.StrConn+":" +String.Format("{0}", Program.myReader[0]));
                }*/
                //MessageBox.Show("test: " + cbb_ChiNhanh.SelectedValue.ToString());
                //MessageBox.Show(cbb_ChiNhanh.SelectedIndex.ToString());

                this.nhanVienTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

                this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.GD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);

                this.danhSachNVTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.danhSachNVTableAdapter.Fill(DS.SP_Laydanhsachnhanvien, Program.serverName);

                gc_NhanVien.DataSource = DS.SP_Laydanhsachnhanvien;

                

                //MessageBox.Show(bds_DanhsachNV.Count.ToString());

                if (bds_DanhsachNV.Count == 0)
                {
                    btnXoa.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ở loadData() là: " + ex.Message);
            }
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            if (Program.groupNV == "NGANHANG")
            {
                cbb_ChiNhanh.Enabled = true;
                btnTThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btn_ChuyenChiNhanh.Enabled = false;
            }
            else
            {
                cbb_ChiNhanh.Enabled = false;
                btnTThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
            }

            loadData();
            loadComboBox();

            //maCN = ((DataRowView)bds_NhanVien[0])["MACN"].ToString();
            try
            {
                Program.conn.Close();
                SqlDataReader reader;
                String strSql = "EXEC [sp_Laychinhanh]" + "'" + Program.serverName + "'";
                reader = Program.ExecuteSqlReader(strSql);
                reader.Read();
                maCN = reader.GetString(0);

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gridView1.FocusedRowHandle;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            btnTThem.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnXoa.Enabled = btnDanhsachnhanvien.Enabled = btnThoat.Enabled = btn_ChuyenChiNhanh.Enabled = false;
            btnPhucHoi.Enabled = true;
            gc_NhanVien.Enabled = false;
            type = "SaveData";


            txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
            txtHo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HO").ToString();
            txtTen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TEN").ToString();
            cbbPhai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PHAI").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIACHI").ToString();
            txtSoDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SODT").ToString();

        }


        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
            Refresh();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString().Trim();
            type = "DeleteData";
            int countGR = 0, countCT = 0;

            try
            {
                Program.conn.Close();
                SqlDataReader reader;

                String strSqlChuyenTien = "EXEC [sp_countChuyenTien]" + "'" + maNV + "'";
                reader = Program.ExecuteSqlReader(strSqlChuyenTien);
                reader.Read();
                countCT = reader.GetInt32(0);

                Program.conn.Close();
                String strSqlGoiRut = "EXEC [sp_countGuiRut]" + "'" + maNV + "'";
                reader = Program.ExecuteSqlReader(strSqlGoiRut);
                reader.Read();
                countGR = reader.GetInt32(0);



                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (countGR > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã thực hiện gửi rút!!!", "ERROR", MessageBoxButtons.OK);
                return;
            }
            if (countCT > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã thực hiện chuyển tiền!!!", "ERROR", MessageBoxButtons.OK);
                return;
            }
            if (Program.MaNV == maNV)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đang trong phiên đăng nhập", "ERROR", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Program.conn.Close();
                    String strSql = "EXEC [spEmployee]" + "'" + "" + "'," + "'" + maNV + "'," + "'" + "" + "'," + "'" + "" + "'," + "N'" + "" + "'," + "'" + "" + "'," + "'" + "" + "'," + "'" + "" + "'," + "'" + this.type + "'";
                    Program.ExecuteSqlNonQuery(strSql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại!!!" + ex.Message, "ERROR", MessageBoxButtons.OK);
                    return;
                }
                finally
                {
                    loadData();
                    Refresh();
                }
            }

            if (bds_DanhsachNV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnTThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gridView1.FocusedRowHandle;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            gc_NhanVien.Enabled = false;
            btnTThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnXoa.Enabled = btnDanhsachnhanvien.Enabled = btnThoat.Enabled = btn_ChuyenChiNhanh.Enabled = false;
            btnPhucHoi.Enabled = true;

            type = "SaveData";
            Emptytxt();
        }
        private void Emptytxt()
        {
            txtMaCN.Text = maCN;
            cbbPhai.SelectedIndex = 1;
            txtMaNV.Text = sinhMaTuDong();
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHo.Focus();
                return;
            }
            else if (Regex.IsMatch(txtHo.Text.Trim(), "[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ]{1,40}$") == false)
            {
                MessageBox.Show("Họ nhân viên chỉ chứa chữ cái và không quá 40 kí tự!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHo.Focus();
                return;
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (Regex.IsMatch(txtTen.Text.Trim(), "[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ]{1,10}$") == false)
            {
                MessageBox.Show("Tên nhân viên chỉ chứa chữ cái và không quá 10 kí tự!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            else if (Regex.IsMatch(txtDiaChi.Text.Trim(), "[0-9a-zA-Z/,.àáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ-]{1,100}$") == false)
            {
                MessageBox.Show("Địa chỉ nhân viên không chứa kí tự đặc biệt!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            else if (txtSoDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại nhân viên không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDT.Focus();
                return;
            }
            else if (Regex.IsMatch(txtSoDT.Text.Trim(), "0[0-9]{9}$") == false)
            {
                MessageBox.Show("Số điện thoại nhân viên không đúng định dạng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDT.Focus();
                return;
            }

            try
            {
                String macn = txtMaCN.ToString().Trim();
                Program.conn.Close();
                String strSql = "EXEC [spEmployee]" + "'" + txtMaCN.Text.Trim() + "'," + "'" + txtMaNV.Text.Trim() + "'," + "N'" + txtHo.Text.Trim() + "'," + "N'" + txtTen.Text.Trim() + "'," + "N'" + cbbPhai.SelectedItem.ToString().Trim() + "'," + "N'" + txtDiaChi.Text.Trim() + "'," + "'" + txtSoDT.Text.Trim() + "'," + "'" + 0 + "'," + "'" + this.type + "'";
                Program.ExecuteSqlNonQuery(strSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                loadData();
                Refresh();
            }
            if (btnSua.Enabled == false)
            {
                Emptytxt();
                MessageBox.Show("Thêm thành công");
                gridView1.FocusedRowHandle = vitri;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox1.Enabled = false;
                gc_NhanVien.Enabled = true;

                btnTThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnXoa.Enabled = btnDanhsachnhanvien.Enabled = btnThoat.Enabled =btn_ChuyenChiNhanh.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = true;

                MessageBox.Show("Thay đổi thành công");
                gridView1.FocusedRowHandle = vitri;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds_NhanVien.CancelEdit();
            if (btnTThem.Enabled == true) bds_NhanVien.Position = vitri;
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            gc_NhanVien.Enabled = true;


            btnTThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnXoa.Enabled = btnDanhsachnhanvien.Enabled = btnThoat.Enabled = btn_ChuyenChiNhanh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            errorProviderFalse.SetError(txtHo, null);
            errorProviderFalse.SetError(txtTen, null);
            errorProviderFalse.SetError(txtSoDT, null);
            errorProviderFalse.SetError(txtDiaChi, null);
        }

        private void cbb_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            this.danhSachNVTableAdapter.Fill(DS.SP_Laydanhsachnhanvien, cbb_ChiNhanh.SelectedValue.ToString().Trim());
            gc_NhanVien.DataSource = DS.SP_Laydanhsachnhanvien;
        }

        private void btn_ChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString().Trim();
            String hoTen = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HO").ToString().Trim() + " " + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TEN").ToString().Trim();
            if (Program.MaNV == maNV)
            {
                MessageBox.Show("Không thể chuyển chi nhánh nhân viên này vì đang trong phiên đăng nhập", "ERROR", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn chuyển chi nhánh cho nhân viên " + hoTen + " ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Program.conn.Close();
                    String strSql = "EXEC [SP_ChuyenChiNhanh]" + "'" + maNV + "'";
                    Program.ExecuteSqlNonQuery(strSql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                }
                finally
                {
                    loadData();
                    Refresh();
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*CultureInfo culture = new CultureInfo("en-US");
            Decimal value = Decimal.Parse(textBox1.Text, NumberStyles.AllowThousands);
            textBox1.Text = String.Format(culture, "{0:N0}", value);
            textBox1.Select(textBox1.Text.Length, 0);*/
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtHo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHo.Text))
            {
                errorProviderFalse.SetError(txtHo, "Họ không được để trống");
            }
            else if (Regex.IsMatch(txtHo.Text.Trim(), "[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ]{1,40}$") == false)
            {
                errorProviderFalse.SetError(txtHo, "Họ không được chứa kí tự đặc biệt");
            }
            else
            {
                errorProviderFalse.SetError(txtHo, null);
            }
        }

        private void txtTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                errorProviderFalse.SetError(txtTen, "Tên không được để trống");
            }
            else if (Regex.IsMatch(txtTen.Text.Trim(), "[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ]{1,40}$") == false)
            {
                errorProviderFalse.SetError(txtTen, "Tên không được chứa kí tự đặt biệt");
            }
            else
            {
                errorProviderFalse.SetError(txtTen, null);
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                errorProviderFalse.SetError(txtDiaChi, "Địa chỉ không được để trống");
            }
            else if (Regex.IsMatch(txtDiaChi.Text.Trim(), "[0-9a-zA-Z/,.àáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ðàáãảạăằắẵẳặâầấẫẩậÀÁÃẢẠĂẰẮẴẲẶÂẦẤẪẨẬđĐêềếễểệEÊỀẾỄỂỆôồốỗổộơờớỡởợÔỒỐỖỔỘƠỜỚỠỞỢứưừữửựỨƯỪỮỬỰyýỳỹỵỷYÝỲỸỴỶiíìĩỉịIÍÌĨỈỊ-]{1,100}$") == false)
            {
                errorProviderFalse.SetError(txtDiaChi, "Địa chỉ không hợp lệ");
            }
            else
            {
                errorProviderFalse.SetError(txtDiaChi, null);
            }
        }

        private void txtSoDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoDT.Text))
            {
                errorProviderFalse.SetError(txtSoDT, "Số điện thoại không được để trống");
            }
            else if (Regex.IsMatch(txtSoDT.Text.Trim(), "0[0-9]{9}$") == false)
            {
                errorProviderFalse.SetError(txtSoDT, "Số điện thoại có 10 số và phải đúng định dạng\nVD:0378543287");
            }
            else
            {
                errorProviderFalse.SetError(txtSoDT, null);
            }
        }
        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
