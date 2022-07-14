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
using DTO;
namespace Project_Apple
{
    public partial class frmQuanLy : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        private static Point coorMenuTmp = new Point(205, 31);
        private static Point coorMenuChildTmp = new Point(12, 87);
        private static Point coorLogoTmp = new Point(12, 6);
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            //panelContent.Controls.Clear();
            frmQuanTK frmTK = new frmQuanTK();
            //{
            //    Dock = DockStyle.Fill,
            //    TopLevel = false,
            //    TopMost = true
            //};
            //panelContent.Controls.Add(frmTK);
            //frmTK.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmTK.ShowDialog();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNV frmQLNV = new frmQuanLyNV();
            frmQLNV.ShowDialog();
        }

        private void menuChild_Paint(object sender, PaintEventArgs e)
        {
            if (Dulieudangnhap.quyen == "Bán hàng")
            {
                btnQuanLyNhanVien.Enabled = false;
                btnBaoCao.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;



            }
            else if (Dulieudangnhap.quyen == "Thủ kho")
            {
                btnQuanLyKhachHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnBaoCao.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
                btnBaoHanh.Enabled = false;
                btnQuanLyHoaDon.Enabled = false;

            }
            else if (Dulieudangnhap.quyen == "Thu ngân")
            {
                btnQuanLyKhachHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
                btnBaoHanh.Enabled = false;
                btnBaoCao.Enabled = true;
                btnQuanLySanPham.Enabled = false;
                btnQuanLyPhieuNhap.Enabled = false;
                btnQuanLyNhaCungCap.Enabled = false;
            }
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            frmQuanLySP frmQLSP = new frmQuanLySP();
            frmQLSP.ShowDialog();
        }

        private void btnQuanLyPhieuNhap_Click(object sender, EventArgs e)
        {
            frmQuanlyphieunhap frmQLPN = new frmQuanlyphieunhap();
            frmQLPN.ShowDialog();
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmDSkhachhang frmDSKH = new frmDSkhachhang();
            frmDSKH.ShowDialog();
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            frmQuanlyHD frmQLHD = new frmQuanlyHD();
            frmQLHD.ShowDialog();
        }

        private void btnQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            frmQuanlyNhaCungCap frmQLNCC = new frmQuanlyNhaCungCap();
            frmQLNCC.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmXembaocao frmXBC = new frmXembaocao();
            frmXBC.ShowDialog();
        }

        
        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            frmBaoHanh frmBH = new frmBaoHanh();
            frmBH.ShowDialog();
        }

        private void frmQuanLy_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                btnQuanLyNhanVien_Click(null, null);
            }
            //

            if (e.KeyCode.Equals(Keys.F2))
            {
                btnQuanLyTaiKhoan_Click(null, null);
            }
            //

            if (e.KeyCode.Equals(Keys.F3))
            {
                btnQuanLySanPham_Click(null, null);
            }
            //
            if (e.KeyCode.Equals(Keys.F4))
            {
                btnQuanLyHoaDon_Click(null, null);
            }

            //
            if (e.KeyCode.Equals(Keys.F5))
            {
                btnExit_Click(null, null);
            }
        }

       

        private void user_DX1_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc muôn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    frmDangnhap frm = new frmDangnhap();
            //    frm.Show();
            //    this.Hide();
            //}

            this.Close();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
