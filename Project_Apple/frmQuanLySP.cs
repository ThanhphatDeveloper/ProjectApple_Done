using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Project_Apple
{
    public partial class frmQuanLySP : Form
    {
        private string maNV = null;
        private string tenNV = null;
        SanPhamBUS spBUS = new SanPhamBUS();
        LoaiSanPhamBUS loaiSPBus = new LoaiSanPhamBUS();
        //...
        Thongbao mess = new Thongbao();
        public frmQuanLySP()
        {
            InitializeComponent();
        }
        public frmQuanLySP(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLySP_Load(object sender, EventArgs e)
        {
            dgvQLSP.AutoGenerateColumns = false;
            dgvQLSP.DataSource = spBUS.LayDanhSachSanPham();
            //...
            LoadLoaiSPListView();
        }
        public void LoadLoaiSPListView()
        {
            foreach (LoaiSanPhamDTO loai in loaiSPBus.LoadLoaiSP())
            {
                lvwDanhMucSanPham.Items.Add(loai.TenLoai);
            }
        }

        private void dgvQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvQLSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvQLSP.CurrentRow.Selected = true;
                txtMaSP.Text = dgvQLSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvQLSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLoai.Text = dgvQLSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                decimal giaBan = (decimal)dgvQLSP.Rows[e.RowIndex].Cells[3].Value;
                txtGiaban.Text = DinhdangtienVN.DinhDangTienVND(giaBan);
                txtGiagoc.Text = DinhdangtienVN.DinhDangTienVND(giaBan / (decimal)1.5);
                txtSoluongton.Text = dgvQLSP.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtnhacungcap.Text = dgvQLSP.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtXuatxu.Text = dgvQLSP.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(mess.deleteProductQuestion, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                SanPhamDTO spDTO = new SanPhamDTO();
                spDTO.MaSP = txtMaSP.Text;
                if (result == DialogResult.Yes)
                {
                    if (spBUS.XoaSanPham(spDTO))
                    {
                        MessageBox.Show(mess.deleteProductSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvQLSP.DataSource = spBUS.LayDanhSachSanPham();
                    }
                    else
                    {
                        MessageBox.Show(mess.deleteProductFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(mess.UnknownExceptionError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void txtTimkiemnhanh_TextChanged(object sender, EventArgs e)
        {
            int valueNumber = 0;
            bool checkValue = int.TryParse(txtTimkiemnhanh.Text, out valueNumber);
            if (checkValue)
            {
                dgvQLSP.DataSource = "";
                dgvQLSP.AutoGenerateColumns = false;
                dgvQLSP.DataSource = spBUS.TimKiemNhanh(valueNumber.ToString());
            }
            else
            {
                dgvQLSP.DataSource = "";
                dgvQLSP.AutoGenerateColumns = false;
                dgvQLSP.DataSource = spBUS.TimKiemNhanh(txtTimkiemnhanh.Text);
            }
        }

        private void btnQuanLyLoai_Click(object sender, EventArgs e)
        {
            //Dulieudangnhap.formOpacity.Show();
            frmQuanLyLoaiSP frm = new frmQuanLyLoaiSP();
            frm.ShowDialog();
        }
    }
}
