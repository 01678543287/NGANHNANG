namespace QUANLYNGANHANG
{
    partial class FrmNhanVien
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
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChuyenChiNhanh = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhsachnhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QUANLYNGANHANG.DS();
            this.bds_NhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QUANLYNGANHANG.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QUANLYNGANHANG.DSTableAdapters.TableAdapterManager();
            this.bds_DanhsachNV = new System.Windows.Forms.BindingSource(this.components);
            this.danhSachNVTableAdapter = new QUANLYNGANHANG.DSTableAdapters.SP_LaydanhsachnhanvienTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbbPhai = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.bds_chuyentien = new System.Windows.Forms.BindingSource(this.components);
            this.GD_CHUYENTIENTableAdapter = new QUANLYNGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.bds_Goirut = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new QUANLYNGANHANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_NhanVien = new DevExpress.XtraGrid.GridControl();
            this.errorProviderFalse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTrue = new System.Windows.Forms.ErrorProvider(this.components);
            mACNLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DanhsachNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_chuyentien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Goirut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(36, 41);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(54, 17);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã CN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Enabled = false;
            mANVLabel.Location = new System.Drawing.Point(253, 41);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(54, 17);
            mANVLabel.TabIndex = 14;
            mANVLabel.Text = "Mã NV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(451, 41);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 15;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(748, 41);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(37, 17);
            tENLabel.TabIndex = 16;
            tENLabel.Text = "Tên:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(956, 41);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(40, 17);
            pHAILabel.TabIndex = 17;
            pHAILabel.Text = "Phái:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(424, 97);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 17);
            dIACHILabel.TabIndex = 18;
            dIACHILabel.Text = "Địa Chỉ:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(737, 97);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(52, 17);
            sODTLabel.TabIndex = 19;
            sODTLabel.Text = "Số ĐT:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnDanhsachnhanvien,
            this.btnThoat,
            this.btnTThem,
            this.btn_ChuyenChiNhanh});
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_ChuyenChiNhanh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnTThem
            // 
            this.btnTThem.Caption = "Thêm";
            this.btnTThem.Id = 8;
            this.btnTThem.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.add_user;
            this.btnTThem.Name = "btnTThem";
            this.btnTThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.edit_user;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.remove_user;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btn_ChuyenChiNhanh
            // 
            this.btn_ChuyenChiNhanh.Caption = "Chuyển Chi Nhánh";
            this.btn_ChuyenChiNhanh.Id = 9;
            this.btn_ChuyenChiNhanh.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.change_user;
            this.btn_ChuyenChiNhanh.Name = "btn_ChuyenChiNhanh";
            this.btn_ChuyenChiNhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ChuyenChiNhanh_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.undo;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnDanhsachnhanvien
            // 
            this.btnDanhsachnhanvien.Caption = "Danh sách nhân viên";
            this.btnDanhsachnhanvien.Id = 6;
            this.btnDanhsachnhanvien.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.preferences_contact_list;
            this.btnDanhsachnhanvien.Name = "btnDanhsachnhanvien";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.log_out;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1177, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 839);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1177, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 789);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1177, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 789);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.upload;
            this.btnGhi.Name = "btnGhi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_ChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 100);
            this.panel1.TabIndex = 5;
            // 
            // cbb_ChiNhanh
            // 
            this.cbb_ChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ChiNhanh.FormattingEnabled = true;
            this.cbb_ChiNhanh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbb_ChiNhanh.Location = new System.Drawing.Point(145, 32);
            this.cbb_ChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_ChiNhanh.Name = "cbb_ChiNhanh";
            this.cbb_ChiNhanh.Size = new System.Drawing.Size(309, 24);
            this.cbb_ChiNhanh.TabIndex = 1;
            this.cbb_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbb_ChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_NhanVien
            // 
            this.bds_NhanVien.DataMember = "NhanVien";
            this.bds_NhanVien.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bds_DanhsachNV
            // 
            this.bds_DanhsachNV.DataMember = "SP_Laydanhsachnhanvien";
            this.bds_DanhsachNV.DataSource = this.DS;
            // 
            // danhSachNVTableAdapter
            // 
            this.danhSachNVTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sODTLabel);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(this.cbbPhai);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(mACNLabel);
            this.groupBox1.Controls.Add(this.txtMaCN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 370);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1177, 469);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // txtSoDT
            // 
            this.txtSoDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DanhsachNV, "SODT", true));
            this.txtSoDT.Location = new System.Drawing.Point(795, 94);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDT.MaxLength = 10;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(311, 22);
            this.txtSoDT.TabIndex = 20;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            this.txtSoDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoDT_Validating);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DanhsachNV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(485, 94);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.MaxLength = 100;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(227, 22);
            this.txtDiaChi.TabIndex = 19;
            this.txtDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiaChi_Validating);
            // 
            // cbbPhai
            // 
            this.cbbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DanhsachNV, "PHAI", true));
            this.cbbPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhai.FormattingEnabled = true;
            this.cbbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbPhai.Location = new System.Drawing.Point(1005, 38);
            this.cbbPhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPhai.Name = "cbbPhai";
            this.cbbPhai.Size = new System.Drawing.Size(95, 24);
            this.cbbPhai.TabIndex = 18;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DanhsachNV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(795, 38);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.MaxLength = 10;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(129, 22);
            this.txtTen.TabIndex = 17;
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            this.txtTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtTen_Validating);
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DanhsachNV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(489, 38);
            this.txtHo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHo.MaxLength = 40;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(224, 22);
            this.txtHo.TabIndex = 16;
            this.txtHo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHo_KeyPress);
            this.txtHo.Validating += new System.ComponentModel.CancelEventHandler(this.txtHo_Validating);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_DanhsachNV, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(309, 38);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 15;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(491, 149);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(104, 31);
            this.btnThemMoi.TabIndex = 14;
            this.btnThemMoi.Text = "Đồng ý";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtMaCN
            // 
            this.txtMaCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_NhanVien, "MACN", true));
            this.txtMaCN.Enabled = false;
            this.txtMaCN.Location = new System.Drawing.Point(93, 38);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(133, 22);
            this.txtMaCN.TabIndex = 13;
            // 
            // bds_chuyentien
            // 
            this.bds_chuyentien.DataMember = "GD_CHUYENTIEN";
            this.bds_chuyentien.DataSource = this.DS;
            // 
            // GD_CHUYENTIENTableAdapter
            // 
            this.GD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // bds_Goirut
            // 
            this.bds_Goirut.DataMember = "GD_GOIRUT";
            this.bds_Goirut.DataSource = this.DS;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.DropDownRows = 2;
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT});
            this.gridView1.GridControl = this.gc_NhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMANV, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 113;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 109;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 109;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 109;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.ColumnEdit = this.repositoryItemComboBox1;
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 109;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số ĐT";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            this.colSODT.Width = 109;
            // 
            // gc_NhanVien
            // 
            this.gc_NhanVien.DataSource = this.bds_NhanVien;
            this.gc_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_NhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_NhanVien.Location = new System.Drawing.Point(0, 150);
            this.gc_NhanVien.MainView = this.gridView1;
            this.gc_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_NhanVien.MenuManager = this.barManager1;
            this.gc_NhanVien.Name = "gc_NhanVien";
            this.gc_NhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gc_NhanVien.Size = new System.Drawing.Size(1177, 220);
            this.gc_NhanVien.TabIndex = 6;
            this.gc_NhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // errorProviderFalse
            // 
            this.errorProviderFalse.ContainerControl = this;
            // 
            // errorProviderTrue
            // 
            this.errorProviderTrue.ContainerControl = this;
            this.errorProviderTrue.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderTrue.Icon")));
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 859);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gc_NhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_DanhsachNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_chuyentien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_Goirut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDanhsachnhanvien;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_ChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bds_NhanVien;
        private DS DS;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bds_DanhsachNV;
        private DSTableAdapters.SP_LaydanhsachnhanvienTableAdapter danhSachNVTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Button btnThemMoi;
        private DevExpress.XtraBars.BarButtonItem btnTThem;
        private System.Windows.Forms.BindingSource bds_chuyentien;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter GD_CHUYENTIENTableAdapter;
        private System.Windows.Forms.BindingSource bds_Goirut;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DevExpress.XtraGrid.GridControl gc_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbbPhai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraBars.BarButtonItem btn_ChuyenChiNhanh;
        private System.Windows.Forms.ErrorProvider errorProviderFalse;
        private System.Windows.Forms.ErrorProvider errorProviderTrue;
    }
}