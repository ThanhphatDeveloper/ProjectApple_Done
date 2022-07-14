using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Globalization;

namespace Project_Apple
{
    public partial class frmChitietHD : Form
    {
        private string maHD;
        private string stdKhachHang;
        private DateTime ngayLap;
        private string maNV;
        private string tenNV;
        //...
        ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
        public frmChitietHD(string maHD, DateTime ngayLap, string maNV, string tenNV, string stdKhachHang) : this()
        {
            this.maHD = maHD;
            this.ngayLap = ngayLap;
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.stdKhachHang = stdKhachHang;
        }
        public frmChitietHD()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvCTHoaDon.AutoGenerateColumns = false;

            dgvCTHoaDon.DataSource = cthdBUS.loadDataBUS(txtMaHoadon.Text);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChitietHD_Load(object sender, EventArgs e)
        {
            txtMaHoadon.Text = maHD;
            txtSDT.Text = stdKhachHang;
            dtpNgayLap.EditValue = ngayLap;
            txtManhanvien.Text = maNV;
            txtTennhanvien.Text = tenNV;
            //...
            loadData();
            txtTongThanhTien.Text = DinhDangTienVND(cthdBUS.TinhTongTien(maHD));
        }
        public string DinhDangTienVND(decimal tien)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tien);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }
    }
}
