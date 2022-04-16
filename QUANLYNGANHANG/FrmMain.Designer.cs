
namespace QUANLYNGANHANG
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoKe = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuiRutTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonGalleryBarItem2 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonCauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonCapNhat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.sttThongTinNhanVien = new System.Windows.Forms.StatusStrip();
            this.lbMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbGroup = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.sttThongTinNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.barButtonItem4,
            this.btnSaoKe,
            this.btnThongKeTaiKhoan,
            this.btnThongKeKhachHang,
            this.barButtonItem8,
            this.btnGuiRutTien,
            this.btnChuyenTien,
            this.btnKhachHang,
            this.btnNhanVien,
            this.barButtonItem13,
            this.btnMoTaiKhoan,
            this.ribbonGalleryBarItem1,
            this.ribbonGalleryBarItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonCauHinh,
            this.ribbonDanhMuc,
            this.ribbonCapNhat,
            this.ribbonBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1109, 209);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnTaoTaiKhoan.Id = 2;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnSaoKe
            // 
            this.btnSaoKe.Caption = "Sao kê";
            this.btnSaoKe.Id = 5;
            this.btnSaoKe.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.icons8_purchase_order_30;
            this.btnSaoKe.Name = "btnSaoKe";
            this.btnSaoKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoKe_ItemClick);
            // 
            // btnThongKeTaiKhoan
            // 
            this.btnThongKeTaiKhoan.Caption = "Thống kê tài khoản";
            this.btnThongKeTaiKhoan.Id = 6;
            this.btnThongKeTaiKhoan.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.icons8_merchant_account_32;
            this.btnThongKeTaiKhoan.Name = "btnThongKeTaiKhoan";
            this.btnThongKeTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeTaiKhoan_ItemClick);
            // 
            // btnThongKeKhachHang
            // 
            this.btnThongKeKhachHang.Caption = "Thống kê khách hàng";
            this.btnThongKeKhachHang.Id = 7;
            this.btnThongKeKhachHang.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.icons8_bank_account_24;
            this.btnThongKeKhachHang.Name = "btnThongKeKhachHang";
            this.btnThongKeKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeKhachHang_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Nhân viên";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // btnGuiRutTien
            // 
            this.btnGuiRutTien.Caption = "Gửi rút tiền";
            this.btnGuiRutTien.Id = 9;
            this.btnGuiRutTien.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.icons8_money_bag_30;
            this.btnGuiRutTien.Name = "btnGuiRutTien";
            this.btnGuiRutTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuiRutTien_ItemClick);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Caption = "Chuyển tiền";
            this.btnChuyenTien.Id = 10;
            this.btnChuyenTien.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.icons8_initiate_money_transfer_30;
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenTien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 11;
            this.btnKhachHang.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.customers;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 12;
            this.btnNhanVien.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.user;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.VisibleInSearchMenu = false;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "barButtonItem13";
            this.barButtonItem13.Id = 13;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // btnMoTaiKhoan
            // 
            this.btnMoTaiKhoan.Caption = "Tài khoản";
            this.btnMoTaiKhoan.Id = 14;
            this.btnMoTaiKhoan.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.account;
            this.btnMoTaiKhoan.Name = "btnMoTaiKhoan";
            this.btnMoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMoTaiKhoan_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 15;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // ribbonGalleryBarItem2
            // 
            this.ribbonGalleryBarItem2.Caption = "ribbonGalleryBarItem2";
            this.ribbonGalleryBarItem2.Id = 16;
            this.ribbonGalleryBarItem2.Name = "ribbonGalleryBarItem2";
            // 
            // ribbonCauHinh
            // 
            this.ribbonCauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonCauHinh.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.config;
            this.ribbonCauHinh.Name = "ribbonCauHinh";
            this.ribbonCauHinh.Text = "Cấu hình";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài Khoản";
            // 
            // ribbonDanhMuc
            // 
            this.ribbonDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonDanhMuc.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.category;
            this.ribbonDanhMuc.Name = "ribbonDanhMuc";
            this.ribbonDanhMuc.Text = "Danh mục";
            this.ribbonDanhMuc.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnGuiRutTien);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnChuyenTien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Giao dịch";
            // 
            // ribbonCapNhat
            // 
            this.ribbonCapNhat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup2});
            this.ribbonCapNhat.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.update;
            this.ribbonCapNhat.Name = "ribbonCapNhat";
            this.ribbonCapNhat.Text = "Cập nhật";
            this.ribbonCapNhat.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Cập nhật";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMoTaiKhoan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Khách hàng";
            // 
            // ribbonBaoCao
            // 
            this.ribbonBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonBaoCao.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.report;
            this.ribbonBaoCao.Name = "ribbonBaoCao";
            this.ribbonBaoCao.Text = "Báo cáo";
            this.ribbonBaoCao.Visible = false;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSaoKe);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnThongKeTaiKhoan);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnThongKeKhachHang);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Hệ thống";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // sttThongTinNhanVien
            // 
            this.sttThongTinNhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttThongTinNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMaNV,
            this.lbHoTen,
            this.lbGroup});
            this.sttThongTinNhanVien.Location = new System.Drawing.Point(0, 658);
            this.sttThongTinNhanVien.Name = "sttThongTinNhanVien";
            this.sttThongTinNhanVien.Size = new System.Drawing.Size(1109, 25);
            this.sttThongTinNhanVien.TabIndex = 2;
            this.sttThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(52, 20);
            this.lbMaNV.Text = "MANV";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(57, 20);
            this.lbHoTen.Text = "HOTEN";
            // 
            // lbGroup
            // 
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(55, 20);
            this.lbGroup.Text = "NHOM";
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 683);
            this.Controls.Add(this.sttThongTinNhanVien);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = global::QUANLYNGANHANG.Properties.Resources.icons8_get_cash_96;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Ngân Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.sttThongTinNhanVien.ResumeLayout(false);
            this.sttThongTinNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonCauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonCapNhat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnSaoKe;
        private DevExpress.XtraBars.BarButtonItem btnThongKeTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnThongKeKhachHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem btnGuiRutTien;
        private DevExpress.XtraBars.BarButtonItem btnChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem btnMoTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem2;
        private System.Windows.Forms.StatusStrip sttThongTinNhanVien;
        public System.Windows.Forms.ToolStripStatusLabel lbMaNV;
        public System.Windows.Forms.ToolStripStatusLabel lbHoTen;
        public System.Windows.Forms.ToolStripStatusLabel lbGroup;
    }
}

