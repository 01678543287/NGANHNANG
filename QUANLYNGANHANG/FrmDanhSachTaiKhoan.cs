using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QUANLYNGANHANG
{
    public partial class FrmDanhSachTaiKhoan : Form
    {
        String maCN = "";
        public FrmDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

       

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void FrmDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;

            this.chiNhanhTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.chiNhanhTableAdapter.Fill(this.nGANHANGDataSet.ChiNhanh); // TODO: This line of code loads data into the 'nGANHANGDataSet.ChiNhanh' table. You can move, or remove it, as needed.
            cbbChiNhanh.DataSource = Program.bds_LisSubscriber.DataSource;  // đưa bds_dsPhanManh vào combobox
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
            Program.serverName = cbbChiNhanh.Text;
            maCN = nGANHANGDataSet.ChiNhanh.Rows[0][0].ToString().Trim();
            if (Program.groupNV == "NGANHANG")
            {
                cbbChiNhanh.Enabled = true;
               
            }
            else
            {
                cbbChiNhanh.Enabled = btnBCAll.Enabled = false;
                
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
           
        }
        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            String tuNgay = txtTuNgay.Text.Trim();
            String denNgay = txtDenNgay.Text.Trim();

          
            if (tuNgay.Equals(""))
            {
                MessageBox.Show("Hãy chọn thời gian bắt đầu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuNgay.Focus();
                return;
            }

            if (denNgay.Equals(""))
            {
                MessageBox.Show("Hãy chọn thời gian kết thúc!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDenNgay.Focus();
                return;
            }
            if (DateTime.Parse(txtTuNgay.Text.Trim()) > DateTime.Parse(txtDenNgay.Text.Trim()))
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuNgay.Focus();
                return;
            }
            if (DateTime.Compare(DateTime.Now.Date, txtTuNgay.DateTime.Date) < 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày hiện tại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuNgay.Focus();
                return;
            }
            if (DateTime.Compare(DateTime.Now.Date, txtDenNgay.DateTime.Date) < 0)
            {
                MessageBox.Show("Ngày kết thúc không thể lớn hơn ngày hiện tại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDenNgay.Focus();
                return;
            }


            cbbChiNhanh.ValueMember = "TENSERVER";
            xrpt_DSTK report = new xrpt_DSTK(maCN,tuNgay, denNgay);
            report.lbTitle.Text = "DANH SÁCH TÀI KHOẢN THUỘC CHI NHÁNH " + cbbChiNhanh.Text.ToUpper();
            report.lbTuNgay.Text = tuNgay;
            report.lbDenNgay.Text = denNgay;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
        private void btnBCAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tuNgay = txtTuNgay.Text.Trim();
            String denNgay = txtDenNgay.Text.Trim();


            if (tuNgay.Equals(""))
            {
                MessageBox.Show("Hãy chọn thời gian bắt đầu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuNgay.Focus();
                return;
            }

            if (denNgay.Equals(""))
            {
                MessageBox.Show("Hãy chọn thời gian kết thúc!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDenNgay.Focus();
                return;
            }
            if (DateTime.Parse(txtTuNgay.Text.Trim()) > DateTime.Parse(txtDenNgay.Text.Trim()))
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuNgay.Focus();
                return;
            }
            if (DateTime.Compare(DateTime.Now.Date, txtTuNgay.DateTime.Date) < 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày hiện tại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuNgay.Focus();
                return;
            }
            if (DateTime.Compare(DateTime.Now.Date, txtDenNgay.DateTime.Date) < 0)
            {
                MessageBox.Show("Ngày kết thúc không thể lớn hơn ngày hiện tại", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDenNgay.Focus();
                return;
            }

            xrpt_DSTK report = new xrpt_DSTK("TC", tuNgay, denNgay);
            report.lbTitle.Text = "DANH SÁCH TÀI KHOẢN THUỘC TẤT CẢ CHI NHÁNH ";
            report.lbTuNgay.Text = tuNgay;
            report.lbDenNgay.Text = denNgay;

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}
