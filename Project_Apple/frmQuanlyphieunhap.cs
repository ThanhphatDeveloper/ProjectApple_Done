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

namespace Project_Apple
{
    public partial class frmQuanlyphieunhap : Form
    {

        private string maNV = null;
        private string tenNV = null;
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();

        public frmQuanlyphieunhap()
        {
            InitializeComponent();
        }
        public frmQuanlyphieunhap(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            frmNhaphang frmNH = new frmNhaphang(maNV, tenNV);
            frmNH.ShowDialog();
        }

        private void frmQuanlyphieunhap_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
        }
        public void LoadPhieuNhap()
        {
            dgvDanhSachPN.AutoGenerateColumns = false;
            dgvDanhSachPN.DataSource = pnBUS.LayDSPN();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string Values = txtTimkiem.Text;
            dgvDanhSachPN.DataSource = pnBUS.TimKiemNhanh(Values);
        }

        private void dgvDanhSachPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDanhSachPN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhSachPN.CurrentCell.Selected = true;
                string maPhieu = dgvDanhSachPN.Rows[e.RowIndex].Cells[0].Value.ToString();
                string maNhanVien = dgvDanhSachPN.Rows[e.RowIndex].Cells[1].Value.ToString();
                string tenNhanVien = dgvDanhSachPN.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime NgayNhap = Convert.ToDateTime(dgvDanhSachPN.Rows[e.RowIndex].Cells[3].Value.ToString());
                frmChitietphieunhap frm = new frmChitietphieunhap(maPhieu, maNhanVien, tenNhanVien, NgayNhap);
                frm.ShowDialog();
            }
        }
    }
}
