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
    public partial class frmQuanlyHD : Form
    {
        HoaDonBUS hdBUS = new HoaDonBUS();
        private string maNV = null;
        private string tenNV = null;
        public frmQuanlyHD()
        {
            InitializeComponent();
        }
        public frmQuanlyHD(string maNV, string tenNV) : this()
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLaphoadon_Click(object sender, EventArgs e)
        {
            //Dulieudangnhap.formOpacity.Show();
            frmLapHoaDon frmLHD = new frmLapHoaDon(maNV, tenNV);
            frmLHD.ShowDialog();
        }
        public void loadData()
        {
            dgvDSHoadon.AutoGenerateColumns = false;
            dgvDSHoadon.DataSource = hdBUS.LoadDataBUS();
        }

        private void frmQuanlyHD_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvDSHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDSHoadon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDSHoadon.CurrentRow.Selected = true;
                string maHD = dgvDSHoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTime ngayLap = Convert.ToDateTime(dgvDSHoadon.Rows[e.RowIndex].Cells[1].Value);
                string maNV = dgvDSHoadon.Rows[e.RowIndex].Cells[2].Value.ToString();
                string tenNV = dgvDSHoadon.Rows[e.RowIndex].Cells[3].Value.ToString();
                string sdtKhachHang = dgvDSHoadon.Rows[e.RowIndex].Cells[4].Value.ToString();
                //...
                //Dulieudangnhap.formOpacity.Show();
                frmChitietHD frm = new frmChitietHD(maHD, ngayLap, maNV, tenNV, sdtKhachHang);
                frm.ShowDialog();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSHoadon.AutoGenerateColumns = false;
            dgvDSHoadon.DataSource = hdBUS.TimKiemNhanhBUS(txtTimkiem.Text);
        }
    }
}
