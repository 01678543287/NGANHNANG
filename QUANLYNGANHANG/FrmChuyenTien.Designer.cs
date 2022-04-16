namespace QUANLYNGANHANG
{
    partial class FrmChuyenTien
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
            System.Windows.Forms.Label sOTK_CHUYENLabel;
            System.Windows.Forms.Label sOTK_NHANLabel;
            this.bds_GDChuyenTien = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QUANLYNGANHANG.DS();
            this.GD_CHUYENTIENTableAdapter = new QUANLYNGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new QUANLYNGANHANG.DSTableAdapters.TableAdapterManager();
            this.txt_STKChuyen = new System.Windows.Forms.TextBox();
            this.bds_KhachHang = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new QUANLYNGANHANG.DSTableAdapters.KhachHangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_STKNhan = new System.Windows.Forms.TextBox();
            this.txt_HoTenNguoiChuyen = new System.Windows.Forms.TextBox();
            this.txt_HoTenNguoiNhan = new System.Windows.Forms.TextBox();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ChuyenTien = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            sOTK_CHUYENLabel = new System.Windows.Forms.Label();
            sOTK_NHANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTK_CHUYENLabel
            // 
            sOTK_CHUYENLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sOTK_CHUYENLabel.AutoSize = true;
            sOTK_CHUYENLabel.Location = new System.Drawing.Point(161, 80);
            sOTK_CHUYENLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sOTK_CHUYENLabel.Name = "sOTK_CHUYENLabel";
            sOTK_CHUYENLabel.Size = new System.Drawing.Size(76, 13);
            sOTK_CHUYENLabel.TabIndex = 6;
            sOTK_CHUYENLabel.Text = "Số TK Chuyển";
            // 
            // sOTK_NHANLabel
            // 
            sOTK_NHANLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sOTK_NHANLabel.AutoSize = true;
            sOTK_NHANLabel.Location = new System.Drawing.Point(495, 80);
            sOTK_NHANLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sOTK_NHANLabel.Name = "sOTK_NHANLabel";
            sOTK_NHANLabel.Size = new System.Drawing.Size(66, 13);
            sOTK_NHANLabel.TabIndex = 7;
            sOTK_NHANLabel.Text = "Số TK Nhận";
            // 
            // bds_GDChuyenTien
            // 
            this.bds_GDChuyenTien.DataMember = "GD_CHUYENTIEN";
            this.bds_GDChuyenTien.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GD_CHUYENTIENTableAdapter
            // 
            this.GD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.GD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_STKChuyen
            // 
            this.txt_STKChuyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_STKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDChuyenTien, "SOTK_CHUYEN", true));
            this.txt_STKChuyen.Location = new System.Drawing.Point(249, 74);
            this.txt_STKChuyen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_STKChuyen.MaxLength = 9;
            this.txt_STKChuyen.Multiline = true;
            this.txt_STKChuyen.Name = "txt_STKChuyen";
            this.txt_STKChuyen.Size = new System.Drawing.Size(162, 30);
            this.txt_STKChuyen.TabIndex = 7;
            this.txt_STKChuyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_STKChuyen_KeyPress);
            this.txt_STKChuyen.Leave += new System.EventHandler(this.sOTK_CHUYENTextBox_Leave);
            this.txt_STKChuyen.Validating += new System.ComponentModel.CancelEventHandler(this.txt_STKChuyen_Validating);
            // 
            // bds_KhachHang
            // 
            this.bds_KhachHang.DataMember = "KhachHang";
            this.bds_KhachHang.DataSource = this.DS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ Tên Người Chuyển";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ Tên Người Nhận";
            // 
            // txt_STKNhan
            // 
            this.txt_STKNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_STKNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDChuyenTien, "SOTK_CHUYEN", true));
            this.txt_STKNhan.Location = new System.Drawing.Point(579, 74);
            this.txt_STKNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_STKNhan.MaxLength = 9;
            this.txt_STKNhan.Multiline = true;
            this.txt_STKNhan.Name = "txt_STKNhan";
            this.txt_STKNhan.Size = new System.Drawing.Size(162, 30);
            this.txt_STKNhan.TabIndex = 14;
            this.txt_STKNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_STKNhan_KeyPress);
            this.txt_STKNhan.Leave += new System.EventHandler(this.txt_STKNhan_Leave);
            this.txt_STKNhan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_STKNhan_Validating);
            // 
            // txt_HoTenNguoiChuyen
            // 
            this.txt_HoTenNguoiChuyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HoTenNguoiChuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDChuyenTien, "SOTK_CHUYEN", true));
            this.txt_HoTenNguoiChuyen.Enabled = false;
            this.txt_HoTenNguoiChuyen.Location = new System.Drawing.Point(249, 157);
            this.txt_HoTenNguoiChuyen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HoTenNguoiChuyen.Multiline = true;
            this.txt_HoTenNguoiChuyen.Name = "txt_HoTenNguoiChuyen";
            this.txt_HoTenNguoiChuyen.Size = new System.Drawing.Size(162, 30);
            this.txt_HoTenNguoiChuyen.TabIndex = 15;
            // 
            // txt_HoTenNguoiNhan
            // 
            this.txt_HoTenNguoiNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HoTenNguoiNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDChuyenTien, "SOTK_CHUYEN", true));
            this.txt_HoTenNguoiNhan.Enabled = false;
            this.txt_HoTenNguoiNhan.Location = new System.Drawing.Point(579, 157);
            this.txt_HoTenNguoiNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HoTenNguoiNhan.Multiline = true;
            this.txt_HoTenNguoiNhan.Name = "txt_HoTenNguoiNhan";
            this.txt_HoTenNguoiNhan.Size = new System.Drawing.Size(162, 30);
            this.txt_HoTenNguoiNhan.TabIndex = 16;
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoTien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDChuyenTien, "SOTK_CHUYEN", true));
            this.txt_SoTien.Location = new System.Drawing.Point(359, 301);
            this.txt_SoTien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoTien.Multiline = true;
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(162, 30);
            this.txt_SoTien.TabIndex = 17;
            this.txt_SoTien.TextChanged += new System.EventHandler(this.txt_SoTien_TextChanged);
            this.txt_SoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTien_KeyPress);
            this.txt_SoTien.Leave += new System.EventHandler(this.txt_SoTien_Leave);
            this.txt_SoTien.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SoTien_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số Tiền";
            // 
            // btn_ChuyenTien
            // 
            this.btn_ChuyenTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ChuyenTien.Location = new System.Drawing.Point(359, 358);
            this.btn_ChuyenTien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChuyenTien.Name = "btn_ChuyenTien";
            this.btn_ChuyenTien.Size = new System.Drawing.Size(161, 35);
            this.btn_ChuyenTien.TabIndex = 19;
            this.btn_ChuyenTien.Text = "Chuyển Tiền";
            this.btn_ChuyenTien.UseVisualStyleBackColor = true;
            this.btn_ChuyenTien.Click += new System.EventHandler(this.btn_ChuyenTien_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "VND";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SoDu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bds_GDChuyenTien, "SOTK_CHUYEN", true));
            this.txt_SoDu.Enabled = false;
            this.txt_SoDu.Location = new System.Drawing.Point(249, 233);
            this.txt_SoDu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoDu.Multiline = true;
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Size = new System.Drawing.Size(162, 30);
            this.txt_SoDu.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số Dư";
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
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = global::QUANLYNGANHANG.Properties.Resources.log_out;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(946, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 402);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(946, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 362);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(946, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 362);
            // 
            // FrmChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(946, 422);
            this.Controls.Add(this.txt_SoDu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ChuyenTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SoTien);
            this.Controls.Add(this.txt_HoTenNguoiNhan);
            this.Controls.Add(this.txt_HoTenNguoiChuyen);
            this.Controls.Add(this.txt_STKNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(sOTK_NHANLabel);
            this.Controls.Add(sOTK_CHUYENLabel);
            this.Controls.Add(this.txt_STKChuyen);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmChuyenTien";
            this.Text = "Chuyển Tiền";
            this.Load += new System.EventHandler(this.FrmChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bds_GDChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bds_GDChuyenTien;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter GD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_STKChuyen;
        private System.Windows.Forms.BindingSource bds_KhachHang;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_STKNhan;
        private System.Windows.Forms.TextBox txt_HoTenNguoiChuyen;
        private System.Windows.Forms.TextBox txt_HoTenNguoiNhan;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ChuyenTien;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SoDu;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}