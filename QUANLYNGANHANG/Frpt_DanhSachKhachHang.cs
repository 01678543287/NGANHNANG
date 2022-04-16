using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNGANHANG
{
    public partial class Frpt_DanhSachKhachHang : Form
    {
        public Frpt_DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            xrpt_DanhSachKH report = new xrpt_DanhSachKH( cbb_ChiNhanh.SelectedValue.ToString().Trim());
            report.lbTitle.Text = "DANH SÁCH KHÁCH HÀNG THUỘC CHI NHÁNH " + cbb_ChiNhanh.Text.ToUpper();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void Frpt_DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            cbb_ChiNhanh.DataSource = Program.bds_LisSubscriber;
            cbb_ChiNhanh.DisplayMember = "TENCN";
            cbb_ChiNhanh.ValueMember = "TENSERVER";
            cbb_ChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
