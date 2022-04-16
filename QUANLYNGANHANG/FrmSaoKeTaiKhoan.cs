using DevExpress.XtraReports.UI;
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
    public partial class FrmSaoKeTaiKhoan : Form
    {
        public FrmSaoKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String SoTK = txtSoTK.Text.Trim(), TuNgay = txtTuNgay.Text.Trim(), DenNGay = txtDenNgay.Text.Trim();
            if (!Regex.IsMatch(SoTK, "[0-9]{9}"))
            {
                MessageBox.Show("Số tài khoản không hợp lệ! \nSố tài khoản có 9 số!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTK.Focus();
                return;
            }

            if (TuNgay == "")
            {
                MessageBox.Show("Hãy chọn thời gian bắt đầu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTuNgay.Focus();
                return;
            }

            if (DenNGay == "")
            {
                MessageBox.Show("Hãy chọn thời gian kết thúc!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDenNgay.Focus();
                return;
            }

            xrpt_SaoKeGiaoDichTaiKhoan report = new xrpt_SaoKeGiaoDichTaiKhoan(SoTK, TuNgay, DenNGay);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
