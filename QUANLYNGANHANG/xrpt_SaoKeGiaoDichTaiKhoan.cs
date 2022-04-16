using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace QUANLYNGANHANG
{
    public partial class xrpt_SaoKeGiaoDichTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_SaoKeGiaoDichTaiKhoan(String SoTK, String TuNgay, String DenNgay)
        {
            InitializeComponent();
            pSOTK.Value = SoTK;
            pTuNgay.Value = TuNgay;
            pDenNgay.Value = DenNgay;
            this.sqlDataSource4.Connection.ConnectionString = Program.StrConn;
            
        }

        
    }
}
