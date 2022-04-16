using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNGANHANG
{

    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }
        public void HienThiMenu()
        {
            this.ribbonBaoCao.Visible = true;
            this.ribbonCapNhat.Visible = true;
            this.ribbonCauHinh.Visible = true;
            this.btnTaoTaiKhoan.Enabled = true;
            this.ribbonDanhMuc.Visible = true;
            this.btnDangXuat.Enabled = true;
            this.btnDangNhap.Enabled = false;
            if(Program.groupNV.Equals("CHINHANH") ) // login thuộc chi nhánh toàn quyền bật hết các chức nắng (buttons)
            {
                this.btnGuiRutTien.Enabled = true;
                this.btnChuyenTien.Enabled = true;
                this.btnKhachHang.Enabled = true;
                this.btnNhanVien.Enabled = true;
                this.btnMoTaiKhoan.Enabled = true;
            }
            if (Program.groupNV.Equals("NGANHANG")) // login thuộc chi nhánh toàn quyền bật hết các chức nắng (buttons)
            {
                this.btnKhachHang.Enabled = true;
                // hide các button cập nhật dữ liệu chỉ cho xem
                //...
                this.btnNhanVien.Enabled = true;
                // hide các button cập nhật dữ liệu chỉ cho xem
                this.btnMoTaiKhoan.Enabled = true;
                this.ribbonDanhMuc.Visible = false;

            }



        }
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangNhap));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Visible = true;

            }

            
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmNhanVien));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmNhanVien frmNhanVien = new FrmNhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Visible = true;
            }
        }

        private void btnChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmChuyenTien));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmChuyenTien frmChuyenTien = new FrmChuyenTien();
                frmChuyenTien.MdiParent = this;
                frmChuyenTien.Visible = true;
            }
        }

        private void btnThongKeKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_DanhSachKhachHang));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                Frpt_DanhSachKhachHang frpt_DSKH = new Frpt_DanhSachKhachHang();
                frpt_DSKH.MdiParent = this;
                frpt_DSKH.Visible = true;
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangKi));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmDangKi frmMoTK = new FrmDangKi();
                frmMoTK.MdiParent = this;
                frmMoTK.Visible = true;

            }
        }

        private void btnMoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmMoTaiKhoanKH));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmMoTaiKhoanKH frmMoTK = new FrmMoTaiKhoanKH();
                frmMoTK.MdiParent = this;
                frmMoTK.Visible = true;

            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }

            this.ribbonBaoCao.Visible = false;
            this.ribbonCapNhat.Visible = false;
            this.ribbonDanhMuc.Visible = false;
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnDangXuat.Enabled = false;
            this.btnDangNhap.Enabled = true;
            lbHoTen.Text = "";
            lbMaNV.Text = "";
            lbGroup.Text = "";
        }

        private void btnSaoKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmSaoKeTaiKhoan));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmSaoKeTaiKhoan frmMoTK = new FrmSaoKeTaiKhoan();
                frmMoTK.MdiParent = this;
                frmMoTK.Visible = true;

            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmKhachHang));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmKhachHang frmKhachHang = new FrmKhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.Visible = true;

            }
        }

        private void btnGuiRutTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmGoiRut));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmGoiRut frmGoiRut = new FrmGoiRut();
                frmGoiRut.MdiParent = this;
                frmGoiRut.Visible = true;

            }
        }

        private void btnThongKeTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDanhSachTaiKhoan));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmDanhSachTaiKhoan frmDSTK = new FrmDanhSachTaiKhoan();
                frmDSTK.MdiParent = this;
                frmDSTK.Visible = true;

            }
        }
    }
}
