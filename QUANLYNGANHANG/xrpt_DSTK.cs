using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace QUANLYNGANHANG
{
    public partial class xrpt_DSTK : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_DSTK(String chiNhanh, String tuNgay, String denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.StrConn;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = chiNhanh;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denNgay;
            this.sqlDataSource1.Fill();
        }

    }
}
