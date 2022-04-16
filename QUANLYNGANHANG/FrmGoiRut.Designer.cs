
namespace QUANLYNGANHANG
{
    partial class FrmGoiRut
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoiRut));
            this.groupBox = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTienGD = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGANHANGDataSet = new QUANLYNGANHANG.NGANHANGDataSet();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new QUANLYNGANHANG.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new QUANLYNGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.khachHangTableAdapter = new QUANLYNGANHANG.NGANHANGDataSetTableAdapters.KhachHangTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnGoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRut = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            sOTKLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(275, 92);
            sOTKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(49, 17);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "Số TK:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(273, 158);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(75, 17);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "Họ tên KH:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(275, 223);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 4;
            cMNDLabel.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(273, 290);
            sODULabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(45, 17);
            sODULabel.TabIndex = 6;
            sODULabel.Text = "Số dư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(275, 358);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 17);
            label1.TabIndex = 6;
            label1.Text = "Số tiền GD";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.btnSubmit);
            this.groupBox.Controls.Add(label1);
            this.groupBox.Controls.Add(sODULabel);
            this.groupBox.Controls.Add(this.txtTienGD);
            this.groupBox.Controls.Add(this.txtSoDu);
            this.groupBox.Controls.Add(cMNDLabel);
            this.groupBox.Controls.Add(this.txtCMND);
            this.groupBox.Controls.Add(tENLabel);
            this.groupBox.Controls.Add(this.txtHoTen);
            this.groupBox.Controls.Add(sOTKLabel);
            this.groupBox.Controls.Add(this.txtSoTK);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 51);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1067, 483);
            this.groupBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập vào số TK và số tiền giao dịch";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(453, 416);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(159, 28);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Thực hiện GD";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTienGD
            // 
            this.txtTienGD.Location = new System.Drawing.Point(360, 354);
            this.txtTienGD.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienGD.Name = "txtTienGD";
            this.txtTienGD.Properties.DisplayFormat.FormatString = "n0";
            this.txtTienGD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTienGD.Properties.EditFormat.FormatString = "n0";
            this.txtTienGD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTienGD.Size = new System.Drawing.Size(377, 22);
            this.txtTienGD.TabIndex = 7;
            this.txtTienGD.EditValueChanged += new System.EventHandler(this.txtTienGD_EditValueChanged);
            this.txtTienGD.TextChanged += new System.EventHandler(this.txtTienGD_TextChanged);
            this.txtTienGD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienGD_KeyPress);
            this.txtTienGD.Validating += new System.ComponentModel.CancelEventHandler(this.txtTienGD_Validating);
            // 
            // txtSoDu
            // 
            this.txtSoDu.Enabled = false;
            this.txtSoDu.Location = new System.Drawing.Point(360, 287);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoDu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoDu.Properties.EditFormat.FormatString = "n0";
            this.txtSoDu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoDu.Properties.ReadOnly = true;
            this.txtSoDu.Size = new System.Drawing.Size(377, 22);
            this.txtSoDu.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(360, 219);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(376, 23);
            this.txtCMND.TabIndex = 5;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.nGANHANGDataSet;
            // 
            // nGANHANGDataSet
            // 
            this.nGANHANGDataSet.DataSetName = "NGANHANGDataSet";
            this.nGANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TEN", true));
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(360, 154);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(376, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtSoTK
            // 
            this.txtSoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "SOTK", true));
            this.txtSoTK.Location = new System.Drawing.Point(360, 89);
            this.txtSoTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTK.MaxLength = 9;
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(376, 23);
            this.txtSoTK.TabIndex = 1;
            this.txtSoTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTK_KeyPress);
            this.txtSoTK.Leave += new System.EventHandler(this.txtSoTK_Leave);
            this.txtSoTK.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoTK_Validating);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.nGANHANGDataSet;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = QUANLYNGANHANG.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnGoi,
            this.btnRut,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnGoi
            // 
            this.btnGoi.Caption = "Gởi tiền";
            this.btnGoi.Id = 0;
            this.btnGoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoi.ImageOptions.Image")));
            this.btnGoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGoi.ImageOptions.LargeImage")));
            this.btnGoi.Name = "btnGoi";
            this.btnGoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGoi_ItemClick);
            // 
            // btnRut
            // 
            this.btnRut.Caption = "Rút tiền";
            this.btnRut.Id = 1;
            this.btnRut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRut.ImageOptions.Image")));
            this.btnRut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRut.ImageOptions.LargeImage")));
            this.btnRut.Name = "btnRut";
            this.btnRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRut_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy GD";
            this.btnHuy.Id = 2;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
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
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmGoiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGoiRut";
            this.Text = "Gởi Rút";
            this.Load += new System.EventHandler(this.FrmGoiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl groupBox;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private NGANHANGDataSet nGANHANGDataSet;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtSoTK;
        private NGANHANGDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtTienGD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnGoi;
        private DevExpress.XtraBars.BarButtonItem btnRut;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}