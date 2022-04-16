
namespace QUANLYNGANHANG
{
    partial class FrmKhachHang
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel1;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGANHANGDataSet = new QUANLYNGANHANG.NGANHANGDataSet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QUANLYNGANHANG.NGANHANGDataSetTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new QUANLYNGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.chiNhanhTableAdapter = new QUANLYNGANHANG.NGANHANGDataSetTableAdapters.ChiNhanhTableAdapter();
            this.taiKhoanTableAdapter = new QUANLYNGANHANG.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbbPhai = new System.Windows.Forms.ComboBox();
            this.dtNgayCap = new DevExpress.XtraEditors.DateEdit();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new DevExpress.XtraEditors.PanelControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            mACNLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(128, 47);
            mACNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(70, 17);
            mACNLabel.TabIndex = 0;
            mACNLabel.Text = "Chi nhánh";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(113, 47);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(132, 112);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(32, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(127, 180);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(38, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TÊN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(609, 47);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(61, 17);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(1101, 47);
            pHAILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(42, 17);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHÁI:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(595, 113);
            nGAYCAPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(76, 17);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "NGÀY CẤP:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(621, 180);
            sODTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(53, 17);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SỐ ĐT:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(1095, 117);
            mACNLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(53, 17);
            mACNLabel1.TabIndex = 14;
            mACNLabel1.Text = "MÃ CN:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.add_user;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
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
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.remove_user;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.undo;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1258, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 839);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1258, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 789);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1258, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 789);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(mACNLabel);
            this.panelControl1.Controls.Add(this.cbbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1258, 123);
            this.panelControl1.TabIndex = 4;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiNhanhBindingSource, "MACN", true));
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(209, 43);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(160, 24);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // chiNhanhBindingSource
            // 
            this.chiNhanhBindingSource.DataMember = "ChiNhanh";
            this.chiNhanhBindingSource.DataSource = this.nGANHANGDataSet;
            // 
            // nGANHANGDataSet
            // 
            this.nGANHANGDataSet.DataSetName = "NGANHANGDataSet";
            this.nGANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.nGANHANGDataSet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = this.chiNhanhTableAdapter;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = QUANLYNGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.khachHangBindingSource;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcKH.Location = new System.Drawing.Point(0, 173);
            this.gcKH.MainView = this.gridView1;
            this.gcKH.Margin = new System.Windows.Forms.Padding(4);
            this.gcKH.MenuManager = this.barManager1;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(1258, 171);
            this.gcKH.TabIndex = 6;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gcKH;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 27;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 100;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 27;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 100;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 27;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 100;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 27;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 100;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "PHÁI";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 27;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 100;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "NGÀY CẤP";
            this.colNGAYCAP.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 27;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 100;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "SỐ ĐT";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 27;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 100;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "FK_TaiKhoan_KhachHang";
            this.taiKhoanBindingSource.DataSource = this.khachHangBindingSource;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(175, 43);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.MaxLength = 10;
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(355, 24);
            this.txtCMND.TabIndex = 1;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(175, 108);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(355, 23);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(175, 176);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(355, 23);
            this.txtTen.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(680, 43);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(348, 23);
            this.txtDiaChi.TabIndex = 7;
            // 
            // cbbPhai
            // 
            this.cbbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "PHAI", true));
            this.cbbPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhai.FormattingEnabled = true;
            this.cbbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbPhai.Location = new System.Drawing.Point(1156, 43);
            this.cbbPhai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPhai.Name = "cbbPhai";
            this.cbbPhai.Size = new System.Drawing.Size(160, 24);
            this.cbbPhai.TabIndex = 9;
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "NGAYCAP", true));
            this.dtNgayCap.EditValue = null;
            this.dtNgayCap.Location = new System.Drawing.Point(680, 110);
            this.dtNgayCap.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayCap.MenuManager = this.barManager1;
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayCap.Size = new System.Drawing.Size(349, 22);
            this.dtNgayCap.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SODT", true));
            this.txtSDT.Location = new System.Drawing.Point(680, 176);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(348, 23);
            this.txtSDT.TabIndex = 13;
            // 
            // txtCN
            // 
            this.txtCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "MACN", true));
            this.txtCN.Enabled = false;
            this.txtCN.Location = new System.Drawing.Point(1156, 113);
            this.txtCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCN.Name = "txtCN";
            this.txtCN.ReadOnly = true;
            this.txtCN.Size = new System.Drawing.Size(160, 23);
            this.txtCN.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1098, 169);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Đồng ý";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(mACNLabel1);
            this.groupBox1.Controls.Add(this.txtCN);
            this.groupBox1.Controls.Add(sODTLabel);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(nGAYCAPLabel);
            this.groupBox1.Controls.Add(this.dtNgayCap);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(this.cbbPhai);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(cMNDLabel);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 344);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1258, 495);
            this.groupBox1.TabIndex = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.FloatLocation = new System.Drawing.Point(966, 269);
            this.bar1.Offset = 2;
            this.bar1.Text = "Tools";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 859);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcKH);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKhachHang";
            this.Text = "Khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private NGANHANGDataSet nGANHANGDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private NGANHANGDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private NGANHANGDataSetTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private System.Windows.Forms.BindingSource chiNhanhBindingSource;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraEditors.PanelControl groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraEditors.DateEdit dtNgayCap;
        private System.Windows.Forms.ComboBox cbbPhai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtCMND;
        private DevExpress.XtraBars.Bar bar1;
    }
}