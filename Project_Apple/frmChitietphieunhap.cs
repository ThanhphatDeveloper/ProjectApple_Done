using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO;

namespace Project_Apple
{
    public partial class frmChitietphieunhap : Form
    {
        private string maPN;
        private DateTime ngayNhap;
        private string maNhanVien;
        private string tenNhanVien;
        ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        public frmChitietphieunhap()
        {
            InitializeComponent();
        }

        public frmChitietphieunhap(string maPN, string maNhanVien, string tenNhanVien, DateTime ngayNhap) : this()
        {
            this.maPN = maPN;
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.ngayNhap = ngayNhap;
        }
        public void loadData()
        {
            gdvChitietPhieuNhap.AutoGenerateColumns = false;
            gdvChitietPhieuNhap.DataSource = ctpnBUS.loadData(txtMaPN.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmChitietphieunhap_Load(object sender, EventArgs e)
        {
            txtMaPN.Text = maPN;
            txtMaNV.Text = maNhanVien;
            txtTenNV.Text = tenNhanVien;
            dtpNgayNhap.EditValue = ngayNhap;
            loadData();
            Int64 tongTienPhieuNhap = ctpnBUS.TinhTongTienPN(maPN);
            txtThanhtien.Text = DinhDangTienVND(tongTienPhieuNhap);
        }

        public string DinhDangTienVND(long tien)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tien);
        }
    }
}
