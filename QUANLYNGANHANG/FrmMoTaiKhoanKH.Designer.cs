namespace QUANLYNGANHANG
{
    partial class FrmMoTaiKhoanKH
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
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoTaiKhoanKH));
            this.DS_NGANHANG = new QUANLYNGANHANG.DS();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QUANLYNGANHANG.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new QUANLYNGANHANG.DSTableAdapters.TableAdapterManager();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QUANLYNGANHANG.DSTableAdapters.TaiKhoanTableAdapter();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QUANLYNGANHANG.DSTableAdapters.ChiNhanhTableAdapter();
            this.chiNhanhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCMND3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHO3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTEN3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDIACHI3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPHAI3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNGAYCAP2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSODT2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMACN2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colrowguid2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSOTK = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSODU = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMACN3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTK = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.colSODT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTEN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCMND = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPHAI1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDIACHI1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTEN1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHO1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCMND2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            sODULabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NGANHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(52, 116);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(50, 17);
            sODULabel.TabIndex = 8;
            sODULabel.Text = "SODU:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(53, 34);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(47, 17);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "SOTK:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(51, 73);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 4;
            cMNDLabel.Text = "CMND:";
            // 
            // DS_NGANHANG
            // 
            this.DS_NGANHANG.DataSetName = "DS";
            this.DS_NGANHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.DS_NGANHANG;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.khachHangBindingSource;
            this.khachHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khachHangGridControl.Location = new System.Drawing.Point(332, 77);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(300, 220);
            this.khachHangGridControl.TabIndex = 1;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "FK_TaiKhoan_KhachHang";
            this.taiKhoanBindingSource.DataSource = this.khachHangBindingSource;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanGridControl.Location = new System.Drawing.Point(716, 94);
            this.taiKhoanGridControl.MainView = this.gridView2;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(300, 220);
            this.taiKhoanGridControl.TabIndex = 2;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.taiKhoanGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // chiNhanhBindingSource
            // 
            this.chiNhanhBindingSource.DataMember = "ChiNhanh";
            this.chiNhanhBindingSource.DataSource = this.DS_NGANHANG;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // chiNhanhGridControl
            // 
            this.chiNhanhGridControl.DataSource = this.chiNhanhBindingSource;
            this.chiNhanhGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chiNhanhGridControl.Location = new System.Drawing.Point(747, 311);
            this.chiNhanhGridControl.MainView = this.gridView3;
            this.chiNhanhGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chiNhanhGridControl.Name = "chiNhanhGridControl";
            this.chiNhanhGridControl.Size = new System.Drawing.Size(300, 220);
            this.chiNhanhGridControl.TabIndex = 2;
            this.chiNhanhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.chiNhanhGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            // 
            // colCMND3
            // 
            this.colCMND3.FieldName = "CMND";
            this.colCMND3.Name = "colCMND3";
            // 
            // colHO3
            // 
            this.colHO3.FieldName = "HO";
            this.colHO3.Name = "colHO3";
            // 
            // colTEN3
            // 
            this.colTEN3.FieldName = "TEN";
            this.colTEN3.Name = "colTEN3";
            // 
            // colDIACHI3
            // 
            this.colDIACHI3.FieldName = "DIACHI";
            this.colDIACHI3.Name = "colDIACHI3";
            // 
            // colPHAI3
            // 
            this.colPHAI3.FieldName = "PHAI";
            this.colPHAI3.Name = "colPHAI3";
            // 
            // colNGAYCAP2
            // 
            this.colNGAYCAP2.FieldName = "NGAYCAP";
            this.colNGAYCAP2.Name = "colNGAYCAP2";
            // 
            // colSODT2
            // 
            this.colSODT2.FieldName = "SODT";
            this.colSODT2.Name = "colSODT2";
            // 
            // colMACN2
            // 
            this.colMACN2.FieldName = "MACN";
            this.colMACN2.Name = "colMACN2";
            // 
            // colrowguid2
            // 
            this.colrowguid2.FieldName = "rowguid";
            this.colrowguid2.Name = "colrowguid2";
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 0;
            // 
            // colHO2
            // 
            this.colHO2.FieldName = "HO";
            this.colHO2.Name = "colHO2";
            this.colHO2.Visible = true;
            this.colHO2.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Controls.Add(this.taiKhoanGridControl);
            this.groupControl1.Controls.Add(this.khachHangGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 217);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1313, 358);
            this.groupControl1.TabIndex = 54;
            this.groupControl1.Text = "Danh sách khách hàng ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.taiKhoanBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(2, 195);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1309, 161);
            this.gridControl1.TabIndex = 43;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSOTK,
            this.colSODU,
            this.colMACN3,
            this.colNGAYMOTK,
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Tài Khoản Khách Hàng";
            this.gridBand1.Columns.Add(this.colSOTK);
            this.gridBand1.Columns.Add(this.colSODU);
            this.gridBand1.Columns.Add(this.colMACN3);
            this.gridBand1.Columns.Add(this.colNGAYMOTK);
            this.gridBand1.MinWidth = 13;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 312;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.AllowEdit = false;
            this.colSOTK.Visible = true;
            this.colSOTK.Width = 87;
            // 
            // colSODU
            // 
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.Name = "colSODU";
            this.colSODU.OptionsColumn.AllowEdit = false;
            this.colSODU.Visible = true;
            // 
            // colMACN3
            // 
            this.colMACN3.FieldName = "MACN";
            this.colMACN3.Name = "colMACN3";
            this.colMACN3.OptionsColumn.AllowEdit = false;
            this.colMACN3.Visible = true;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.OptionsColumn.AllowEdit = false;
            this.colNGAYMOTK.Visible = true;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn2.Visible = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.barButtonItem2,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(239, 135);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1313, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 652);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1313, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 617);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1313, 35);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 617);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.khachHangBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(2, 28);
            this.gridControl2.MainView = this.gridView4;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1309, 491);
            this.gridControl2.TabIndex = 43;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND4,
            this.colHO4,
            this.colTEN2,
            this.colDIACHI2,
            this.colPHAI2,
            this.colNGAYCAP1,
            this.colSODT1,
            this.colMACN1});
            this.gridView4.GridControl = this.gridControl2;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowFooter = true;
            // 
            // colCMND4
            // 
            this.colCMND4.FieldName = "CMND";
            this.colCMND4.Name = "colCMND4";
            this.colCMND4.OptionsColumn.AllowEdit = false;
            this.colCMND4.Visible = true;
            this.colCMND4.VisibleIndex = 0;
            this.colCMND4.Width = 87;
            // 
            // colHO4
            // 
            this.colHO4.FieldName = "HO";
            this.colHO4.Name = "colHO4";
            this.colHO4.OptionsColumn.AllowEdit = false;
            this.colHO4.Visible = true;
            this.colHO4.VisibleIndex = 1;
            // 
            // colTEN2
            // 
            this.colTEN2.FieldName = "TEN";
            this.colTEN2.Name = "colTEN2";
            this.colTEN2.OptionsColumn.AllowEdit = false;
            this.colTEN2.Visible = true;
            this.colTEN2.VisibleIndex = 2;
            // 
            // colDIACHI2
            // 
            this.colDIACHI2.FieldName = "DIACHI";
            this.colDIACHI2.Name = "colDIACHI2";
            this.colDIACHI2.OptionsColumn.AllowEdit = false;
            this.colDIACHI2.Visible = true;
            this.colDIACHI2.VisibleIndex = 3;
            // 
            // colPHAI2
            // 
            this.colPHAI2.FieldName = "PHAI";
            this.colPHAI2.Name = "colPHAI2";
            this.colPHAI2.OptionsColumn.AllowEdit = false;
            this.colPHAI2.Visible = true;
            this.colPHAI2.VisibleIndex = 4;
            // 
            // colNGAYCAP1
            // 
            this.colNGAYCAP1.FieldName = "NGAYCAP";
            this.colNGAYCAP1.Name = "colNGAYCAP1";
            this.colNGAYCAP1.OptionsColumn.AllowEdit = false;
            this.colNGAYCAP1.Visible = true;
            this.colNGAYCAP1.VisibleIndex = 5;
            // 
            // colSODT1
            // 
            this.colSODT1.FieldName = "SODT";
            this.colSODT1.Name = "colSODT1";
            this.colSODT1.OptionsColumn.AllowEdit = false;
            this.colSODT1.Visible = true;
            this.colSODT1.VisibleIndex = 6;
            // 
            // colMACN1
            // 
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.OptionsColumn.AllowEdit = false;
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 7;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cbbChiNhanh);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 35);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1313, 182);
            this.panelControl2.TabIndex = 53;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(965, 27);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(259, 24);
            this.cbbChiNhanh.TabIndex = 0;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtSoDu);
            this.groupBox1.Controls.Add(this.txtSoTK);
            this.groupBox1.Controls.Add(sODULabel);
            this.groupBox1.Controls.Add(sOTKLabel);
            this.groupBox1.Controls.Add(cMNDLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(813, 222);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mở Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "VND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(97, 70);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.MaxLength = 10;
            this.txtCMND.Size = new System.Drawing.Size(201, 22);
            this.txtCMND.TabIndex = 13;
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(97, 110);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDu.MenuManager = this.barManager1;
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoDu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoDu.Properties.EditFormat.FormatString = "n0";
            this.txtSoDu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoDu.Properties.Mask.EditMask = "n0";
            this.txtSoDu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoDu.Size = new System.Drawing.Size(201, 22);
            this.txtSoDu.TabIndex = 11;
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(97, 32);
            this.txtSoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTK.MenuManager = this.barManager1;
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Properties.MaxLength = 9;
            this.txtSoTK.Size = new System.Drawing.Size(201, 22);
            this.txtSoTK.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            // 
            // colPHAI1
            // 
            this.colPHAI1.FieldName = "PHAI";
            this.colPHAI1.Name = "colPHAI1";
            // 
            // colDIACHI1
            // 
            this.colDIACHI1.FieldName = "DIACHI";
            this.colDIACHI1.Name = "colDIACHI1";
            // 
            // colTEN1
            // 
            this.colTEN1.FieldName = "TEN";
            this.colTEN1.Name = "colTEN1";
            // 
            // colHO1
            // 
            this.colHO1.FieldName = "HO";
            this.colHO1.Name = "colHO1";
            // 
            // colCMND2
            // 
            this.colCMND2.FieldName = "CMND";
            this.colCMND2.Name = "colCMND2";
            // 
            // FrmMoTaiKhoanKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 652);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.chiNhanhGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMoTaiKhoanKH";
            this.Text = "FrmMoTaiKhoanKH";
            this.Load += new System.EventHandler(this.FrmMoTaiKhoanKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_NGANHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS DS_NGANHANG;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource chiNhanhBindingSource;
        private DSTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private DevExpress.XtraGrid.GridControl chiNhanhGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMACN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCMND3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHO3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTEN3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDIACHI3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPHAI3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNGAYCAP2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSODT2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMACN2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colrowguid2;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSOTK;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSODU;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMACN3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNGAYMOTK;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
        private DevExpress.XtraEditors.TextEdit txtSoTK;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND4;
        private DevExpress.XtraGrid.Columns.GridColumn colHO4;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN2;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI2;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI2;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colrowguid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSODT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPHAI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDIACHI;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTEN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCMND;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPHAI1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDIACHI1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTEN1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHO1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCMND2;
        private System.Windows.Forms.Label label3;
    }
}